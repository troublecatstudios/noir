using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace NoirEditor.Reflection {
    public static partial class Reflector {
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

        public static string ToLogString(this Type type) {
            if (type.IsGenericType)
            {
                var typeName = new StringBuilder();

                // Get the type name without the generic parameters
                var baseTypeName = type.Name.Substring(0, type.Name.IndexOf('`'));
                typeName.Append(baseTypeName);
                typeName.Append('<');

                // Get the generic type arguments
                var genericArguments = type.GetGenericArguments();
                for (int i = 0; i < genericArguments.Length; i++)
                {
                    if (i > 0) typeName.Append(", ");
                    typeName.Append(genericArguments[i].ToLogString());
                }

                typeName.Append('>');
                return typeName.ToString();
            }
            else
            {
                return type.Name;
            }
        }
    }
}