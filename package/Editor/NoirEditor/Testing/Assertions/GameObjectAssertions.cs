using NUnit.Framework;
using UnityEngine;

namespace Noir.Testing.Assertions {
    public static class GameObjectAssertions {
        /// <summary>
        /// Asserts that the game object has the given component.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="message"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IAssertionContext<T> HasComponent<T>(this IAssertionContext<GameObject> context, string message = null) {
            var component = context.Target.GetComponent<T>();
            Assert.IsNotNull(component, message);
            return new AssertionContext<T>(component);
        }

        /// <summary>
        /// Asserts that the game object is enabled.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="message"></param>
        public static void IsEnabled(this IAssertionContext<Behaviour> context, string message = null) {
            Assert.IsTrue(context.Target.enabled, message);
        }

        /// <summary>
        /// Asserts that the game object is active within the scene hierarchy.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="message"></param>
        public static void IsActive(this IAssertionContext<GameObject> context, string message = null) {
            Assert.That(context.Target.gameObject.activeInHierarchy.Equals(true), message ?? $"{context.Target.name} was expected to be active but instead it was not.");
        }

        /// <summary>
        /// Asserts that the game object is not active within the scene hierarchy.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="message"></param>
        public static void IsNotActive(this IAssertionContext<GameObject> context, string message = null) {
            Assert.That(context.Target.gameObject.activeInHierarchy.Equals(false), message ?? $"{context.Target.name} was expected to be inactive but instead it was active.");
        }
    }
}