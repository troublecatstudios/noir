using NoirEditor.CodeGen;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;

namespace NoirEditor.Building.PreProcessing {
    internal class CodeGenPreProcessor : IPreprocessBuildWithReport  {
        public int callbackOrder { get; } = -10;

        public void OnPreprocessBuild(BuildReport report) {
            DefaultCodeGenerationHandler.DoCodeGeneration();
        }
    }
}