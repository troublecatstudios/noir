using NUnit.Framework;
using System;

namespace Noir.Testing.Assertions {
    public static class ComparableAssertions {
        /// <summary>
        /// Asserts that the comparable is within an expected range.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="inclusive"></param>
        /// <typeparam name="T"></typeparam>
        public static void IsWithinRange<T>(this IAssertionContext<T> context, T min, T max, bool inclusive = true) where T : IComparable {
            var failMessage = $"Expected '{context.Target}' to fall within the range {min}:{max}{(inclusive ? " (inclusive)" : "")}.";
            bool result = context.Target.CompareTo(min) > 0 && context.Target.CompareTo(max) < 0;
            if (inclusive) {
                result = context.Target.CompareTo(min) >= 0 && context.Target.CompareTo(max) <= 0;
            }

            Assert.That(result, Is.True, failMessage);
        }

        /// <summary>
        /// Asserts that the comparable is equal to an expected value.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="expectedValue"></param>
        /// <param name="message"></param>
        /// <typeparam name="T"></typeparam>
        public static void IsEqualTo<T>(this IAssertionContext<T> context, T expectedValue, string message = null) where T : IComparable {
            Assert.AreEqual(expectedValue, context.Target, message ?? $"Expected '{context.Target}' to equal '{expectedValue}'.");
        }

        /// <summary>
        /// Asserts that the comparable is not equal to an expected value.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="expectedValue"></param>
        /// <param name="message"></param>
        /// <typeparam name="T"></typeparam>
        public static void IsNotEqualTo<T>(this IAssertionContext<T> context, T expectedValue, string message = null) where T : IComparable {
            Assert.AreNotEqual(expectedValue, context.Target, message ?? $"Expected '{context.Target}' not to equal '{expectedValue}'.");
        }

        /// <summary>
        /// Asserts that the comparable is greater than an expected value.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="expectedValue"></param>
        /// <typeparam name="T"></typeparam>
        public static void IsGreaterThan<T>(this IAssertionContext<T> context, T expectedValue) where T : IComparable {
            Assert.True(context.Target.CompareTo(expectedValue) == 1, $"Expected '{context.Target}' to be greater than '{expectedValue}'.");
        }

        /// <summary>
        /// Asserts that the comparable is less than an expected value.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="expectedValue"></param>
        /// <typeparam name="T"></typeparam>
        public static void IsLessThan<T>(this IAssertionContext<T> context, T expectedValue) where T : IComparable {
            Assert.True(context.Target.CompareTo(expectedValue) == -1, $"Expected '{context.Target}' to be less than '{expectedValue}'.");
        }
    }
}