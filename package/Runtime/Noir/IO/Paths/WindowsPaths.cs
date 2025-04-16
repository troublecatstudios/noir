using System;
using System.IO;

namespace Noir.IO.Paths {
    public class WindowsPaths : PathsBase, IPlatformPaths {
        public WindowsPaths() {
            ConfigurationDirectory = GetPath("Config");
            SaveFileDirectory = GetPath("Saves");
            LogDirectory = GetPath("Logs");
        }

        public string ConfigurationDirectory { get; private set; }
        public string SaveFileDirectory { get; private set; }
        public string LogDirectory { get; private set; }

        private static string GetPath(string subdirectory) {
            var result = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "My Games");

            result = AppendProductPath(result);
            return AppendDirectory(result, subdirectory);
        }
    }
}