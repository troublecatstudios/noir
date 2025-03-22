namespace Noir.Unity.Abstractions.Impl {
    public class UnityEnvironment : AbstractEnvironment {
        public override string GetEnvironmentVariable(string variableName) {
            return System.Environment.GetEnvironmentVariable(variableName);
        }
    }
}
