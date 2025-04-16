using System;
using UnityEngine;

namespace Noir {
    public static class Collider2DExtensions {
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