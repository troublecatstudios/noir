using Noir.Attributes;
using UnityEngine;

namespace NoirEditor.Editors {
    public static class TrafficLightGUILayout {
        public static void DrawTrafficLightSingle(TrafficLightColor colorA) {
            var size = TrafficLightGUI.GetTrafficLightSize(TrafficLightSize.Single);
            size += new Vector2(0, 2); // add a lil bit of padding under
            var rect = GUILayoutUtility.GetRect(size.x, size.y);
            TrafficLightGUI.DrawTrafficLightSingle(rect, colorA);
        }

        public static void DrawTrafficLightDouble(TrafficLightColor colorA, TrafficLightColor ccolorB) {
            var size = TrafficLightGUI.GetTrafficLightSize(TrafficLightSize.Double);
            size += new Vector2(0, 2);
            var rect = GUILayoutUtility.GetRect(size.x, size.y);
            TrafficLightGUI.DrawTrafficLightDouble(rect, colorA, ccolorB);
        }

        public static void DrawTrafficLightTriple(TrafficLightColor colorA, TrafficLightColor colorB, TrafficLightColor colorC) {
            var size = TrafficLightGUI.GetTrafficLightSize(TrafficLightSize.Triple);
            size += new Vector2(0, 2);
            var rect = GUILayoutUtility.GetRect(size.x, size.y);
            TrafficLightGUI.DrawTrafficLightTriple(rect, colorA, colorB, colorC);
        }

        public static void DrawTrafficLightQuad(TrafficLightColor colorA, TrafficLightColor colorB, TrafficLightColor colorC, TrafficLightColor colorD) {
            var size = TrafficLightGUI.GetTrafficLightSize(TrafficLightSize.Quad);
            size += new Vector2(0, 2);
            var rect = GUILayoutUtility.GetRect(size.x, size.y);
            TrafficLightGUI.DrawTrafficLightQuad(rect, colorA, colorB, colorC, colorD);
        }

        public static void BoolLight(bool val, TrafficLightColor color = TrafficLightColor.Green) {
            DrawTrafficLightSingle(val ? color : TrafficLightColor.Off);
        }

        public static void BoolLightLarge(bool val, TrafficLightColor colorA = TrafficLightColor.Red, TrafficLightColor colorB = TrafficLightColor.Green) {
            DrawTrafficLightDouble(!val ? colorA : TrafficLightColor.Off, val ? colorB : TrafficLightColor.Off);
        }
    }
}