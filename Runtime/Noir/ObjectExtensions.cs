using System;

namespace Noir {
    /// <summary>
    /// Provides extension methods for safely converting objects to strings.
    /// </summary>
    public static class ObjectExtensions {
        /// <summary>
        /// Returns the string representation of the object, or "NULL" if the object is null.
        /// </summary>
        /// <param name="o">The object to convert to a string.</param>
        /// <returns>
        /// The result of <c>o.ToString()</c> if <c>o</c> is not null; otherwise, the string "NULL".
        /// </returns>
        public static string ToStringSafe(this object o) => o == null ? "NULL" : o.ToString();

        /// <summary>
        /// Returns the string representation of the object, or a custom string if the object is null.
        /// </summary>
        /// <param name="o">The object to convert to a string.</param>
        /// <param name="valueDelegate">
        /// A delegate function that returns a string when the object is null.
        /// </param>
        /// <returns>
        /// The result of <c>o.ToString()</c> if <c>o</c> is not null; otherwise, the result of <paramref name="valueDelegate"/>.<br/>
        /// If a <see cref="NullReferenceException"/> occurs, returns "NULL".
        /// </returns>
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