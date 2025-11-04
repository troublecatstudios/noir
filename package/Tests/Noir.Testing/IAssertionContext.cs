namespace Noir.Testing {
    public interface IAssertionContext<out T> {
        /// <summary>
        /// Gets the target that the assertions will be run against.
        /// </summary>
        T Target { get; }

        /// <summary>
        /// Gets any additional contexts that will be used by the assertions.
        /// </summary>
        object[] AdditionalContexts { get; }
    }
}