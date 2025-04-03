using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NoirEditor.Reflection {
    public static partial class Reflector {
        public const BindingFlags DefaultFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.DeclaredOnly;

        private static bool NotObsolete<T>(T member) where T : MemberInfo {
            return !member.IsDefined(typeof(ObsoleteAttribute), true);
        }

        public static IEnumerable<Type> GetTypesInAppDomain() {
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies()) {
                foreach (var type in asm.GetTypes()) {
                    yield return type;
                }
            }
        }

        public static (TAttribute[] Attributes, Type Type)[] GetTypesWithAttribute<TAttribute>() where TAttribute : Attribute {
            var results = new List<(TAttribute[] Attributes, Type Type)>();
            foreach (var type in GetTypesInAppDomain()) {
                var attrs = type.GetCustomAttributes(true);
                if (attrs == null || attrs.Length == 0) continue;
                var attributes = attrs.Where(a => a as TAttribute != null).Cast<TAttribute>();
                results.Add(new(attributes.ToArray(), type));
            }
            return results.ToArray();
        }
    }
}