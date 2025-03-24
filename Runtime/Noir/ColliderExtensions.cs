using System;
using UnityEngine;

namespace Noir {
    public static class ColliderExtensions {
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