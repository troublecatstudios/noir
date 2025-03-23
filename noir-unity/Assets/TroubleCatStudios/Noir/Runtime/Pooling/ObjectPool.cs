using Noir.Logging;
using System.Collections.Generic;
using UnityEngine;

namespace Noir.Pooling {

    public delegate void OnPoolItemCreatedEvent(ObjectPoolItemSystem objectPoolItem);
    public delegate void OnPoolItemRetrievedEvent(ObjectPoolItemSystem objectPoolItem);
    public delegate void OnPoolItemReturnedEvent(ObjectPoolItemSystem objectPoolItem);
    public delegate void OnPoolItemResetToDefaultsEvent(ObjectPoolItemSystem objectPoolItem);

    /// <summary>
    /// Allows easy reuse of Unity objects.
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public class ObjectPool : System.IDisposable {
        private readonly List<ObjectPoolItemSystem> _activeItems = new();
        private readonly List<ObjectPoolItemSystem> _inactiveItems = new();
        protected readonly ObjectPoolItemSystem _prefab;

        private uint _count = 0;

        private Transform _poolParent;
        protected bool _disposedValue = false; // To detect redundant calls

        public event OnPoolItemCreatedEvent OnPoolItemCreated;
        public event OnPoolItemRetrievedEvent OnPoolItemRerieved;
        public event OnPoolItemReturnedEvent OnPoolItemReturned;
        public event OnPoolItemResetToDefaultsEvent OnPoolItemResetToDefaults;

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPool"/> class.
        /// </summary>
        /// <param name="prefab">The prefab.</param>
        /// <param name="capacity">The capacity.</param>
        /// <exception cref="System.ArgumentNullException">prefab</exception>
        public ObjectPool(GameObject prefab, uint capacity = 128) : this(prefab.GetComponent<ObjectPoolItemSystem>(), capacity) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPool"/> class.
        /// </summary>
        /// <param name="prefab">The prefab.</param>
        /// <param name="capacity">The capacity.</param>
        /// <exception cref="System.ArgumentNullException">prefab</exception>
        public ObjectPool(ObjectPoolItemSystem prefab, uint capacity = 128) {
            if (!prefab) {
                throw new System.ArgumentNullException(nameof(prefab));
            }
            _prefab = prefab;
            MaxCapacity = capacity;
        }

        /// <summary>
        /// Gets the total items.
        /// </summary>
        /// <value>
        /// The total items.
        /// </value>
        public uint TotalItems => (uint)(_activeItems.Count + _inactiveItems.Count);

        /// <summary>
        /// Gets the pool utilization.
        /// </summary>
        /// <value>
        /// A value ranging from 0.0 to 1.0 representing how many of the total items within the pool are currently in use.
        /// </value>
        public float PoolUtilization => (float)((float)ActiveCount / (float)MaxCapacity);

        /// <summary>
        /// Gets the maximum capacity.
        /// </summary>
        /// <value>
        /// The maximum capacity.
        /// </value>
        public uint MaxCapacity { get; private set; }

        /// <summary>
        /// Gets the active count.
        /// </summary>
        /// <value>
        /// The active count.
        /// </value>
        public uint ActiveCount => (uint)(_activeItems?.Count ?? 0);

        /// <summary>
        /// Gets the inactive count.
        /// </summary>
        /// <value>
        /// The inactive count.
        /// </value>
        public uint InactiveCount => (uint)(_inactiveItems?.Count ?? 0);

        /// <summary>
        /// Gets whether or not the pool has been pre-warmed.
        /// </summary>
        /// <value>
        /// <c>true</c> if the pool has been pre-warmed, <c>false</c> otherwise.
        /// </value>
        public bool IsPreWarmed { get; private set; }

        /// <summary>
        /// Sets the parent.
        /// </summary>
        /// <param name="transform">The transform.</param>
        public void SetParent(Transform transform) => _poolParent = transform;

        /// <summary>
        /// Sets the parent.
        /// </summary>
        /// <param name="gameObject">The game object.</param>
        public void SetParent(GameObject gameObject) => _poolParent = gameObject.transform;


        public IEnumerable<ObjectPoolItemSystem> GetActiveItems() {
            int count = 0;
            while(count < ActiveCount) {
                var item = _activeItems[count];
                if (!item || item.IsReturned) continue;
                yield return item;
                count++;
            }
        }

        /// <summary>
        /// Prewarms the object pool.
        /// </summary>
        /// <remarks>This can cause stutters if the <see cref="MaxCapacity"/> is large.</remarks>
        public void PreWarm() {
            _activeItems.Clear();
            _inactiveItems.Clear();
            for (int i = 0; i < MaxCapacity; i++) {
                CreateNewPoolItem();
            }
            IsPreWarmed = true;
        }

        /// <summary>
        /// Tries to retrieve an inactive item from the pool. If the pool is under capacity a new item wil be created.
        /// </summary>
        /// <param name="item">The new item. This can be <c>null</c> if there was no more capacity within the pool.</param>
        /// <returns><c>true</c> if an item was able to be returned, <c>false</c> otherwise.</returns>
        public bool TryGet(out ObjectPoolItemSystem item) {
            item = null;
            if (_inactiveItems.Count > 0) {
                item = _inactiveItems[0];
                item.RetrievedFromPool();
                _inactiveItems.RemoveAt(0);
                _activeItems.Add(item);
                OnPoolItemRerieved?.Invoke(item);
                OnItemRetrieved(item);
                EnsureProperParent(item);
                ResetToDefaults(item);
                return true;
            }
            if (_activeItems.Count + _inactiveItems.Count < MaxCapacity) {
                item = CreateNewPoolItem();
                item.RetrievedFromPool();
                _activeItems.Add(item);
                OnPoolItemRerieved?.Invoke(item);
                OnItemRetrieved(item);
                EnsureProperParent(item);
                ResetToDefaults(item);
                return true;
            }
            LoggerSingleton.Instance.Warn($"TryGet unable to retrieve object from pool. capacity={MaxCapacity}, active={ActiveCount}, utilization={PoolUtilization}", this);
            return false;
        }

        /// <summary>
        /// Returns the specified item to the pool.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Return(ObjectPoolItemSystem item) {
            ReturnToPool(item);
        }

