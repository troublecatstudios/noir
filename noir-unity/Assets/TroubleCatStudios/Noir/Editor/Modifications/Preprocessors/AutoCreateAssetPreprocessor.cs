using NoirUnityEditor.Modifications.Menu;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

namespace NoirUnityEditor.Modifications.Preprocessors {
    public class AutoCreateAssetPreprocessor : IPreprocessBuildWithReport {
        public int callbackOrder => -20;

        public void OnPreprocessBuild(BuildReport report) {
            var settings = NoirEditorSettings.GetOrCreateSettings();
            if (settings.AutoCreateAssetsEnabled) {
                Debug.Log($"[{nameof(AutoCreateAssetPreprocessor)}] INFO Checking for new auto create assets.");
                var createdAssets = AutoCreateAssetsMenu.AutoCreateAssetsWork(isBuild: true);
                foreach (var a in createdAssets) {
                    Debug.Log($"[{nameof(AutoCreateAssetPreprocessor)}] DEBUG created asset: {a}");
                }
            }
        }

    }
}
