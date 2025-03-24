using System;

namespace Noir.Attributes {
    public enum EngineCallbackType {
        /// <summary>
        /// Initialize occurs as soon as the engine starts up
        /// </summary>
        Initialize,

        /// <summary>
        /// ConfigureServices is called after the engine configures its own internal dependency injection
        /// </summary>
        ConfigureServices,

        /// <summary>
        /// Start is called after all Noir library setup is finished
        /// </summary>
        Start,
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class EngineCallbackAttribute : Attribute {
        public EngineCallbackType CallbackType { get; set; } = EngineCallbackType.Start;

        public EngineCallbackAttribute(EngineCallbackType callbackType) {
            CallbackType = callbackType;
        }
    }
}