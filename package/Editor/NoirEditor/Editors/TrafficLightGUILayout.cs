using Noir.Attributes;
using UnityEngine;

namespace NoirEditor.Editors {
    /// <summary>
    /// Provides utility methods for rendering traffic light indicators in Unity's IMGUI system using <see cref="GUILayout"/>.
    /// </summary>
    public static class TrafficLightGUILayout {
        /// <summary>
        /// Draws a single traffic light indicator using GUILayout positioning.
        /// </summary>
        /// <param name="colorA">The color to display for the single light.</param>
        public static void DrawTrafficLightSingle(TrafficLightColor colorA) {
            var size = TrafficLightGUI.GetTrafficLightSize(TrafficLightSize.Single);
            size += new Vector2(0, 2); // add a lil bit of padding under
            var rect = GUILayoutUtility.GetRect(size.x, size.y);
            TrafficLightGUI.DrawTrafficLightSingle(rect, colorA);
        }

        /// <summary>
        /// Draws a double traffic light indicator using GUILayout positioning.
        /// </summary>
        /// <param name="colorA">The color for the top or first light.</param>
        /// <param name="ccolorB">The color for the bottom or second light.</param>
        public static void DrawTrafficLightDouble(TrafficLightColor colorA, TrafficLightColor ccolorB) {
            var size = TrafficLightGUI.GetTrafficLightSize(TrafficLightSize.Double);
            size += new Vector2(0, 2);
            var rect = GUILayoutUtility.GetRect(size.x, size.y);
            TrafficLightGUI.DrawTrafficLightDouble(rect, colorA, ccolorB);
        }

        /// <summary>
        /// Draws a triple traffic light indicator using GUILayout positioning.
        /// </summary>
        /// <param name="colorA">The color for the first light.</param>
        /// <param name="colorB">The color for the second light.</param>
        /// <param name="colorC">The color for the third light.</param>
        public static void DrawTrafficLightTriple(TrafficLightColor colorA, TrafficLightColor colorB, TrafficLightColor colorC) {
            var size = TrafficLightGUI.GetTrafficLightSize(TrafficLightSize.Triple);
            size += new Vector2(0, 2);
            var rect = GUILayoutUtility.GetRect(size.x, size.y);
            TrafficLightGUI.DrawTrafficLightTriple(rect, colorA, colorB, colorC);
        }

        /// <summary>
        /// Draws a quadruple traffic light indicator using GUILayout positioning.
        /// </summary>
        /// <param name="colorA">The color for the first light.</param>
        /// <param name="colorB">The color for the second light.</param>
        /// <param name="colorC">The color for the third light.</param>
        /// <param name="colorD">The color for the fourth light.</param>
        public static void DrawTrafficLightQuad(TrafficLightColor colorA, TrafficLightColor colorB, TrafficLightColor colorC, TrafficLightColor colorD) {
            var size = TrafficLightGUI.GetTrafficLightSize(TrafficLightSize.Quad);
            size += new Vector2(0, 2);
            var rect = GUILayoutUtility.GetRect(size.x, size.y);
            TrafficLightGUI.DrawTrafficLightQuad(rect, colorA, colorB, colorC, colorD);
        }

        /// <summary>
        /// Draws a single light that turns on or off based on a boolean value.
        /// </summary>
        /// <param name="val">If <c>true</c>, the light is on; otherwise, off.</param>
        /// <param name="color">The color to use when the light is on. Defaults to <see cref="TrafficLightColor.Green"/>.</param>
        public static void BoolLight(bool val, TrafficLightColor color = TrafficLightColor.Green) {
            DrawTrafficLightSingle(val ? color : TrafficLightColor.Off);
        }

        /// <summary>
        /// Draws a large two-light indicator for a boolean value, showing red for false and green for true by default.
        /// </summary>
        /// <param name="val">The boolean state to represent.</param>
        /// <param name="colorA">The color for the "off" or false light. Defaults to <see cref="TrafficLightColor.Red"/>.</param>
        /// <param name="colorB">The color for the "on" or true light. Defaults to <see cref="TrafficLightColor.Green"/>.</param>
        public static void BoolLightLarge(bool val, TrafficLightColor colorA = TrafficLightColor.Red, TrafficLightColor colorB = TrafficLightColor.Green) {
            DrawTrafficLightDouble(!val ? colorA : TrafficLightColor.Off, val ? colorB : TrafficLightColor.Off);
        }
    }
}