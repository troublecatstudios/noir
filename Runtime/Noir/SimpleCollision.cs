using UnityEngine;

namespace Noir {
    /// <summary>
    /// Defines which dimensional method should be used when performing collision checks.
    /// </summary>
    public enum CollisionCheckMethod {
        /// <summary>
        /// Performs collision checks using 2D physics (e.g., Collider2D, Rigidbody2D).
        /// </summary>
        TwoDimensional,
        /// <summary>
        /// Performs collision checks using 3D physics (e.g., Collider, Rigidbody).
        /// </summary>
        ThreeDimensional,
    }

    /// <summary>
    /// Provides simple and efficient utility methods for performing 2D and 3D collision checks
    /// and working with colliders in Unity.
    /// </summary>
    public static class SimpleCollision {

        private static readonly RaycastHit2D[] _hits2d = new RaycastHit2D[10];
        private static readonly RaycastHit[] _hits3d = new RaycastHit[10];

        /// <summary>
        /// Performs a 2D or 3D collision check via raycast within the Unity Physics Engine.
        /// </summary>
        /// <param name="origin">The starting position of the ray.</param>
        /// <param name="direction">The unnormalized direction that the ray will be cast in.</param>
        /// <param name="length">The length of the ray, in world units.</param>
        /// <param name="mask">The collision mask to use.</param>
        /// <param name="method">Whether the 2D or 3D physics system should be checked</param>
        /// <param name="hitThreshold">The minimum number of hits that must be returned in order for the check to be successful.</param>
        /// <returns><c>true</c> if the hit threshold was met, <c>false</c> otherwise.</returns>
        public static bool Check(Vector3 origin, Vector3 direction, float length, LayerMask mask, CollisionCheckMethod method = CollisionCheckMethod.ThreeDimensional, int hitThreshold = 0) {
            if (method == CollisionCheckMethod.TwoDimensional) {
                var hits = Physics2D.RaycastNonAlloc(origin, direction.normalized, _hits2d, length, mask);
                if (hits > hitThreshold) {
                    var other = _hits2d[hitThreshold];
                    if (other.collider.enabled && other.collider.gameObject.activeInHierarchy) {
                        return true;
                    }
                }
            }

            if (method == CollisionCheckMethod.ThreeDimensional) {
                var hits = Physics.RaycastNonAlloc(origin, direction.normalized, _hits3d, length, mask);
                if (hits > hitThreshold) {
                    var other = _hits3d[hitThreshold];
                    if (other.collider.enabled && other.collider.gameObject.activeInHierarchy) {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to perform a raycast and retrieves the first hit position if successful.
        /// </summary>
        /// <param name="origin">The starting position of the ray.</param>
        /// <param name="direction">The unnormalized direction of the ray.</param>
        /// <param name="length">The maximum distance of the ray.</param>
        /// <param name="mask">The layer mask to filter collisions.</param>
        /// <param name="method">The physics system to use: 2D or 3D.</param>
        /// <param name="hitPosition">Outputs the position of the first hit if successful.</param>
        /// <returns><c>true</c> if a hit occurred; otherwise, <c>false</c>.</returns>
        public static bool TryGetHit(Vector3 origin, Vector3 direction, float length, LayerMask mask, CollisionCheckMethod method, out Vector3 hitPosition) {
            hitPosition = Vector3.zero;
            if (method == CollisionCheckMethod.TwoDimensional) {
                var hits = Physics2D.RaycastNonAlloc(origin, direction.normalized, _hits2d, length, mask);
                hitPosition = _hits2d[0].point;
                return hits > 0;
            }

            if (method == CollisionCheckMethod.ThreeDimensional) {
                var hits = Physics.RaycastNonAlloc(origin, direction.normalized, _hits3d, length, mask);
                hitPosition = _hits3d[0].point;
                return hits > 0;
            }

            return false;
        }

        /// <summary>
        /// Calculates a fast approximation of the contact point between two bounds.
        /// </summary>
        /// <param name="attackBounds">The bounds of the attacking object.</param>
        /// <param name="defenseBounds">The bounds of the defending object.</param>
        /// <returns>The midpoint between the centers of the two bounds.</returns>
        public static Vector2 GetContactPointFast(Bounds attackBounds, Bounds defenseBounds) {
            return attackBounds.center + (defenseBounds.center - attackBounds.center) / 2;
        }

        /// <summary>
        /// Determines whether a 2D collider contains a specified position.
        /// </summary>
        /// <param name="collider">The collider to check.</param>
        /// <param name="position">The position to test.</param>
        /// <returns><c>true</c> if the position is within the collider; otherwise, <c>false</c>.</returns>
        public static bool CheckPosition(Collider2D collider, Vector2 position) {
            return collider.bounds.Contains(position);
        }

        /// <summary>
        /// Returns a random point inside a <see cref="BoxCollider2D"/>.
        /// </summary>
        /// <param name="collider">The box collider.</param>
        /// <returns>A random point within the collider's bounds.</returns>
        public static Vector2 GetRandomPointWithinCollider(BoxCollider2D collider) {
            Vector2 colliderPos = (Vector2)collider.transform.position + collider.offset;
            float randomPosX = Random.Range(colliderPos.x - collider.size.x / 2, colliderPos.x + collider.size.x / 2);
            float randomPosY = Random.Range(colliderPos.y - collider.size.y / 2, colliderPos.y + collider.size.y / 2);

            return new Vector2(randomPosX, randomPosY);
        }

        /// <summary>
        /// Returns a random point inside a <see cref="CircleCollider2D"/>.
        /// </summary>
        /// <param name="collider">The circle collider.</param>
        /// <returns>A random point within the collider's bounds.</returns>
        public static Vector2 GetRandomPointWithinCollider(CircleCollider2D collider) {
            Vector2 colliderPos = (Vector2)collider.transform.position + collider.offset;
            return colliderPos + (Random.insideUnitCircle * collider.radius);
        }
    }
}