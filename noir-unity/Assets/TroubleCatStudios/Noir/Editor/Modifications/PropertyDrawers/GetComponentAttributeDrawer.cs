using Noir.Unity.Attributes;
using NoirUnityEditor.Utility;
using System.Reflection;
using UnityEditor;
using UnityEngine;

// -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
// Fork of AutohookAttribute by the extremely talented Lotte:
// Original Source: https://gist.github.com/LotteMakesStuff/d6a9a4944fc667e557083108606b7d22
// Donate to Lotte: https://ko-fi.com/lotte | https://t.co/E7RCjsxCFw | https://t.co/I4JELT2QzR
// Follow them on Twitter: https://twitter.com/LotteMakesStuff
// -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

namespace NoirUnityEditor.Modifications.PropertyDrawers {
    [CustomPropertyDrawer(typeof(GetComponentAttribute))]
    public class GetComponentAttributeDrawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // First, lets attempt to find a valid component we could hook into this property
            var component = FindAutohookTarget(property);
            if (component != null) {
                // if we found something, AND the autohook is empty, lets slot it.
                // the reason were straight up looking for a target component is so we
                // can skip drawing the field if theres a valid autohook.
                // this just looks a bit cleaner but isnt particularly safe. YMMV
                if (property.objectReferenceValue == null)
                    property.objectReferenceValue = component;
                //GUI.enabled = false;
            }

            // havent found one? lets just draw the default property field, let the user manually
            // hook something in.
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
            var attribute = PropertyUtility.GetAttribute<GetComponentAttribute>(property);

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
            var superFields = super.GetTypeInfo().DeclaredFields;
            foreach (var f in superFields) {
                if (f.Name == property.propertyPath) {
                    return f.FieldType;
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
