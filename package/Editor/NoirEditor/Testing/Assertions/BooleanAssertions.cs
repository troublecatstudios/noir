using NUnit.Framework;

namespace Noir.Testing.Assertions {
    public static class BooleanAssertions {
        public static void IsTrue(this IAssertionContext<bool> context, string message = null) {
            Assert.That(context.Target, Is.True, message ?? $"Expected true, but got false instead.");
        }

        public static void IsFalse(this IAssertionContext<bool> context, string message = null) {
            Assert.That(context.Target, Is.False, message ?? $"Expected false, but got true instead.");
        }
    }
}
