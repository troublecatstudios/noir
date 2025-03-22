using UnityEngine;

namespace Noir.IO.Paths {
    public class UnknownPaths : IPlatformPaths {
        public string ConfigurationDirectory => Application.persistentDataPath;
        public string SaveFileDirectory => Application.persistentDataPath;
        public string LogDirectory => Application.persistentDataPath;
    }
}