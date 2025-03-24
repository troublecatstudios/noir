using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

namespace NoirEditor.Building.PreProcessing {
    internal class AutoCreateAssetPreProcessor : IPreprocessBuildWithReport  {
        public int callbackOrder => -20;

        public void OnPreprocessBuild(BuildReport report) {
            Debug.Log($"[{nameof(AutoCreateAssetPreProcessor)}] INFO Checking for new auto create assets.");
            var createdAssets = AutoCreateAssetProcessor.ProcessClassesWithAttribute(isBuild: true);
            foreach (var a in createdAssets) {
                Debug.Log($"[{nameof(AutoCreateAssetPreProcessor)}] DEBUG created asset: {a}");
            }
        }
    }
}