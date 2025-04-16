using System.Collections.Generic;
using UnityEngine;

namespace Noir.Randomness {

    /// <summary>
    /// Helper methods for generating numbers/points based on the Halton Sequence algorithm.
    /// </summary>
    /// <remarks>
    /// In statistics, Halton sequences are sequences used to generate points in space for numerical methods such as
    /// Monte Carlo simulations. Although these sequences are deterministic, they are of low discrepancy, that is,
    /// appear to be random for many purposes. They were first introduced in 1960 and are an example of a quasi-random
    /// number sequence. They generalize the one-dimensional van der Corput sequences.
    ///
    /// See https://en.wikipedia.org/wiki/Halton_sequence for more information.
    /// </remarks>
    public static class HaltonSequence {
        public static float GetIndex(int index, int baseNum)
        {
            float result = 0;
            float f = 1;
            while (index > 0)
            {
                f = f / baseNum;
                result += f * (index % baseNum);
                index = index / baseNum;
            }
            return result;
        }


        /// <summary>
        /// Returns an array of points based on the Halton Sequence algorithm.
        /// </summary>
        /// <param name="count">The number of points to generate</param>
        /// <param name="base1">The prime value to use as the X axis</param>
        /// <param name="base2">The prime value to use as the Y axis</param>
        /// <returns>An array of <see cref="Vector2"/> points, with X and Y values ranging from 0 to 1 inclusive.</returns>
        public static Vector2[] GeneratePoints(int count, int base1, int base2)
        {
            Vector2[] result = new Vector2[count];
            for (int i = 0; i < count; i++)
            {
                result[i].x = GetIndex(i, base1);
                result[i].y = GetIndex(i, base2);
            }
            return result;
        }
    }
}