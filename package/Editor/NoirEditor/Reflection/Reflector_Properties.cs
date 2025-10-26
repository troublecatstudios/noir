using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace NoirEditor.Reflection {
    internal static partial class Reflector {

        public static PropertyInfo GetProperty(object target, string propertyName, BindingFlags flags = DefaultFlags) {
            return GetAllProperties(target, p => p.Name.Equals(propertyName, StringComparison.InvariantCulture), flags).FirstOrDefault();
        }

        public static object GetPropertyValue(this object obj, string name, BindingFlags flags = DefaultFlags) {
            if (obj == null) return null;
            var parts = name.Split('.');
            var type = obj.GetType();
            var prop = type.GetProperty(parts[0], flags);
            var retVal = prop.GetValue(obj);
            for(var idx = 1; idx < parts.Length; idx++) {
                type = retVal.GetType();
                prop = type.GetProperty(parts[idx], flags);
                if (prop == null) return null;
                retVal = prop.GetValue(retVal);
            }
            return retVal;
        }

        public static T GetPropertyValue<T>(this object obj, string name, BindingFlags flags = DefaultFlags) {
            object retval = obj.GetPropertyValue(name, flags);
            if (retval == null) { return default; }

            // throws InvalidCastException if types are incompatible
            return (T)retval;
        }

        private static Func<PropertyInfo, bool> AllProperties = (p) => true;
        public static IEnumerable<PropertyInfo> GetAllProperties(object target, Func<PropertyInfo, bool> predicate = null, BindingFlags flags = DefaultFlags) {
            predicate = predicate ?? AllProperties;
            var types = new List<Type>()
            {
                target.GetType()
            };

            while (types.Last().BaseType != null) {
                types.Add(types.Last().BaseType);
            }

            for (int i = types.Count - 1; i >= 0; i--) {
                IEnumerable<PropertyInfo> propertyInfos = types[i]
                    .GetProperties(flags)
                    .Where(NotObsolete)
                    .Where(predicate);

                foreach (var propertyInfo in propertyInfos) {
                    yield return propertyInfo;
                }
            }
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
                Debug.LogError($"Error reading property {property.propertyPath} on object of type {targetObjectClassType.FullName}. {e}", targetObject);
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