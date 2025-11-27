using System;

namespace Noir.Logging {
    internal class NoirLogger<T> {
        public void Verify(bool condition, string label, string subsystem = null) => LoggerSingleton.Verify<T>(condition, label, subsystem);
        public void Verify(Func<bool> condition, string label, string subsystem = null) => LoggerSingleton.Verify<T>(condition, label, subsystem);
        public void Info(string message, string subsystem = null) => LoggerSingleton.Info<T>(message, subsystem);
        public void Trace(string trace, string message, string subsystem = null) => LoggerSingleton.Trace<T>(trace, message, subsystem);
        public void Debug(string message, string subsystem = null) => LoggerSingleton.Debug<T>(message, subsystem);
        public void Warn(string message, string subsystem = null) => LoggerSingleton.Warn<T>(message, subsystem);
        public void Error(string message, string subsystem = null) => LoggerSingleton.Error<T>(message, subsystem);
    }
}