        /// <summary>
        /// Iterates through all the active objects, calling <see cref="ObjectPoolItemSystem.ReturnToPool()"/> on each.
        /// </summary>
        public void ReturnAll() {
            while(_activeItems.Count > 0) {
                var item = _activeItems[0];
                item.ReturnToPool();
            }
        }

        protected virtual ObjectPoolItemSystem CreateNewPoolItem() {
            var item = UnityEngine.Object.Instantiate(_prefab);
            var id = ++_count;
            item.name = $"{_prefab.name}_{id}";
            item.CreatedByPool(this, id);
            OnPoolItemCreated?.Invoke(item);
            ResetToDefaults(item);
            OnItemCreated(item);
            ReturnToPool(item);
            return item;
        }

        protected virtual void ReturnToPool(ObjectPoolItemSystem item, bool isPreWarm = false) {
            var index = _activeItems.IndexOf(item);
            if (index >= 0) {
                _activeItems.RemoveAt(index);
            }
            item.ReturnedToPool();
            OnPoolItemReturned?.Invoke(item);
            _inactiveItems.Add(item);
            ResetToDefaults(item);
            OnItemReturned(item, isPreWarm);
            EnsureProperParent(item);
        }


        private void ResetToDefaults(ObjectPoolItemSystem item) {
            OnPoolItemResetToDefaults?.Invoke(item);
            OnResetToDefaults(item);
        }


        /// <summary>
        /// Called when the item should be reset to its default state.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <remarks>
        /// This method can be called when the pool is being pre-warmed, when an item is created for the first time or when an item is returned to the pool. <br/>
        /// The returned item from this method is then stored in the internal active or inactive collections depending on the action being taken. <br/>
        /// This method is always called before <see cref="OnItemCreated(ObjectPoolItemSystem, bool)"/> and <see cref="OnItemReturned(ObjectPoolItemSystem, bool)"/>.
        /// </remarks>
        protected virtual void OnResetToDefaults(ObjectPoolItemSystem item) { }

        /// <summary>
        /// Called when an item has been created for the first time.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="isPreWarm">if set to <c>true</c> the pool is pre-warming.</param>
        protected virtual void OnItemCreated(ObjectPoolItemSystem item, bool isPreWarm = false) { }

        /// <summary>
        /// Called when an inactive item is retrieved from the pool.
        /// </summary>
        /// <param name="item">The item.</param>
        protected virtual void OnItemRetrieved(ObjectPoolItemSystem item) { }

        /// <summary>
        /// Called when an active item is returned to the pool.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="isPreWarm">if set to <c>true</c> the pool is pre-warming.</param>
        protected virtual void OnItemReturned(ObjectPoolItemSystem item, bool isPreWarm = false) { }

        private void EnsureProperParent(ObjectPoolItemSystem item) {
            if (_poolParent) {
                item.transform.SetParent(_poolParent, false);
            }
        }

        protected virtual void Dispose(bool disposing) {
            if (!_disposedValue) {
                if (disposing) {
                    for (var i = 0; i < _activeItems.Count; i++) {
                        if (_activeItems[i] != null) {
                            UnityEngine.Object.Destroy(_activeItems[i].gameObject);
                            _activeItems[i] = null;
                        }
                    }
                    for (var i = 0; i < _inactiveItems.Count; i++) {
                        if (_inactiveItems[i] != null) {
                            UnityEngine.Object.Destroy(_inactiveItems[i].gameObject);
                            _inactiveItems[i] = null;
                        }
                    }
                }

                _disposedValue = true;
            }
        }

        /// <summary>
        /// Releases unmanaged and managed resources.
        /// </summary>
        public void Dispose() {
            Dispose(true);
        }
    }
}