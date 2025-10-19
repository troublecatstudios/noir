using UnityEngine;

namespace Noir {
    /// <summary>
    /// Provides extension methods for working with <see cref="Transform"/> instances in Unity.
    /// </summary>
    public static class TransformExtensions {
        /// <summary>
        /// Attempts to find a child transform by name and retrieve a component of type <typeparamref name="T"/> from it.
        /// </summary>
        /// <typeparam name="T">The type of the component to retrieve.</typeparam>
        /// <param name="transform">The parent transform to search under.</param>
        /// <param name="name">The name of the child transform to find.</param>
        /// <param name="component">Outputs the component of type <typeparamref name="T"/> if found; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the child transform was found and contains the component; otherwise, <c>false</c>.</returns>
        public static bool TryFind<T>(this Transform transform, string name, out T component) where T : Component {
            component = null;
            var t = transform.Find(name);
            if (t && t.TryGetComponent<T>(out component)) {
                return true;
            }
            return false;
        }
    }
}