using System;
using UnityEngine;

namespace Noir {
    /// <summary>
    /// Extension methods for Unity <see cref="Collider"/> components.
    /// </summary>
    public static class ColliderExtensions {
        /// <summary>
        /// Sets the dimensions of the collider based on the specified size.
        /// The behavior depends on the specific collider type:
        /// <list type="bullet">
        /// <item><see cref="BoxCollider"/>: Sets the size to (x, y, x).</item>
        /// <item><see cref="SphereCollider"/>: Sets the radius to x.</item>
        /// <item><see cref="CapsuleCollider"/>: Sets the radius to x and the height to y.</item>
        /// </list>
        /// </summary>
        /// <param name="collider">The collider to modify.</param>
        /// <param name="size">The size parameters to apply.</param>
        /// <exception cref="InvalidOperationException">
        /// Thrown when the collider type is not supported by this method.
        /// </exception>
        public static void SetDimensions(this Collider collider, Vector2 size) {
            switch (collider)
            {
                case BoxCollider boxCollider:
                    boxCollider.size = new Vector3(size.x, size.y, size.x);
                    return;
                case SphereCollider circleCollider:
                    circleCollider.radius = size.x;
                    return;
                case CapsuleCollider capsuleCollider:
                    capsuleCollider.radius = size.x;
                    capsuleCollider.height = size.y;
                    return;
                default:
                    throw new InvalidOperationException($"SetDimensions cannot be called on colliders of type {collider.GetType().Name})");
            }
        }
    }
}