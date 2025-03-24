using UnityEngine;

namespace Noir {
    public class NoirProjectConfiguration : ScriptableObject {
        private static readonly object _lock = new();
        private static NoirProjectConfiguration _instance = null;
        public static NoirProjectConfiguration Instance {
            get {
                if (!_instance) {
                    lock (_lock) {
                        _instance = Resources.Load<NoirProjectConfiguration>(nameof(NoirProjectConfiguration));
                    }
                }

                return _instance;
            }
        }


#if ODIN_INSPECTOR
        [AssetsOnly]
        [ShowIf("@_selectedParent == \"Home\"")]
#endif
        [SerializeField]
        private NoirGameManager _gameManagerPrefab;

#if ODIN_INSPECTOR
        [ShowIf("@_selectedParent == \"Gameplay\"")]
#endif
        [SerializeField]
        private bool _lockFrameRate = true;

#if ODIN_INSPECTOR
        [ShowIf("@_selectedParent == \"Gameplay\" && _lockFrameRate")]
#endif
        [SerializeField]
        private int _lockedFrameRate = 60;

#if ODIN_INSPECTOR
        [ShowIf("@_selectedParent == \"Home\"")]
#endif
        [SerializeField]
        private bool _automaticallySpawnGameManagers = true;

        public int LockedFrameRate => _lockedFrameRate;
        public bool IsFramerateLocked => _lockFrameRate;
        public bool IsAutomaticSpawnEnabled => _automaticallySpawnGameManagers;
        public NoirGameManager GameManagerPrefab => _gameManagerPrefab;
    }
}