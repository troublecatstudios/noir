using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace NoirEditor.CodeGen {
    internal static class CodeGenFile {
        public static string GetClassWrapper(string @namespace, string className, string contents, string[] usings = null, string header = null, string footer = null) {
            var output = $"namespace {@namespace} {{\n";
            output += "    using System.Collections.Generic;\n";
            if (usings != null) {
                foreach (var ns in usings) {
                    output += $"    using {ns};\n";
                }
            }
            output += $"    public class {className}{{\n";
            output += contents;
            output += "\n    }\n";
            output += "}";

            if (header == null) header = "";
            if (footer == null) footer = "";

            return $"{header}\n{output}\n{footer}";
        }

        public static string GetClassContent(string[] labelsArray) {
            string output = "";
            var list = new StringBuilder();
            list.AppendLine($"\t\tpublic static List<string> All = new List<string>() {{");
            foreach (string label in labelsArray) {
                output += $"\t\t{BuildConstStringVariable(label, indent: "\t\t")}\n";
                list.AppendLine($"\t\t\t\"{label}\",");
            }
            list.AppendLine($"\t\t}};");
            output += list.ToString();
            return output;
        }

        public static string GetClassContent(IEnumerable<(string Key, string Value)> items) {
            string output = "";
            foreach (var item in items) {
                output += $"\t\t{BuildConstStringVariable(item.Key, item.Value, indent: "\t\t")}\n";
            }
            output += "\n";

            var dictionary = new StringBuilder();
            dictionary.AppendLine($"\t\tpublic static IEnumerable<string> All = new List<string>() {{");

            foreach (var item in items) {
                dictionary.AppendLine($"\t\t\t\"{item.Value}\",");
            }

            dictionary.AppendLine($"\t\t}};");
            output += dictionary.ToString();

            return output;
        }

        public static string BuildConstIntegerVariable(string varName, int varValue, string indent = "") {
            return $"{indent}public const int {UppercaseVariableName(varName)}_INT = {varValue};\n";
        }

        public static string BuildConstStringVariable(string varName, string varValue = null, string indent = "") {
            return $"{indent}public const string {UppercaseVariableName(varName)} = \"{(varValue ?? varName)}\";\n";
        }

        public static string UppercaseVariableName(string input) {
            while (Regex.IsMatch(input, @"^\d")) {
                input = Regex.Replace(input, @"^\d", string.Empty);
            }
            input = input.Replace('-', '_');
            return Regex.Replace(input, @"[^\w\d]", string.Empty).ToUpper();
        }

        public static string GetHashFromSourceFile(string sourceFilePath) {
            if (File.Exists(sourceFilePath)) {
                var contents = File.ReadAllText(sourceFilePath);
                if (contents.Contains("// Content hash: ")) {
                    var hashStart = contents.IndexOf("// Content hash: ") + "// Content hash: ".Length;
                    var hashEnd = contents.IndexOf("\n", hashStart);
                    var hash = contents.Substring(hashStart, hashEnd - hashStart);
                    return hash;
                }
            }
            return String.Empty;
        }
    }
}