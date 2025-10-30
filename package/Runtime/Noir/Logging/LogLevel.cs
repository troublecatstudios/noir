namespace Noir.Logging {
    /// <summary>
    /// Defines the severity or verbosity level for log messages within the Noir logging system.
    /// </summary>
    public enum LogLevel {
        /// <summary>
        /// Represents general information messages about normal system operation.
        /// Typically used for high-level status updates or significant events.
        /// </summary>
        Info,

        /// <summary>
        /// Represents potential issues or unexpected situations that do not prevent normal execution.
        /// Used to highlight conditions that may require attention.
        /// </summary>
        Warn,

        /// <summary>
        /// Represents serious issues or failures that prevent part of the system from functioning properly.
        /// Used when an operation fails or an unrecoverable state is encountered.
        /// </summary>
        Error,

        /// <summary>
        /// Represents diagnostic messages useful for debugging and detailed system analysis.
        /// Typically disabled in production builds.
        /// </summary>
        Debug,

        /// <summary>
        /// Represents highly detailed trace-level messages for step-by-step execution tracking.
        /// Usually reserved for deep troubleshooting or profiling.
        /// </summary>
        Verbose,
    }
}