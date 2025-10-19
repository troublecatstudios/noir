using UnityEngine;

namespace Noir {
    /// <summary>
    /// Provides extension methods for working with <see cref="ScriptableObject"/> instances.
    /// </summary>
    public static class ScriptableObjectExtensions {
        /// <summary>
        /// Returns a safe string representation of the <see cref="ScriptableObject"/>,
        /// using its name if available, or "null" if the object is not set.
        /// </summary>
        /// <param name="so">The <see cref="ScriptableObject"/> instance.</param>
        /// <returns>
        /// The name of the <see cref="ScriptableObject"/> if it is not null; otherwise, the string "null".
        /// </returns>
        public static string ToLogStringSafe(this ScriptableObject so) => $"{so?.name ?? "null"}";
    }
}