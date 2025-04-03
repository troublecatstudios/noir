using NUnit.Framework;
using System;

namespace Noir.Testing.Assertions {
    public static class EquatableAssertions {
        public static void IsEquatableTo<T>(this ICustomAssertionContext<T> context, T expectedValue) where T : IEquatable<T> {
            Assert.That(context.Target.Equals(expectedValue), Is.True, $"Expected '{context.Target}' to equal '{expectedValue}'.");
        }
    }
}