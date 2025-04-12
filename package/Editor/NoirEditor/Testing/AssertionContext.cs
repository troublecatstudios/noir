namespace Noir.Testing {
    public class AssertionContext<T> : IAssertionContext<T> {
        public AssertionContext() { }
        public AssertionContext(T target, params object[] additionalContexts) {
            Target = target;
            AdditionalContexts = additionalContexts;
        }
        public T Target { get; internal set; }

        public object[] AdditionalContexts { get; internal set; }
    }
}
