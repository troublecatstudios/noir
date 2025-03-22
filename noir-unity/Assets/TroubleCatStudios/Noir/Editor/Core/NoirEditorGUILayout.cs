using UnityEditor;
using UnityEngine;
using static NoirUnityEditor.UnityEditorIcons;

namespace NoirUnityEditor.Utility {
    public class NoirEditorGUILayout {
        public static void Line(int height = 1) {
            Rect rect = EditorGUILayout.GetControlRect(false, height);

            rect.height = height;

            EditorGUI.DrawRect(rect, new Color(0.5f, 0.5f, 0.5f, 1));
        }

        public static void Header(string text) {
            GUILayout.Space(20);
            EditorGUILayout.LabelField(text, EditorStyles.boldLabel);
            Line();
            GUILayout.Space(10);
        }

        public static void QuietCenteredText(string text) {
            EditorGUILayout.LabelField(text, EditorStyles.centeredGreyMiniLabel);
        }

        public static GUIContent IconWithText(string text, UnityEditorIcon unityEditorIcon) {
            return new GUIContent(text, unityEditorIcon.Image);
        }

        public static bool IconButton(string text, UnityEditorIcon unityEditorIcon, int iconSize = 0, params GUILayoutOption[] options) {
            EditorGUIUtility.SetIconSize(Vector2.one * iconSize); // 0 = automatically determine icon size using available space
            return GUILayout.Button(new GUIContent(text, unityEditorIcon.Image), options);
        }

        public static bool LabelButton(string text) {
            return GUILayout.Button(text, "Label");
        }

        private static Texture2D _transparent = TextureUtility.GenerateTexture(new Color(0, 0, 0, 0));
        private static Color PrimaryActionColor = new Color(5f / 255f, 132f / 255f, 196f / 255f, 1);
        private static Color PrimaryActionInactiveColor = new Color(102f / 255f, 117f / 255f, 125f / 255f, 1);
        private static Texture2D PrimaryActionTexture = TextureUtility.GenerateTexture(PrimaryActionColor);
        private static Texture2D PrimaryActionTextureInactive = TextureUtility.GenerateTexture(PrimaryActionInactiveColor);

        public static GUIStyle PrimaryActionButtonStyle() {
            var s = new GUIStyle();
            var b = s.border;
            b.left = 0;
            b.top = 0;
            b.right = 0;
            b.bottom = 0;
            s.clipping = TextClipping.Clip;
            s.wordWrap = true;
            s.fontStyle = FontStyle.Bold;
            s.alignment = TextAnchor.MiddleCenter;
            s.active = new GUIStyleState() {
                background = PrimaryActionTextureInactive,
            };
            s.hover = new GUIStyleState() {
                background = PrimaryActionTexture,
                textColor = Color.white,
            };
            s.normal = new GUIStyleState() {
                background = PrimaryActionTextureInactive,
            };
            return s;
        }

        public static GUIStyle TransparentLabelStyle() {
            var s = new GUIStyle();
            var b = s.border;
            b.left = 0;
            b.top = 0;
            b.right = 0;
            b.bottom = 0;
            s.clipping = TextClipping.Clip;
            s.wordWrap = true;
            s.fontStyle = FontStyle.Bold;
            s.alignment = TextAnchor.MiddleCenter;
            s.normal = new GUIStyleState() {
                background = _transparent,
                textColor = Color.white,
            };
            return s;
        }

        private static GUIStyle LabelButtonStyle() {
            var s = new GUIStyle();
            var b = s.border;
            b.left = 0;
            b.top = 0;
            b.right = 0;
            b.bottom = 0;
            return s;
        }
    }
}
