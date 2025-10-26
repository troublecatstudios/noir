using System.IO;

namespace NoirEditor {
    public class PlatformHelper {
        /// <summary>
        /// Gets a singleton instance of the <see cref="PlatformHelper"/>.
        /// </summary>
        public static readonly PlatformHelper Instance = new();

        private readonly char _separator = Path.DirectorySeparatorChar;

        internal PlatformHelper(char separator = char.MinValue) {
            _separator = separator;
        }
        private PlatformHelper() {}


        /// <summary>
        /// Converts a path that uses <c>\</c> as its path separator to a path that uses <c>/</c>.
        /// </summary>
        /// <param name="fileSystemPath">The path to a file system object (directory, folder, link).</param>
        /// <returns>The same file system path that was given, with <c>\</c> replaced by <c>/</c>.</returns>
        public string NormalizePath(string fileSystemPath) {
            if (string.IsNullOrEmpty(fileSystemPath)) return string.Empty;
            return fileSystemPath.Replace(_separator, '/');
        }
    }
}