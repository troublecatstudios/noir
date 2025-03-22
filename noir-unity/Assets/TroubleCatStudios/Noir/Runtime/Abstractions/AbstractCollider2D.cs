using UnityEngine;

namespace Noir.Unity.Abstractions {
    public abstract class AbstractCollider2D {
        public abstract Vector2 Size { get; }
        public abstract Vector2 Offset { get; }
        public abstract Vector2 Position { get; }

        public Rect ToRect() {
            return new Rect(Position + Offset, Size);
        }

        public abstract Vector2 ClosestPoint(Vector2 point);
    }
}
