using NUnit.Framework;

namespace Noir.Testing.Assertions {
    public static class ObjectAssertions {
        public static void IsNotNull(this IAssertionContext<object> context, string message = null) {
            Assert.That(context.Target, Is.Not.Null, message ?? $"Expected object to be assigned, but object was null.");
        }

        public static void IsNull(this IAssertionContext<object> context, string message = null) {
            Assert.That(context.Target, Is.Null, message ?? $"Expected object to be null, but object was assigned.");
        }

        public static void IsSameAs<T>(this IAssertionContext<T> context, T expectedValue, string message = null) where T : class {
            Assert.That(context.Target == expectedValue, message ?? $"Expected {expectedValue} to be same as {context.Target}.");
        }
    }
}
