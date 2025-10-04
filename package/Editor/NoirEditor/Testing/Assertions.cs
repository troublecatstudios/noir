namespace Noir.Testing {
    public class NoirAssertions {
        /// <summary>
        /// Gets the current assertion context.
        /// </summary>
        /// <param name="context">The value or object to use when running assertions.</param>
        /// <typeparam name="T">The type of the assertion target.</typeparam>
        /// <returns>A new assertion context.</returns>
        public IAssertionContext<T> That<T>(T context) {
            return new AssertionContext<T>() { Target = context };
        }
    }
}