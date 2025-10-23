using System;
using System.Linq;
using System.Reflection;
using UnityEditor;

namespace NoirEditor.Reflection {
    internal partial class Reflector {
        public static bool IsDecoratedWithAttribute<TAttr>(this Type type) where TAttr : Attribute {
            var attributeUsage = Attribute.GetCustomAttribute(typeof(TAttr), typeof(AttributeUsageAttribute)) as AttributeUsageAttribute;
            var inherited = attributeUsage?.Inherited ?? false;
            var attributes = type.GetCustomAttributes(typeof(TAttr), inherited);
            return attributes.Length > 0;
        }

        public static T GetAttribute<T>(SerializedProperty property) where T : Attribute {
            T[] attributes = GetAttributes<T>(property);
            return attributes.Length > 0 ? attributes[0] : null;
        }

        public static T[] GetAttributes<T>(SerializedProperty property) where T : Attribute {
            FieldInfo fieldInfo = Reflector.GetField(GetTargetObject(property), property.name);

            if (fieldInfo == null) return new T[0];

            return (T[])fieldInfo.GetCustomAttributes(typeof(T), true);
        }
    }
}