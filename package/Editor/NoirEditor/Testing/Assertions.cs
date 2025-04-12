namespace Noir.Testing {
    public class NoirAssertions {
        public IAssertionContext<T> That<T>(T context) {
            return new AssertionContext<T>() { Target = context };
        }
    }
}
