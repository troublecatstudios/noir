using NUnit.Framework;
using System;

namespace Noir.Testing.Assertions {
    /// <summary>
    /// Provides assertion extensions for objects implementing <see cref="IComparable"/>,
    /// enabling expressive tests for value comparisons such as ranges, equality, and ordering.
    /// </summary>
    public static class ComparableAssertions {
        /// <summary>
        /// Asserts that the comparable value in the specified <see cref="IAssertionContext{T}"/>
        /// falls within the given range.
        /// </summary>
        /// <typeparam name="T">The comparable type being tested.</typeparam>
        /// <param name="context">The assertion context containing the target value.</param>
        /// <param name="min">The minimum boundary of the valid range.</param>
        /// <param name="max">The maximum boundary of the valid range.</param>
        /// <param name="inclusive">If <c>true</c>, the range includes the boundary values.</param>
        /// <exception cref="AssertionException">
        /// Thrown when the value is outside the specified range.
        /// </exception>
        public static void IsWithinRange<T>(this IAssertionContext<T> context, T min, T max, bool inclusive = true) where T : IComparable {
            var failMessage = $"Expected '{context.Target}' to fall within the range {min}:{max}{(inclusive ? " (inclusive)" : "")}.";
            bool result = context.Target.CompareTo(min) > 0 && context.Target.CompareTo(max) < 0;
            if (inclusive) {
                result = context.Target.CompareTo(min) >= 0 && context.Target.CompareTo(max) <= 0;
            }

            Assert.That(result, Is.True, failMessage);
        }

        /// <summary>
        /// Asserts that the comparable value is equal to the expected value.
        /// </summary>
        /// <typeparam name="T">The comparable type being tested.</typeparam>
        /// <param name="context">The assertion context containing the target value.</param>
        /// <param name="expectedValue">The expected value for comparison.</param>
        /// <param name="message">An optional custom message to display if the assertion fails.</param>
        /// <exception cref="AssertionException">
        /// Thrown when the values are not equal.
        /// </exception>
        public static void IsEqualTo<T>(this IAssertionContext<T> context, T expectedValue, string message = null) where T : IComparable {
            Assert.AreEqual(expectedValue, context.Target, message ?? $"Expected '{context.Target}' to equal '{expectedValue}'.");
        }

        /// <summary>
        /// Asserts that the comparable value is not equal to the expected value.
        /// </summary>
        /// <typeparam name="T">The comparable type being tested.</typeparam>
        /// <param name="context">The assertion context containing the target value.</param>
        /// <param name="expectedValue">The value that the target should not equal.</param>
        /// <param name="message">An optional custom message to display if the assertion fails.</param>
        /// <exception cref="AssertionException">
        /// Thrown when the values are equal.
        /// </exception>
        public static void IsNotEqualTo<T>(this IAssertionContext<T> context, T expectedValue, string message = null) where T : IComparable {
            Assert.AreNotEqual(expectedValue, context.Target, message ?? $"Expected '{context.Target}' not to equal '{expectedValue}'.");
        }

        /// <summary>
        /// Asserts that the comparable value is greater than the expected value.
        /// </summary>
        /// <typeparam name="T">The comparable type being tested.</typeparam>
        /// <param name="context">The assertion context containing the target value.</param>
        /// <param name="expectedValue">The value to compare against.</param>
        /// <exception cref="AssertionException">
        /// Thrown when the target value is less than or equal to the expected value.
        /// </exception>
        public static void IsGreaterThan<T>(this IAssertionContext<T> context, T expectedValue) where T : IComparable {
            Assert.True(context.Target.CompareTo(expectedValue) == 1, $"Expected '{context.Target}' to be greater than '{expectedValue}'.");
        }

        /// <summary>
        /// Asserts that the comparable value is less than the expected value.
        /// </summary>
        /// <typeparam name="T">The comparable type being tested.</typeparam>
        /// <param name="context">The assertion context containing the target value.</param>
        /// <param name="expectedValue">The value to compare against.</param>
        /// <exception cref="AssertionException">
        /// Thrown when the target value is greater than or equal to the expected value.
        /// </exception>
        public static void IsLessThan<T>(this IAssertionContext<T> context, T expectedValue) where T : IComparable {
            Assert.True(context.Target.CompareTo(expectedValue) == -1, $"Expected '{context.Target}' to be less than '{expectedValue}'.");
        }
    }
}