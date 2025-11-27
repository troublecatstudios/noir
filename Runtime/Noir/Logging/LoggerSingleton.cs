using System;
using System.Collections.Generic;
using Noir.IO.Paths;

namespace Noir.Logging {

    /// <summary>
    /// A globally accessible singleton logger that provides centralized logging, tracing, and subsystem management
    /// for the Noir framework. This acts as a façade over the configured <see cref="INoirLogger"/> implementation.
    /// </summary>
    public sealed class LoggerSingleton {
        private static INoirLogger _writer;

        private static INoirLogger LogWriter {
            get {
                if (_writer == null) {
                    var paths = new PathsFactory().GetPlatformPaths();
                    _writer = new NoirFileLogger(paths);
                }
                return _writer;
            }
        }

        /// <summary>
        /// Replaces the internal logger instance. This is primarily intended for unit testing or temporary overrides.
        /// </summary>
        /// <param name="logWriter">The custom logger to use as the writer.</param>
        internal static void SetWriter(INoirLogger logWriter) => _writer = logWriter;

        private static readonly Dictionary<string, float> _sampleTimes = new Dictionary<string, float>();

        /// <summary>
        /// Logs a message only at a specified sample rate, to prevent log spam from frequently occurring events.
        /// </summary>
        /// <param name="token">A unique identifier for this sample type.</param>
        /// <param name="rate">The minimum time (in seconds) between logs with the same token.</param>
        /// <param name="message">The log message to output when the sample is emitted.</param>
        public void Sample(string token, float rate, string message) {
            var shouldLog = false;
            if (!_sampleTimes.ContainsKey(token)) {
                _sampleTimes.Add(token, UnityEngine.Time.time);
                shouldLog = true;
            } else {
                shouldLog = UnityEngine.Time.time - _sampleTimes[token] >= rate;
            }
            if (shouldLog) {
                _sampleTimes[token] = UnityEngine.Time.time;
                Debug($"SAMPLE [{token}] {message}");
            }
        }

        private readonly static LoggerSingleton _instance = new();

        /// <summary>
        /// Gets the global <see cref="LoggerSingleton"/> instance.
        /// </summary>
        public static LoggerSingleton Instance => _instance;

        private LoggerSingleton() { }

        /// <summary>
        /// Starts a named trace, allowing performance or behavior to be tracked across log events.
        /// </summary>
        /// <param name="traceName">The unique name of the trace.</param>
        public void StartTrace(string traceName) => LogWriter.StartTrace(traceName);

        /// <summary>
        /// Ends a trace previously started with <see cref="StartTrace(string)"/>.
        /// </summary>
        /// <param name="traceName">The name of the trace to end.</param>
        public void EndTrace(string traceName) => LogWriter.EndTrace(traceName);

        /// <summary>
        /// Ends all currently active traces.
        /// </summary>
        public void EndAllTraces() => LogWriter.EndAllTraces();

        /// <summary>
        /// Enables logging output for a specific subsystem.
        /// </summary>
        /// <param name="system">The name of the subsystem to enable.</param>
        public void EnableSubsystem(string system) => LogWriter.EnableSubsystem(system);

        /// <summary>
        /// Disables logging output for a specific subsystem.
        /// </summary>
        /// <param name="system">The name of the subsystem to disable.</param>
        public void DisableSubsystem(string system) => LogWriter.DisableSubsystem(system);

        /// <summary>
        /// Verifies that a condition is true and logs the result.
        /// </summary>
        /// <param name="condition">The condition to check.</param>
        /// <param name="label">A short description of what is being verified.</param>
        /// <param name="context">An optional context object (such as a Unity component or system).</param>
        /// <param name="subsystem">An optional subsystem name for categorizing the log.</param>
        public void Verify(bool condition, string label, object context = null, string subsystem = null) => LogWriter.Verify(condition, label, context, subsystem);

        /// <summary>
        /// Verifies that a condition is true and logs the result. The condition is provided as a function delegate.
        /// </summary>
        /// <param name="condition">A delegate returning a boolean condition to check.</param>
        /// <param name="label">A short description of what is being verified.</param>
        /// <param name="context">An optional context object (such as a Unity component or system).</param>
        /// <param name="subsystem">An optional subsystem name for categorizing the log.</param>
        public void Verify(Func<bool> condition, string label, object context = null, string subsystem = null) => Verify(condition(), label, context, subsystem);

        /// <summary>
        /// Writes an informational message to the log.
        /// </summary>
        public void Info(string message, object context = null, string subsystem = null) => LogWriter.Info(message, context, subsystem);

        /// <summary>
        /// Writes a trace message associated with a named trace.
        /// </summary>
        public void Trace(string trace, string message, object context = null, string subsystem = null) => LogWriter.Trace(trace, message, context, subsystem);

        /// <summary>
        /// Writes a debug message to the log.
        /// </summary>
        public void Debug(string message, object context = null, string subsystem = null) => LogWriter.Debug(message, context, subsystem);

        /// <summary>
        /// Writes a warning message to the log.
        /// </summary>
        public void Warn(string message, object context = null, string subsystem = null) => LogWriter.Warn(message, context, subsystem);

        /// <summary>
        /// Writes an error message to the log.
        /// </summary>
        public void Error(string message, object context = null, string subsystem = null) => LogWriter.Error(message, context, subsystem);


        /// <summary>
        /// Writes an informational message associated with a specific type as context.
        /// </summary>
        public static void Info<T>(string message, string subsystem = null) => LogWriter.Info(message, typeof(T).FriendlyName(), subsystem);

        /// <summary>
        /// Writes a trace message associated with a specific type as context.
        /// </summary>
        public static void Trace<T>(string trace, string message, string subsystem = null) => LogWriter.Trace(trace, message, typeof(T).FriendlyName(), subsystem);

        /// <summary>
        /// Writes a debug message associated with a specific type as context.
        /// </summary>
        public static void Debug<T>(string message, string subsystem = null) => LogWriter.Debug(message, typeof(T).FriendlyName(), subsystem);

        /// <summary>
        /// Writes a warning message associated with a specific type as context.
        /// </summary>
        public static void Warn<T>(string message, string subsystem = null) => LogWriter.Warn(message, typeof(T).FriendlyName(), subsystem);

        /// <summary>
        /// Writes an error message associated with a specific type as context.
        /// </summary>
        public static void Error<T>(string message, string subsystem = null) => LogWriter.Error(message, typeof(T).FriendlyName(), subsystem);

        /// <summary>
        /// Verifies a condition for a given type context and logs the result.
        /// </summary>
        public static void Verify<T>(bool condition, string label, string subsystem = null) => LogWriter.Verify(condition, label, typeof(T).FriendlyName(), subsystem);

        /// <summary>
        /// Verifies a condition (provided as a delegate) for a given type context and logs the result.
        /// </summary>
        public static void Verify<T>(Func<bool> condition, string label, string subsystem = null) => Verify<T>(condition(), label, subsystem);

        /// <summary>
        /// Writes a log message at a specified level, optionally including context, subsystem, and trace information.
        /// </summary>
        /// <param name="message">The log message.</param>
        /// <param name="level">The severity level of the log message.</param>
        /// <param name="context">An optional context object, such as a Unity component.</param>
        /// <param name="subsystem">An optional subsystem identifier.</param>
        /// <param name="trace">An optional trace identifier.</param>
        public void WriteLog(string message, LogLevel level = LogLevel.Info, object context = null, string subsystem = null, string trace = null) => LogWriter.WriteLog(message, level, context, subsystem, trace);
    }
}