using NUnit.Framework;

namespace Noir.Testing.Assertions {
    /// <summary>
    /// Provides assertion extensions for boolean values,
    /// allowing expressive and readable test assertions.
    /// </summary>
    public static class BooleanAssertions {
        /// <summary>
        /// Asserts that the boolean value in the specified <see cref="IAssertionContext{T}"/> is <c>true</c>.
        /// </summary>
        /// <param name="context">The assertion context containing the target boolean value.</param>
        /// <param name="message">An optional custom message to display if the assertion fails.</param>
        /// <exception cref="AssertionException">Thrown when the value is <c>false</c>.</exception>
        public static void IsTrue(this IAssertionContext<bool> context, string message = null) {
            Assert.That(context.Target, Is.True, message ?? $"Expected true, but got false instead.");
        }

        /// <summary>
        /// Asserts that the boolean value in the specified <see cref="IAssertionContext{T}"/> is <c>false</c>.
        /// </summary>
        /// <param name="context">The assertion context containing the target boolean value.</param>
        /// <param name="message">An optional custom message to display if the assertion fails.</param>
        /// <exception cref="AssertionException">Thrown when the value is <c>true</c>.</exception>
        public static void IsFalse(this IAssertionContext<bool> context, string message = null) {
            Assert.That(context.Target, Is.False, message ?? $"Expected false, but got true instead.");
        }
    }
}