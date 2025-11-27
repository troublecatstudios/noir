using NUnit.Framework;
using System;

namespace Noir.Testing.Assertions {
    /// <summary>
    /// Provides assertion extensions for verifying equality between <see cref="IEquatable{T}"/> objects.
    /// </summary>
    public static class EquatableAssertions {

        /// <summary>
        /// Asserts that the target object is equal to the specified expected value.
        /// </summary>
        /// <typeparam name="T">The type of object being compared. Must implement <see cref="IEquatable{T}"/>.</typeparam>
        /// <param name="context">The assertion context containing the target object.</param>
        /// <param name="expectedValue">The value expected to be equal to the target object.</param>
        /// <exception cref="AssertionException">
        /// Thrown if the target object does not equal the expected value.
        /// </exception>
        public static void IsEquatableTo<T>(this IAssertionContext<T> context, T expectedValue) where T : IEquatable<T> {
            Assert.That(context.Target.Equals(expectedValue), Is.True, $"Expected '{context.Target}' to equal '{expectedValue}'.");
        }
    }
}