using System;
using UnityEngine;

namespace Noir {
    public abstract class NoirSingletonBehaviour<T> : NoirBehaviour where T : MonoBehaviour {
        protected static T _instance = null;

        private static readonly object _lock = new();

        public static T Instance {
            get {
                if (!_instance) {
                    lock (_lock) {
                        if (!_instance) {
                            _instance = UnityEngine.Object.FindFirstObjectByType<T>(FindObjectsInactive.Include);
                        }
                    }
                }
                return _instance;
            }
        }

        private void Awake() {
            if (CheckInstance(SingletonAwake)) {
                DontDestroyOnLoad(gameObject);
                _instance = GetComponent<T>();
            }
        }

        protected virtual void SingletonAwake() { }

        private void Start() => CheckInstance(SingletonStart);

        protected virtual void SingletonStart() { }

        private bool CheckInstance(Action callback) {
            if (_instance && _instance != this) {
                Destroy(this);
                return false;
            }
            callback();
            return true;
        }

        private void OnDisable() {
            OnDisabled(false);
        }

        private void OnDestroy() {
            OnDisabled(true);
        }

        private void OnEnable() {
            OnEnabled();
        }

        protected virtual void OnDisabled(bool isDestroyed = false) {

        }

        protected virtual void OnEnabled() {

        }
    }
}