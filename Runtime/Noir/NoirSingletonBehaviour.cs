using System;
using UnityEngine;

namespace Noir {
    /// <summary>
    /// Abstract base class for singleton behaviours in Noir.
    /// Ensures that only one instance of type <typeparamref name="T"/> exists in the scene.
    /// </summary>
    /// <typeparam name="T">The type of the singleton MonoBehaviour.</typeparam>
    public abstract class NoirSingletonBehaviour<T> : NoirBehaviour where T : MonoBehaviour {

        /// <summary>
        /// The singleton instance of type <typeparamref name="T"/>.
        /// </summary>
        protected static T _instance = null;

        private static readonly object _lock = new();

        /// <summary>
        /// Gets the singleton instance of type <typeparamref name="T"/>.
        /// Searches for an instance in the scene if not already set.
        /// </summary>
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

        /// <summary>
        /// Called when the singleton instance is awoken.
        /// Override to provide custom awake logic for the singleton.
        /// </summary>
        protected virtual void SingletonAwake() { }

        private void Start() => CheckInstance(SingletonStart);

        /// <summary>
        /// Called when the singleton instance is started.
        /// Override to provide custom start logic for the singleton.
        /// </summary>
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

        /// <summary>
        /// Called when the singleton instance is disabled or destroyed.
        /// Override to provide custom logic for disable/destroy events.
        /// </summary>
        /// <param name="isDestroyed">True if the component was destroyed, false if just disabled.</param>
        protected virtual void OnDisabled(bool isDestroyed = false) {

        }

        /// <summary>
        /// Called when the singleton instance is enabled.
        /// Override to provide custom logic for enable events.
        /// </summary>
        protected virtual void OnEnabled() {

        }
    }
}