using Noir.Attributes;
using Noir.Logging;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using System.Collections.Generic;
using UnityEngine;

namespace Noir.Pooling {
    /// <summary>
    /// Provides the ability to create, and manage the lifetime of a <see cref="ObjectPool"/>.
    /// </summary>
    [AddComponentMenu("Noir/Pooling/Object Pool System")]
    [RequireComponent(typeof(ObjectPoolComponent))]
    public class ObjectPoolSystem : NoirBehaviour {
        private int _highPressureFrames = 0;
        private ObjectPool _pool;

        [GetComponent]
        [SerializeField] private ObjectPoolComponent _objectPoolData;

#if ODIN_INSPECTOR
        [ShowInInspector]
        [ProgressBar(0f, 100f)]
#endif
        /// <summary>
        /// Gets the pool utilization.
        /// </summary>
        /// <value>
        /// A value ranging from 0.0 to 1.0 representing how many of the total items within the pool are currently in use.
        /// </value>
        public float Utilization => _pool == null ? 0f : _pool.PoolUtilization * 100f;

#if ODIN_INSPECTOR
        [ShowInInspector]
#endif
        /// <summary>
        /// Gets the total items.
        /// </summary>
        /// <value>
        /// The total number of inactive and active items.
        /// </value>
        public uint TotalItems => _pool?.TotalItems ?? 0;

#if ODIN_INSPECTOR
        [ShowInInspector]
#endif
        /// <summary>
        /// Gets the number of active items in the pool.
        /// </summary>
        /// <value>
        /// The number of active items in the pool.
        /// </value>
        public uint ActiveItems => _pool?.ActiveCount ?? 0;

#if ODIN_INSPECTOR
        [ShowInInspector]
#endif
        /// <summary>
        /// Gets the number of inactive items in the pool.
        /// </summary>
        /// <value>
        /// The number of inactive items in the pool.
        /// </value>
        public uint InactiveItems => _pool?.InactiveCount ?? 0;

        /// <inheritdoc cref="ObjectPool.TryGet"/>
        public virtual bool TryGet(out ObjectPoolItemSystem item) => _pool.TryGet(out item);

        /// <inheritdoc cref="ObjectPool.Return"/>
        public virtual void Return(ObjectPoolItemSystem item) => _pool.Return(item);

        /// <inheritdoc cref="ObjectPool.ReturnAll"/>
        public virtual void ReturnAll() => _pool.ReturnAll();

        /// <inheritdoc cref="OnPoolItemCreatedEvent"/>
        public event OnPoolItemCreatedEvent OnPoolItemCreated {
            add => _pool.OnPoolItemCreated += value;
            remove => _pool.OnPoolItemCreated -= value;
        }

        /// <inheritdoc cref="OnPoolItemResetToDefaultsEvent"/>
        public event OnPoolItemResetToDefaultsEvent OnPoolItemResetToDefaults {
            add => _pool.OnPoolItemResetToDefaults += value;
            remove => _pool.OnPoolItemResetToDefaults -= value;
        }

        /// <inheritdoc cref="OnPoolItemRetrievedEvent"/>
        public event OnPoolItemRetrievedEvent OnPoolItemRerieved {
            add => _pool.OnPoolItemRerieved += value;
            remove => _pool.OnPoolItemRerieved -= value;
        }

        /// <inheritdoc cref="OnPoolItemReturnedEvent"/>
        public event OnPoolItemReturnedEvent OnPoolItemReturned {
            add => _pool.OnPoolItemReturned += value;
            remove => _pool.OnPoolItemReturned -= value;
        }

        /// <inheritdoc cref="ObjectPool.GetActiveItems"/>
        public IEnumerable<ObjectPoolItemSystem> GetActiveItems() => _pool.GetActiveItems();

        private void Awake() {
            _pool = CreateObjectPool(_objectPoolData.Prefab, _objectPoolData.Capacity);
        }

        private void Start() {
            if (_objectPoolData.IsParentForSpawnedObjects) {
                _pool.SetParent(transform);
            }
            if (_objectPoolData.IsPreWarmEnabled) {
                _pool.PreWarm();
            }
        }

        private void Update() {
            if (_pool.PoolUtilization > 0.85f) {
                _highPressureFrames++;
                if (_highPressureFrames % 15 == 0) {
                    LoggerSingleton.Instance.Warn($"Object pool pressure is high for too many frames! pressure={_pool.PoolUtilization}, frames={_highPressureFrames}", this);
                }
            }
            if (_highPressureFrames > 0 && _pool.PoolUtilization < 0.35f) {
                _highPressureFrames = 0;
            }
        }

        /// <summary>
        /// A <see cref="ObjectPoolSystem"/> calls <see cref="CreateObjectPool"/> to instantiate the underlying <see cref="ObjectPool"/>.
        /// </summary>
        /// <param name="prefab">The <see cref="ObjectPoolItemSystem"/> to use in the pool.</param>
        /// <param name="capacity">The max capacity of the pool</param>
        /// <returns>The created <see cref="ObjectPool"/> instance.</returns>
        /// <remarks>The <see cref="CreateObjectPool"/> method allows derived classes to provide a custom <see cref="ObjectPool"/> instance, if needed. This is the preferred technique for customizing object pool behavior within Noir.</remarks>
        protected virtual ObjectPool CreateObjectPool(ObjectPoolItemSystem prefab, uint capacity) => new(prefab, capacity);
    }
}