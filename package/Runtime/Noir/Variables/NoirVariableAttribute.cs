using System;

namespace Noir.Variables {

    /// <summary>
    /// Declares that this variable field should be bound automatically to a named variable in the asset library.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class NoirVariableAttribute : Attribute {
        /// <summary>
        /// The variable name to use when looking up the event asset in the asset library.
        /// </summary>
        public string VariableName { get; private set; }

        /// <summary>
        /// Declares that this variable field should be bound automatically to a named variable in the asset library.
        /// </summary>
        /// <param name="variableName">The variable name to look for in the asset library</param>
        public NoirVariableAttribute(string variableName) {
            VariableName = variableName;
        }
    }
}