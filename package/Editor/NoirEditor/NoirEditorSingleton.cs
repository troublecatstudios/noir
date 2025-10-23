using UnityEngine;
// ReSharper disable InconsistentNaming

namespace NoirEditor {
    /// <summary>
    /// ScriptableObject-based singleton for GUI-less editor plug-ins.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <remarks>
    /// OnEnable() / OnDisable() should be used to register with any global events to properly support domain reloads.
    /// </remarks>
    public abstract class EditorSingleton<T> : ScriptableObject
        where T : EditorSingleton<T> {

        /// <summary>
        /// The singleton instance of type <typeparamref name="T"/>.
        /// </summary>
        /// <remarks>
        /// This is not thread safe, but should be fine for use within ScriptableObjects within the Unity Editor.
        /// </remarks>
        public static T instance => _instance != null ? _instance : Initialize();

        private static T _instance;

        /// <summary>
        /// Finds or creates the singleton instance and stores it in _instance.
        /// </summary>
        /// <returns>The singleton instance.</returns>
        /// <remarks>
        /// Can be called from a derived type to ensure creation of the singleton using the [InitializeOnLoadMethod] attribute on a static method.
        /// </remarks>
        protected static T Initialize() {
            // If the instance is already valid, return it. Needed if called from a
            // derived class that wishes to ensure the instance is initialized.
            if (_instance != null) return _instance;

            // Find the existing instance or creates a new one.
            var instances = Resources.FindObjectsOfTypeAll<T>();
            return instances.Length > 0 ? _instance = instances[0] :
                CreateInstance<T>();
        }

        /// <summary>
        /// Called once during creation of this instance
        /// </summary>
        /// <remarks>
        /// Derived classes should call this base method first if overridden.
        /// </remarks>
        protected virtual void Awake() {
            // Verify there is only a single instance; catches accidental creation
            // from other CreateInstance() calls.
            Debug.Assert(_instance == null);

            // Ensure _instance is assigned here to prevent possible double-creation
            // should the instance property be called by a derived class handler.
            _instance = (T)this;

            // Prevent Resources.UnloadUnusedAssets() from destroying the singleton
            // instance if called or when new scenes are loaded.
            _instance.hideFlags = HideFlags.HideAndDontSave;
        }
    }
}