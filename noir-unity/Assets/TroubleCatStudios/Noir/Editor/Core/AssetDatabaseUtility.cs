using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace NoirUnityEditor {
    /// <summary>
    /// Useful utility methods for interacting with the Unity AssetDatabase.
    /// </summary>
    public static class AssetDatabaseUtility {
        private static string[] _assetPaths;
        private static uint _lastGlobalVersion;

        /// <summary>
        /// A cache containing all the prefabs within the <see cref="AssetDatabase"/>.
        /// </summary>
        /// <value>
        /// All the prefab asset paths within the project.
        /// </value>
        /// <remarks>The cache is refreshed as needed. It checks the AssetDatabase version and determines if a refresh is necessary.</remarks>
        private static IEnumerable<string> PrefabAssetPaths {
            get {
                if (_lastGlobalVersion != AssetDatabase.GlobalArtifactDependencyVersion) {
                    _assetPaths = AssetDatabase.GetAllAssetPaths();
                    _lastGlobalVersion = AssetDatabase.GlobalArtifactDependencyVersion;
                }
                return _assetPaths.Where(p => p.EndsWith(".prefab"));
            }
        }

        /// <summary>
        /// Walks a directory path ensuring each directory exists.
        /// </summary>
        /// <param name="path">The path to evaluate.</param>
        /// <returns><c>true</c> if the path was able to be created and <c>false</c> otherwise.</returns>
        public static bool Mkdirp(string path) {
            var parts = path.Split('/');
            var builtPath = "Assets";
            var result = false;
            Debug.Log($"[ {nameof(AssetDatabaseUtility)} ]  - Ensuring that 'Assets/{path}' exists.");
            foreach (var part in parts) {
                var folderExists = AssetDatabase.IsValidFolder($"{builtPath}/{part}");
                if (!folderExists) {
                    AssetDatabase.CreateFolder(builtPath, part);
                    result = true;
                }
                Debug.Log($"[ {nameof(AssetDatabaseUtility)} ]  - Folder '{builtPath}/{part}' {(folderExists ? "exists" : "did not exist")}.");
                builtPath += $"/{part}";
            }
            return result;
        }

        /// <summary>
        /// Tries the find references to the given <see cref="UnityEngine.Object"/> within prefabs and scriptable objects in the Unity Asset Database.
        /// </summary>
        /// <param name="asset">The asset.</param>
        /// <param name="assetPaths">The paths to assets that contain a reference to the given object.</param>
        /// <returns><c>true</c> if a match is found and <c>false</c> otherwise.</returns>
        /// <remarks>This will attempt to read every Prefab from the disk so it is an expensive call. <strong>Do not call this in a loop!</strong></remarks>
        public static bool TryGetReferencesToObject(UnityEngine.Object asset, out IEnumerable<string> assetPaths) {
            var paths = new List<string>();
            if (AssetDatabase.TryGetGUIDAndLocalFileIdentifier(asset, out var guid, out long localId)) {
                var searchText = $"{{fileID: {localId}, guid: {guid},";
                Debug.Log($"Searching {PrefabAssetPaths.Count()} prefabs for '{searchText}'...");
                foreach (var assetPath in PrefabAssetPaths) {
                    if (TrySafeRead(assetPath, out var contents) && contents.Contains(searchText)) {
                        paths.Add(assetPath);
                        Debug.Log($"Matched: {assetPath}");
                    }
                }
            }
            assetPaths = paths;
            return paths.Count > 0;
        }

        /// <summary>
        /// Attempts to read a file from disk.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        /// <param name="contents">The contents of the file.</param>
        /// <returns><c>true</c> if the contents could be read and <c>false</c> otherwise.</returns>
        private static bool TrySafeRead(string path, out string contents) {
            contents = String.Empty;
            try {
                contents = File.ReadAllText(path);
                return true;
            } catch (Exception e) {
                Debug.LogException(e);
            }
            return false;
        }

        /// <summary>
        /// Loads all assets from the <see cref="AssetDatabase"/> that match the given type paramter.
        /// </summary>
        /// <typeparam name="T">The <see cref="Type"/> of the assets to search for.</typeparam>
        /// <param name="query">An optional query to use to filter assets. Providing a query will not immediately filter objects by type. The query can be any valid query from the projects tab.</param>
        /// <param name="criteria">An optional predicate to use to filter assets. It will be called with the path for each asset that matches the type or query given.</param>
        /// <param name="searchPaths">An optional collection of the paths within the project to search. All paths should start with "Assets/".</param>
        /// <returns>A list containing the matching items or an empty list if no matches were found.</returns>
        public static List<T> Load<T>(string query = null, Func<string, bool> criteria = null, params string[] searchPaths) where T : UnityEngine.Object {
            var items = new List<T>();
            string[] guids;
            string searchQuery = query ?? $"t:{typeof(T).Name}";
            if (searchPaths == null || searchPaths.Length == 0) {
                guids = AssetDatabase.FindAssets(searchQuery);
            } else {
                guids = AssetDatabase.FindAssets(searchQuery, searchPaths);
            }

            foreach (var item in guids) {
                if (item == null) continue;
                var path = AssetDatabase.GUIDToAssetPath(item);
                if (criteria != null && !criteria(path)) {
                    continue;
                }

                // Sprites require special treatment as
                // they are stored as sub-objects within a Texture2D
                // so the code has to load each Sprite object within the asset
                if (typeof(T) == typeof(Sprite)) {
                    var assets = AssetDatabase.LoadAllAssetsAtPath(path);
                    var sprites = assets.Where(q => q is Sprite).Cast<Sprite>();
                    foreach (var sprite in sprites) {
                        if (items.Contains(sprite as T)) continue;
                        items.Add(sprite as T);
                    }
                } else {
                    var asset = AssetDatabase.LoadAssetAtPath<T>(path);
                    items.Add(asset);
                }
            }
            return items;
        }
    }
}
