using NUnit.Framework;
using UnityEngine;

namespace Noir.Testing.Assertions {
    /// <summary>
    /// Provides assertion extensions for validating <see cref="Vector2"/> and <see cref="Vector3"/> values.
    /// </summary>
    public static class VectorAssertions {
        /// <summary>
        /// Asserts that the given <see cref="Vector2"/> has both x and y components equal to <c>0</c>.
        /// </summary>
        /// <param name="context">The assertion context containing the <see cref="Vector2"/> target.</param>
        /// <param name="message">An optional custom message to use if the assertion fails.</param>
        public static void IsZero(this IAssertionContext<Vector2> context, string message = null) {
            Assert.That(context.Target.x, Is.EqualTo(0), message ?? $"Expected vector x component to be 0 but was {context.Target.x}.");
            Assert.That(context.Target.y, Is.EqualTo(0), message ?? $"Expected vector y component to be 0 but was {context.Target.y}.");
        }

        /// <summary>
        /// Asserts that the given <see cref="Vector3"/> has all x, y, and z components equal to <c>0</c>.
        /// </summary>
        /// <param name="context">The assertion context containing the <see cref="Vector3"/> target.</param>
        /// <param name="message">An optional custom message to use if the assertion fails.</param>
        public static void IsZero(this IAssertionContext<Vector3> context, string message = null) {
            Assert.That(context.Target.x, Is.EqualTo(0), message ?? $"Expected vector x component to be 0 but was {context.Target.x}.");
            Assert.That(context.Target.y, Is.EqualTo(0), message ?? $"Expected vector y component to be 0 but was {context.Target.y}.");
            Assert.That(context.Target.z, Is.EqualTo(0), message ?? $"Expected vector z component to be 0 but was {context.Target.z}.");
        }
    }
}