using System;

namespace Noir.Attributes {
    /// <summary>
    /// Declare that this ScriptableObject should be automatically created at build time.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class AutomaticallyCreateAttribute : Attribute {

        /// <summary>
        /// Gets the custom folder path to store the created asset. Is automatically prefixed with "Assets/".
        /// </summary>
        public string CreatePathPrefix { get; private set; }

        /// <summary>
        /// Gets the file name of the asset, without the extension.
        /// </summary>
        /// <remarks>Defaults to the class name, ex: "MyDataObject".</remarks>
        public string AssetNameOverride { get; private set; }

        /// <summary>
        /// Declare that this ScriptableObject should be automatically created at build time.
        /// </summary>
        /// <param name="customPathPrefix">The custom folder path to store the created asset. The value given here is automatically prefixed with "Assets/".</param>
        /// <param name="assetNameOverride">The file name of the asset, without the extension. Defaults to the class name. ex: "MyDataObject".</param>
        public AutomaticallyCreateAttribute(string customPathPrefix = null, string assetNameOverride = null) {
            CreatePathPrefix = customPathPrefix ?? "";
            AssetNameOverride = assetNameOverride;
        }
    }
}