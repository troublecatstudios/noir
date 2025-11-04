using Noir.Variables;
using NUnit.Framework;
using UnityEngine;

namespace Noir.Testing.Assertions {
    /// <summary>
    /// Provides assertion extensions for verifying the state and contents of <see cref="DataVariable{T}"/> instances.
    /// </summary>
    public static class CustomDataVariableAssertions {
        /// <summary>
        /// Asserts that the <see cref="DataVariable{T}"/> has the specified expected value.
        /// </summary>
        /// <typeparam name="T">The type of the value stored in the data variable.</typeparam>
        /// <param name="context">The assertion context containing the target data variable.</param>
        /// <param name="value">The expected value to compare against the variable’s current value.</param>
        /// <param name="message">An optional custom message to display if the assertion fails.</param>
        /// <exception cref="AssertionException">
        /// Thrown when the data variable’s value does not equal the expected value.
        /// </exception>
        public static void HasValue<T>(this IAssertionContext<DataVariable<T>> context, T value, string message = null) {
            Assert.That(context.Target.Value.Equals(value), message);
        }
    }
}