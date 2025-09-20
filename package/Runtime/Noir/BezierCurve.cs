using System;
using System.Collections.Generic;
using UnityEngine;

namespace Noir {
    /// <summary>
    /// Used to create a set of discrete "control points" that define a smooth,
    /// continuous curve by means of a formula.
    /// </summary>
    /// <seealso href="https://en.wikipedia.org/wiki/B%C3%A9zier_curve">Bézier curve on Wikipedia</seealso>
    [Serializable]
    public struct BezierCurve {
        /// <summary>
        /// The starting point of the curve.
        /// </summary>
        public Vector3 Start { get; set; }

        /// <summary>
        /// The ending point of the curve.
        /// </summary>
        public Vector3 End { get; set; }

        /// <summary>
        /// The height of the arc for the curve.
        /// </summary>
        public float ArcHeight { get; set; }

        /// <summary>
        /// Gets the computed control point for the curve.
        /// </summary>
        public readonly Vector3 ControlPoint {
            get {
                return Start + ((End - Start) / 2) + Vector3.up * ArcHeight;
            }
        }


        /// <summary>
        /// Creates a new <c>BezierCurve</c> that starts from <c>Vector3.zero</c>.
        /// </summary>
        /// <param name="distance">The distance the curve travels.</param>
        /// <param name="height">The arc height of the curve.</param>
        /// <returns>A new BezierCurve object</returns>
        public static BezierCurve Create(int distance, int height) {
            var start = Vector3.zero;
            var curve = new BezierCurve() {
                Start = start,
                End = start + new Vector3(1, 0, 1) * distance,
                ArcHeight = height,
            };
            return curve;
        }

        /// <summary>
        /// Creates a <see cref="BezierCurveMovement"/> that starts from <c>Vector3.zero</c>.
        /// </summary>
        /// <param name="initialDistance">The distance for the first curve.</param>
        /// <param name="initialArcHeight">The arc height of the first curve.</param>
        /// <param name="initialDuration">The duration it takes to travel the first curve.</param>
        /// <param name="bounciness">The bounce factor used to compute the number of subsequent curves.</param>
        /// <returns></returns>
        public static BezierCurveMovement[] CreateMovement(int initialDistance, int initialArcHeight, float initialDuration, float bounciness = 0f) {
            var curves = new List<BezierCurveMovement>();
            var lastMove = new BezierCurveMovement() {
                Duration = initialDuration,
                Curve = BezierCurve.Create(initialDistance, initialArcHeight)
            };
            curves.Add(lastMove);
            while (bounciness > 0.1f) {
                var endPoint = lastMove.Curve.End.x + initialDistance * bounciness;
                lastMove = new BezierCurveMovement() {
                    Duration = initialDuration * bounciness,
                    Curve = new BezierCurve() {
                        Start = new Vector3(lastMove.Curve.End.x, 0, lastMove.Curve.End.z),
                        End = new Vector3(endPoint, 0, endPoint),
                        ArcHeight = initialArcHeight * bounciness
                    }
                };
                curves.Add(lastMove);
                bounciness /= 2;
            }
            return curves.ToArray();
        }
    }
}
