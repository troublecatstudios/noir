using NUnit.Framework;

namespace Noir.Testing.Assertions {
    public static class BooleanAssertions {
        /// <summary>
        /// Asserts that the value is <c>true</c>.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="message"></param>
        public static void IsTrue(this IAssertionContext<bool> context, string message = null) {
            Assert.That(context.Target, Is.True, message ?? $"Expected true, but got false instead.");
        }

        /// <summary>
        /// Asserts that the value is <c>false</c>.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="message"></param>
        public static void IsFalse(this IAssertionContext<bool> context, string message = null) {
            Assert.That(context.Target, Is.False, message ?? $"Expected false, but got true instead.");
        }
    }
}