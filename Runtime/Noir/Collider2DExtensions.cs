using System;
using UnityEngine;

namespace Noir {
    /// <summary>
    /// Extension methods for Unity <see cref="Collider2D"/> components.
    /// </summary>
    public static class Collider2DExtensions {
        /// <summary>
        /// Sets the dimensions of the 2D collider based on the specified size.
        /// The behavior depends on the specific collider type:
        /// <list type="bullet">
        /// <item><see cref="BoxCollider2D"/>: Sets the size property.</item>
        /// <item><see cref="CircleCollider2D"/>: Sets the radius to the x value of the size.</item>
        /// <item><see cref="CapsuleCollider2D"/>: Sets the size property.</item>
        /// <item><see cref="PolygonCollider2D"/>: Throws an exception as dimensions cannot be set directly.</item>
        /// </list>
        /// </summary>
        /// <param name="collider">The 2D collider to modify.</param>
        /// <param name="size">The size parameters to apply.</param>
        /// <exception cref="InvalidOperationException">
        /// Thrown when called on a <see cref="PolygonCollider2D"/>, as dimensions cannot be set.
        /// </exception>
        public static void SetDimensions(this Collider2D collider, Vector2 size) {
            if (collider is BoxCollider2D boxCollider) {
                boxCollider.size = size;
            }

            if (collider is CircleCollider2D circleCollider) {
                circleCollider.radius = size.x;
            }

            if (collider is PolygonCollider2D polyCollider) {
                throw new InvalidOperationException("SetDimensions cannot be called on PolgonCollider2D colliders.");
            }

            if (collider is CapsuleCollider2D capsuleCollider) {
                capsuleCollider.size = size;
            }
        }
    }
}