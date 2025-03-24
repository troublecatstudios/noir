using Noir.Attributes;
using NoirEditor.Reflection;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace NoirEditor.Building {
    internal static class AutoCreateAssetProcessor {
        internal static List<string> ProcessClassesWithAttribute(bool isBuild = false) {
            int createdAssetCount = 0;
            var createdAssets = new List<string>();
            var assetTypes = Reflector.GetTypesWithAttribute<AutomaticallyCreateAttribute>();
            foreach (var assetType in assetTypes) {
                foreach (var attr in assetType.Attributes) {
                    try {
                        var rootPath = attr.CreatePathPrefix;
                        var path = $"Assets/{rootPath}/{attr.AssetNameOverride ?? assetType.Type.Name}.asset".Replace("//", "/").Replace("\\/", "/");
                        var shouldCreateAsset = AssetDB.Mkdirp(rootPath);
                        UnityEngine.Object asset = null;
                        if (!shouldCreateAsset) {
                            asset = AssetDatabase.LoadAssetAtPath(path, assetType.Type);
                        }

                        if (asset == null) {
                            asset = ScriptableObject.CreateInstance(assetType.Type);
                            AssetDatabase.CreateAsset(asset, path);
                            createdAssetCount++;
                            createdAssets.Add(path);
                        }
                    } catch {
                        Debug.LogWarning($"[ {nameof(AutoCreateAssetProcessor)} ]  - couldn't process asset of type: {assetType.Type.FullName}");
                    }
                }
            }
            if (!isBuild)
                EditorUtility.DisplayDialog($"{nameof(AutoCreateAssetProcessor)} ProcessClassesWithAttribute", $"Created {createdAssetCount} new assets.", "Ok");

            return createdAssets;
        }
    }
}