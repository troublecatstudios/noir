using System;
using System.Collections;
using System.Reflection;
using System.Text.RegularExpressions;
using NoirEditor.Reflection;
using UnityEditor;
using UnityEngine;

namespace NoirEditor {
    // Provide simple value get/set methods for SerializedProperty.  Can be used with
    // any data types and with arbitrarily deeply-pathed properties.
    public static class SerializedPropertyExtensions {
        /// <summary>
        /// Retrieves the value of the specified SerializedProperty.
        /// </summary>
        /// <param name="property">The SerializedProperty from which to retrieve the value.</param>
        /// <returns>The value of the SerializedProperty.</returns>
        /// <remarks>
        /// This method navigates through the property path of the SerializedProperty to retrieve the final value.
        /// </remarks>
        public static object GetValue(this SerializedProperty property) {
            string propertyPath = property.propertyPath;
            object value = property.serializedObject.targetObject;
            int i = 0;
            while (NextPathComponent(propertyPath, ref i, out var token))
                value = GetPathComponentValue(value, token);
            return value;
        }

        /// <summary>
        /// Sets the value of the specified SerializedProperty.
        /// </summary>
        /// <param name="property">The SerializedProperty for which to set the value.</param>
        /// <param name="value">The new value to set for the SerializedProperty.</param>
        /// <remarks>
        /// This method records an undo operation, sets the value of the SerializedProperty, marks the object as dirty, and applies the modified properties.
        /// </remarks>
        public static void SetValue(this SerializedProperty property, object value) {
            Undo.RecordObject(property.serializedObject.targetObject, $"Set {property.name}");

            SetValueNoRecord(property, value);

            EditorUtility.SetDirty(property.serializedObject.targetObject);
            property.serializedObject.ApplyModifiedProperties();
        }

        /// <summary>
        /// Sets the value of the specified SerializedProperty.
        /// </summary>
        /// <param name="property">The SerializedProperty for which to set the value.</param>
        /// <param name="value">The new value to set for the SerializedProperty.</param>
        /// <remarks>
        /// This method sets the value of the SerializedProperty, however the change will not be persisted unless you call SetDirty and ApplyModifiedProperties. Also, no undo operation is recorded.
        /// </remarks>
        public static void SetValueNoRecord(this SerializedProperty property, object value) {
            string propertyPath = property.propertyPath;
            object container = property.serializedObject.targetObject;

            int i = 0;
            NextPathComponent(propertyPath, ref i, out var deferredToken);
            while (NextPathComponent(propertyPath, ref i, out var token)) {
                container = GetPathComponentValue(container, deferredToken);
                deferredToken = token;
            }
            Debug.Assert(!container.GetType().IsValueType, GetCannotSetStructMessage(container.GetType()));
            SetPathComponentValue(container, deferredToken, value);
        }

        // Union type representing either a property name or array element index.  The element
        // index is valid only if propertyName is null.
        struct PropertyPathComponent {
            public string propertyName;
            public int elementIndex;
        }

        private static readonly Regex arrayElementRegex = new Regex(@"\GArray\.data\[(\d+)\]", RegexOptions.Compiled);

        // Parse the next path component from a SerializedProperty.propertyPath.  For simple field/property access,
        // this is just tokenizing on '.' and returning each field/property name.  Array/list access is via
        // the pseudo-property "Array.data[N]", so this method parses that and returns just the array/list index N.
        //
        // Call this method repeatedly to access all path components.  For example:
        //
        //      string propertyPath = "quests.Array.data[0].goal";
        //      int i = 0;
        //      NextPropertyPathToken(propertyPath, ref i, out var component);
        //          => component = { propertyName = "quests" };
        //      NextPropertyPathToken(propertyPath, ref i, out var component)
        //          => component = { elementIndex = 0 };
        //      NextPropertyPathToken(propertyPath, ref i, out var component)
        //          => component = { propertyName = "goal" };
        //      NextPropertyPathToken(propertyPath, ref i, out var component)
        //          => returns false
        private static bool NextPathComponent(string propertyPath, ref int index, out PropertyPathComponent component) {
            component = new PropertyPathComponent();

            if (index >= propertyPath.Length)
                return false;

            var arrayElementMatch = arrayElementRegex.Match(propertyPath, index);
            if (arrayElementMatch.Success) {
                index += arrayElementMatch.Length + 1; // Skip past next '.'
                component.elementIndex = int.Parse(arrayElementMatch.Groups[1].Value);
                return true;
            }

            int dot = propertyPath.IndexOf('.', index);
            if (dot == -1) {
                component.propertyName = propertyPath.Substring(index);
                index = propertyPath.Length;
            } else {
                component.propertyName = propertyPath.Substring(index, dot - index);
                index = dot + 1; // Skip past next '.'
            }

            return true;
        }

        private static object GetPathComponentValue(object container, PropertyPathComponent component) {
            if (component.propertyName == null)
                return ((IList)container)[component.elementIndex];
            else
                return GetMemberValue(container, component.propertyName);
        }

        private static void SetPathComponentValue(object container, PropertyPathComponent component, object value) {
            if (component.propertyName == null)
                ((IList)container)[component.elementIndex] = value;
            else
                SetMemberValue(container, component.propertyName, value);
        }

        private static object GetMemberValue(object container, string name) {
            if (container == null)
                return null;
            var type = container.GetType();
            var members = type.GetMember(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            for (int i = 0; i < members.Length; ++i) {
                if (members[i] is FieldInfo field)
                    return field.GetValue(container);
                else if (members[i] is PropertyInfo property)
                    return property.GetValue(container);
            }
            return null;
        }

        private static void SetMemberValue(object container, string name, object value) {
            var type = container.GetType();
            var members = type.GetAllMembers(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.FlattenHierarchy | BindingFlags.Instance);
            Debug.Assert(members != null && members.Count > 0, GetMissingMemberMessage(type, name));
            for (int i = 0; i < members.Count; ++i) {
                // Debug.Log($"SetMemberValue found {members[i].GetType().Name} member: {members[i].Name} ({members[i].MemberType.GetType().Name}) in {container}.");
                if (members[i] is FieldInfo field) {
                    field.SetValue(container, value);
                    return;
                }
                if (members[i] is PropertyInfo property) {
                    property.SetValue(container, value);
                    return;
                }
            }
            Debug.Assert(false, GetSetMemberValueFailedMessage(type, name));
        }

        private static string GetMissingMemberMessage(Type type, string expectedMemberName) {
            return $"SetMemberValue No public/non-public instance members matching '{expectedMemberName}' found in {type.FullName} via reflection. Is the member a field or property with at least protected access level?";
        }

        private static string GetSetMemberValueFailedMessage(Type type, string expectedMemberName) {
            return $"SetMemberValue Failed to set member {type.FullName}.{expectedMemberName} via reflection";
        }

        private static string GetCannotSetStructMessage(Type type) {
            return $"Cannot use SerializedObject.SetValue on a struct object, as the result will be set on a temporary.  Either change {type.Name} to a class, or use SetValue with a parent member.";
        }
    }
}