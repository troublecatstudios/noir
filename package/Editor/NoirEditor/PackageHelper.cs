using Noir;
using System.IO;
using UnityEditor;

namespace NoirEditor {
    internal static class PackageHelper {
        public static string GetPackageDirectoryRoot() {
            var folder = NoirProjectConfiguration.PackageFolder;
            return Path.GetFullPath(folder);
        }
    }
}