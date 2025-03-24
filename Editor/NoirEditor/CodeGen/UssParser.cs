using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using ExCSS;

namespace NoirEditor.CodeGen {
    internal class UssParser {
        private readonly StylesheetParser _parser = new(includeUnknownRules: true, includeUnknownDeclarations: true);

        private readonly string _path;

        public UssParser(string path) {
            _path = path;
        }

        public Dictionary<string, string> ParseClassConstants() {
            var stylesheet = _parser.Parse(File.ReadAllText(_path));
            var seenStyles = new HashSet<string>();
            var textInfo = new CultureInfo("en-US", false).TextInfo;
            var dictionary = new Dictionary<string, string>();
            foreach (var rule in stylesheet.StyleRules) {
                var sel = rule.SelectorText;
                var lastSpace = sel.LastIndexOf(' ');
                var p = lastSpace == -1 ? new string[] { sel } : sel.Split(' ', ',');
                foreach (var p2 in p) {
                    var clean = p2.Trim('.', ',');

                    if (clean == "VisualElement") continue;
                    if (clean.StartsWith("unity")) continue;
                    if (clean.Contains(':')) continue;

                    if (clean.Contains('.'))
                    {
                        clean = clean.Split(".", StringSplitOptions.RemoveEmptyEntries)[^1];
                    }

                    if (clean.Contains(">"))
                    {
                        clean = clean.Split(">", StringSplitOptions.RemoveEmptyEntries)[^1].Trim();
                        // Skip .someclass > TagName type styles
                        if (!clean.StartsWith("."))
                            continue;
                    }

                    // skip id based selectors
                    if (clean.StartsWith('#')) {
                        continue;
                    }

                    var constantName = textInfo.ToTitleCase(clean.Replace("--", "__").Replace("-", "+").Replace(".", "_dot_")).Replace("+", "-").Replace(">", "_GT_");
                    if (!seenStyles.Add(constantName))
                    {
                        continue;
                    }

                    dictionary.Add(constantName, clean);
                }
            }

            return dictionary;
        }
    }
}