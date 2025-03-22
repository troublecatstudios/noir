using System;
using UnityEngine;

namespace Noir.Unity.Abstractions.Impl {
    public class UnityPhysics2D : AbstractPhysics2D {
        public override int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Collider2D[] results, int layerMask) {
            var mask = (LayerMask)layerMask;
            var filter = new ContactFilter2D() {
                useTriggers = true,
                layerMask = mask,
                useLayerMask = true,
            };
            //Debug.Log($"UnityPhysics2D - " +
            //    $"mask={layerMask}:{filter.layerMask.value}:{mask.value} ({String.Join(",", mask.DecodeLayerNames())}), " +
            //    $"usingMask={filter.useLayerMask}, " +
            //    $"useTriggers={filter.useTriggers}");
            return Physics2D.OverlapBox(point, size, angle, filter, results);
        }
    }
}
