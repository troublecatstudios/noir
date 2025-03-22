using Noir.Unity.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace NoirUnityEditor.Modifications.Menu {
    public class AutoCreateAssetsMenu {
        [MenuItem("Tools/TroubleCat Studios/Process [AutoCreateAsset] ScriptableObjects", priority = 100)]
        public static void AutoCreateAssets() {
            AutoCreateAssetsWork();
        }

        internal static List<string> AutoCreateAssetsWork(bool isBuild = false) {
            int createdAssetCount = 0;
            var createdAssets = new List<string>();
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies()) {
                try {
                    foreach (var type in asm.GetTypes()) {
                        if (type.IsSubclassOf(typeof(ScriptableObject))) {
                            var attrs = type.GetCustomAttributes(true);
                            if (attrs != null && attrs.Length > 0) {
                                var bindings = attrs.Where(a => a as AutoCreateAssetAttribute != null);
                                foreach (var binding in bindings) {
                                    var attr = binding as AutoCreateAssetAttribute;
                                    var rootPath = attr.CreatePathPrefix;
                                    var path = $"Assets/{rootPath}/{attr.AssetNameOverride ?? type.Name}.asset".Replace("//", "/").Replace("\\/", "/");

                                    var shouldCreateAsset = AssetDatabaseUtility.Mkdirp(rootPath);

                                    UnityEngine.Object asset = null;
                                    if (!shouldCreateAsset) {
                                        // check if the asset already exists
                                        asset = AssetDatabase.LoadAssetAtPath(path, type);
                                    }

                                    if (asset == null) {
                                        asset = ScriptableObject.CreateInstance(type);
                                        AssetDatabase.CreateAsset(asset, path);
                                        createdAssetCount++;
                                        createdAssets.Add(path);
                                    }
                                }
                            }
                        }
                    }
                } catch {
                    Debug.LogWarning($"[ {nameof(AutoCreateAssetsMenu)} ]  - couldn't load types from assembly: {asm.FullName}");
                }
            }

            if (!isBuild)
                EditorUtility.DisplayDialog($"{nameof(AutoCreateAssetsMenu)} AutoCreateAsset", $"Created {createdAssetCount} new assets.", "Ok");

            return createdAssets;
        }
    }
}
