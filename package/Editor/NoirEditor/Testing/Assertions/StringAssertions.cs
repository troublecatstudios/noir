using NUnit.Framework;

namespace Noir.Testing.Assertions {
    /// <summary>
    /// Provides assertion extensions for validating string values.
    /// </summary>
    public static class StringAssertions {
        /// <summary>
        /// Asserts that the target string is exactly equal to the expected string.
        /// </summary>
        /// <param name="context">The assertion context containing the target string.</param>
        /// <param name="expected">The expected string value.</param>
        public static void IsExactly(this IAssertionContext<string> context, string expected) {
            Assert.That(context.Target, Is.EqualTo(expected), $"Expected '{context.Target}' to equal '{expected}'.");
        }

        /// <summary>
        /// Asserts that the target string starts with the specified expected string.
        /// </summary>
        /// <param name="context">The assertion context containing the target string.</param>
        /// <param name="expected">The string expected at the start.</param>
        public static void StartsWith(this IAssertionContext<string> context, string expected) {
            Assert.That(context.Target.StartsWith(expected), Is.True, $"Expected '{context.Target}' to start with '{expected}'.");
        }

        /// <summary>
        /// Asserts that the target string contains the specified expected substring.
        /// </summary>
        /// <param name="context">The assertion context containing the target string.</param>
        /// <param name="expected">The substring expected to be found within the target string.</param>
        public static void Contains(this IAssertionContext<string> context, string expected) {
            Assert.That(context.Target.Contains(expected), Is.True, $"Expected '{context.Target}' to contain '{expected}'.");
        }

        /// <summary>
        /// Asserts that the target string ends with the specified expected string.
        /// </summary>
        /// <param name="context">The assertion context containing the target string.</param>
        /// <param name="expected">The string expected at the end.</param>
        public static void EndsWith(this IAssertionContext<string> context, string expected) {
            Assert.That(context.Target.EndsWith(expected), Is.True, $"Expected '{context.Target}' to end with '{expected}'.");
        }
    }
}