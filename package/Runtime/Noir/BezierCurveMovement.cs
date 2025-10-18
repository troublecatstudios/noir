using System;

namespace Noir {
    /// <summary>
    /// Represents movement along a Bezier curve over a specified duration.
    /// </summary>
    [Serializable]
    public class BezierCurveMovement {

        /// <summary>
        /// Gets or sets the Bezier curve to use for movement.
        /// </summary>
        public BezierCurve Curve { get; set; }

        /// <summary>
        /// Gets or sets the duration of the movement along the curve, in seconds.
        /// </summary>
        public float Duration { get; set; }
    }
}