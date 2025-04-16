using Noir;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

#if ODIN_INSPECTOR
using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;
#endif

namespace NoirEditor.Editors.SettingsProviders {
    internal static class NoirProjectConfigurationSettingsProvider {
        internal static NoirProjectConfiguration GetOrCreateSettings() {
            var settings = AssetDatabase.LoadAssetAtPath<NoirProjectConfiguration>(NoirProjectConfiguration.SettingsPath);
            if (settings == null) {
                settings = ScriptableObject.CreateInstance<NoirProjectConfiguration>();
                AssetDB.Mkdirp(Path.GetDirectoryName(NoirProjectConfiguration.SettingsPath));
                AssetDatabase.CreateAsset(settings, NoirProjectConfiguration.SettingsPath);
                AssetDatabase.SaveAssets();
            }
            return settings;
        }

        internal static class NoirProjectSettingsRegister {
            private static Editor _settingsAssetEditor = null;
            private static Vector2 _scrollPosition = Vector2.zero;

#if ODIN_INSPECTOR
            private static OdinMenuTree _menuTree = null;
#endif

            [SettingsProvider]
            public static SettingsProvider CreateNoirSettingsProvider() {
                var provider = new SettingsProvider("Project/NoirProjectSettings", SettingsScope.Project) {
                    label = "Troublecat Noir",
                    guiHandler = SettingsGUI,
                    keywords = new HashSet<string>(new[] { "noir", "FPS", "framerate", "frame", "rate" })
                };
                return provider;
            }

            internal static void SettingsGUI(string searchContext) {
                var settingsAsset = GetOrCreateSettings();
                var serializedSettings = new SerializedObject(settingsAsset);

                if (_settingsAssetEditor == null) {
                    _settingsAssetEditor = Editor.CreateEditor(settingsAsset);
                }

#if ODIN_INSPECTOR
                if (_menuTree == null) {
                    _menuTree = new OdinMenuTree();
                    foreach(var (path, icon) in NoirProjectSettings.GetEditorCategories()) {
                        _menuTree.Add(path, icon);
                    }
                }

                foreach (var item in _menuTree.MenuItems) {
                    if (item.IsSelected) {
                        settingsAsset.SelectedParent = item.Name ?? "";
                    }
                }

                using (_ = new EditorGUILayout.HorizontalScope()) {
                    using (_ = new EditorGUILayout.VerticalScope(GUILayout.MaxWidth(200))) {
                        using (_ = new EditorGUILayout.HorizontalScope(GUILayout.ExpandHeight(true))) {
                            _menuTree.DrawMenuTree();
                        }
                    }
                }
#endif

                using (_ = new EditorGUILayout.VerticalScope(GUILayout.MaxWidth(512))) {
                    using (var scrollScope = new EditorGUILayout.ScrollViewScope(_scrollPosition)) {
                        _scrollPosition = scrollScope.scrollPosition;
                        if (_settingsAssetEditor != null) {
                            _settingsAssetEditor.OnInspectorGUI();
                        }
                    }
                }

                if (GUI.changed) {
                    serializedSettings.ApplyModifiedProperties();
                }
            }
        }
    }
}