using System;

namespace Noir {
    internal static class TypeExtensions {
        public static string FriendlyName(this Type type, bool includeNamespace = false) {
            string friendlyName = type.Name;
            if (type.IsGenericType) {
                int iBacktick = friendlyName.IndexOf('`');
                if (iBacktick > 0) {
                    friendlyName = friendlyName.Remove(iBacktick);
                }
                friendlyName += "<";
                Type[] typeParameters = type.GetGenericArguments();
                for (int i = 0; i < typeParameters.Length; ++i) {
                    string typeParamName = FriendlyName(typeParameters[i], includeNamespace);
                    friendlyName += (i == 0 ? typeParamName : "," + typeParamName);
                }
                friendlyName += ">";
            }

            return (includeNamespace ? $"{type.Namespace}." : "") + $"{friendlyName}";
        }
    }
}