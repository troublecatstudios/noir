namespace Noir.Abstractions.Unity {
    public class UnityEnvironment : AbstractEnvironment {
        public override string GetEnvironmentVariable(string variableName) {
            return System.Environment.GetEnvironmentVariable(variableName);
        }
    }
}