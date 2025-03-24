namespace Noir.Testing {
    public interface ICustomAssertionContext<out T> {
        T Target { get; }
        object[] AdditionalContexts { get; }
    }
}