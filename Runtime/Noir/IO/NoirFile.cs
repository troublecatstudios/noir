using System.IO;

namespace Noir.IO {
    public class NoirFile {
        public static void Write(string contents, string filePath) {
            using FileStream file = new(filePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            using StreamWriter writer = new(file);
            writer.WriteLine(contents);
        }
    }
}