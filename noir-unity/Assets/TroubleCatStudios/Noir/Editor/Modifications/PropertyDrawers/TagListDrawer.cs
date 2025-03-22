using Noir.Unity.Attributes;
using System;
using UnityEditor;
using UnityEngine;

namespace NoirUnityEditor.Modifications.PropertyDrawers {
    [CustomPropertyDrawer(typeof(TagListAttribute))]
    public class TagListPropertyDrawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            EditorGUI.BeginProperty(position, label, property);
            EditorGUI.LabelField(position, label);

            if (property.propertyType == SerializedPropertyType.String) {
                var tags = UnityEditorInternal.InternalEditorUtility.tags;
                var index = Array.IndexOf(tags, property.stringValue);
                index = Mathf.Clamp(index, 0, tags.Length - 1);
                index = EditorGUILayout.Popup(index, tags);
                property.stringValue = tags[index];
            } else {
                EditorGUI.HelpBox(position, string.Format("{0} is not a string type. Only use [TagList] with strings.", property.name), MessageType.Error);
            }

            EditorGUI.EndProperty();
        }
    }
}
