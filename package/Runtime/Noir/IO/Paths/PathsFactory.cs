using UnityEngine;

namespace Noir.IO.Paths {
    public class PathsFactory : IPlatformPathsFactory {
        public IPlatformPaths GetPlatformPaths() {
            IPlatformPaths basePaths;
            switch (Application.platform) {
                case RuntimePlatform.WindowsEditor:
                case RuntimePlatform.WindowsPlayer: basePaths = new WindowsPaths(); break;
                case RuntimePlatform.OSXEditor:
                case RuntimePlatform.OSXPlayer: basePaths = new OsxPaths(); break;
                case RuntimePlatform.LinuxPlayer: basePaths = new LinuxPaths(); break;
                default: basePaths = new UnknownPaths(); break;
            }

#if UNITY_EDITOR
            basePaths = new EditorPaths();
#endif

            var finalPaths = new EnvironmentVariablePaths(basePaths);

            System.IO.Directory.CreateDirectory(finalPaths.LogDirectory);
            System.IO.Directory.CreateDirectory(finalPaths.ConfigurationDirectory);
            System.IO.Directory.CreateDirectory(finalPaths.SaveFileDirectory);

            return finalPaths;
        }

#if UNITY_EDITOR
        public class EditorPaths : IPlatformPaths {
            public string ConfigurationDirectory => System.IO.Path.Combine(Application.dataPath, "../../.data");
            public string SaveFileDirectory => System.IO.Path.Combine(Application.dataPath, "../../.data");
            public string LogDirectory => System.IO.Path.Combine(Application.dataPath, "../../.data");
        }
#endif
    }
}