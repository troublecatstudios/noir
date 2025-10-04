using NUnit.Framework;
using System;

namespace Noir.Testing.Assertions {
    public static class EquatableAssertions {

        /// <summary>
        /// Asserts that the given object is equal to the expected value.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="expectedValue"></param>
        /// <typeparam name="T"></typeparam>
        public static void IsEquatableTo<T>(this IAssertionContext<T> context, T expectedValue) where T : IEquatable<T> {
            Assert.That(context.Target.Equals(expectedValue), Is.True, $"Expected '{context.Target}' to equal '{expectedValue}'.");
        }
    }
}