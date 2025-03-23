using UnityEditor;

namespace NoirEditor {
    public static class SerializedObjectExtensions {
        /// <summary>
        /// Retrieves a property from the specified SerializedObject.
        /// </summary>
        /// <param name="serializedObject">The SerializedObject from which to retrieve the property.</param>
        /// <param name="propertyName">The name of the property to match against when filtering the list of properties.</param>
        /// <param name="property">The matched property (if applicable).</param>
        /// <returns><c>true</c> if a matching property was found, <c>false</c> otherwise.</returns>
        public static bool TryFindProperty(this SerializedObject serializedObject, string propertyName, out SerializedProperty property) {
            property = serializedObject.FindProperty(propertyName);
            return property != null;
        }
    }
}