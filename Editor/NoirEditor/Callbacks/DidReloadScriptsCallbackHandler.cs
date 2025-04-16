using Noir;
using Noir.DataObjects;
using NoirEditor.CodeGen;
using NoirEditor.Editors.SettingsProviders;

// using Noir.Editing.Editors;

namespace NoirEditor.Callbacks {
    internal class DidReloadScriptsCallbackHandler {

        [UnityEditor.Callbacks.DidReloadScripts]
        public static void OnDidReloadScripts() {
            if (InternalUnityEditor.ParallelSync.IsClone()) return;
            var dataLibrary = NoirDataLibrary.Instance;
            if (dataLibrary) {
                DataLibraryBuilder.UpdateDataLibrary(dataLibrary);
            }

            if (!NoirProjectConfiguration.CheckFirstTimeSetupComplete()) {
                NoirProjectConfigurationSettingsProvider.GetOrCreateSettings();
            }
            // DefaultCodeGenerationHandler.DoCodeGeneration();
        }
    }
}