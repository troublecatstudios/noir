using System;

namespace Noir.Logging {
    /// <summary>
    /// Defines a unified interface for components that can produce structured log output.
    /// </summary>
    /// <remarks>
    /// The <see cref="ILoggingComponent"/> interface standardizes logging methods across Noir systems,
    /// providing a consistent set of operations for verification, diagnostics, and subsystem-level tracing.
    /// </remarks>
    public interface ILoggingComponent {
        /// <summary>
        /// Verifies that a condition is true, logging a failure if it evaluates to false.
        /// </summary>
        /// <param name="condition">The boolean condition to evaluate.</param>
        /// <param name="label">A short descriptive label for this verification.</param>
        /// <param name="subsystem">An optional subsystem name for categorization.</param>
        void Verify(bool condition, string label, string subsystem = null);

        /// <summary>
        /// Verifies that a condition is true, logging a failure if the delegate returns false.
        /// </summary>
        /// <param name="condition">A function that evaluates the condition at runtime.</param>
        /// <param name="label">A short descriptive label for this verification.</param>
        /// <param name="subsystem">An optional subsystem name for categorization.</param>
        void Verify(Func<bool> condition, string label, string subsystem = null);

        /// <summary>
        /// Writes an informational message to the log.
        /// </summary>
        /// <param name="message">The message content.</param>
        /// <param name="subsystem">An optional subsystem name for categorization.</param>
        void Info(string message, string subsystem = null);

        /// <summary>
        /// Writes a trace message associated with a named trace context.
        /// </summary>
        /// <param name="trace">The trace identifier associated with this message.</param>
        /// <param name="message">The message content.</param>
        /// <param name="subsystem">An optional subsystem name for categorization.</param>
        void Trace(string trace, string message, string subsystem = null);

        /// <summary>
        /// Writes a debug-level message to the log, typically used for development or testing.
        /// </summary>
        /// <param name="message">The message content.</param>
        /// <param name="subsystem">An optional subsystem name for categorization.</param>
        void Debug(string message, string subsystem = null);

        /// <summary>
        /// Writes a warning message to the log, indicating potential issues or unexpected states.
        /// </summary>
        /// <param name="message">The message content.</param>
        /// <param name="subsystem">An optional subsystem name for categorization.</param>
        void Warn(string message, string subsystem = null);

        /// <summary>
        /// Writes an error message to the log, indicating a critical or unrecoverable problem.
        /// </summary>
        /// <param name="message">The message content.</param>
        /// <param name="subsystem">An optional subsystem name for categorization.</param>
        void Error(string message, string subsystem = null);

        /// <summary>
        /// Writes a log message with a specified severity, optionally scoped to a subsystem or trace.
        /// </summary>
        /// <param name="message">The message content.</param>
        /// <param name="level">The severity level of the log entry.</param>
        /// <param name="subsystem">An optional subsystem name for categorization.</param>
        /// <param name="trace">An optional trace identifier for related log entries.</param>
        void WriteLog(string message, LogLevel level = LogLevel.Info, string subsystem = null, string trace = null);
    }
}