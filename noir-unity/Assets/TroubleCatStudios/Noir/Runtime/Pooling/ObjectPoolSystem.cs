using Noir.Attributes;
using Noir.Logging;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using System.Collections.Generic;
using UnityEngine;

namespace Noir.Pooling {
    [AddComponentMenu("Noir/Spawning/Object Pool System")]
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
        public float Utilization => _pool == null ? 0f : _pool.PoolUtilization * 100f;

#if ODIN_INSPECTOR
        [ShowInInspector]
#endif
        public uint TotalItems => _pool?.TotalItems ?? 0;

#if ODIN_INSPECTOR
        [ShowInInspector]
#endif
        public uint ActiveItems => _pool?.ActiveCount ?? 0;

#if ODIN_INSPECTOR
        [ShowInInspector]
#endif
        public uint InactiveItems => _pool?.InactiveCount ?? 0;

        /// <inheritdoc cref="ObjectPool.TryGet"/>
        public virtual bool TryGet(out ObjectPoolItemSystem item) => _pool.TryGet(out item);

        /// <inheritdoc cref="ObjectPool.Return"/>
        public virtual void Return(ObjectPoolItemSystem item) => _pool.Return(item);

        /// <inheritdoc cref="ObjectPool.ReturnAll"/>
        public virtual void ReturnAll() => _pool.ReturnAll();

        public event OnPoolItemCreatedEvent OnPoolItemCreated {
            add => _pool.OnPoolItemCreated += value;
            remove => _pool.OnPoolItemCreated -= value;
        }

        public event OnPoolItemResetToDefaultsEvent OnPoolItemResetToDefaults {
            add => _pool.OnPoolItemResetToDefaults += value;
            remove => _pool.OnPoolItemResetToDefaults -= value;
        }

        public event OnPoolItemRetrievedEvent OnPoolItemRerieved {
            add => _pool.OnPoolItemRerieved += value;
            remove => _pool.OnPoolItemRerieved -= value;
        }

        public event OnPoolItemReturnedEvent OnPoolItemReturned {
            add => _pool.OnPoolItemReturned += value;
            remove => _pool.OnPoolItemReturned -= value;
        }

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

        protected virtual ObjectPool CreateObjectPool(ObjectPoolItemSystem prefab, uint capacity) => new(prefab, capacity);
    }
}