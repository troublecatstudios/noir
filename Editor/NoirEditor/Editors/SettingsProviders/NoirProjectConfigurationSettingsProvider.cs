using Noir;
using System.IO;
using UnityEditor;
using UnityEngine;

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
    }
}