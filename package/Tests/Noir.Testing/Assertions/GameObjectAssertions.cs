using NUnit.Framework;
using UnityEngine;

namespace Noir.Testing.Assertions {
    /// <summary>
    /// Provides assertion extensions for verifying the state and components of <see cref="GameObject"/> and <see cref="Behaviour"/> instances in Unity.
    /// </summary>
    public static class GameObjectAssertions {
        /// <summary>
        /// Asserts that the target <see cref="GameObject"/> has the specified component of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of component expected to exist on the game object.</typeparam>
        /// <param name="context">The assertion context containing the target game object.</param>
        /// <param name="message">An optional custom message for the assertion failure.</param>
        /// <returns>
        /// An assertion context containing the component of type <typeparamref name="T"/> retrieved from the game object.
        /// </returns>
        /// <exception cref="AssertionException">
        /// Thrown if the component of type <typeparamref name="T"/> does not exist on the game object.
        /// </exception>
        public static IAssertionContext<T> HasComponent<T>(this IAssertionContext<GameObject> context, string message = null) {
            var component = context.Target.GetComponent<T>();
            Assert.IsNotNull(component, message);
            return new AssertionContext<T>(component);
        }

        /// <summary>
        /// Asserts that the target <see cref="Behaviour"/> is enabled.
        /// </summary>
        /// <param name="context">The assertion context containing the target behaviour.</param>
        /// <param name="message">An optional custom message for the assertion failure.</param>
        public static void IsEnabled(this IAssertionContext<Behaviour> context, string message = null) {
            Assert.IsTrue(context.Target.enabled, message);
        }

        /// <summary>
        /// Asserts that the target <see cref="GameObject"/> is active in the scene hierarchy.
        /// </summary>
        /// <param name="context">The assertion context containing the target game object.</param>
        /// <param name="message">An optional custom message for the assertion failure.</param>
        public static void IsActive(this IAssertionContext<GameObject> context, string message = null) {
            Assert.That(context.Target.gameObject.activeInHierarchy.Equals(true), message ?? $"{context.Target.name} was expected to be active but instead it was not.");
        }

        /// <summary>
        /// Asserts that the target <see cref="GameObject"/> is not active in the scene hierarchy.
        /// </summary>
        /// <param name="context">The assertion context containing the target game object.</param>
        /// <param name="message">An optional custom message for the assertion failure.</param>
        public static void IsNotActive(this IAssertionContext<GameObject> context, string message = null) {
            Assert.That(context.Target.gameObject.activeInHierarchy.Equals(false), message ?? $"{context.Target.name} was expected to be inactive but instead it was active.");
        }
    }
}