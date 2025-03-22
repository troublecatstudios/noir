
using UnityEngine;

namespace NoirUnityEditor {
    public static class NoirEditorUtility {
        /// <summary>
        /// Determines whether the editor is in prefab editing mode.
        /// </summary>
        /// <param name="prefabStage">The current prefab editor stage.</param>
        /// <returns>
        ///   <c>true</c> if the editor is in prefab edit mode; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsInPrefabEditMode(out UnityEditor.SceneManagement.PrefabStage prefabStage) {
            prefabStage = UnityEditor.SceneManagement.PrefabStageUtility.GetCurrentPrefabStage();
            return prefabStage != null;
        }

        /// <summary>
        /// Tries to create an object in the current scene.
        /// </summary>
        /// <param name="objectName">Name of the object.</param>
        /// <param name="newObject">The new object.</param>
        /// <param name="parent">The parent of the object in the hierarchy.</param>
        /// <returns></returns>
        public static bool TryCreateObjectInScene(string objectName, out GameObject newObject, GameObject parent = null) {
            newObject = new GameObject(objectName);
            if (!parent && IsInPrefabEditMode(out var prefabStage)) {
                parent = prefabStage.prefabContentsRoot;
            }

            if (parent) {
                newObject.transform.parent = parent.transform;
            }
            return true;
        }

        /// <summary>
        /// Tries to instantiate a copy of a GameObject in the current scene.
        /// </summary>
        /// <param name="objectName">Name of the object.</param>
        /// <param name="sourceObject">The GameObject to use as the basis for the new object.</param>
        /// <param name="newObject">The new object.</param>
        /// <param name="parent">The parent of the object in the hierarchy.</param>
        /// <returns></returns>
        public static bool TryCreateObjectInScene(string objectName, GameObject sourceObject, out GameObject newObject, GameObject parent = null) {
            newObject = GameObject.Instantiate(sourceObject);
            newObject.name = objectName;
            if (!parent && IsInPrefabEditMode(out var prefabStage)) {
                parent = prefabStage.prefabContentsRoot;
            }

            if (parent) {
                parent.transform.parent = parent.transform;
            }
            return true;
        }

        /// <summary>
        /// Gets a component by type within the current scene.
        /// </summary>
        /// <typeparam name="T">The component type.</typeparam>
        /// <returns>The component instance or <c>null</c> if none could be found.</returns>
        /// <remarks>
        /// GetComponentInScene supports finding components within both normal scene editing and prefab editing mode
        /// </remarks>
        public static T GetComponentInScene<T>() where T : Component {
            if (IsInPrefabEditMode(out var stage)) {
                return stage.FindComponentOfType<T>();
            }
            return GameObject.FindObjectOfType<T>();
        }

        /// <summary>
        /// Gets a set of components by type within the current scene.
        /// </summary>
        /// <typeparam name="T">The components type.</typeparam>
        /// <returns>An array containing all the component instances or <c>null</c> if none could be found.</returns>
        /// <remarks>
        /// GetComponentsInScene supports finding components within both normal scene editing and prefab editing mode
        /// </remarks>
        public static T[] GetComponentsInScene<T>() where T : Component {
            if (IsInPrefabEditMode(out var stage)) {
                return stage.FindComponentsOfType<T>();
            }
            return GameObject.FindObjectsOfType<T>();
        }
    }
}
