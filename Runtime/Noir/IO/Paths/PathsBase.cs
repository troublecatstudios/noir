using System.IO;
using UnityEngine;

namespace Noir.IO.Paths {
    public abstract class PathsBase {
        protected static string AppendProductPath(string path, bool includeCompanyName = false) {
            if (includeCompanyName) {
                path = AppendDirectory(path, Application.isPlaying ? Application.companyName : "Noir_CompanyName");
            }

            return AppendDirectory(path, Application.isPlaying ? Application.productName : "Noir_ProductName");
        }

        protected static string AppendDirectory(string path, string dir) {
            if (string.IsNullOrEmpty(dir)) {
                return path;
            }

            dir = CleanForPath(dir);
            return Path.Combine(path, dir);
        }

        protected static string CleanForPath(string str) {
            var invalidChars = Path.GetInvalidFileNameChars();

            foreach (var ch in invalidChars) {
                str = str.Replace(ch, '_');
            }

            return str;
        }
    }
}