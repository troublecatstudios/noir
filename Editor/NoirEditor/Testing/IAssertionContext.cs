namespace Noir.Testing {
    public interface IAssertionContext<out T> {
        T Target { get; }
        object[] AdditionalContexts { get; }
    }
}
