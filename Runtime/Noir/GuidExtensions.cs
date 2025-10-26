using System;

namespace Noir {
    /// <summary>
    /// Provides extension methods for working with <see cref="Guid"/> values.
    /// </summary>
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

        /// <summary>
        /// Converts a <see cref="Guid"/> to an integer representation by hashing its character values.
        /// </summary>
        /// <param name="guid">The <see cref="Guid"/> to convert.</param>
        /// <returns>An integer value derived from the <see cref="Guid"/>.</returns>
        public static int ToInt(this Guid guid) => ToInt(guid.ToString().ToLower());
    }
}