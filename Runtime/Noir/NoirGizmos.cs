using UnityEngine;
using UnityEngine.Events;

namespace Noir {
    /// <summary>
    /// Provides helper methods for drawing gizmos and handles in Unity editor and runtime.
    /// </summary>
    public static class NoirGizmos {

        /// <summary>
        /// Draws an arrow gizmo at the given position and direction using the current Gizmos color.
        /// </summary>
        /// <param name="pos">The starting position of the arrow.</param>
        /// <param name="direction">The direction vector of the arrow.</param>
        /// <param name="arrowHeadLength">The length of the arrow head. Default is 2.</param>
        /// <param name="arrowHeadAngle">The angle of the arrow head in degrees. Default is 20.</param>
        public static void DrawArrow(Vector3 pos, Vector3 direction, float arrowHeadLength = 2f, float arrowHeadAngle = 20.0f) {
            DrawArrow(pos, direction, Gizmos.color, arrowHeadLength, arrowHeadAngle);
        }

        /// <summary>
        /// Draws an arrow gizmo at the given position and direction, with a specified color.
        /// </summary>
        /// <param name="pos">The starting position of the arrow.</param>
        /// <param name="direction">The direction vector of the arrow.</param>
        /// <param name="color">The color to use for the arrow.</param>
        /// <param name="arrowHeadLength">The length of the arrow head. Default is 2.</param>
        /// <param name="arrowHeadAngle">The angle of the arrow head in degrees. Default is 20.</param>
        public static void DrawArrow(Vector3 pos, Vector3 direction, Color color, float arrowHeadLength = 2f, float arrowHeadAngle = 20.0f) {
            Gizmos.color = color;
            Gizmos.DrawRay(pos, direction);

            Vector3 right = Quaternion.LookRotation(direction) * Quaternion.Euler(180 + arrowHeadAngle, 0, 0) * new Vector3(0, 0, 1);
            Vector3 left = Quaternion.LookRotation(direction) * Quaternion.Euler(180 - arrowHeadAngle, 0, 0) * new Vector3(0, 0, 1);
            Gizmos.DrawRay(pos + direction, right * arrowHeadLength);
            Gizmos.DrawRay(pos + direction, left * arrowHeadLength);
        }

        /// <summary>
        /// Draws an icon and label for the specified type at the given position in the scene view.
        /// Only works in the Unity Editor.
        /// </summary>
        /// <typeparam name="T">The type to display with an icon and label.</typeparam>
        /// <param name="position">The position to draw the icon and label.</param>
        /// <param name="label">A label to display next to the type name.</param>
        /// <param name="iconSize">The size of the icon in pixels. Default is 32.</param>
        public static void DrawTypeIcon<T>(Vector3 position, string label, float iconSize = 32) {
#if UNITY_EDITOR
            var typeName = typeof(T).Name;
            UnityEditor.Handles.Label(position, $"{typeName}: {label}");
            Gizmos.DrawIcon(position + (Vector3.up * iconSize / 2), $"{typeName}.png", true);
            Gizmos.DrawWireCube(position + (Vector3.up * iconSize / 2), Vector3.one * iconSize);
#endif
        }

        /// <summary>
        /// Draws a wireframe circle at the specified center and radius, oriented upwards.
        /// </summary>
        /// <param name="circleCenter">The center of the circle.</param>
        /// <param name="circleRadius">The radius of the circle.</param>
        /// <param name="segments">The number of line segments to use (higher means smoother circle). Default is 32.</param>
        public static void DrawWireCircle(Vector3 circleCenter, float circleRadius, int segments = 32) {
            DrawWireCircle(circleCenter, circleRadius, Vector3.up, segments);
        }

        /// <summary>
        /// Draws a wireframe circle at the specified center, radius, and normal direction.
        /// </summary>
        /// <param name="circleCenter">The center of the circle.</param>
        /// <param name="circleRadius">The radius of the circle.</param>
        /// <param name="circleNormal">The normal vector that determines the circle's orientation.</param>
        /// <param name="segments">The number of line segments to use (higher means smoother circle). Default is 32.</param>
        public static void DrawWireCircle(Vector3 circleCenter, float circleRadius, Vector3 circleNormal, int segments = 32) {
            Vector3 radiusVector = Mathf.Abs(Vector3.Dot(circleNormal, Vector3.right)) - 1f <= Mathf.Epsilon
                ? Vector3.Cross(circleNormal, Vector3.forward).normalized
                : Vector3.Cross(circleNormal, Vector3.right).normalized;
            radiusVector *= circleRadius;
            float angleBetweenSegments = 360f / segments;
            Vector3 previousCircumferencePoint = circleCenter + radiusVector;
            for (int i = 0; i < segments; ++i)
            {
                radiusVector = Quaternion.AngleAxis(angleBetweenSegments, circleNormal) * radiusVector;
                Vector3 newCircumferencePoint = circleCenter + radiusVector;
                Gizmos.DrawLine(previousCircumferencePoint, newCircumferencePoint);
                previousCircumferencePoint = newCircumferencePoint;
            }
        }

