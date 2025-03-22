using NoirUnityEditor.Utility;
using UnityEditor;
using UnityEngine;

namespace NoirUnityEditor.Modifications {
    public static class NoirEditorSettingsGui {
        private static Editor _settingsAssetEditor = null;
        private static Vector2 _scrollPosition = Vector2.zero;

        internal static void DrawSettings(NoirEditorSettings settings) {
            NoirEditorGUILayout.Header("Code Generation");
            EditorGUI.BeginChangeCheck();
            settings.CodeGeneratorNamespace = EditorGUILayout.TextField(new GUIContent("Namespace", ""), settings.CodeGeneratorNamespace);
            if (EditorGUI.EndChangeCheck()) {

            }

            EditorGUI.BeginChangeCheck();
            settings.CodeGeneratorOutputFolder = EditorGUILayout.TextField(new GUIContent("Output Folder", ""), settings.CodeGeneratorOutputFolder);
            if (EditorGUI.EndChangeCheck()) {

            }

            NoirEditorGUILayout.Header("ScriptableObject Automatic Creation");
            EditorGUI.BeginChangeCheck();
            settings.AutoCreateAssetsEnabled = EditorGUILayout.Toggle(new GUIContent("Enabled", ""), settings.AutoCreateAssetsEnabled);
            if (EditorGUI.EndChangeCheck()) {

            }
        }
    }
}
