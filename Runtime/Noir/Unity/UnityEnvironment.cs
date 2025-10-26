namespace Noir.Abstractions.Unity {
    /// <summary>
    /// Provides access to environment variables using the standard
    /// <see cref="System.Environment"/> API within the Unity runtime environment.
    /// </summary>
    public class UnityEnvironment : IEnvironment {
        /// <inheritdoc />
        public string GetEnvironmentVariable(string name) => System.Environment.GetEnvironmentVariable(name);
    }
}