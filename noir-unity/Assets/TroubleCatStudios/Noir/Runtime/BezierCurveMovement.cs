using System;

namespace Noir {
    [Serializable]
    public class BezierCurveMovement {
        public BezierCurve Curve { get; set; }
        public float Duration { get; set; }
    }
}