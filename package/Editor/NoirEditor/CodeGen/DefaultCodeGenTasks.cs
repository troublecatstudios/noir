using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using Noir.DataObjects;
using Noir.Variables;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace NoirEditor.CodeGen {
    internal static class DefaultCodeGenerationTasks {
        public static IEnumerable<CodeGenTask> GetCodeGenTasks() {
            yield return new CodeGenTask() {
                CodeClassName = "Tags",
                ContentBuilder = () => CodeGenFile.GetClassContent(UnityEditorInternal.InternalEditorUtility.tags),
                HashTargetBuilder = () => String.Join(string.Empty, UnityEditorInternal.InternalEditorUtility.tags),
            };

            yield return new CodeGenTask() {
                CodeClassName = "Layers",
                ContentBuilder = () => GetLayerClassContent(UnityEditorInternal.InternalEditorUtility.layers),
                HashTargetBuilder = () => String.Join(string.Empty, UnityEditorInternal.InternalEditorUtility.layers)
            };

            yield return new CodeGenTask() {
                CodeClassName = "Scenes",
                ContentBuilder = () => CodeGenFile.GetClassContent(EditorBuildSettingsScenesToNameStrings(EditorBuildSettings.scenes)),
                HashTargetBuilder = () => String.Join(string.Empty, EditorBuildSettingsScenesToNameStrings(EditorBuildSettings.scenes))
            };

            var sortingLayers = InternalUnityEditor.Core.GetSortingLayers();
            yield return new CodeGenTask() {
                CodeClassName = "SortingLayers",
                ContentBuilder = () => GetSortingLayerClassContent(sortingLayers),
                HashTargetBuilder = () => String.Concat(sortingLayers.Select(sl => sl.Name), sortingLayers.Select(sl => sl.Id))
            };

            yield return new CodeGenTask() {
                CodeClassName = "Variables",
                ContentBuilder = () => GetVariableClassContent(),
                HashTargetBuilder = () => GetVariablesGenerationHash(),
                ImportNamespaces = new string[] {
                    "Noir",
                    "Noir.DataObjects",
                    "Noir.Variables",
                    "System",
                    "UnityEngine"
                }
            };

            var stylesheets = AssetDB.Load<StyleSheet>(searchPaths: "Assets/UI");
            foreach (var stylesheet in stylesheets) {
                var path = AssetDatabase.GetAssetPath(stylesheet);
                // for some reason uxml and tss files get picked up when searching for stylesheets...
                if (path.EndsWith(".uss")) {
                    var contents = GetUssClassContent(path);
                    if (string.IsNullOrEmpty(contents)) continue;
                    var textInfo = new CultureInfo("en-US", false).TextInfo;
                    yield return new CodeGenTask() {
                        CodeClassName = $"{textInfo.ToTitleCase(stylesheet.name)}Styles",
                        ContentBuilder = () => contents,
                        HashTargetBuilder = () => GetUssClassHash(path),
                    };
                }
            }
        }

        private static string GetUssClassHash(string ussFilePath) {
            var parser = new UssParser(ussFilePath);
            var map = parser.ParseClassConstants();
            var code = new StringBuilder();
            foreach (var entry in map) {
                code.Append($"{entry.Key}:{entry.Value},");
            }
            return code.ToString();
        }

        private static string GetUssClassContent(string ussFilePath) {
            var parser = new UssParser(ussFilePath);
            var map = parser.ParseClassConstants();
            var code = new StringBuilder();
            foreach (var entry in map) {
                code.AppendLine($"\n{CodeGenFile.BuildConstStringVariable(entry.Key, entry.Value, indent: "\t\t")}");
            }
            return code.ToString();
        }

        private static string GetSortingLayerClassContent(IEnumerable<(string Name, uint Id)> sortingLayers) {
            string output = "";
            int idx = 0;
            var dictionary = new StringBuilder();
            dictionary.AppendLine($"\n\t\tpublic static Dictionary<int, string> All = new Dictionary<int, string>() {{");
            foreach (var layer in sortingLayers) {
                output += $"\n{CodeGenFile.BuildConstStringVariable(layer.Name, indent: "\t\t")}";
                output += $"\n{CodeGenFile.BuildConstIntegerVariable(layer.Name, (int)layer.Id, indent: "\t\t")}";
                dictionary.AppendLine($"\t\t\t{{ {layer.Id}, \"{layer.Name}\" }},");
                idx++;
            }
            dictionary.AppendLine($"\t\t}};");
            output += dictionary.ToString();

            return output;
        }

        private static string GetLayerClassContent(string[] labelsArray) {
            string output = "";
            foreach (string label in labelsArray) {
                output += $"\t\t{CodeGenFile.BuildConstStringVariable(label, indent: "\t\t")}\n";
            }
            output += "\n";

            var dictionary = new StringBuilder();
            dictionary.AppendLine($"\t\tpublic static Dictionary<int, string> All = new Dictionary<int, string>() {{");

            foreach (string label in labelsArray) {
                output += CodeGenFile.BuildConstIntegerVariable(label, LayerMask.NameToLayer(label), indent: "\t\t");
                dictionary.AppendLine($"\t\t\t{{  {LayerMask.NameToLayer(label)} ,\"{label}\" }},");
            }

            dictionary.AppendLine($"\t\t}};");
            output += dictionary.ToString();
            return output;
        }

        private static string GetVariableClassContent() {
            var dataVariables = GetDataVariables();
            var source = new StringBuilder();
            var generationDetails = new List<string>();
            source.AppendLine("");
            source.AppendLine("\t\t/// <summary>Gets a variable by name.</summary>");
            source.AppendLine("\t\tpublic static T GetByName<T>(string key) where T : DataVariable {");
            source.AppendLine("\t\t    var variable = NoirDataLibrary.Instance.GetVariableByName<T>(key);");
            source.AppendLine("\t\t    return variable;");
            source.AppendLine("\t\t}");
            source.AppendLine("");

            var names = new List<string>();
            foreach (var variable in dataVariables) {
                var valueType = variable.ToObject().GetType();
                var propertyType = variable.GetType();
                if (propertyType.IsNotPublic || valueType.IsNotPublic) {
                    generationDetails.Add($"\t\t// skipping variable {variable.name} because either {valueType.Name} or {propertyType.Name} are not public.");
                    continue;
                }

                var propertyName = $"{CodeGenFile.UppercaseVariableName(variable.Name)}";
                var valueTypeName = $"{valueType.Name}";
                var propertyTypeName = $"{propertyType.Name}";
                source.Append("\n");
                source.Append($"\t\tprivate static {propertyTypeName} __{propertyName};\n");
                if (!String.IsNullOrEmpty(variable.FriendlyName)) {
                    source.Append($"\t\t/// <summary>Gets or Sets the value of the '{variable.FriendlyName}' variable.</summary>\n");
                } else {
                    source.Append($"\t\t/// <summary>Gets or Sets the value of the '{variable.Name}' variable.</summary>\n");
                }
                if (!String.IsNullOrEmpty(variable.Description)) {
                    source.Append($"\t\t/// <remarks>{variable.Description}</remarks>\n");
                }
                source.Append($"\t\tpublic static {valueTypeName} {propertyName} {{\n");
                source.Append($"\t\t  get {{\n");
                source.Append($"\t\t    if (__{propertyName} == null) __{propertyName} = NoirDataLibrary.Instance.GetVariableByName<{propertyTypeName}>(\"{variable.Name}\");\n");
                source.Append($"\t\t    return __{propertyName}.Value;\n");
                source.Append($"\t\t  }}\n");
                source.Append($"\t\t  set {{\n");
                source.Append($"\t\t    if (__{propertyName} == null) __{propertyName} = NoirDataLibrary.Instance.GetVariableByName<{propertyTypeName}>(\"{variable.Name}\");\n");
                source.Append($"\t\t    __{propertyName}.Value = value;\n");
                source.Append($"\t\t  }}\n");
                source.Append($"\t\t}}\n");
                source.Append($"\n");
                names.Add(variable.name);
            }
            source.Append($"\t\tpublic static class Names {{\n");
            var list = new StringBuilder();
            list.AppendLine($"\t\t\t\tpublic static List<string> All = new List<string>() {{");
            foreach (string label in names) {
                source.Append($"\t\t\t\t{CodeGenFile.BuildConstStringVariable(label, indent: "\t\t")}\n");
                list.AppendLine($"\t\t\t\t\t\"{label}\",");
            }
            list.AppendLine($"\t\t\t\t}};");
            source.Append(list.ToString());
            source.Append($"\t\t}}\n");
            return $"\n{String.Join(Environment.NewLine, generationDetails)}\n{source}";
        }

        private static string[] EditorBuildSettingsScenesToNameStrings(EditorBuildSettingsScene[] scenes) {
            return scenes
                .Select(s => System.IO.Path.GetFileNameWithoutExtension(s.path))
                .TakeWhile(s => !string.IsNullOrWhiteSpace(s))
                .ToArray();
        }

        private static string GetVariablesGenerationHash() {
            var variables = GetDataVariables();
            var stringBuilder = new StringBuilder();
            foreach (var variable in variables) {
                stringBuilder.Append($"[{variable.Name}/{variable.FriendlyName}/{variable.Description}],");
            }
            return stringBuilder.ToString();
        }

        private static string[] GetVariableNames() {
            var variables = GetDataVariables();
            return variables.Select(v => v.name).OrderBy(v => v).ToArray();
        }

        private static List<DataVariable> GetDataVariables() {
            return AssetDB.Load<DataVariable>("t:DataVariable", searchPaths: "Assets/Data");
        }

        private static string[] GetSortingLayerNames() {
            Type internalEditorUtilityType = typeof(UnityEditorInternal.InternalEditorUtility);
            PropertyInfo sortingLayersProperty = internalEditorUtilityType.GetProperty("sortingLayerNames", BindingFlags.Static | BindingFlags.NonPublic);
            return (string[])sortingLayersProperty.GetValue(null, new object[0]);
        }
        private static int[] GetSortingLayerUniqueIDs() {
            Type internalEditorUtilityType = typeof(UnityEditorInternal.InternalEditorUtility);
            PropertyInfo sortingLayerUniqueIDsProperty = internalEditorUtilityType.GetProperty("sortingLayerUniqueIDs", BindingFlags.Static | BindingFlags.NonPublic);
            return (int[])sortingLayerUniqueIDsProperty.GetValue(null, new object[0]);
        }
    }
}