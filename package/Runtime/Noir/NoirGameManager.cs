using UnityEngine;

namespace Noir {
    public sealed class NoirGameManager : NoirSingletonBehaviour<NoirGameManager> {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        private static void OnFirstSceneLoad() {
            if (!_instance) {
                var config = NoirProjectConfiguration.Instance;
                GameObject instance = null;
                if (config.IsAutomaticSpawnEnabled) {
                    if (config.GameManagerPrefab) {
                        var manager = GameObject.Instantiate<NoirGameManager>(config.GameManagerPrefab, Vector3.zero, Quaternion.identity);
                        instance = manager.gameObject;
                    } else {
                        instance = new GameObject($"{nameof(NoirGameManager)}", typeof(NoirGameManager));
                    }
                }
            }
        }
    }
}