using Noir;
using UnityEditor;
using UnityEngine;

namespace NoirEditor.TroubleCatStudios.Noir.Editor.MenuItems {
    public static class CreateNoirProjectConfigurationAsset {
        private const string MENU_PATH = "Tools/Trouble Cat Studios/Noir/Setup/Create Project Configuration";

        [MenuItem(MENU_PATH, priority = 100)]
        public static void CreateAsset() {
            var settings = AssetDatabase.LoadAssetAtPath<NoirProjectConfiguration>(NoirProjectConfiguration.SettingsPath);
            if (settings == null) {
                settings = ScriptableObject.CreateInstance<NoirProjectConfiguration>();
                AssetDatabase.CreateAsset(settings, NoirProjectConfiguration.SettingsPath);
                AssetDatabase.SaveAssets();
            }
        }

        [MenuItem(MENU_PATH, true)]
        public static bool CreateAssetValidation() {
            try {
                var config = Resources.Load<NoirProjectConfiguration>(nameof(NoirProjectConfiguration));
                return !!config;
            } catch {
                return false;
            }
        }
    }
}