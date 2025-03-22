using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NoirUnityEditor.Utility {
    public static class ReflectionUtility {
        private static bool NotObsolete<T>(T member) where T : MemberInfo {
            return !member.IsDefined(typeof(ObsoleteAttribute), true);
        }

        public static IEnumerable<Type> GetTypes(Func<Type, bool> predicate) {
            foreach (var assemb in AppDomain.CurrentDomain.GetAssemblies()) {
                foreach (var tp in assemb.GetTypes()) {
                    if (predicate == null || predicate(tp)) yield return tp;
                }
            }
        }

        public static IEnumerable<Type> GetTypesAssignableFrom(Type rootType) {
            foreach (var assemb in AppDomain.CurrentDomain.GetAssemblies()) {
                foreach (var tp in assemb.GetTypes()) {
                    if (rootType.IsAssignableFrom(tp)) yield return tp;
                }
            }
        }

        public static IEnumerable<Type> GetTypesAssignableFrom(Assembly assemb, Type rootType) {
            foreach (var tp in assemb.GetTypes()) {
                if (rootType.IsAssignableFrom(tp) && rootType != tp) yield return tp;
            }
        }

        public static bool IsType(Type tp, Type assignableType) {
            return assignableType.IsAssignableFrom(tp);
        }

        public static bool IsType(Type tp, params Type[] assignableTypes) {
            foreach (var otp in assignableTypes) {
                if (otp.IsAssignableFrom(tp)) return true;
            }

            return false;
        }

        public static object GetDefaultValue(this Type tp) {
            if (tp == null) throw new ArgumentNullException("tp");

            if (tp.IsValueType)
                return Activator.CreateInstance(tp);
            else
                return null;
        }


        public static Type ParseType(string assembName, string typeName) {
            var assemb = (from a in AppDomain.CurrentDomain.GetAssemblies()
                          where a.GetName().Name == assembName || a.FullName == assembName
                          select a).FirstOrDefault();
            if (assemb != null) {
                return (from t in assemb.GetTypes()
                        where t.FullName == typeName
                        select t).FirstOrDefault();
            } else {
                return null;
            }
        }

        public static Type FindType(string typeName, bool useFullName = false, bool ignoreCase = false) {
            if (string.IsNullOrEmpty(typeName)) return null;

            bool isArray = typeName.EndsWith("[]");
            if (isArray)
                typeName = typeName.Substring(0, typeName.Length - 2);

            StringComparison e = ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;
            if (useFullName) {
                foreach (var assemb in AppDomain.CurrentDomain.GetAssemblies()) {
                    foreach (var t in assemb.GetTypes()) {
                        if (string.Equals(t.FullName, typeName, e)) {
                            if (isArray)
                                return t.MakeArrayType();
                            else
                                return t;
                        }
                    }
                }
            } else {
                foreach (var assemb in AppDomain.CurrentDomain.GetAssemblies()) {
                    foreach (var t in assemb.GetTypes()) {
                        if (string.Equals(t.Name, typeName, e) || string.Equals(t.FullName, typeName, e)) {
                            if (isArray)
                                return t.MakeArrayType();
                            else
                                return t;
                        }
                    }
                }
            }
            return null;
        }

        public static Type FindType(string typeName, Type baseType, bool useFullName = false, bool ignoreCase = false) {
            if (string.IsNullOrEmpty(typeName)) return null;
            if (baseType == null) throw new ArgumentNullException("baseType");

            bool isArray = typeName.EndsWith("[]");
            if (isArray)
                typeName = typeName.Substring(0, typeName.Length - 2);

            StringComparison e = ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;
            if (useFullName) {
                foreach (var assemb in AppDomain.CurrentDomain.GetAssemblies()) {
                    foreach (var t in assemb.GetTypes()) {
                        if (baseType.IsAssignableFrom(t) && string.Equals(t.FullName, typeName, e)) {
                            if (isArray)
                                return t.MakeArrayType();
                            else
                                return t;
                        }
                    }
                }
            } else {
                foreach (var assemb in AppDomain.CurrentDomain.GetAssemblies()) {
                    foreach (var t in assemb.GetTypes()) {
                        if (baseType.IsAssignableFrom(t) && (string.Equals(t.Name, typeName, e) || string.Equals(t.FullName, typeName, e))) {
                            if (isArray)
                                return t.MakeArrayType();
                            else
                                return t;
                        }
                    }
                }
            }

            return null;
        }

        public static bool IsListType(this Type tp) {
            if (tp == null) return false;

            if (tp.IsArray) return tp.GetArrayRank() == 1;

            var interfaces = tp.GetInterfaces();
            //if (interfaces.Contains(typeof(System.Collections.IList)) || interfaces.Contains(typeof(IList<>)))
            if (Array.IndexOf(interfaces, typeof(System.Collections.IList)) >= 0 || Array.IndexOf(interfaces, typeof(IList<>)) >= 0) {
                return true;
            }

            return false;
        }

        public static bool IsListType(this Type tp, bool ignoreAsInterface) {
            if (tp == null) return false;

            if (tp.IsArray) return tp.GetArrayRank() == 1;

            if (ignoreAsInterface) {
                //if (tp == typeof(System.Collections.ArrayList) || (tp.IsGenericType && tp.GetGenericTypeDefinition() == typeof(List<>))) return true;
                if (tp.IsGenericType && tp.GetGenericTypeDefinition() == typeof(List<>)) return true;
            } else {
                var interfaces = tp.GetInterfaces();
                //if (interfaces.Contains(typeof(System.Collections.IList)) || interfaces.Contains(typeof(IList<>)))
                if (Array.IndexOf(interfaces, typeof(System.Collections.IList)) >= 0 || Array.IndexOf(interfaces, typeof(IList<>)) >= 0) {
                    return true;
                }
            }

            return false;
        }

        public static bool IsListType(this Type tp, out Type innerType) {
            innerType = null;
            if (tp == null) return false;

            if (tp.IsArray) {
                if (tp.GetArrayRank() == 1) {
                    innerType = tp.GetElementType();
                    return true;
                } else
                    return false;
            }

            var interfaces = tp.GetInterfaces();
            if (Array.IndexOf(interfaces, typeof(System.Collections.IList)) >= 0 || Array.IndexOf(interfaces, typeof(IList<>)) >= 0) {
                if (tp.IsGenericType) {
                    innerType = tp.GetGenericArguments()[0];
                } else {
                    innerType = typeof(object);
                }
                return true;
            }

            return false;
        }

        public static bool IsListType(this Type tp, bool ignoreAsInterface, out Type innerType) {
            innerType = null;
            if (tp == null) return false;

            if (tp.IsArray) {
                if (tp.GetArrayRank() == 1) {
                    innerType = tp.GetElementType();
                    return true;
                } else
                    return false;
            }

            if (ignoreAsInterface) {
                if (tp.IsGenericType && tp.GetGenericTypeDefinition() == typeof(List<>)) {
                    innerType = tp.GetGenericArguments()[0];
                    return true;
                } else {
                    return false;
                }
            } else {
                var interfaces = tp.GetInterfaces();
                if (Array.IndexOf(interfaces, typeof(System.Collections.IList)) >= 0 || Array.IndexOf(interfaces, typeof(IList<>)) >= 0) {
                    if (tp.IsGenericType) {
                        innerType = tp.GetGenericArguments()[0];
                    } else {
                        innerType = typeof(object);
                    }
                    return true;
                }
            }

            return false;
        }

        public static Type GetElementTypeOfListType(this Type tp) {
            if (tp == null) return null;

            if (tp.IsArray) return tp.GetElementType();

            var interfaces = tp.GetInterfaces();
            //if (interfaces.Contains(typeof(System.Collections.IList)) || interfaces.Contains(typeof(IList<>)))
            if (Array.IndexOf(interfaces, typeof(System.Collections.IList)) >= 0 || Array.IndexOf(interfaces, typeof(IList<>)) >= 0) {
                if (tp.IsGenericType) return tp.GetGenericArguments()[0];
                else return typeof(object);
            }

            return null;
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

        private static Func<PropertyInfo, bool> AllProperties = (p) => true;
        public static IEnumerable<PropertyInfo> GetAllProperties(object target, Func<PropertyInfo, bool> predicate = null) {
            predicate = predicate ?? AllProperties;
            List<Type> types = new List<Type>()
            {
                target.GetType()
            };

            while (types.Last().BaseType != null) {
                types.Add(types.Last().BaseType);
            }

            for (int i = types.Count - 1; i >= 0; i--) {
                IEnumerable<PropertyInfo> propertyInfos = types[i]
                    .GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.DeclaredOnly)
                    .Where(NotObsolete)
                    .Where(predicate);

                foreach (var propertyInfo in propertyInfos) {
                    yield return propertyInfo;
                }
            }
        }

        public static IEnumerable<MethodInfo> GetAllMethods(object target, Func<MethodInfo, bool> predicate) {
            IEnumerable<MethodInfo> methodInfos = target.GetType()
                .GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public)
                .Where(NotObsolete)
                .Where(predicate);

            return methodInfos;
        }

        public static FieldInfo GetField(object target, string fieldName) {
            return GetAllFields(target, f => f.Name.Equals(fieldName, StringComparison.InvariantCulture)).FirstOrDefault();
        }

        public static FieldInfo GetField(Type type, string fieldName) {
            return GetAllFields(type, f => f.Name.Equals(fieldName, StringComparison.InvariantCulture)).FirstOrDefault();
        }

        public static PropertyInfo GetProperty(object target, string propertyName) {
            return GetAllProperties(target, p => p.Name.Equals(propertyName, StringComparison.InvariantCulture)).FirstOrDefault();
        }

        public static MethodInfo GetMethod(object target, string methodName) {
            return GetAllMethods(target, m => m.Name.Equals(methodName, StringComparison.InvariantCulture)).FirstOrDefault();
        }

        public static object GetPropertyValue(this object obj, string name) {
            foreach (string part in name.Split('.')) {
                if (obj == null) { return null; }

                Type type = obj.GetType();
                PropertyInfo info = type.GetProperty(part);
                if (info == null) { return null; }

                obj = info.GetValue(obj, null);
            }
            return obj;
        }

        public static T GetPropertyValue<T>(this object obj, string name) {
            object retval = obj.GetPropertyValue(name);
            if (retval == null) { return default; }

            // throws InvalidCastException if types are incompatible
            return (T)retval;
        }
    }
}
