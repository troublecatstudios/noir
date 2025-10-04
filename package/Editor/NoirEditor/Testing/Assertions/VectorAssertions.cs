using NUnit.Framework;
using UnityEngine;

namespace Noir.Testing.Assertions {
    public static class VectorAssertions {
        /// <summary>
        /// Asserts that the given <see cref="Vector2"/> values x and y components are both <c>0</c>.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="message"></param>
        public static void IsZero(this IAssertionContext<Vector2> context, string message = null) {
            Assert.That(context.Target.x, Is.EqualTo(0), message ?? $"Expected vector x component to be 0 but was {context.Target.x}.");
            Assert.That(context.Target.y, Is.EqualTo(0), message ?? $"Expected vector y component to be 0 but was {context.Target.y}.");
        }

        /// <summary>
        /// Asserts that the given <see cref="Vector3"/> values x, y and z components are all <c>0</c>.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="message"></param>
        public static void IsZero(this IAssertionContext<Vector3> context, string message = null) {
            Assert.That(context.Target.x, Is.EqualTo(0), message ?? $"Expected vector x component to be 0 but was {context.Target.x}.");
            Assert.That(context.Target.y, Is.EqualTo(0), message ?? $"Expected vector y component to be 0 but was {context.Target.y}.");
            Assert.That(context.Target.z, Is.EqualTo(0), message ?? $"Expected vector z component to be 0 but was {context.Target.z}.");
        }
    }
}