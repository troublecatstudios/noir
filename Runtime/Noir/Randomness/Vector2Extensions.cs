using UnityEngine;

namespace Noir.Randomness {
    public static class Vector2Extensions {
        public static Vector2 Random(this Vector2 vector) {
            return new Vector2(
                UnityEngine.Random.Range(-1.0f, 1.0f),
                UnityEngine.Random.Range(-1.0f, 1.0f)
            );
        }
    }
}
