using NUnit.Framework;
using UnityEngine;

namespace Noir.Testing.Assertions {
    public static class FloatAssertions {
        /// <summary>
        /// Asserts that the given float value is within the given epsilon of an expected float value.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="value"></param>
        /// <param name="epsilon"></param>
        /// <param name="message"></param>
        public static void IsApproximately(this IAssertionContext<float> context, float value, float epsilon = float.Epsilon, string message = null) {
            var a = context.Target;
            var b = value;
            var approx = Mathf.Abs(b - a) < Mathf.Max(0.000001f * Mathf.Max(Mathf.Abs(a), Mathf.Abs(b)), epsilon * 8);
            Assert.That(approx, message ?? $"{a} is not close enough in value to {b}.");
        }
    }
}