namespace Noir.Testing {
    public class CustomAssertionContext<T> : ICustomAssertionContext<T> {
        public CustomAssertionContext() { }
        public CustomAssertionContext(T target, params object[] additionalContexts) {
            Target = target;
            AdditionalContexts = additionalContexts;
        }
        public T Target { get; internal set; }

        public object[] AdditionalContexts { get; internal set; }
    }
}