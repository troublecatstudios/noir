using System;

namespace Noir.Attributes {
    /// <summary>
    /// Engine callback triggers
    /// </summary>
    public enum EngineCallbackType {
        /// <summary>
        /// Initialize occurs as soon as the engine starts up.
        /// </summary>
        Initialize,

        /// <summary>
        /// ConfigureServices is called after the engine configures its own internal dependency injection.
        /// </summary>
        ConfigureServices,

        /// <summary>
        /// Start is called after all Noir library setup is finished.
        /// </summary>
        Start,
    }

    /// <summary>
    /// Allows static methods to be invoked at specific points during the Noir Library startup lifecycle.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class EngineCallbackAttribute : Attribute {
        /// <summary>
        /// Gets or sets a value indicating when the decorated method should be invoked by the Noir library.
        /// </summary>
        public EngineCallbackType CallbackType { get; set; } = EngineCallbackType.Start;

        /// <summary>
        /// Creates a new <see cref="EngineCallbackAttribute"/> with the specified callback type.
        /// </summary>
        /// <param name="callbackType">The point during the initialization lifecycle that this method should be invoked.</param>
        public EngineCallbackAttribute(EngineCallbackType callbackType) {
            CallbackType = callbackType;
        }
    }
}