using UnityEngine;

namespace Noir.Unity.Abstractions {
    public abstract class AbstractPhysics2D {
        public abstract int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Collider2D[] results, int layerMask);
    }
}
