using UnityEngine;

namespace Noir {
    /// <summary>
    /// Provides mathematical utility methods and constants for working with vectors and numeric operations.
    /// </summary>
    public static class Maths {
        /// <summary>
        /// A <see cref="Vector2"/> with both components set to <see cref="float.MaxValue"/>.
        /// </summary>
        public static Vector2 MaxVector2 = new Vector2(float.MaxValue, float.MaxValue);

        /// <summary>
        /// A <see cref="Vector2"/> with both components set to <see cref="float.MinValue"/>.
        /// </summary>
        public static Vector2 MinVector2 = new Vector2(float.MinValue, float.MinValue);

        /// <summary>
        /// Scales the given value <paramref name="x"/> to the nearest multiple of <paramref name="y"/>,
        /// rounding up to the next multiple if necessary.
        /// </summary>
        /// <param name="x">The value to scale.</param>
        /// <param name="y">The base multiple to scale to.</param>
        /// <returns>The scaled value, rounded up to the nearest multiple of <paramref name="y"/>.</returns>
        public static float Scale(float x, float y) => Mathf.Ceil(x/y) * y;
    }
}