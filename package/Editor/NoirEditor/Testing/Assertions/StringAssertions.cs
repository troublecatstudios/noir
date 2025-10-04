using NUnit.Framework;

namespace Noir.Testing.Assertions {
    public static class StringAssertions {
        /// <summary>
        /// Asserts that the string matches the given expected string.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="expected">The string that is expected.</param>
        public static void IsExactly(this IAssertionContext<string> context, string expected) {
            Assert.That(context.Target, Is.EqualTo(expected), $"Expected '{context.Target}' to equal '{expected}'.");
        }

        /// <summary>
        /// Asserts that the string starts with the given string.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="expected">The string that is expected at the start.</param>
        public static void StartsWith(this IAssertionContext<string> context, string expected) {
            Assert.That(context.Target.StartsWith(expected), Is.True, $"Expected '{context.Target}' to start with '{expected}'.");
        }

        /// <summary>
        /// Asserts that the string contains the given string.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="expected">The string that is expected.</param>
        public static void Contains(this IAssertionContext<string> context, string expected) {
            Assert.That(context.Target.Contains(expected), Is.True, $"Expected '{context.Target}' to contain '{expected}'.");
        }

        /// <summary>
        /// Asserts that the string ends with the given string.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="expected">The string that is expected.</param>
        public static void EndsWith(this IAssertionContext<string> context, string expected) {
            Assert.That(context.Target.EndsWith(expected), Is.True, $"Expected '{context.Target}' to end with '{expected}'.");
        }
    }
}