using System.Collections.Generic;
using UnityEngine;

namespace Noir.Pooling {
    /// <summary>
    /// Allows easy, cached reuse of MonoBehaviours
    /// </summary>
    /// <typeparam name="T">The MonoBehaviour to use in the pool</typeparam>
    public abstract class BehaviourPoolBase<T> : NoirBehaviour where T : Component {
        [SerializeField] private int _maxPoolSize;
        [SerializeField] private bool _preWarmPool = false;
        [SerializeField] private bool _poolItemsShouldBeChildren = false;

        private readonly List<T> _activeItems = new();
        private readonly List<T> _inactiveItems = new();

        private bool _initialized;

        /// <summary>
        /// Gets the sum of <see cref="InactiveItems"/> and <see cref="ActiveItems"/>.
        /// </summary>
        public int TotalItems => _activeItems.Count + _inactiveItems.Count;
        
        /// <summary>
        /// Gets the max number of items that can be created by this pool.
        /// </summary>
        public int MaxItems => _maxPoolSize;

        /// <summary>
        /// Gets the number of inactive items in the pool.
        /// </summary>
        /// <remarks>Inactive items will be reused before new items are created.</remarks>
        public int InactiveItems => _inactiveItems.Count;

        /// <summary>
        /// Gets the number of active items in the pool.
        /// </summary>
        /// <remarks>Active items are items that are still active within the game scene and have not been returned to the pool.</remarks>
        public int ActiveItems => _activeItems.Count;

        /// <summary>
        /// Gets a value that indicates the percentage of active vs total items in the pool.
        /// </summary>
        public float PoolUtilization => (float)((float)ActiveItems / (float)TotalItems);

        /// <summary>
        /// Gets a value that indicates whether the pool should pre-warm during its <see cref="Start"/> lifecycle.
        /// </summary>
        public bool IsPreWarmEnabled => _preWarmPool;

        /// <summary>
        /// Returns an <see cref="IEnumerable{T}"/> that you can use to enumerate the active <see cref="Component"/> objects in the pool.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> that you can use to enumerate the active <see cref="Component"/> objects in the pool.</returns>
        public IEnumerable<T> GetActiveItems() => _activeItems;

        private void Start() {
            if (_preWarmPool) {
                PreWarmPool();
            }
            _initialized = true;
            OnStart();
        }

        /// <summary>
        /// A <see cref="BehaviourPoolBase{T}"/> calls <see cref="OnStart"/> when the component first initializes, as part of the <see cref="Start"/> MonoBehaviour lifecycle.
        /// </summary>
        /// <remarks>The <see cref="OnStart"/> method allows derived classes to handle the event without attaching a delegate. This is the preferred technique for handling the event in a derived class.</remarks>
        protected virtual void OnStart() { }

        /// <summary>
        /// Called when the object pool starts, if <see cref="IsPreWarmEnabled"/> is <c>true</c>.
        /// </summary>
        protected virtual void PreWarmPool() {
            _activeItems.Clear();
            _inactiveItems.Clear();
            for (int i = 0; i < _maxPoolSize; i++) {
                var item = CreateNewPoolItem();
                item = ResetItemToDefaults(item);
                EnsureProperParent(item);
                _inactiveItems.Add(item);
            }
            Logger.Info($"pool prewarmed. size={_maxPoolSize}");
        }

        protected abstract T CreateNewPoolItem();

        /// <summary>
        /// A <see cref="BehaviourPoolBase{T}"/> calls <see cref="OnRetrieveItemFromPool"/> when an item is being returned to the pool.
        /// </summary>
        /// <param name="item">The item that was retrieved from the pool.</param>
        /// <remarks>The <see cref="OnRetrieveItemFromPool"/> method allows derived classes to handle the event without attaching a delegate. This is the preferred technique for handling the event in a derived class.</remarks>
        protected virtual void OnRetrieveItemFromPool(T item) {

        }

        /// <summary>
        /// A <see cref="BehaviourPoolBase{T}"/> calls <see cref="OnReturnItemToPool"/> after an item was retrieved from the pool.
        /// </summary>
        /// <param name="item">The item being returned to the pool.</param>
        /// <remarks>The <see cref="OnReturnItemToPool"/> method allows derived classes to handle the event without attaching a delegate. This is the preferred technique for handling the event in a derived class.</remarks>
        protected virtual void OnReturnItemToPool(T item) {

        }

        /// <summary>
        /// Resets the item to its default state.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>The item with its default values set.</returns>
        /// <remarks>
        /// This method is called during <see cref="PreWarmPool"/>, <see cref="TryGetItemFromPool(out T)"/> and <see cref="ReturnItemToPool(T)"/>. <br/>
        /// The returned item from this method is then stored in the internal active or inactive collections depending on the action being taken. <br/>
        /// This method is called before <see cref="OnRetrieveItemFromPool(T)"/> and <see cref="OnReturnItemToPool(T)"/>.
        /// </remarks>
        protected virtual T ResetItemToDefaults(T item) {
            return item;
        }

        private void EnsureProperParent(T item) {
            if (_poolItemsShouldBeChildren) {
                item.transform.SetParent(transform);
            }
        }

        /// <summary>
        /// Gets a fresh item from the pool.
        /// </summary>
        /// <param name="item">When this method returns, contains the pool item, if one was available; otherwise, the default value for the behaviour. This parameter is passed uninitialized.</param>
        /// <returns><c>true</c> if the pool has available capacity; otherwise, <c>false</c>.</returns>
        public virtual bool TryGetItemFromPool(out T item) {
            item = default(T);
            if (_inactiveItems.Count > 0) {
                item = _inactiveItems[0];
                item = ResetItemToDefaults(item);
                _inactiveItems.RemoveAt(0);
                _activeItems.Add(item);
                OnRetrieveItemFromPool(item);
                EnsureProperParent(item);
                return true;
            }
            if (_activeItems.Count + _inactiveItems.Count < _maxPoolSize) {
                item = CreateNewPoolItem();
                item = ResetItemToDefaults(item);
                _activeItems.Add(item);
                OnRetrieveItemFromPool(item);
                EnsureProperParent(item);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns an item to the pool, marking it inactive.
        /// </summary>
        /// <param name="item">The item to return to the pool.</param>
        public virtual void ReturnItemToPool(T item) {
            var index = _activeItems.IndexOf(item);
            if (index >= 0) {
                _activeItems.RemoveAt(index);
                item = ResetItemToDefaults(item);
                OnReturnItemToPool(item);
                EnsureProperParent(item);
                _inactiveItems.Add(item);
            }
        }
    }
}