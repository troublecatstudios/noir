using System;
using System.Collections.Generic;
using System.Linq;
using NoirEditor.Reflection;
using Noir.Logging;
using Noir.Variables;
using UnityEditor;
using UnityEngine;

namespace NoirEditor.Editors.PropertyDrawers {
    [CustomPropertyDrawer(typeof(DataVariable<>))]
    internal class DataVariablePropertyDrawer : PropertyDrawer {
        private static List<DataVariable> _allVariables = null;

        private static void LoadVariables() {
            var variableGuids = AssetDatabase.FindAssets("t:DataVariable").ToList();
            if (_allVariables == null || variableGuids.Count != _allVariables.Count) {
                if (_allVariables == null) _allVariables = new List<DataVariable>();
                _allVariables.Clear();
                foreach (var guid in variableGuids) {
                    var path = AssetDatabase.GUIDToAssetPath(guid);
                    var v = AssetDatabase.LoadAssetAtPath<DataVariable>(path);
                    _allVariables.Add(v);
                }
            }
        }

        private System.Reflection.FieldInfo ResolvePropertyField(SerializedProperty property) {
            var type = property.serializedObject.targetObject.GetType();
            var field = type.GetField(property.name);
            // Debug.LogWarning($"ResolvePropertyField type={type.Name}, propertyPath={property.propertyPath}");
            if (property.propertyPath.Contains(".")) {
                var segments = property.propertyPath.Split('.');
                var so = property.serializedObject;
                foreach (var segment in segments) {
                    field = Reflector.GetField(type, segment);
                    if (field != null) {
                        // Debug.LogWarning($"ResolvePropertyField segment={segment}, field={field.Name}, type={type.Name}, fieldType={field.FieldType.Name}");
                        type = field.FieldType;
                    }
                }
            }

            return field;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            if (_allVariables == null) {
                LoadVariables();
            }
            EditorGUI.BeginProperty(position, label, property);
            EditorGUI.BeginChangeCheck();

            // present the field
            var refreshIcon = EditorGUIUtility.IconContent("Refresh");
            var popupRect = new Rect(position.x, position.y, position.width - 45, position.height);
            var refreshRect = new Rect(position.x + position.width - 40, position.y, 40, position.height);

            try {
                var savedObject = property.objectReferenceValue;
                var type = property.serializedObject.targetObject.GetType();
                var field = type.GetField(property.name);
                if (field == null) {
                    field = type.GetField(property.name, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.GetField);
                }

                if (field == null) {
                    field = ResolvePropertyField(property);
                }

                var name = savedObject?.name ?? "null";
                Type dataType = null;
                foreach (var t in field.FieldType.GetGenericArguments()) {
                    dataType = t;
                }

                // build out the list
                var list = _allVariables.Where(v => v.ToObject().GetType() == dataType).ToList();
                var index = savedObject ? -1 : list.IndexOf(savedObject as DataVariable);

                var wasAutoBound = false;
                var autoBindAttr = Reflector.GetAttribute<NoirVariableAttribute>(property);
                if (autoBindAttr != null && name == "null") {
                    name = autoBindAttr.VariableName;
                    wasAutoBound = true;
                }

                var i = 0;
                foreach (var v in list) {
                    if (v.name == name) {
                        index = i;
                        break;
                    }
                    i++;
                }

                try {
                    var newIndex = EditorGUI.Popup(popupRect, label.text, index, list.Select(v => v.name).ToArray());

                    if (newIndex != -1 && (newIndex != index || wasAutoBound)) {
                        property.objectReferenceValue = list[newIndex];
                        GUI.changed = true;
                    }
                } catch (ArgumentOutOfRangeException) {

                }

                //EditorGUI.LabelField(position, $"type={property.type}, propertyType={property.propertyType}");

                if (EditorGUI.EndChangeCheck()) {
                    property.serializedObject.ApplyModifiedProperties();
                }
            } catch {
                var type = property.serializedObject.targetObject.GetType();
                var text = $"{property.propertyPath}";
                var field = ResolvePropertyField(property);
                Debug.LogWarning($"Exception during field render type={type.Name}, property={property.name}, field={field.FieldType.Name}, text={text}");
            }


            if (GUI.Button(refreshRect, refreshIcon, EditorStyles.toolbarButton)) {
                LoadVariables();
            }
            EditorGUI.EndProperty();
        }

        /// <summary>
        /// Gets the declared type of the specified object.
        /// </summary>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="obj">The object.</param>
        /// <returns>
        /// A <see cref="Type"/> object representing type
        /// <typeparamref name="T"/>; i.e., the type of <paramref name="obj"/>
        /// as it was declared. Note that the contents of
        /// <paramref name="obj"/> are irrelevant; if <paramref name="obj"/>
        /// contains an object whose class is derived from
        /// <typeparamref name="T"/>, then <typeparamref name="T"/> is
        /// returned, not the derived type.
        /// </returns>
        private static Type GetDeclaredType<T>(T obj) {
            return typeof(T);
        }
    }
}