using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NoirEditor.Reflection {
    internal static partial class Reflector {
        private static readonly Func<FieldInfo, bool> IncludeAllFields = _ => true;

        public static FieldInfo GetField(object target, string fieldName) {
            return GetAllFields(target, f => f.Name.Equals(fieldName, StringComparison.InvariantCulture)).FirstOrDefault();
        }

        public static FieldInfo GetField(Type type, string fieldName) {
            return GetAllFields(type, f => f.Name.Equals(fieldName, StringComparison.InvariantCulture)).FirstOrDefault();
        }

        public static IEnumerable<FieldInfo> GetAllFields(object target) {
            return GetAllFields(target, IncludeAllFields);
        }

        public static IEnumerable<FieldInfo> GetAllFields(Type type) {
            return GetAllFields(type, IncludeAllFields);
        }

        public static IEnumerable<FieldInfo> GetAllFields(object target, Func<FieldInfo, bool> predicate) {
            List<Type> types = new List<Type>()
            {
                target.GetType()
            };

            while (types.Last().BaseType != null) {
                types.Add(types.Last().BaseType);
            }

            for (int i = types.Count - 1; i >= 0; i--) {
                IEnumerable<FieldInfo> fieldInfos = types[i]
                    .GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.DeclaredOnly)
                    .Where(NotObsolete)
                    .Where(predicate);

                foreach (var fieldInfo in fieldInfos) {
                    yield return fieldInfo;
                }
            }
        }

        public static IEnumerable<FieldInfo> GetAllFields(Type type, Func<FieldInfo, bool> predicate) {
            List<Type> types = new List<Type>()
            {
                type
            };

            while (types.Last().BaseType != null) {
                types.Add(types.Last().BaseType);
            }

            for (int i = types.Count - 1; i >= 0; i--) {
                IEnumerable<FieldInfo> fieldInfos = types[i]
                    .GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.DeclaredOnly)
                    .Where(NotObsolete)
                    .Where(predicate);

                foreach (var fieldInfo in fieldInfos) {
                    yield return fieldInfo;
                }
            }
        }
    }
}