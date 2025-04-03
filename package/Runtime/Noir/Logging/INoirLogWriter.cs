using System;

namespace Noir.Logging {
    public interface ILogWriter {
        void Verify(bool condition, string label, string subsystem = null);
        void Verify(Func<bool> condition, string label, string subsystem = null);

        void Info(string message, string subsystem = null);
        void Trace(string trace, string message, string subsystem = null);
        void Debug(string message, string subsystem = null);
        void Warn(string message, string subsystem = null);
        void Error(string message, string subsystem = null);
        void WriteLog(string message, LogLevel level = LogLevel.Info, string subsystem = null, string trace = null);
    }
}