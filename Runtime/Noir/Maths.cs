using UnityEngine;

namespace Noir {
    public static class Maths {
        public static Vector2 MaxVector2 = new Vector2(float.MaxValue, float.MaxValue);
        public static Vector2 MinVector2 = new Vector2(float.MinValue, float.MinValue);
        public static float Scale(float x, float y) => Mathf.Ceil(x/y) * y;
    }
}