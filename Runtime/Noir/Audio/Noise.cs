using UnityEngine;

namespace Noir.Audio {
    /// <summary>
    /// Provides utility methods for converting between linear audio amplitude and decibel levels.
    /// </summary>
    public static class Noise {
        /// <summary>
        /// Converts a linear amplitude value to decibels (dB).
        /// </summary>
        /// <param name="linear">The linear amplitude value, typically between 0 and 1.</param>
        /// <returns>The corresponding value in decibels. Returns -144 dB if <paramref name="linear"/> is 0.</returns>
        public static float LinearToDecibel(float linear) {
            if (linear == 0f) {
                return -144f;
            }
            return 20f * Mathf.Log10(linear);
        }

        /// <summary>
        /// Converts a decibel (dB) value to a linear amplitude.
        /// </summary>
        /// <param name="db">The value in decibels.</param>
        /// <returns>The corresponding linear amplitude, typically between 0 and 1 for normalized signals.</returns>
        public static float DecibelToLinear(float db) {
            return Mathf.Pow(10f, db / 20f);
        }
    }
}