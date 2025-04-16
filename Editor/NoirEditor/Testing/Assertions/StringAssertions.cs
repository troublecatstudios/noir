using NUnit.Framework;

namespace Noir.Testing.Assertions {
    public static class StringAssertions {
        public static void IsExactly(this IAssertionContext<string> context, string expected) {
            Assert.That(context.Target, Is.EqualTo(expected), $"Expected '{context.Target}' to equal '{expected}'.");
        }

        public static void StartsWith(this IAssertionContext<string> context, string expected) {
            Assert.That(context.Target.StartsWith(expected), Is.True, $"Expected '{context.Target}' to start with '{expected}'.");
        }

        public static void Contains(this IAssertionContext<string> context, string expected) {
            Assert.That(context.Target.Contains(expected), Is.True, $"Expected '{context.Target}' to contain '{expected}'.");
        }

        public static void EndsWith(this IAssertionContext<string> context, string expected) {
            Assert.That(context.Target.EndsWith(expected), Is.True, $"Expected '{context.Target}' to end with '{expected}'.");
        }
    }
}
