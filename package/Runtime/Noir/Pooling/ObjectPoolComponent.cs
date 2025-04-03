#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;

namespace Noir.Pooling {
    /// <summary>
    /// Configures an object for use with a <see cref="ObjectPoolSystem"/>.
    /// </summary>
    [AddComponentMenu("Noir/Pooling/Object Pool Data")]
    public class ObjectPoolComponent : NoirBehaviour {
#if ODIN_INSPECTOR
        [AssetsOnly]
#endif
        [Tooltip("The gameobject to spawn using the object pool")]
        [SerializeField] private ObjectPoolItemSystem _prefab;

        [Tooltip("The max capacity of the object pool")]
        [SerializeField] private uint _capacity = 128;

#if ODIN_INSPECTOR
        [LabelText("Pre-Warm?")]
#endif
        [Tooltip("If checked, the pool will be filled with instances when the gameobject is first instantiated")]
        [SerializeField] private bool _prewarm;

#if ODIN_INSPECTOR
        [LabelText("Spawn as children?")]
#endif
        [Tooltip("If checked, the spawned objects will be children of the ObjectPoolSystem gameobject")]
        [SerializeField] private bool _spawnObjectsAsChildren;

        /// <summary>
        /// The gameobject to spawn using the object pool
        /// </summary>
        public ObjectPoolItemSystem Prefab => _prefab;

        /// <summary>
        /// The max size of the pool
        /// </summary>
        public uint Capacity => _capacity;

        /// <summary>
        /// Should the object pool pre-generate all the items at startup?
        /// </summary>
        public bool IsPreWarmEnabled => _prewarm;

        /// <summary>
        /// Should the <see cref="ObjectPoolSystem"/> gameobject be the parent for spawned objects?
        /// </summary>
        public bool IsParentForSpawnedObjects => _spawnObjectsAsChildren;
    }
}