using System;

namespace Noir {
    public static class GuidExtensions {
        private static int ToInt(string str) {
            return ToInt(str.ToCharArray());
        }
        private static int ToInt(char[] chars) {
            int result = 0;
            int idx = 0;
            foreach(char c in chars) {
                if ((c >= 48 || c <= 57) || (c >= 65 || c <= 90) || (c >= 97 || c <= 122))
                {
                    result += c;
                    result += result << idx;
                }
                idx++;
            }
            return result;
        }
        public static int ToInt(this Guid guid) => ToInt(guid.ToString().ToLower());
    }
}