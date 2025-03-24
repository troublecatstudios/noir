using Noir.Variables;
using NUnit.Framework;
using UnityEngine;

namespace Noir.Testing.Assertions {
    public static class CustomDataVariableAssertions {
        public static void HasValue<T>(this ICustomAssertionContext<DataVariable<T>> context, T value, string message = null) {
            Assert.That(context.Target.Value.Equals(value), message);
        }
    }
}