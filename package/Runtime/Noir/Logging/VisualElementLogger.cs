using System;
using UnityEngine.UIElements;

namespace Noir.Logging {
    /// <summary>
    /// Provides a logging interface for UI Toolkit (<see cref="VisualElement"/>) components.
    /// </summary>
    /// <remarks>
    /// This logger wraps the <see cref="LoggerSingleton"/> system and associates log messages
    /// with a specific <see cref="VisualElement"/> context for improved debugging and traceability.
    /// </remarks>
    public class VisualElementLogger : ILoggingComponent {
        private readonly string _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualElementLogger"/> class,
        /// associating it with the specified <see cref="VisualElement"/> context.
        /// </summary>
        /// <param name="context">The visual element that this logger represents.</param>
        public VisualElementLogger(VisualElement context) {
            _context = context.GetType().FriendlyName();
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