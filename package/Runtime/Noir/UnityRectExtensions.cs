using UnityEngine;

namespace Noir {
    /// <summary>
    /// Provides extension methods for working with <see cref="Rect"/> structures in Unity.
    /// </summary>
    public static class UnityRectExtensions {
        /// <summary>
        /// Returns a random position within the bounds of the rectangle.
        /// </summary>
        /// <param name="rect">The rectangle to sample from.</param>
        /// <returns>A random <see cref="Vector2"/> position inside the rectangle.</returns>
        public static Vector2 GetRandomPositionInside(this Rect rect) {
            float randomPosX = Random.Range(rect.position.x - rect.size.x / 2, rect.position.x + rect.size.x / 2);
            float randomPosY = Random.Range(rect.position.y - rect.size.y / 2, rect.position.y + rect.size.y / 2);

            return new Vector2(randomPosX, randomPosY);
        }

        /// <summary>
        /// Returns a random position within the bounds of the rectangle, considering the specified padding.
        /// </summary>
        /// <param name="rect">The rectangle to sample from.</param>
        /// <param name="padding">The amount of padding to leave from the rectangle's edges.</param>
        /// <returns>A random <see cref="Vector2"/> position inside the rectangle, offset by the padding.</returns>
        public static Vector2 GetRandomPositionInside(this Rect rect, Vector2 padding) {
            var size = new Vector2(rect.size.x - padding.x, rect.size.y - padding.y);
            float randomPosX = Random.Range(rect.position.x - size.x / 2, rect.position.x + size.x / 2);
            float randomPosY = Random.Range(rect.position.y - size.y / 2, rect.position.y + size.y / 2);

            return new Vector2(randomPosX, randomPosY);
        }

        /// <summary>
        /// Returns the top-left corner position of the rectangle.
        /// </summary>
        /// <param name="rect">The rectangle to get the corner from.</param>
        /// <returns>A <see cref="Vector2"/> representing the top-left corner of the rectangle.</returns>
        public static Vector2 TopLeft(this Rect rect) {
            return new Vector2(rect.xMin, rect.yMax);
        }
    }
}