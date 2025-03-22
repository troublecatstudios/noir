using UnityEngine;

namespace Noir.Unity.Abstractions {
    public abstract class AbstractRaycastHit2D {
        public Vector2 point { get; protected set; }
        public Vector2 normal { get; protected set; }
        public float distance { get; protected set; }
        public float fraction { get; protected set; }

        public virtual bool IsValid() {
            return true;
        }

        public static implicit operator bool(AbstractRaycastHit2D hit) {
            return hit.IsValid();
        }

        public int CompareTo(AbstractRaycastHit2D other) {
            if (!this) {
                return 1;
            }

            if (!other) {
                return -1;
            }

            return fraction.CompareTo(other.fraction);
        }
    }
}
