using System.Reflection;
using Noir.Attributes;
using NoirEditor.Reflection;
using UnityEditor;
using UnityEngine;

namespace NoirEditor.Editors.PropertyDrawers {
    [CustomPropertyDrawer(typeof(GetComponentAttribute))]
    internal class GetComponentPropertyDrawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // First, lets attempt to find a valid component we could hook into this property
            var component = FindAutohookTarget(property);
            if (component) {
                // if we found something, AND the autohook is empty, lets slot it.
                // the reason were straight up looking for a target component is so we
                // can skip drawing the field if theres a valid autohook.
                // this just looks a bit cleaner but isnt particularly safe. YMMV
                if (property.objectReferenceValue == null)
                    property.objectReferenceValue = component;
            }
            EditorGUI.PropertyField(position, property, label);
            GUI.enabled = true;
        }

        /// <summary>
        /// Takes a SerializedProperty and finds a local component that can be slotted into it.
        /// Local in this context means its a component attached to the same GameObject.
        /// This could easily be changed to use GetComponentInParent/GetComponentInChildren
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        private Component FindAutohookTarget(SerializedProperty property) {
            var root = property.serializedObject;
            var attribute = Reflector.GetAttribute<GetComponentAttribute>(property);

            if (root.targetObject is Component) {
                // first, lets find the type of component were trying to autohook...
                var type = GetTypeFromProperty(property);

                Component component = (Component)root.targetObject;
                Component target = ResolveHook(component, type, attribute.SearchArea);
                return target;
            } else {
                Debug.Log("OH NO handle fails here better pls");
            }

            return null;
        }

        private static Component ResolveHook(Component component, System.Type type, GetComponentSearchArea searchArea) {
            Component target = null;
            if (searchArea == GetComponentSearchArea.ParentFirst) target = component.GetComponentInParent(type);
            if (searchArea == GetComponentSearchArea.ChildrenFirst) target = component.GetComponentInChildren(type);
            if (!target) {
                target = component.GetComponent(type);
            }
            return target;
        }

        /// <summary>
        /// Uses reflection to get the type from a serialized property
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        private static System.Type GetTypeFromProperty(SerializedProperty property) {
            // first, lets get the Type of component this serialized property is part of...
            var parentComponentType = property.serializedObject.targetObject.GetType();
            var info = parentComponentType.GetTypeInfo();
            // ... then, using reflection well get the raw field info of the property this
            // SerializedProperty represents...
            var fields = info.DeclaredFields;
            foreach (var f in fields) {
                if (f.Name == property.propertyPath) {
                    return f.FieldType;
                }
            }

            var super = property.serializedObject.targetObject.GetType().BaseType;
            var monobehaviour = typeof(MonoBehaviour).FullName;
            var lastType = super.FullName;
            int count = 0;
            while(super.FullName != monobehaviour && count++ < 10) {
                var superFields = super.GetTypeInfo().DeclaredFields;
                foreach (var f in superFields) {
                    if (f.Name == property.propertyPath) {
                        return f.FieldType;
                    }
                }
                super = super.BaseType;
                if (lastType == super.FullName) {
                    break;
                } else {
                    lastType = super.FullName;
                }
            }


            var fieldInfo = parentComponentType.GetField(property.propertyPath) ?? super.GetField(property.propertyPath);
            // ... using that we can return the raw .net type!
            if (fieldInfo == null) {
                string error = "";
                foreach (var f in fields) {
                    error += f.Name + ",";
                }
                throw new System.Exception($"Unable to determine field type for {property.propertyPath} of {parentComponentType.FullName}. {error}");
            }

            return fieldInfo.FieldType;
        }
    }
}