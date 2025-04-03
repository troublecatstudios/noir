using System;

namespace Noir {
    public static class ObjectExtensions {
        public static string ToStringSafe(this object o) => o == null ? "NULL" : o.ToString();

        public static string ToStringSafe(this object o, Func<object, string> valueDelegate) {
            try {
                if (o == null) return valueDelegate(o);
                return o.ToString();
            } catch (NullReferenceException) {
                return "NULL";
            }
        }
    }
}