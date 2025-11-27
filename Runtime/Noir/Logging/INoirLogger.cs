using System;

namespace Noir.Logging {
    /// <summary>
    /// Defines the contract for Noir's logging backend, providing structured, subsystem-aware log output.
    /// </summary>
    /// <remarks>
    /// Implementations of <see cref="INoirLogger"/> handle core logging responsibilities across all systems,
    /// including verification, tracing, and dynamic subsystem control. Typical implementations include
    /// in-memory loggers, Unity console output, or file-based logging systems.
    /// </remarks>
    public interface INoirLogger {
        /// <summary>
        /// Writes an informational message to the log.
        /// </summary>
        /// <param name="message">The message content.</param>
        /// <param name="context">An optional context object, typically a <see cref="UnityEngine.Object"/> or component instance.</param>
        /// <param name="subsystem">An optional subsystem identifier for categorization.</param>
        void Info(string message, object context = null, string subsystem = null);

        /// <summary>
        /// Writes a trace message associated with a named trace context.
        /// </summary>
        /// <param name="trace">The trace identifier associated with this message.</param>
        /// <param name="message">The message content.</param>
        /// <param name="context">An optional context object, typically a <see cref="UnityEngine.Object"/> or component instance.</param>
        /// <param name="subsystem">An optional subsystem identifier for categorization.</param>
        void Trace(string trace, string message, object context = null, string subsystem = null);

        /// <summary>
        /// Writes a debug-level message to the log, typically used for detailed diagnostics during development.
        /// </summary>
        /// <param name="message">The message content.</param>
        /// <param name="context">An optional context object, typically a <see cref="UnityEngine.Object"/> or component instance.</param>
        /// <param name="subsystem">An optional subsystem identifier for categorization.</param>
        void Debug(string message, object context = null, string subsystem = null);

        /// <summary>
        /// Writes a warning message to the log, indicating potential issues or unexpected behavior.
        /// </summary>
        /// <param name="message">The message content.</param>
        /// <param name="context">An optional context object, typically a <see cref="UnityEngine.Object"/> or component instance.</param>
        /// <param name="subsystem">An optional subsystem identifier for categorization.</param>
        void Warn(string message, object context = null, string subsystem = null);

        /// <summary>
        /// Writes an error message to the log, indicating a critical or unrecoverable problem.
        /// </summary>
        /// <param name="message">The message content.</param>
        /// <param name="context">An optional context object, typically a <see cref="UnityEngine.Object"/> or component instance.</param>
        /// <param name="subsystem">An optional subsystem identifier for categorization.</param>
        void Error(string message, object context = null, string subsystem = null);

        /// <summary>
        /// Writes a log message with a specified severity, optionally scoped to a subsystem or trace.
        /// </summary>
        /// <param name="message">The message content.</param>
        /// <param name="level">The severity level of the log entry.</param>
        /// <param name="context">An optional context object, typically a <see cref="UnityEngine.Object"/> or component instance.</param>
        /// <param name="subsystem">An optional subsystem identifier for categorization.</param>
        /// <param name="trace">An optional trace identifier for related log entries.</param>
        void WriteLog(string message, LogLevel level = LogLevel.Info, object context = null, string subsystem = null, string trace = null);

        /// <summary>
        /// Verifies that a condition is true, logging a failure if it evaluates to false.
        /// </summary>
        /// <param name="condition">The boolean condition to evaluate.</param>
        /// <param name="label">A short descriptive label for this verification.</param>
        /// <param name="context">An optional context object for the log entry.</param>
        /// <param name="subsystem">An optional subsystem identifier for categorization.</param>
        void Verify(bool condition, string label, object context = null, string subsystem = null);

        /// <summary>
        /// Verifies that a condition is true, logging a failure if the delegate returns false.
        /// </summary>
        /// <param name="condition">A function that evaluates the condition at runtime.</param>
        /// <param name="label">A short descriptive label for this verification.</param>
        /// <param name="context">An optional context object for the log entry.</param>
        /// <param name="subsystem">An optional subsystem identifier for categorization.</param>
        void Verify(Func<bool> condition, string label, object context = null, string subsystem = null);

        /// <summary>
        /// Disables logging for a specific subsystem.
        /// </summary>
        /// <param name="system">The name of the subsystem to disable.</param>
        void DisableSubsystem(string system);

        /// <summary>
        /// Enables logging for a specific subsystem.
        /// </summary>
        /// <param name="system">The name of the subsystem to enable.</param>
        void EnableSubsystem(string system);

        /// <summary>
        /// Ends all active trace contexts and disables trace mode.
        /// </summary>
        void EndAllTraces();

        /// <summary>
        /// Ends an active trace context by name.
        /// </summary>
        /// <param name="traceName">The name of the trace context to end.</param>
        void EndTrace(string traceName);

        /// <summary>
        /// Starts a new trace context for fine-grained debugging and performance tracking.
        /// </summary>
        /// <param name="traceName">The name of the trace context to start.</param>
        void StartTrace(string traceName);
    }
}