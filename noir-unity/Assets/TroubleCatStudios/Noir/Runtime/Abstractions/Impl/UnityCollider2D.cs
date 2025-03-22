using System;
using UnityEngine;

namespace Noir.Unity.Abstractions.Impl {
    public class UnityCollider2D : AbstractCollider2D {
        private readonly Collider2D _collider;
        public UnityCollider2D(Collider2D collider) {
            if (collider == null) throw new ArgumentNullException(nameof(collider));
            _collider = collider;
        }

        public override Vector2 Size {
            get {
                if (_collider is BoxCollider2D box) {
                    return box.size;
                }
                if (_collider is CapsuleCollider2D cap) {
                    return cap.size;
                }
                if (_collider is CircleCollider2D cir) {
                    return Vector2.one * cir.radius;
                }
                return Vector2.zero;
            }
        }
        public override Vector2 Offset => _collider.offset;
        public override Vector2 Position => _collider.transform.position;

        public override Vector2 ClosestPoint(Vector2 point) {
            return _collider.ClosestPoint(point);
        }
    }
}
