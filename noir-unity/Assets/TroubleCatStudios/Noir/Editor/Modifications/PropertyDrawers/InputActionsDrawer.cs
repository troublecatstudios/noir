using Noir.Unity.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace NoirUnityEditor.Modifications.PropertyDrawers {
#if ENABLE_INPUT_SYSTEM
    [CustomPropertyDrawer(typeof(InputActionAttribute))]
    public class InputActionsDrawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            EditorGUI.BeginProperty(position, label, property);
            if (property.propertyType == SerializedPropertyType.String) {
                var scheme = new InputScheme();
                var items = new List<string>();
                foreach (var map in scheme.asset.actionMaps) {
                    foreach (var action in map.actions) {
                        items.Add($"{map.name}/{action.name}");
                    }
                }

                var index = items.IndexOf(property.stringValue);
                index = Mathf.Clamp(index, 0, items.Count - 1);
                index = EditorGUILayout.Popup(label, index, items.ToArray());
                property.stringValue = items[index];
            } else {
                EditorGUI.HelpBox(position, string.Format("{0} is not a string type. Only use [InputAction] with strings.", property.name), MessageType.Error);
            }

            EditorGUI.EndProperty();
        }
    }
#endif
}
