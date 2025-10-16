using System;
using UnityEngine;
using UnityEngine.Audio;

namespace Noir {
    /// <summary>
    /// Scriptable object that holds Noir project configuration settings and provides runtime access to them.
    /// </summary>
    public class NoirProjectConfiguration : ScriptableObject {
        internal const string DefineDisableCodeGeneration = "NOIR_CODE_GEN_DISABLED";
        internal const string PackageName = "Noir Library";
        internal const string PackageId = "io.troublecat.noir";
        internal static readonly string PackageFolder = $"Packages/{PackageId}";
        internal static readonly string AssetsFolder = $"Assets/TroubleCatStudios/Noir";
        internal static readonly string SettingsPath = $"{AssetsFolder}/Resources/{nameof(NoirProjectConfiguration)}.asset";

        private static readonly object _lock = new();
        private static NoirProjectConfiguration _instance = null;

        /// <summary>
        /// Gets the singleton instance of the NoirProjectConfiguration from project resources.
        /// </summary>
        public static NoirProjectConfiguration Instance {
            get {
                if (!_instance) {
                    lock (_lock) {
                        _instance = Resources.Load<NoirProjectConfiguration>(nameof(NoirProjectConfiguration));
                    }
                }

                return _instance;
            }
        }

        /// <summary>
        /// Returns a value indicating whether the first-time setup of the noir library has been completed or not.
        /// </summary>
        /// <returns><c>true</c> if first-time setup has been completed, <c>false</c> otherwise.</returns>
        public static bool CheckFirstTimeSetupComplete() => ((bool)Instance) == true;

#if ODIN_INSPECTOR
        // only used by odin inspector to build the editor view
        [SerializeField] private string _selectedParent;
 #endif

#if ODIN_INSPECTOR
        [ShowIf("@_selectedParent == \"Editor\"")]
#else
        [Header("Editor")]
#endif
        [SerializeField]
        private bool _enableCodeGeneration = true;

#if ODIN_INSPECTOR
        [AssetsOnly]
        [ShowIf("@_selectedParent == \"Gameplay\"")]
#else
        [Header("Gameplay")]
#endif
        [SerializeField]
        private NoirGameManager _gameManagerPrefab;

#if ODIN_INSPECTOR
        [ShowIf("@_selectedParent == \"Gameplay\"")]
#else
        [Header("Gameplay")]
#endif
        [SerializeField]
        private bool _lockFrameRate = true;

#if ODIN_INSPECTOR
        [ShowIf("@_selectedParent == \"Gameplay\" && _lockFrameRate")]
#else
        [Header("Gameplay")]
#endif
        [SerializeField]
        private int _lockedFrameRate = 60;

#if ODIN_INSPECTOR
        [ShowIf("@_selectedParent == \"Gameplay\"")]
#else
        [Header("Gameplay")]
#endif
        [SerializeField]
        private bool _automaticallySpawnGameManagers = true;

#if ODIN_INSPECTOR
        [ShowIf("@_selectedParent == \"Gameplay\"")]
#else
        [Header("Audio")]
#endif
        [SerializeField]
        private AudioMixerGroup _defaultAudioMixerGroup;

        /// <summary>
        /// Gets the frame rate to lock the application to, if framerate locking is enabled.
        /// </summary>
        public int LockedFrameRate => _lockedFrameRate;

        /// <summary>
        /// Gets a value indicating whether the framerate is locked.
        /// </summary>
        public bool IsFramerateLocked => _lockFrameRate;

        /// <summary>
        /// Gets a value indicating whether automatic spawning of game managers is enabled.
        /// </summary>
        public bool IsAutomaticSpawnEnabled => _automaticallySpawnGameManagers;

        /// <summary>
        /// Gets a value indicating whether code generation is enabled.
        /// </summary>
        public bool IsCodeGenerationEnabled => _enableCodeGeneration;

        /// <summary>
        /// Gets the prefab to use for the Noir game manager.
        /// </summary>
        internal NoirGameManager GameManagerPrefab => _gameManagerPrefab;

        /// <summary>
        /// Gets the default audio mixer group for the Noir project.
        /// </summary>
        public AudioMixerGroup DefaultAudioMixerGroup => _defaultAudioMixerGroup;

#if UNITY_EDITOR
        /// <summary>
        /// Called by Unity when the scriptable object is validated in the editor.
        /// Updates scripting define symbols based on code generation settings.
        /// </summary>
        private void OnValidate() {
            // TODO: figure out a way to not have this code in two places (here and in ActiveBuildTargetChangedHandler)
            var platform = UnityEditor.EditorUserBuildSettings.selectedBuildTargetGroup;
            var defines = UnityEditor.PlayerSettings.GetScriptingDefineSymbolsForGroup(platform);
            if (!IsCodeGenerationEnabled && !defines.Contains(DefineDisableCodeGeneration)) {
                if (defines.Length > 0) {
                    defines += ";";
                }
                defines += DefineDisableCodeGeneration;
                UnityEditor.PlayerSettings.SetScriptingDefineSymbolsForGroup(platform, defines);
                return;
            }

            if (IsCodeGenerationEnabled && defines.Contains(DefineDisableCodeGeneration)) {
                defines = defines.Replace(DefineDisableCodeGeneration, string.Empty).Replace(";;", ";");
                UnityEditor.PlayerSettings.SetScriptingDefineSymbolsForGroup(platform, defines);
            }
        }
#endif
    }
}