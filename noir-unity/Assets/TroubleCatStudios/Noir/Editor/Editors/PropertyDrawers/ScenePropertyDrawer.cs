using Noir.Attributes;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_6_OR_NEWER
using Unity.Properties;
#endif

namespace NoirEditor.Editors.PropertyDrawers {
    [CustomPropertyDrawer(typeof(SceneAttribute), true)]
    public class SceneAssetPropertyDrawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            if (property.propertyType != SerializedPropertyType.String && property.propertyType != SerializedPropertyType.Integer) {
                EditorGUI.LabelField(position, label.text, "You can only use the [SceneAsset] attribute with string or integer types.");
                return;
            }

            var sceneAsset = GetSceneAsset(property);
            var sceneObject = EditorGUI.ObjectField(position, label, sceneAsset, typeof(SceneAsset), true);
            if (sceneObject == null) {
                if (property.propertyType == SerializedPropertyType.String) property.stringValue = "";
                if (property.propertyType == SerializedPropertyType.Integer) property.intValue = -1;
                return;
            }

            if (!GUI.changed) {
                return;
            }

            sceneAsset = LookupSceneAssetByName(sceneObject.name);
            if (sceneAsset == null && GUI.changed) {
                Debug.LogError($"The scene {sceneObject.name} cannot be used. To use this scene add it to the build settings for the project");
                return;
            }

            var index = GetBuildIndexForSceneAsset(sceneAsset);
            if (property.propertyType == SerializedPropertyType.String) property.stringValue = sceneAsset.name;
            if (property.propertyType == SerializedPropertyType.Integer) property.intValue = index;
        }

        private int GetBuildIndexForSceneAsset(SceneAsset asset) {
            int idx = 0;
            foreach (var editorScene in EditorBuildSettings.scenes) {
                if (editorScene.path.IndexOf(asset.name) > -1) {
                    return idx;
                }
                idx++;
            }
            return -1;
        }

        private SceneAsset LookupSceneAssetByIndex(int index) {
            if (index < 0 || index >= EditorBuildSettings.scenes.Length) {
                return null;
            }
            var item = EditorBuildSettings.scenes[index];
            return AssetDatabase.LoadAssetAtPath(item.path, typeof(SceneAsset)) as SceneAsset;
        }

        private SceneAsset LookupSceneAssetByName(string name) {
            if (string.IsNullOrEmpty(name)) {
                return null;
            }
            foreach (var editorScene in EditorBuildSettings.scenes) {
                if (editorScene.path.IndexOf(name) != -1) {
                    return AssetDatabase.LoadAssetAtPath(editorScene.path, typeof(SceneAsset)) as SceneAsset;
                }
            }
            return null;
        }

        protected SceneAsset GetSceneAsset(SerializedProperty prop) {
            if (prop.propertyType == SerializedPropertyType.String) {
                return LookupSceneAssetByName(prop.stringValue);
            }

            if (prop.propertyType == SerializedPropertyType.Integer) {
                return LookupSceneAssetByIndex(prop.intValue);
            }
            return null;
        }
    }
}