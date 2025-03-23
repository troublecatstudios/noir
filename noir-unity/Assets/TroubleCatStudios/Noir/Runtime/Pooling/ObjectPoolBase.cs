using System.Collections.Generic;
using UnityEngine;

namespace Noir.Pooling {
    public abstract class ObjectPoolBase<T> : NoirBehaviour where T : Component {
        [SerializeField] private int _maxPoolSize;
        [SerializeField] private bool _preWarmPool = false;
        [SerializeField] private bool _poolItemsShouldBeChildren = false;

        private readonly List<T> _activeItems = new();
        private readonly List<T> _inactiveItems = new();

        private bool _initialized;

        public int TotalItems => _activeItems.Count + _inactiveItems.Count;
        public int MaxItems => _maxPoolSize;
        public int InactiveItems => _inactiveItems.Count;
        public int ActiveItems => _activeItems.Count;
        public float PoolUtilization => (float)((float)ActiveItems / (float)TotalItems);

        public IEnumerable<T> GetActiveItems() => _activeItems;

        private void Start() {
            if (_preWarmPool) {
                PreWarmPool();
            }
            _initialized = true;
            OnStart();
        }

        protected virtual void OnStart() { }

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
        protected virtual void OnRetrieveItemFromPool(T item) {

        }
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