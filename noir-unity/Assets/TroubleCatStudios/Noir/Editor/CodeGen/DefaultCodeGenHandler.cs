using Noir.Logging;

namespace NoirEditor.CodeGen {
    internal class DefaultCodeGenerationHandler {
        public static void DoCodeGeneration(bool dryRun = false) {
            var codeGenerator = new CodeGenerator();
            codeGenerator.AddTasks(DefaultCodeGenerationTasks.GetCodeGenTasks());
            var results = codeGenerator.Generate(dryRun: dryRun);
            LoggerSingleton.Info<DefaultCodeGenerationHandler>($"{results}");
        }
    }
}