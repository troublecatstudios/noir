using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace NoirEditor.MenuItems {
    internal class CreateMarkdownFile {
        [MenuItem("Assets/Create/Noir/Markdown File", false, 101)]
        public static void CreateMarkdown() {
            var path = AssetDatabase.GUIDToAssetPath(Selection.assetGUIDs[0]);
            if (!AssetDatabase.IsValidFolder(path)) {
                Debug.LogError("Please select a valid folder in the Project view.");
                return;
            }
            var filePath = Path.Combine(path, "MarkdownFile.md");
            int counter = 1;
            while (File.Exists(filePath)) {
                counter++;
                filePath = Path.Combine(path, $"MarkdownFile-{counter}.md");
            }
            // Create the ReadMe file with initial content
            File.WriteAllText(filePath, GetBasicMarkdownStructure());
            AssetDatabase.Refresh(); // Refresh to show the file in Unity
            Debug.Log($"Markdown file created successfully at: {filePath}");
        }

        private static string GetBasicMarkdownStructure() {
            var timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            return "" +
@$"
---
created: {timestamp}
---
## Markdown file
Add your content here.
";
        }
    }
}