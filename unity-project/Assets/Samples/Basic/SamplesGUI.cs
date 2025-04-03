using UnityEngine;

namespace Samples {
    public static class SamplesGUI {
        public static GUIStyle HeaderTextStyle(int fontSize = 32, FontStyle fontStyle = FontStyle.Bold, TextAnchor alignment = TextAnchor.MiddleCenter, Color? textColor = null) {
            return new() {
                fontSize = fontSize,
                alignment = alignment,
                fontStyle = fontStyle,
                normal = new() {
                    textColor = textColor ?? Color.white,
                }
            };
        }

        public static GUIStyle EditModeLabelStyle(int fontSize = 24, Color? textColor = null, TextAnchor alignment = TextAnchor.MiddleCenter) {
            return new() {
                fontSize = fontSize,
                alignment = alignment,
                normal = new() {
                    textColor = textColor ?? Color.white,
                }
            };
        }
    }
}