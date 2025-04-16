using UnityEngine;

namespace Noir.Audio {
    public static class Noise {
        public static float LinearToDecibel(float linear) {
            if (linear == 0f) {
                return -144f;
            }
            return 20f * Mathf.Log10(linear);
        }

        public static float DecibelToLinear(float db) {
            return Mathf.Pow(10f, db / 20f);
        }
    }
}