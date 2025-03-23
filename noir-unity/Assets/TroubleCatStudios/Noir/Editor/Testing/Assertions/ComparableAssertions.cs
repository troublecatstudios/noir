using NUnit.Framework;
using System;

namespace Noir.Testing.Assertions {
    public static class ComparableAssertions {
        public static void IsWithinRange<T>(this ICustomAssertionContext<T> context, T min, T max, bool inclusive = true) where T : IComparable {
            var failMessage = $"Expected '{context.Target}' to fall within the range {min}:{max}{(inclusive ? " (inclusive)" : "")}.";
            bool result = context.Target.CompareTo(min) > 0 && context.Target.CompareTo(max) < 0;
            if (inclusive) {
                result = context.Target.CompareTo(min) >= 0 && context.Target.CompareTo(max) <= 0;
            }

            Assert.That(result, Is.True, failMessage);
        }

        public static void IsEqualTo<T>(this ICustomAssertionContext<T> context, T expectedValue, string message = null) where T : IComparable {
            Assert.AreEqual(expectedValue, context.Target, message ?? $"Expected '{context.Target}' to equal '{expectedValue}'.");
        }

        public static void IsNotEqualTo<T>(this ICustomAssertionContext<T> context, T expectedValue, string message = null) where T : IComparable {
            Assert.AreNotEqual(expectedValue, context.Target, message ?? $"Expected '{context.Target}' not to equal '{expectedValue}'.");
        }

        public static void IsGreaterThan<T>(this ICustomAssertionContext<T> context, T expectedValue) where T : IComparable {
            Assert.True(context.Target.CompareTo(expectedValue) == 1, $"Expected '{context.Target}' to be greater than '{expectedValue}'.");
        }

        public static void IsLessThan<T>(this ICustomAssertionContext<T> context, T expectedValue) where T : IComparable {
            Assert.True(context.Target.CompareTo(expectedValue) == -1, $"Expected '{context.Target}' to be less than '{expectedValue}'.");
        }
    }
}