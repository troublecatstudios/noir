using UnityEngine;

namespace Noir.Unity.Abstractions.Impl {

    public static class UnityRaycastHit2DExtensions {
        public static void SetFrom(this UnityRaycastHit2D urch, RaycastHit2D rch) {
            urch.Hit = rch;
        }
    }

    public class UnityRaycastHit2D : AbstractRaycastHit2D {
        private RaycastHit2D _hit = new RaycastHit2D();
        internal RaycastHit2D Hit {
            get => _hit;
            set {
                _hit = value;
                point = _hit.point;
                normal = _hit.normal;
                fraction = _hit.fraction;
                distance = _hit.distance;
            }
        }

        public override bool IsValid() {
            return !!_hit;
        }
    }
}