        /// <summary>
        /// Draws a wire arc.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="dir">The direction from which the anglesRange is taken into account</param>
        /// <param name="anglesRange">The angle range, in degrees.</param>
        /// <param name="radius"></param>
        /// <param name="maxSteps">How many steps to use to draw the arc.</param>
        public static void DrawWireArc(Vector3 position, Vector3 dir, float anglesRange, float radius, float maxSteps = 20) {
            var srcAngles = GetAnglesFromDir(position, dir);
            var initialPos = position;
            var posA = initialPos;
            var stepAngles = anglesRange / maxSteps;
            var angle = srcAngles - anglesRange / 2;
            for (var i = 0; i <= maxSteps; i++) {
                var rad = Mathf.Deg2Rad * angle;
                var posB = initialPos;
                posB += new Vector3(radius * Mathf.Cos(rad), radius * Mathf.Sin(rad), 0);

                Gizmos.DrawLine(posA, posB);

                angle += stepAngles;
                posA = posB;
            }
            Gizmos.DrawLine(posA, initialPos);
        }

        private static readonly Vector3[] _bezierPoints = new Vector3[100];

        /// <summary>
        /// Draws a quadratic Bezier curve using the specified origin and curve definition.
        /// </summary>
        /// <param name="origin">Origin offset for the curve.</param>
        /// <param name="curve">The Bezier curve definition.</param>
        /// <param name="numberOfPoints">Number of points used to draw the curve. Default is 16.</param>
        /// <param name="pointRadius">Size of the control point marker. Default is 4.</param>
        /// <param name="direction">Optional direction vector for scaling the curve.</param>
        public static void DrawBezierCurve(Vector3 origin, BezierCurve curve, int numberOfPoints = 16, float pointRadius = 4f, Vector3? direction = null) {
            if (numberOfPoints < 8) {
                numberOfPoints = 8;
            }
            if (numberOfPoints > 100) {
                numberOfPoints = 100;
            }
            var dirVector = direction != null ? new Vector3(direction.Value.x, 1, direction.Value.z) : new Vector3(1, 1, 1);
            var start = Vector3.Scale(dirVector, curve.Start) + origin;
            var end = Vector3.Scale(dirVector, curve.End) + origin;
            var cp = Vector3.Scale(dirVector, curve.ControlPoint) + origin;

            Gizmos.DrawWireCube(cp, Vector3.one * 4);

            // set points of quadratic Bezier curve
            var p0 = start;
            var p1 = cp;
            var p2 = end;
            float t;
            Vector3 position;
            for (int i = 0; i < numberOfPoints; i++) {
                t = i / (numberOfPoints - 1.0f);
                position = (1.0f - t) * (1.0f - t) * p0 + 2.0f * (1.0f - t) * t * p1 + t * t * p2;
                _bezierPoints[i] = position;
            }

            for (int i = 1; i < numberOfPoints; i++) {
                Gizmos.DrawLine(_bezierPoints[i], _bezierPoints[i - 1]);
            }
        }

        /// <summary>
        /// Draws dotted lines from a parent GameObject to the targets of a UnityEvent in the Unity Editor.
        /// </summary>
        /// <param name="parent">The parent GameObject from which lines are drawn.</param>
        /// <param name="ev">The UnityEvent whose persistent targets will be connected.</param>
        /// <param name="offset">An optional offset added to the parent's position when drawing lines.</param>
        public static void DrawLinesToTargets(GameObject parent, UnityEvent ev, Vector3 offset) {
#if UNITY_EDITOR
            var count = ev.GetPersistentEventCount();
            var sceneRoots = UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects();
            for (var i = 0; i < count; i++) {
                var t = ev.GetPersistentTarget(i);
                if (!t || !(t is MonoBehaviour) || !(t is Component)) {
                    continue;
                }
                var stage = UnityEditor.SceneManagement.PrefabStageUtility.GetCurrentPrefabStage();
                if (UnityEditor.PrefabUtility.IsPartOfAnyPrefab(t) && stage != null) {
                    var root = stage.prefabContentsRoot;
                    if (DrawLines(parent.transform.position, root, t, ev, i, offset)) break;
                    continue;
                }
                foreach (var root in sceneRoots) {
                    if (DrawLines(parent.transform.position, root, t, ev, i, offset)) break;
                }
            }
#endif
        }

        /// <summary>
        /// Draws an 'X' shape wireframe at a given 2D point.
        /// </summary>
        /// <param name="point">The center point for the 'X'.</param>
        /// <param name="size">The size of the 'X'. Default is 4.</param>
        public static void DrawX(Vector2 point, float size = 4) {
            Gizmos.DrawLine(point, point + new Vector2(1, 1) * size);
            Gizmos.DrawLine(point, point + new Vector2(1, -1) * size);
            Gizmos.DrawLine(point, point + new Vector2(-1, -1) * size);
            Gizmos.DrawLine(point, point + new Vector2(-1, 1) * size);
        }

        private static float GetAnglesFromDir(Vector3 position, Vector3 dir) {
            var forwardLimitPos = position + dir;
            var srcAngles = Mathf.Rad2Deg * Mathf.Atan2(forwardLimitPos.y - position.y, forwardLimitPos.x - position.x);

            return srcAngles;
        }

        private static bool DrawLines(Vector3 position, GameObject root, UnityEngine.Object source, UnityEvent ev, int i, Vector3 offset) {
#if UNITY_EDITOR
            var start = position + offset;
            if (source is Component c) {
                var end = c.transform.position;
                var mid = Vector3.Lerp(start, end, 0.5f);
                UnityEditor.Handles.DrawDottedLine(start, end, 8f);
                UnityEditor.Handles.Label(mid, $"{source.GetType().Name}.{ev.GetPersistentMethodName(i)}()");
                return true;
            }
#endif
            return false;
        }
    }
}