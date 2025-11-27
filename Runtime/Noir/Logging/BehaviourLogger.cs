using System;
using UnityEngine;

namespace Noir.Logging {
    /// <summary>
    /// Provides a contextual logging interface for Unity <see cref="MonoBehaviour"/> instances.
    /// </summary>
    /// <remarks>
    /// <see cref="BehaviourLogger"/> serves as a thin wrapper around the global
    /// <see cref="LoggerSingleton"/> instance, automatically attaching a specific
    /// <see cref="MonoBehaviour"/> as the logging context.
    ///
    /// This allows log entries to include precise scene and GameObject references,
    /// which improves traceability during runtime debugging and diagnostics.
    ///
    /// Typically, components create a <see cref="BehaviourLogger"/> in <c>Awake</c> or <c>Start</c>
    /// and use it instead of directly calling <see cref="LoggerSingleton"/> methods.
    /// </remarks>
    public class BehaviourLogger : ILoggingComponent {
        private readonly MonoBehaviour _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="BehaviourLogger"/> class for the given <see cref="MonoBehaviour"/>.
        /// </summary>
        /// <param name="context">The Unity component whose context will be included in log output.</param>
        public BehaviourLogger(MonoBehaviour context) {
            _context = context;
        }

        /// <inheritdoc />
        public void Verify(bool condition, string label, string subsystem = null) => LoggerSingleton.Instance.Verify(condition, label, _context, subsystem);

        /// <inheritdoc />
        public void Verify(Func<bool> condition, string label, string subsystem = null) => LoggerSingleton.Instance.Verify(condition, label, _context, subsystem);

        /// <inheritdoc />
        public void Info(string message, string subsystem = null) => LoggerSingleton.Instance.Info(message, _context, subsystem);

        /// <inheritdoc />
        public void Trace(string trace, string message, string subsystem = null) => LoggerSingleton.Instance.Trace(trace, message, _context, subsystem);

        /// <inheritdoc />
        public void Debug(string message, string subsystem = null) => LoggerSingleton.Instance.Debug(message, _context, subsystem);

        /// <inheritdoc />
        public void Warn(string message, string subsystem = null) => LoggerSingleton.Instance.Warn(message, _context, subsystem);

        /// <inheritdoc />
        public void Error(string message, string subsystem = null) => LoggerSingleton.Instance.Error(message, _context, subsystem);

        /// <inheritdoc />
        public void WriteLog(string message, LogLevel level = LogLevel.Info, string subsystem = null, string trace = null) => LoggerSingleton.Instance.WriteLog(message, level, _context, subsystem, trace);
    }
}