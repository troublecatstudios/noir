namespace Noir.Abstractions {
    public abstract class AbstractEnvironment {
        public abstract string GetEnvironmentVariable(string variableName);
    }
}