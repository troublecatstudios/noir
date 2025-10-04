using NUnit.Framework;

namespace Noir.Testing.Assertions {
    public static class ObjectAssertions {
        /// <summary>
        /// Asserts that the given object is not <c>null</c>.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="message"></param>
        public static void IsNotNull(this IAssertionContext<object> context, string message = null) {
            Assert.That(context.Target, Is.Not.Null, message ?? $"Expected object to be assigned, but object was null.");
        }

        /// <summary>
        /// Asserts that the given object is <c>null</c>.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="message"></param>
        public static void IsNull(this IAssertionContext<object> context, string message = null) {
            Assert.That(context.Target, Is.Null, message ?? $"Expected object to be null, but object was assigned.");
        }

        /// <summary>
        /// Asserts that the given object is the same as the expected value.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="message"></param>
        public static void IsSameAs<T>(this IAssertionContext<T> context, T expectedValue, string message = null) where T : class {
            Assert.That(context.Target == expectedValue, message ?? $"Expected {expectedValue} to be same as {context.Target}.");
        }
    }
}