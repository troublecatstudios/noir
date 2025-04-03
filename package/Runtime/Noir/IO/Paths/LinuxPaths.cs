using System;
using System.IO;

namespace Noir.IO.Paths {
    public class LinuxPaths : PathsBase, IPlatformPaths {
        private const string XDG_CONFIG_HOME_ENVIRONMENT_VAR = "XDG_CONFIG_HOME";
        private const string XDG_DATA_HOME_ENVIRONMENT_VAR = "XDG_DATA_HOME";
        private const string HOME_ENVIRONMENT_VAR = "HOME";

        public LinuxPaths() {
            LogDirectory = AppendProductPath("/var/log");

            string configPath = Environment.GetEnvironmentVariable(XDG_CONFIG_HOME_ENVIRONMENT_VAR);
            string home = Environment.GetEnvironmentVariable(HOME_ENVIRONMENT_VAR);
            if (string.IsNullOrEmpty(configPath)) {
                configPath = Path.Combine(home, ".config");
            }
            ConfigurationDirectory = AppendProductPath(configPath);

            string savePath = Environment.GetEnvironmentVariable(XDG_DATA_HOME_ENVIRONMENT_VAR);
            if (string.IsNullOrEmpty(savePath)) {
                savePath = Path.Combine(home, ".local/share");
            }
            SaveFileDirectory = AppendProductPath(savePath);
        }

        public string ConfigurationDirectory { get; private set; }
        public string SaveFileDirectory { get; private set; }
        public string LogDirectory { get; private set; }
    }
}