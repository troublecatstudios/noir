using System;
using System.Collections.Generic;
using UnityEngine;

namespace Noir {
    [Serializable]
    /// <summary>
    /// Used to create a set of discrete "control points" that define a smooth,
    /// continuous curve by means of a formula.
    /// </summary>
    /// <seealso href="https://en.wikipedia.org/wiki/B%C3%A9zier_curve">Bézier curve on Wikipedia</seealso>
    public struct BezierCurve {
        public Vector3 Start { get; set; }
        public Vector3 End { get; set; }
        public float ArcHeight { get; set; }

        public readonly Vector3 ControlPoint {
            get {
                return Start + ((End - Start) / 2) + Vector3.up * ArcHeight;
            }
        }

        public static BezierCurve Create(int distance, int height) {
            var start = Vector3.zero;
            var curve = new BezierCurve() {
                Start = start,
                End = start + new Vector3(1, 0, 1) * distance,
                ArcHeight = height,
            };
            return curve;
        }

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
