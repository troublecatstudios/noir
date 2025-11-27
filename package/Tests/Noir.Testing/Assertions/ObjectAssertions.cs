using NUnit.Framework;

namespace Noir.Testing.Assertions {
    /// <summary>
    /// Provides assertion extensions for validating general object states, including nullability and reference equality.
    /// </summary>
    public static class ObjectAssertions {
        /// <summary>
        /// Asserts that the target object is not <c>null</c>.
        /// </summary>
        /// <param name="context">The assertion context containing the target object.</param>
        /// <param name="message">An optional custom message for the assertion failure.</param>
        public static void IsNotNull(this IAssertionContext<object> context, string message = null) {
            Assert.That(context.Target, Is.Not.Null, message ?? $"Expected object to be assigned, but object was null.");
        }

        /// <summary>
        /// Asserts that the target object is <c>null</c>.
        /// </summary>
        /// <param name="context">The assertion context containing the target object.</param>
        /// <param name="message">An optional custom message for the assertion failure.</param>
        public static void IsNull(this IAssertionContext<object> context, string message = null) {
            Assert.That(context.Target, Is.Null, message ?? $"Expected object to be null, but object was assigned.");
        }

        /// <summary>
        /// Asserts that the target object reference is the same as the specified expected object.
        /// </summary>
        /// <typeparam name="T">The type of object being compared. Must be a reference type.</typeparam>
        /// <param name="context">The assertion context containing the target object.</param>
        /// <param name="expectedValue">The expected object reference to compare against.</param>
        /// <param name="message">An optional custom message for the assertion failure.</param>
        public static void IsSameAs<T>(this IAssertionContext<T> context, T expectedValue, string message = null) where T : class {
            Assert.That(context.Target == expectedValue, message ?? $"Expected {expectedValue} to be same as {context.Target}.");
        }
    }
}