using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace NoirUnityEditor {
    public static class EditorVector2 {
        /// <summary>
        /// Alias for Vector2(0, -1). Unity Editor UI Coordinates use an inverted Y axis.
        /// </summary>
        public static Vector2 up => new Vector2(0, -1);
        /// <summary>
        /// Alias for Vector2(0, 1). Unity Editor UI Coordinates use an inverted Y axis.
        /// </summary>
        public static Vector2 down => new Vector2(0, 1);
        /// <summary>
        /// Alias for Vector2(-1, 0).
        /// </summary>
        public static Vector2 left => new Vector2(-1, 0);
        /// <summary>
        /// Alias for Vector2(1, 0).
        /// </summary>
        public static Vector2 right => new Vector2(1, 0);

        /// <summary>
        /// Alias for Vector2(0, -1). Unity Editor UI Coordinates use an inverted Y axis.
        /// </summary>
        public static Vector2 Up => up;
        /// <summary>
        /// Alias for Vector2(0, 1). Unity Editor UI Coordinates use an inverted Y axis.
        /// </summary>
        public static Vector2 Down => down;
        /// <summary>
        /// Alias for Vector2(-1, 0).
        /// </summary>
        public static Vector2 Left => left;
        /// <summary>
        /// Alias for Vector2(1, 0).
        /// </summary>
        public static Vector2 Right => right;
    }
}
