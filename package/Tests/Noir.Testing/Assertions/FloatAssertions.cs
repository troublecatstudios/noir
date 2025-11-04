using NUnit.Framework;
using UnityEngine;

namespace Noir.Testing.Assertions {
    /// <summary>
    /// Provides assertion extensions for validating approximate equality between floating-point values.
    /// </summary>
    public static class FloatAssertions {
        /// <summary>
        /// Asserts that the target float value is approximately equal to the specified expected value,
        /// within a given tolerance (<paramref name="epsilon"/>).
        /// </summary>
        /// <param name="context">The assertion context containing the target float value.</param>
        /// <param name="value">The expected float value to compare against.</param>
        /// <param name="epsilon">
        /// The tolerance used to determine approximate equality. Defaults to <see cref="float.Epsilon"/>.
        /// </param>
        /// <param name="message">An optional custom message for the assertion failure.</param>
        /// <exception cref="AssertionException">
        /// Thrown if the target value is not within the specified tolerance of the expected value.
        /// </exception>
        public static void IsApproximately(this IAssertionContext<float> context, float value, float epsilon = float.Epsilon, string message = null) {
            var a = context.Target;
            var b = value;
            var approx = Mathf.Abs(b - a) < Mathf.Max(0.000001f * Mathf.Max(Mathf.Abs(a), Mathf.Abs(b)), epsilon * 8);
            Assert.That(approx, message ?? $"{a} is not close enough in value to {b}.");
        }
    }
}