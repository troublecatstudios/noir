#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;

namespace Noir.Pooling {
    [AddComponentMenu("Noir/Spawning/Object Pool Data")]
    public class ObjectPoolComponent : NoirBehaviour {
#if ODIN_INSPECTOR
        [AssetsOnly]
#endif
        [SerializeField] private ObjectPoolItemSystem _prefab;

        [SerializeField] private uint _capacity = 128;

#if ODIN_INSPECTOR
        [LabelText("Pre-Warm?")]
#endif
        [SerializeField] private bool _prewarm;

#if ODIN_INSPECTOR
        [LabelText("Spawn as children?")]
#endif
        [SerializeField] private bool _spawnObjectsAsChildren;

        public ObjectPoolItemSystem Prefab => _prefab;
        public uint Capacity => _capacity;
        public bool IsPreWarmEnabled => _prewarm;
        public bool IsParentForSpawnedObjects => _spawnObjectsAsChildren;
    }
}