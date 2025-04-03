using NUnit.Framework;
using UnityEngine;

namespace Noir.Testing.Assertions {
    public static class FloatAssertions {
        public static void IsApproximately(this ICustomAssertionContext<float> context, float value, float epsilon = float.Epsilon, string message = null) {
            var a = context.Target;
            var b = value;
            var approx = Mathf.Abs(b - a) < Mathf.Max(0.000001f * Mathf.Max(Mathf.Abs(a), Mathf.Abs(b)), epsilon * 8);
            Assert.That(approx, message ?? $"{a} is not close enough in value to {b}.");
        }
    }
}