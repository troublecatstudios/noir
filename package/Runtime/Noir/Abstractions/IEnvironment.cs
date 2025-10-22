namespace Noir.Abstractions {
    /// <summary>
    /// Provides an abstraction layer for accessing environment details.
    /// Implementations of this interface define how environment variables are retrieved,
    /// allowing for platform-specific behavior or easier testing through dependency injection.
    /// </summary>
    public interface IEnvironment {
        /// <summary>
        /// Retrieves the value of the specified environment variable.
        /// </summary>
        /// <param name="name">The name of the environment variable to retrieve.</param>
        /// <returns>
        /// The value of the environment variable if found; otherwise, <c>null</c>.
        /// </returns>
        string GetEnvironmentVariable(string name);
    }
}