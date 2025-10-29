namespace Noir.Configuration {
    /// <summary>
    /// Defines a contract for accessing the active <see cref="NoirProjectConfiguration"/> instance.
    /// </summary>
    /// <remarks>
    /// Implementations of this interface provide a centralized way to retrieve
    /// the current project configuration data used throughout the application or game.
    /// This abstraction helps decouple configuration retrieval from specific storage or loading mechanisms.
    /// </remarks>
    public interface INoirProjectConfigurationAccessor {
        /// <summary>
        /// Retrieves the current project configuration.
        /// </summary>
        /// <returns>
        /// The active <see cref="NoirProjectConfiguration"/> instance containing project-level settings and metadata.
        /// </returns>
        NoirProjectConfiguration GetProjectConfiguration();
    }
}