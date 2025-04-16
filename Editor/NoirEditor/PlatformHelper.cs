using System.IO;

namespace NoirEditor {
    public class PlatformHelper {

        public static readonly PlatformHelper Instance = new();

        private readonly char _separator = Path.DirectorySeparatorChar;

        internal PlatformHelper(char separator = char.MinValue) {
            _separator = separator;
        }
        private PlatformHelper() {}


        public string NormalizePath(string fileSystemPath) {
            if (string.IsNullOrEmpty(fileSystemPath)) return string.Empty;
            return fileSystemPath.Replace(_separator, '/');
        }
    }
}