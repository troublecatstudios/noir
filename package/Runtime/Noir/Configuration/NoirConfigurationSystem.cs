using UnityEngine;

namespace Noir.Configuration {
    /// <summary>
    /// Provides access to the active <see cref="NoirProjectConfiguration"/> at runtime.
    /// </summary>
    /// <remarks>
    /// This class registers itself automatically with the global <see cref="ServiceLocator"/>
    /// during Unity's subsystem initialization, allowing other systems to retrieve the
    /// current <see cref="NoirProjectConfiguration"/> via dependency injection or service lookup.
    /// </remarks>
    public class NoirConfigurationSystem : INoirProjectConfigurationAccessor {
        private static readonly NoirConfigurationSystem _instance = new();

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void SubsystemRegistration() {
            ServiceLocator.RegisterService<INoirProjectConfigurationAccessor>(_instance);
        }

        /// <summary>
        /// Retrieves the current project configuration.
        /// </summary>
        /// <returns>
        /// The singleton instance of <see cref="NoirProjectConfiguration"/>.
        /// </returns>
        /// <remarks>
        /// This method provides a standardized access point for systems that need to
        /// query global project configuration settings.
        /// </remarks>
        public NoirProjectConfiguration GetProjectConfiguration() {
            return NoirProjectConfiguration.Instance;
        }
    }
}