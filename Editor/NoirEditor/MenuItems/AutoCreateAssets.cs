using NoirEditor.Building;
using UnityEditor;

namespace Noir.Editing.MenuItems {
    internal static class AutoCreateAssets {
        [MenuItem("Tools/Trouble Cat Studios/Noir/Process Uncreated ScriptableObjects", priority = 100)]
        public static void MenuAction() {
            AutoCreateAssetProcessor.ProcessClassesWithAttribute();
        }
    }
}