using System.Collections.Generic;
using UnityEngine;

namespace Noir {
    /// <summary>
    /// Provides extension methods and utilities for working with GameObjects.
    /// </summary>
    public static class GameObjectExtensions {
        /// <summary>
        /// Gets the current GameObjects hierarchy as a path expression.
        /// </summary>
        /// <param name="gameObject">The game object.</param>
        /// <returns>A string representing the GameObjects hierarchy as a path expression. ex: "/path/to/my/game/object"</returns>
        public static string GetGameObjectHierarchyPath(this GameObject gameObject) {
            var path = gameObject.name;
            var parent = gameObject.transform.parent;
            while (parent) {
                path = parent.name + "/" + path;
                parent = parent.transform.parent;
            }
            return path;
        }

        /// <summary>
        /// Walks the current GameObjects hierarchy back out to the root, yielding each parent GameObject along the way.
        /// </summary>
        /// <param name="gameObject">The game object.</param>
        /// <returns></returns>
        public static IEnumerable<GameObject> GetGameObjectHierarchy(this GameObject gameObject) {
            var path = gameObject.name;
            var parent = gameObject.transform.parent;
            yield return gameObject;
            while (parent) {
                path = parent.name + "/" + path;
                parent = parent.transform.parent;
                yield return parent.gameObject;
            }
        }
    }
}