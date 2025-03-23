using NoirEditor.CodeGen;
using UnityEditor;

namespace NoirEditor.MenuItems {
    internal class GenerateCodeFiles {

        [MenuItem("Tools/Trouble Cat Studios/Noir/Generate Code Files", priority = 100)]
        public static void MenuAction() => DefaultCodeGenerationHandler.DoCodeGeneration();
    }
}