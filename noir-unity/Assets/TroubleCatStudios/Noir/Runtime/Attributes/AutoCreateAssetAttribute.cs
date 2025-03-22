using System;

namespace Noir.Unity.Attributes {
    /// <summary>
    /// Declare that this ScriptableObject should be automatically created at build time.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class AutoCreateAssetAttribute : Attribute {

        /// <summary>
        /// Gets the custom folder path to store the created asset. Is automatically prefixed with "Assets/".
        /// </summary>
        public string CreatePathPrefix { get; private set; }

        public string AssetNameOverride { get; private set; }

        /// <summary>
        /// Declare that this ScriptableObject should be automatically created at build time.
        /// </summary>
        /// <param name="customPathPrefix">The custom folder path to store the created asset. Is automatically prefixed with "Assets/".</param>
        public AutoCreateAssetAttribute(string customPathPrefix = null, string overrideAssetName = null) {
            CreatePathPrefix = customPathPrefix ?? "";
            AssetNameOverride = overrideAssetName;
        }
    }
}
