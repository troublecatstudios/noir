using UnityEngine;

namespace Noir {
    /// <summary>
    /// Provides utility methods for working with various UnityEngine structures.
    /// </summary>
    public static class Primitives {
        /// <summary>
        /// Creates a <see cref="Rect"/> offset down and to the left by half the size, so it can use the same values we use for literally
        /// every other position calculation within unity.
        /// </summary>
        /// <param name="center"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static Rect RectFromSaneValues(Vector2 center, Vector2 size) {
            // unity insanity ahead: UnityEngine.Rect uses the passed position as the lower bounds of the rectangle position,
            // so we have to move it down and to the left by half the size so it can use the same values we use for literally
            // every other position calculation within unity.
            return new Rect(center - size/2, size);
        }

        /// <summary>
        /// Creates a <see cref="Rect"/> offset down and to the left by half the size, so it can use the same values we use for literally
        /// every other position calculation within unity.
        /// </summary>
        /// <remarks>
        /// This method uses the Z axis in the given <see cref="Vector3"/> as the Y axis within the new <see cref="Rect"/>.
        /// </remarks>
        public static Rect RectFromSane3DValues(Vector3 center, Vector3 size) {
            return RectFromSaneValues(new Vector2(center.x, center.z), new Vector2(size.x, size.z));
        }
    }
}