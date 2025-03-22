using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace NoirUnityEditor.CodeGen {
    public static class EditorIconsGenerator {
        private const string FOLDER_LOCATION = "Scripts/Editor/";
        private const string SCRIPT_EXTENSION = ".cs";
        private const string indent = "    ";

        [MenuItem("Tools/TroubleCat Studios/Generate Editor Icons Script")]
        public static void GenerateEditorIconsScriptMenu() {
            var startTime = DateTime.Now.Ticks;
            string folderPath = Application.dataPath + "/" + FOLDER_LOCATION;
            if (!Directory.Exists(folderPath)) {
                Directory.CreateDirectory(folderPath);
            }

            var scriptContents = new StringBuilder();
            var editorAssetBundle = GetEditorAssetBundle();
            var iconsPath = GetIconsPath();
            var assetNames = EnumerateIcons(editorAssetBundle, iconsPath).ToArray();

            scriptContents.AppendLine($"namespace NoirUnityEditor {{");
            scriptContents.AppendLine($"{indent}using UnityEditor;");
            scriptContents.AppendLine($"{indent}using UnityEngine;");
            scriptContents.AppendLine($"{indent}using System;");
            scriptContents.AppendLine($"");
            scriptContents.AppendLine($"{indent}// This class is auto-generated do not modify.");
            scriptContents.AppendLine($"{indent}// Last Generated: {DateTime.Now.ToString()}");
            scriptContents.AppendLine($"{indent}public static class UnityEditorIcons {{");
            scriptContents.AppendLine($"{indent}{indent}private static Func<string, UnityEditorIcon> _iconBuilder;");
            scriptContents.AppendLine($"{indent}{indent}");
            scriptContents.AppendLine($"{indent}{indent}/// <summary>");
            scriptContents.AppendLine($"{indent}{indent}/// Provides code acccess to an icon resource within the Unity Editor.");
            scriptContents.AppendLine($"{indent}{indent}/// </summary>");
            scriptContents.AppendLine($"{indent}{indent}public class UnityEditorIcon {{");
            scriptContents.AppendLine($"{indent}{indent}{indent}public static void Initialize() {{");
            scriptContents.AppendLine($"{indent}{indent}{indent}{indent}_iconBuilder = (iconName) => new UnityEditorIcon(iconName);");
            scriptContents.AppendLine($"{indent}{indent}{indent}}}");
            scriptContents.AppendLine($"{indent}{indent}{indent}private readonly string _iconName;");
            scriptContents.AppendLine($"{indent}{indent}{indent}private UnityEditorIcon(string iconName) {{");
            scriptContents.AppendLine($"{indent}{indent}{indent}{indent}_iconName = iconName;");
            scriptContents.AppendLine($"{indent}{indent}{indent}}}");
            scriptContents.AppendLine($"{indent}{indent}{indent}/// <summary>");
            scriptContents.AppendLine($"{indent}{indent}{indent}/// Gets a <see cref=\"UnityEditor.GUIContent\" /> containing the icon image.");
            scriptContents.AppendLine($"{indent}{indent}{indent}/// </summary>");
            scriptContents.AppendLine($"{indent}{indent}{indent}public GUIContent IconContent => EditorGUIUtility.IconContent(_iconName);");
            scriptContents.AppendLine($"{indent}{indent}{indent}/// <summary>");
            scriptContents.AppendLine($"{indent}{indent}{indent}/// Gets a <see cref=\"UnityEngine.Texture\" /> containing the icon image.");
            scriptContents.AppendLine($"{indent}{indent}{indent}/// </summary>");
            scriptContents.AppendLine($"{indent}{indent}{indent}public Texture Image => IconContent.image;");
            scriptContents.AppendLine($"{indent}{indent}{indent}/// <summary>");
            scriptContents.AppendLine($"{indent}{indent}{indent}/// Gets the icon name for the icon.");
            scriptContents.AppendLine($"{indent}{indent}{indent}/// </summary>");
            scriptContents.AppendLine($"{indent}{indent}{indent}public string Name => _iconName;");
            scriptContents.AppendLine($"{indent}{indent}{indent}public override string ToString() => _iconName;");
            scriptContents.AppendLine($"{indent}{indent}}}");
            scriptContents.AppendLine($"");
            scriptContents.AppendLine($"{indent}{indent}static UnityEditorIcon BuildIcon(string iconName) {{");
            scriptContents.AppendLine($"{indent}{indent}{indent}UnityEditorIcon.Initialize();");
            scriptContents.AppendLine($"{indent}{indent}{indent}return _iconBuilder(iconName);");
            scriptContents.AppendLine($"{indent}{indent}}}");
            scriptContents.AppendLine($"");

            var seenIconNames = new HashSet<string>();

            for (var i = 0; i < assetNames.Length; i++) {
                var assetName = assetNames[i];
                var icon = editorAssetBundle.LoadAsset<Texture2D>(assetName);
                if (icon == null)
                    continue;

                if (seenIconNames.Add(icon.name)) {
                    scriptContents.AppendLine($"");
                    scriptContents.AppendLine($"{indent}{indent}private static readonly UnityEditorIcon _{SanitizeIconName(icon.name)} = BuildIcon(\"{icon.name}\");");
                    scriptContents.AppendLine($"{indent}{indent}/// <summary>Returns a <see cref=\"UnityEditorIcon\"> containing the data for the \"{icon.name}\" icon.</summary>");
                    scriptContents.AppendLine($"{indent}{indent}public static UnityEditorIcon {SanitizeIconName(icon.name)} => _{SanitizeIconName(icon.name)};");
                    scriptContents.AppendLine($"");
                }
            }

            scriptContents.AppendLine($"{indent}}}");
            scriptContents.AppendLine($"}}");
            var fileName = "UnityEditorIcons";
            var outputFile = folderPath + fileName + SCRIPT_EXTENSION;
            File.WriteAllText(outputFile, scriptContents.ToString());
            AssetDatabase.ImportAsset($"Assets/{FOLDER_LOCATION}{fileName}{SCRIPT_EXTENSION}", ImportAssetOptions.ForceUpdate);

            var generationTime = new TimeSpan(DateTime.Now.Ticks - startTime);
            Debug.Log($"[{nameof(GenerateEditorIconsScriptMenu)}] GenerateEditorIconsScript - Generation Complete. {generationTime.TotalSeconds}s");
        }

        private static string SanitizeIconName(string iconName) {
            var cleaned = iconName
                .Replace(" ", "_")
                .Replace("-", "_")
                .Replace(".", "_")
                .Replace("@", "");
            if (cleaned.StartsWith("_")) cleaned = cleaned.Substring(1);
            return cleaned;
        }

        private static IEnumerable<string> EnumerateIcons(AssetBundle editorAssetBundle, string iconsPath) {
            foreach (var assetName in editorAssetBundle.GetAllAssetNames()) {
                if (assetName.StartsWith(iconsPath, StringComparison.OrdinalIgnoreCase) == false)
                    continue;
                if (assetName.EndsWith(".png", StringComparison.OrdinalIgnoreCase) == false &&
                    assetName.EndsWith(".asset", StringComparison.OrdinalIgnoreCase) == false)
                    continue;

                yield return assetName;
            }
        }

        private static string GetFileId(string proxyAssetPath) {
            var serializedAsset = File.ReadAllText(proxyAssetPath);
            var index = serializedAsset.IndexOf("_MainTex:", StringComparison.Ordinal);
            if (index == -1)
                return string.Empty;

            const string FileId = "fileID:";
            var startIndex = serializedAsset.IndexOf(FileId, index) + FileId.Length;
            var endIndex = serializedAsset.IndexOf(',', startIndex);
            return serializedAsset.Substring(startIndex, endIndex - startIndex).Trim();
        }

        private static AssetBundle GetEditorAssetBundle() {
            var editorGUIUtility = typeof(EditorGUIUtility);
            var getEditorAssetBundle = editorGUIUtility.GetMethod(
                "GetEditorAssetBundle",
                BindingFlags.NonPublic | BindingFlags.Static);

            return (AssetBundle)getEditorAssetBundle.Invoke(null, new object[] { });
        }

        private static string GetIconsPath() {
#if UNITY_2018_3_OR_NEWER
            return UnityEditor.Experimental.EditorResources.iconsPath;
#else
            var assembly = typeof(EditorGUIUtility).Assembly;
            var editorResourcesUtility = assembly.GetType("UnityEditorInternal.EditorResourcesUtility");

            var iconsPathProperty = editorResourcesUtility.GetProperty(
                "iconsPath",
                BindingFlags.Static | BindingFlags.Public);

            return (string)iconsPathProperty.GetValue(null, new object[] { });
#endif
        }
    }
}
