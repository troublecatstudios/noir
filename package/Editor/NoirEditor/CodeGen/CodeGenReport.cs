using System;
using System.Text;

namespace NoirEditor.CodeGen {
    internal class CodeGenReport {
        public (string FileName, string Hash)[] GeneratedFiles { get; set; } = Array.Empty<(string FileName, string Hash)>();
        public TimeSpan TimeTaken { get; set; } = TimeSpan.Zero;
        public DateTime StartTime { get; set; } = DateTime.MinValue;

        public override string ToString() {
            var sb = new StringBuilder();
            sb.AppendLine($"Start Time: {StartTime}");
            sb.AppendLine($"Duration: {TimeTaken.TotalSeconds}");
            foreach (var (FileName, Hash) in GeneratedFiles) {
                sb.AppendLine($"{FileName}: {Hash}");
            }
            return sb.ToString();
        }
    }
}