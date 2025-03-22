using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace NoirUnityEditor.Modifications {
    internal static class NoirEditorSettingsProvider {
        [SettingsProvider]
        public static SettingsProvider CreateSettingsProvider() {
            var provider = new SettingsProvider("Project/Noir.UnityEditor", SettingsScope.Project) {
                guiHandler = (searchContext) => NoirEditorSettingsGui.DrawSettings(NoirEditorSettings.GetOrCreateSettings()),
                keywords = new HashSet<string> { "Noir", "Noir Editor" }
            };
            return provider;
        }
    }
}
