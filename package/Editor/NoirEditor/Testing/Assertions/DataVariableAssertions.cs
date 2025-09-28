using Noir.Variables;
using NUnit.Framework;
using UnityEngine;

namespace Noir.Testing.Assertions {
    public static class CustomDataVariableAssertions {
        /// <summary>
        /// Asserts that the data variable has the expected value.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="value"></param>
        /// <param name="message"></param>
        /// <typeparam name="T"></typeparam>
        public static void HasValue<T>(this IAssertionContext<DataVariable<T>> context, T value, string message = null) {
            Assert.That(context.Target.Value.Equals(value), message);
        }
    }
}