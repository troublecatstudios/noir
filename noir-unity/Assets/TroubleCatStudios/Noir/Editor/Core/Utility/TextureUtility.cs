using System.IO;
using UnityEditor;
using UnityEngine;

namespace NoirUnityEditor.Utility {
    public static class TextureUtility {
        public static Texture2D GenerateTexture(Color color, int size = 64) {
            Texture2D tex = new Texture2D(size, size);
            Color[] cols = new Color[size * size];
            for (int y = 0; y < size; y++) {
                for (int x = 0; x < size; x++) {
                    Color col = color;
                    cols[(y * size) + x] = col;
                }
            }

            tex.SetPixels(cols);
            tex.wrapMode = TextureWrapMode.Clamp;
            tex.filterMode = FilterMode.Point;
            tex.name = "Texture";
            tex.Apply();
            return tex;
        }

        public static Color[] FlipVertically(Color[] arr, int width) {
            Color[] flipped = new Color[arr.Length];
            for (var i = 0; i < arr.Length; i++) {
                var y = (arr.Length / width - 1) - (i / width);
                var x = i % width;
                var newIndex = y * width + x;
                flipped[newIndex] = arr[i];
            }
            return flipped;
        }

        public static Color[] FlipHorizontally(Color[] arr, int width) {
            Color[] flipped = new Color[arr.Length];
            for (var i = 0; i < arr.Length; i++) {
                var y = i / width;
                var x = width - 1 - i % width;
                var newIndex = y * width + x;
                flipped[newIndex] = arr[i];
            }
            return flipped;
        }

        private static TextureImporterSettings DefaultImportSettings = new TextureImporterSettings() {
            alphaSource = TextureImporterAlphaSource.FromInput,
            alphaIsTransparency = true,
            filterMode = FilterMode.Point,
            textureType = TextureImporterType.Default,
            textureShape = TextureImporterShape.Texture2D,
            convertToNormalMap = false,
            mipmapEnabled = false,
            sRGBTexture = true,
            readable = false,
            fadeOut = false,
            wrapMode = TextureWrapMode.Clamp,
            wrapModeU = TextureWrapMode.Clamp,
            wrapModeV = TextureWrapMode.Clamp,
            wrapModeW = TextureWrapMode.Clamp,
        };

        public static void GetDefaultSettings(TextureImporterSettings settings) {
            DefaultImportSettings.CopyTo(settings);
        }

        public static Texture2D ReimportTexture(byte[] textureData, string folderName, string fileName, TextureImporterSettings importSettings = null) {
            if (!AssetDatabase.IsValidFolder($"Assets/{folderName}")) {
                var parts = folderName.Split('/');
                var root = "Assets";
                foreach (var p in parts) {
                    if (!AssetDatabase.IsValidFolder($"{root}/{p}")) {
                        AssetDatabase.CreateFolder(root, p);
                    }
                    root += "/" + p;
                }
            }
            var previewPath = $"Assets/{folderName}/{fileName}.png";

            File.WriteAllBytes(previewPath, textureData);

            AssetDatabase.ImportAsset(previewPath, ImportAssetOptions.ForceUpdate);

            var importer = (TextureImporter)TextureImporter.GetAtPath(previewPath);
            importer.SetPlatformTextureSettings(new TextureImporterPlatformSettings() {
                overridden = true,
                textureCompression = TextureImporterCompression.Uncompressed,
                crunchedCompression = false,
            });
            importer.SetTextureSettings(importSettings ?? DefaultImportSettings);
            importer.SaveAndReimport();
            AssetDatabase.SaveAssets();
            return AssetDatabase.LoadAssetAtPath<Texture2D>(previewPath);
        }
    }
}
