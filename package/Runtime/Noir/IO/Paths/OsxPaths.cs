using System;
using System.IO;

namespace Noir.IO.Paths {
    public class OsxPaths : PathsBase, IPlatformPaths {
        public OsxPaths() {
            ConfigurationDirectory = GetApplicationSupportPath("Config");
            SaveFileDirectory = GetApplicationSupportPath("Saves");
            LogDirectory = GetLibraryPath("Logs");
        }

        private static string GetLibraryPath(string subdirectory) {
            var result = Path.Combine(
                Environment.GetEnvironmentVariable("HOME"),
                "Library/");
            result = AppendDirectory(result, subdirectory);
            return AppendProductPath(result);
        }

        private static string GetApplicationSupportPath(string subdirectory) {
            var result = Path.Combine(
                Environment.GetEnvironmentVariable("HOME"),
                "Library/Application Support");

            result = AppendProductPath(result);
            return AppendDirectory(result, subdirectory);
        }

        public string ConfigurationDirectory { get; private set; }
        public string SaveFileDirectory { get; private set; }
        public string LogDirectory { get; private set; }
    }
}