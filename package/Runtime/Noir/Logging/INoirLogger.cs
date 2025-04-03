using System;

namespace Noir.Logging {
    public interface INoirLogger {
        void Info(string message, object context = null, string subsystem = null);
        void Trace(string trace, string message, object context = null, string subsystem = null);
        void Debug(string message, object context = null, string subsystem = null);
        void Warn(string message, object context = null, string subsystem = null);
        void Error(string message, object context = null, string subsystem = null);
        void WriteLog(string message, LogLevel level = LogLevel.Info, object context = null, string subsystem = null, string trace = null);

        void Verify(bool condition, string label, object context = null, string subsystem = null);
        void Verify(Func<bool> condition, string label, object context = null, string subsystem = null);

        void DisableSubsystem(string system);
        void EnableSubsystem(string system);
        void EndAllTraces();
        void EndTrace(string traceName);
        void StartTrace(string traceName);
    }
}