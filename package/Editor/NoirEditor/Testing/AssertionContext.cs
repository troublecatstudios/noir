namespace Noir.Testing {
    public class AssertionContext<T> : IAssertionContext<T> {
        /// <summary>
        /// Creates a new assertion context.
        /// </summary>
        public AssertionContext() { }

        /// <summary>
        /// Creates a new assertion context using the given target and additional contexts.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="additionalContexts"></param>
        public AssertionContext(T target, params object[] additionalContexts) {
            Target = target;
            AdditionalContexts = additionalContexts;
        }
        public T Target { get; internal set; }

        public object[] AdditionalContexts { get; internal set; }
    }
}