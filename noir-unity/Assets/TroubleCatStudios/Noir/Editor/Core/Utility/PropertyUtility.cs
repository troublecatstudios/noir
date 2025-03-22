using System;
using System.Collections;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace NoirUnityEditor.Utility {
    public static class PropertyUtility {
        public static T GetAttribute<T>(SerializedProperty property) where T : Attribute {
            T[] attributes = GetAttributes<T>(property);
            return attributes.Length > 0 ? attributes[0] : null;
        }

        public static T[] GetAttributes<T>(SerializedProperty property) where T : Attribute {
            FieldInfo fieldInfo = ReflectionUtility.GetField(GetTargetObject(property), property.name);

            if (fieldInfo == null) return new T[0];

            return (T[])fieldInfo.GetCustomAttributes(typeof(T), true);
        }

        public static UnityEngine.Object GetTargetObject(SerializedProperty property) {
            return property.serializedObject.targetObject;
        }

        /// <summary>
		/// Gets the object the property represents.
		/// </summary>
		/// <param name="property"></param>
		/// <returns></returns>
		public static object GetTargetObjectOfProperty(SerializedProperty property) {
            if (property == null) {
                return null;
            }

            string path = property.propertyPath.Replace(".Array.data[", "[");
            object obj = property.serializedObject.targetObject;
            string[] elements = path.Split('.');

            foreach (var element in elements) {
                if (element.Contains("[")) {
                    string elementName = element.Substring(0, element.IndexOf("["));
                    int index = Convert.ToInt32(element.Substring(element.IndexOf("[")).Replace("[", "").Replace("]", ""));
                    obj = GetValue_Imp(obj, elementName, index);
                } else {
                    obj = GetValue_Imp(obj, element);
                }
            }

            return obj;
        }

        public static T GetValue<T>(SerializedProperty property) {
            var targetObject = GetTargetObject(property);
            var targetObjectClassType = targetObject.GetType();
            try {
                var leaf = GetTargetObjectOfProperty(property);
                return (T)leaf;
            } catch (Exception e) {
                Debug.LogError($"Error reading property {property.propertyPath} on object of type {targetObjectClassType.FullName}. {e.ToString()}", targetObject);
            }

            return default(T);
        }

        public static bool SetValue<T>(SerializedProperty property, T value) {
            var targetObject = property.serializedObject.targetObject;
            var targetObjectClassType = targetObject.GetType();
            var field = targetObjectClassType.GetField(property.propertyPath);
            if (field != null) {
                field.SetValue(targetObject, value);
                return true;
            }
            return false;
        }

        public static Vector3 GetVectorValue(SerializedProperty property) {
            switch (property.propertyType) {
                case SerializedPropertyType.Vector3Int: return property.vector3IntValue;
                case SerializedPropertyType.Vector3: return property.vector3Value;
                case SerializedPropertyType.Vector2Int: return new Vector3(property.vector2IntValue.x, property.vector2IntValue.y);
                case SerializedPropertyType.Vector2: return property.vector2Value;
            }
            return Vector3.zero;
        }

        public static void SetVectorValue(SerializedProperty property, float x = 0f, float y = 0f, float z = 0f) {
            switch (property.propertyType) {
                case SerializedPropertyType.Vector3Int: property.vector3IntValue = new Vector3Int((int)x, (int)y, (int)z); break;
                case SerializedPropertyType.Vector3: property.vector3Value = new Vector3(x, y, z); break;
                case SerializedPropertyType.Vector2Int: property.vector2IntValue = new Vector2Int((int)x, (int)y); break;
                case SerializedPropertyType.Vector2: property.vector2Value = new Vector2(x, y); break;
            }
        }

        private static object GetValue_Imp(object source, string name) {
            if (source == null) {
                return null;
            }

            Type type = source.GetType();

            while (type != null) {
                FieldInfo field = type.GetField(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                if (field != null) {
                    return field.GetValue(source);
                }

                PropertyInfo property = type.GetProperty(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (property != null) {
                    return property.GetValue(source, null);
                }

                type = type.BaseType;
            }

            return null;
        }

        private static object GetValue_Imp(object source, string name, int index) {
            var enumerable = GetValue_Imp(source, name) as IEnumerable;
            if (enumerable == null) {
                return null;
            }

            var enumerator = enumerable.GetEnumerator();
            for (int i = 0; i <= index; i++) {
                if (!enumerator.MoveNext()) {
                    return null;
                }
            }

            return enumerator.Current;
        }
    }
}
