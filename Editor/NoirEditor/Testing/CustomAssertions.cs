namespace Noir.Testing {
    public class CustomAssertions {
        public ICustomAssertionContext<T> That<T>(T context) {
            return new CustomAssertionContext<T>() { Target = context };
        }
    }
}