using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace NoirEditor {
    internal static class InternalUnityEditor {
        internal static class ParallelSync {
            /// <summary>
            /// Name used for an identifying file created in the clone project directory.
            /// </summary>
            /// <remarks>
            /// (!) Do not change this after the clone was created, because then connection will be lost.
            /// </remarks>
            public const string CloneFileName = ".clone";
            private static bool? isCloneFileExistCache = null;
            /// <summary>
            /// Get the path to the current unityEditor project folder's info
            /// </summary>
            /// <returns></returns>
            public static string GetCurrentProjectPath()
            {
                return Application.dataPath.Replace("/Assets", "");
            }

            /// <summary>
            /// Returns true if the project currently open in Unity Editor is a clone.
            /// </summary>
            /// <returns></returns>
            public static bool IsClone()
            {
                if (isCloneFileExistCache == null)
                {
                    /// The project is a clone if its root directory contains an empty file named ".clone".
                    string cloneFilePath = Path.Combine(GetCurrentProjectPath(), CloneFileName);
                    isCloneFileExistCache = File.Exists(cloneFilePath);
                }

                return (bool)isCloneFileExistCache;
            }
        }
        internal static class SceneControl {
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
                if (PrefabUtility.IsPartOfPrefabAsset(sourceObject)) {
                    newObject = PrefabUtility.InstantiatePrefab(sourceObject) as GameObject;
                } else {
                    newObject = GameObject.Instantiate(sourceObject);
                }

                if (!newObject) {
                    EditorUtility.DisplayDialog("Error", $"Unable to create instance in scene for '{objectName}'.", "Ok");
                    return false;
                }

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

        internal static class Core {
            public static IEnumerable<(string Name, uint Id)> GetSortingLayers() {
                var tagManager = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset")[0]);
                var sortingLayersProp = tagManager.FindProperty("m_SortingLayers");
                var results = new List<(string Name, uint Id)>();
                var max = sortingLayersProp.arraySize;
                for (var i = 0; i < max; i++) {
                    var sortingLayer = sortingLayersProp.GetArrayElementAtIndex(i);
                    var name = sortingLayer.FindPropertyRelative("name").stringValue;
                    var id = sortingLayer.FindPropertyRelative("uniqueID").intValue;
                    results.Add((name, (uint)id));
                }
                return results;
            }
        }

        internal static class Audio {
            public static bool IsPreviewClipPlaying() {
                Assembly unityEditorAssembly = typeof(AudioImporter).Assembly;

                Type audioUtilClass = unityEditorAssembly.GetType("UnityEditor.AudioUtil");
                MethodInfo method = audioUtilClass.GetMethod(
                    "IsPreviewClipPlaying",
                    BindingFlags.Static | BindingFlags.Public,
                    null,
                    new Type[] { },
                    null
                );

                return (bool)method.Invoke(
                    null,
                    new object[] { }
                );
            }

            public static void PlayClip(AudioClip clip, int startSample = 0, bool loop = false) {
                Assembly unityEditorAssembly = typeof(AudioImporter).Assembly;

                Type audioUtilClass = unityEditorAssembly.GetType("UnityEditor.AudioUtil");
                MethodInfo method = audioUtilClass.GetMethod(
                    "PlayPreviewClip",
                    BindingFlags.Static | BindingFlags.Public,
                    null,
                    new Type[] { typeof(AudioClip), typeof(int), typeof(bool) },
                    null
                );

                method.Invoke(
                    null,
                    new object[] { clip, startSample, loop }
                );
            }

            public static void StopAllClips() {
                Assembly unityEditorAssembly = typeof(AudioImporter).Assembly;

                Type audioUtilClass = unityEditorAssembly.GetType("UnityEditor.AudioUtil");
                MethodInfo method = audioUtilClass.GetMethod(
                    "StopAllPreviewClips",
                    BindingFlags.Static | BindingFlags.Public,
                    null,
                    new Type[] { },
                    null
                );

                method.Invoke(
                    null,
                    new object[] { }
                );
            }
        }
    }
}