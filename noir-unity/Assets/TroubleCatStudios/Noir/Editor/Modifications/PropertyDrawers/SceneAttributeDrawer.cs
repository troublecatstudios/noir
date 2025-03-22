using Noir.Unity.Attributes;
using UnityEditor;
using UnityEngine;

namespace NoirUnityEditor.Modifications.PropertyDrawers {
    [CustomPropertyDrawer(typeof(SceneAttribute))]
    public class SceneAttributeDrawer : PropertyDrawer {

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {

            if (property.propertyType == SerializedPropertyType.String) {
                var sceneObject = GetSceneObject(property.stringValue);
                var scene = EditorGUI.ObjectField(position, label, sceneObject, typeof(SceneAsset), true);
                if (scene == null) {
                    property.stringValue = "";
                } else if (scene.name != property.stringValue) {
                    var sceneObj = GetSceneObject(scene.name);
                    if (sceneObj == null) {
                        EditorUtility.DisplayDialog("Cannot use Scene", $"The scene {scene.name} cannot be used. To use this scene add it to the build settings for the project", "Ok");
                    } else {
                        property.stringValue = scene.name;
                    }
                }
            } else {
                EditorGUI.HelpBox(position, string.Format("{0} is not a string type. Only use [Scene] with strings.", property.name), MessageType.Error);
            }
        }
        protected SceneAsset GetSceneObject(string sceneObjectName) {
            if (string.IsNullOrEmpty(sceneObjectName)) {
                return null;
            }

            foreach (var editorScene in EditorBuildSettings.scenes) {
                if (editorScene.path.IndexOf(sceneObjectName) != -1) {
                    return AssetDatabase.LoadAssetAtPath(editorScene.path, typeof(SceneAsset)) as SceneAsset;
                }
            }
            Debug.LogWarning("Scene '" + sceneObjectName + "' cannot be used. Add this scene to the 'Scenes in the Build' in build settings.");
            return null;
        }
    }
}
