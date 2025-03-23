using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NoirEditor.Reflection {
    public static partial class Reflector {
        public static IEnumerable<MethodInfo> GetAllMethods(object target, Func<MethodInfo, bool> predicate) {
            IEnumerable<MethodInfo> methodInfos = target.GetType()
                .GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public)
                .Where(NotObsolete)
                .Where(predicate);

            return methodInfos;
        }

        public static MethodInfo GetMethod(object target, string methodName) {
            return GetAllMethods(target, m => m.Name.Equals(methodName, StringComparison.InvariantCulture)).FirstOrDefault();
        }
    }
}