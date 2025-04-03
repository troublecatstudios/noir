using Noir;
using UnityEditor;
using UnityEditor.Build;

namespace NoirEditor.Callbacks {
    [InitializeOnLoad]
    public class ActiveBuildTargetChangedHandler : IActiveBuildTargetChanged {

        private static void AddDefines() {
            var platform = EditorUserBuildSettings.selectedBuildTargetGroup;
            var defines = PlayerSettings.GetScriptingDefineSymbolsForGroup(platform);
            var config = NoirProjectConfiguration.Instance;
            if (!config) return;

            if (!config.IsCodeGenerationEnabled && !defines.Contains(NoirProjectConfiguration.DefineDisableCodeGeneration)) {
                if (defines.Length > 0) {
                    defines += ";";
                }
                defines += NoirProjectConfiguration.DefineDisableCodeGeneration;
                PlayerSettings.SetScriptingDefineSymbolsForGroup(platform, defines);
                return;
            }

            if (config.IsCodeGenerationEnabled && defines.Contains(NoirProjectConfiguration.DefineDisableCodeGeneration)) {
                defines = defines.Replace(NoirProjectConfiguration.DefineDisableCodeGeneration, string.Empty).Replace(";;", ";");
                PlayerSettings.SetScriptingDefineSymbolsForGroup(platform, defines);
            }
        }

        static ActiveBuildTargetChangedHandler() {
            AddDefines();
        }

        public int callbackOrder => 0;

        public void OnActiveBuildTargetChanged(BuildTarget previousTarget, BuildTarget newTarget) {
            AddDefines();
        }
    }
}