using System.Collections.Generic;
using System.Linq;
using Noir.Events;
using UnityEditor;
using UnityEngine;

namespace NoirEditor.Editors.PropertyDrawers {
    [CustomPropertyDrawer(typeof(NoirEvent))]
    internal class NoirEventPropertyDrawer : PropertyDrawer {
        private static List<NoirEvent> _events = null;

        private static void LoadEvents() {
            var eventguids = AssetDatabase.FindAssets("t:NoirEvent").ToList();
            if (_events == null || eventguids.Count != _events.Count) {
                if (_events == null) _events = new List<NoirEvent>();
                _events.Clear();
                foreach (var guid in eventguids) {
                    var eventPath = AssetDatabase.GUIDToAssetPath(guid);
                    var ev = AssetDatabase.LoadAssetAtPath<NoirEvent>(eventPath);
                    _events.Add(ev);
                }
            }
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            if (_events == null) {
                LoadEvents();
            }

            EditorGUI.BeginProperty(position, label, property);
            EditorGUI.BeginChangeCheck();

            var refreshIcon = EditorGUIUtility.IconContent("Refresh");
            var popupRect = new Rect(position.x, position.y, position.width - 45, position.height);
            var refreshRect = new Rect(position.x + position.width - 40, position.y, 40, position.height);
            var savedObject = property.objectReferenceValue;
            var name = savedObject?.name ?? "null";

            var wasAutoBound = false;
            //var autoBindAttr = property == null ? (AutoBindEventAttribute)null : PropertyUtility.GetAttribute<AutoBindEventAttribute>(property);
            //if (autoBindAttr != null && name == "null") {
            //    name = autoBindAttr.EventName;
            //    wasAutoBound = true;
            //}

            var index = -1;
            var i = 0;
            foreach (var ev in _events) {
                if (ev.name == name) {
                    index = i;
                    break;
                }
                i++;
            }

            //Debug.Log($"index={index}, name={name}, savedObject={savedObject?.name ?? "null"}, events={_events.Count}", savedObject);

            // build out the list
            var newIndex = EditorGUI.Popup(popupRect, label.text, index, _events.Select(v => v.name).ToArray());
            if (newIndex != index || wasAutoBound) {
                Debug.Log($"newIndex={newIndex}");
                property.objectReferenceValue = _events[newIndex];
                GUI.changed = true;
                property.serializedObject.ApplyModifiedProperties();
            }

            EditorGUI.EndChangeCheck();

            if (GUI.Button(refreshRect, refreshIcon, EditorStyles.toolbarButton)) {
                LoadEvents();
            }
            EditorGUI.EndProperty();
        }
    }
}