using NUnit.Framework;
using UnityEngine;

namespace Noir.Testing.Assertions {
    public static class GameObjectAssertions {
        public static ICustomAssertionContext<T> HasComponent<T>(this ICustomAssertionContext<GameObject> context, string message = null) {
            var component = context.Target.GetComponent<T>();
            Assert.IsNotNull(component, message);
            return new CustomAssertionContext<T>(component);
        }

        public static void IsEnabled(this ICustomAssertionContext<Behaviour> context, string message = null) {
            Assert.IsTrue(context.Target.enabled, message);
        }

        public static void IsActive(this ICustomAssertionContext<GameObject> context, string message = null) {
            Assert.That(context.Target.gameObject.activeInHierarchy.Equals(true), message ?? $"{context.Target.name} was expected to be active but instead it was not.");
        }

        public static void IsNotActive(this ICustomAssertionContext<GameObject> context, string message = null) {
            Assert.That(context.Target.gameObject.activeInHierarchy.Equals(false), message ?? $"{context.Target.name} was expected to be inactive but instead it was active.");
        }
    }
}