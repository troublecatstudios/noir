using Noir.Abstractions;
using Noir.Abstractions.Unity;

 namespace Noir.IO.Paths {
    public class EnvironmentVariablePaths : IPlatformPaths {
        internal const string PATHS_SAVE_ENVIRONMENT_VAR = "EN_SAVE_PATH";
        internal const string PATHS_CONFIG_ENVIRONMENT_VAR = "EN_CONFIG_PATH";
        internal const string PATHS_LOGS_ENVIRONMENT_VAR = "EN_LOG_PATH";
        internal const string CUSTOM_PARAMETERS_VAR = "CUSTOM_PARAMETERS";

        private readonly IPlatformPaths _fallback;

        public EnvironmentVariablePaths(IPlatformPaths fallback, AbstractEnvironment environment = null) {
            _fallback = fallback;
            environment ??= new UnityEnvironment();

            ConfigurationDirectory = environment.GetEnvironmentVariable(PATHS_CONFIG_ENVIRONMENT_VAR);
            if (string.IsNullOrEmpty(ConfigurationDirectory)) {
                ConfigurationDirectory = _fallback.ConfigurationDirectory;
            }

            SaveFileDirectory = environment.GetEnvironmentVariable(PATHS_SAVE_ENVIRONMENT_VAR);
            if (string.IsNullOrEmpty(SaveFileDirectory)) {
                SaveFileDirectory = _fallback.SaveFileDirectory;
            }

            LogDirectory = environment.GetEnvironmentVariable(PATHS_LOGS_ENVIRONMENT_VAR);
            if (string.IsNullOrEmpty(LogDirectory)) {
                LogDirectory = _fallback.LogDirectory;
            }

            var customParameters = environment.GetEnvironmentVariable(CUSTOM_PARAMETERS_VAR);
            if (!string.IsNullOrEmpty(customParameters)) {
                var sets = customParameters.Split(';');
                foreach (var set in sets) {
                    var entry = set.Split('=');
                    switch (entry[0]) {
                        case PATHS_CONFIG_ENVIRONMENT_VAR: ConfigurationDirectory = entry[1]; break;
                        case PATHS_LOGS_ENVIRONMENT_VAR: LogDirectory = entry[1]; break;
                        case PATHS_SAVE_ENVIRONMENT_VAR: SaveFileDirectory = entry[1]; break;
                    }
                }
            }
        }

        public string ConfigurationDirectory { get; private set; }
        public string SaveFileDirectory { get; private set; }
        public string LogDirectory { get; private set; }
    }
}