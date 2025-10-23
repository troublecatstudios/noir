using Noir.DataObjects;
using UnityEditor;

namespace NoirEditor.MenuItems {
    internal static class FirstTimeSetup {
        private const string MENU_PATH = MenuConstants.BASE_MENU_PATH_TOOLS + "/Setup/First Time Setup";

        [MenuItem(MENU_PATH, priority = 111)]
        public static void Setup() {
            AutoCreateAssets.MenuAction();
        }

        [MenuItem(MENU_PATH, true)]
        public static bool SetupValidation() {
            try {
                var library = NoirDataLibrary.Instance;
                return !library;
            } catch {
                return false;
            }
        }
    }
}