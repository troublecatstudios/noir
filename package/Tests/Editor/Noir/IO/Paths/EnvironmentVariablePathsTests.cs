using Moq;
using NExpect;
using Noir.Abstractions;
using Noir.IO.Paths;
using Noir.Testing;
using NUnit.Framework;
using static NExpect.Expectations;

namespace NoirEditModeTests.Noir.IO.Paths {
    public class EnvironmentVariablePathsTests : NoirTestCase {
        private readonly Mock<IEnvironment> _environment = new Mock<IEnvironment>(MockBehavior.Strict);
        private readonly Mock<IPlatformPaths> _paths = new Mock<IPlatformPaths>(MockBehavior.Strict);

        private const string DEFAULT_LOG_DIRECTORY = "/Mock/Log/Path";
        private const string DEFAULT_SAVE_DIRECTORY = "/Mock/Save/Path";
        private const string DEFAULT_CONFIG_DIRECTORY = "/Mock/Config/Path";

        private const string CUSTOM_PARAMS_SET_ALL = "EN_SAVE_PATH=/Custom/Save/Path;EN_CONFIG_PATH=/Custom/Config/Path;EN_LOG_PATH=/Custom/Logs/Path;";
        private const string CUSTOM_PARAMS_SET_CONFIG = "EN_CONFIG_PATH=/Custom/Config/Path";
        private const string CUSTOM_PARAMS_SET_LOGS = "EN_LOG_PATH=/Custom/Logs/Path;";
        private const string CUSTOM_PARAMS_SET_SAVES = "EN_SAVE_PATH=/Custom/Save/Path";

        public override void Setup() {
            base.Setup();
            _paths.Setup(m => m.ConfigurationDirectory).Returns(DEFAULT_CONFIG_DIRECTORY);
            _paths.Setup(m => m.SaveFileDirectory).Returns(DEFAULT_SAVE_DIRECTORY);
            _paths.Setup(m => m.LogDirectory).Returns(DEFAULT_LOG_DIRECTORY);

            _environment.Setup(m => m.GetEnvironmentVariable(EnvironmentVariablePaths.PATHS_CONFIG_ENVIRONMENT_VAR)).Returns(string.Empty);
            _environment.Setup(m => m.GetEnvironmentVariable(EnvironmentVariablePaths.PATHS_SAVE_ENVIRONMENT_VAR)).Returns(string.Empty);
            _environment.Setup(m => m.GetEnvironmentVariable(EnvironmentVariablePaths.PATHS_LOGS_ENVIRONMENT_VAR)).Returns(string.Empty);
            _environment.Setup(m => m.GetEnvironmentVariable(EnvironmentVariablePaths.CUSTOM_PARAMETERS_VAR)).Returns(string.Empty);
        }

        public override void TearDownAll() {
            base.TearDownAll();
            _paths.Reset();
            _environment.Reset();
        }

        [Test]
        [TestCase("", "", DEFAULT_LOG_DIRECTORY, DEFAULT_SAVE_DIRECTORY, DEFAULT_CONFIG_DIRECTORY)]
        [TestCase(EnvironmentVariablePaths.PATHS_SAVE_ENVIRONMENT_VAR, "", DEFAULT_LOG_DIRECTORY, DEFAULT_SAVE_DIRECTORY, DEFAULT_CONFIG_DIRECTORY)]
        [TestCase(EnvironmentVariablePaths.PATHS_CONFIG_ENVIRONMENT_VAR, "", DEFAULT_LOG_DIRECTORY, DEFAULT_SAVE_DIRECTORY, DEFAULT_CONFIG_DIRECTORY)]
        [TestCase(EnvironmentVariablePaths.PATHS_LOGS_ENVIRONMENT_VAR, "", DEFAULT_LOG_DIRECTORY, DEFAULT_SAVE_DIRECTORY, DEFAULT_CONFIG_DIRECTORY)]
        [TestCase(EnvironmentVariablePaths.PATHS_SAVE_ENVIRONMENT_VAR, null, DEFAULT_LOG_DIRECTORY, DEFAULT_SAVE_DIRECTORY, DEFAULT_CONFIG_DIRECTORY)]
        [TestCase(EnvironmentVariablePaths.PATHS_CONFIG_ENVIRONMENT_VAR, null, DEFAULT_LOG_DIRECTORY, DEFAULT_SAVE_DIRECTORY, DEFAULT_CONFIG_DIRECTORY)]
        [TestCase(EnvironmentVariablePaths.PATHS_LOGS_ENVIRONMENT_VAR, null, DEFAULT_LOG_DIRECTORY, DEFAULT_SAVE_DIRECTORY, DEFAULT_CONFIG_DIRECTORY)]
        [TestCase(EnvironmentVariablePaths.PATHS_LOGS_ENVIRONMENT_VAR, "/Overridden/Logs/Path", "/Overridden/Logs/Path", DEFAULT_SAVE_DIRECTORY, DEFAULT_CONFIG_DIRECTORY)]
        [TestCase(EnvironmentVariablePaths.PATHS_SAVE_ENVIRONMENT_VAR, "/Overridden/Save/Path", DEFAULT_LOG_DIRECTORY, "/Overridden/Save/Path", DEFAULT_CONFIG_DIRECTORY)]
        [TestCase(EnvironmentVariablePaths.PATHS_CONFIG_ENVIRONMENT_VAR, "/Overridden/Config/Path", DEFAULT_LOG_DIRECTORY, DEFAULT_SAVE_DIRECTORY, "/Overridden/Config/Path")]
        [TestCase(EnvironmentVariablePaths.CUSTOM_PARAMETERS_VAR, CUSTOM_PARAMS_SET_ALL, "/Custom/Logs/Path", "/Custom/Save/Path", "/Custom/Config/Path")]
        [TestCase(EnvironmentVariablePaths.CUSTOM_PARAMETERS_VAR, CUSTOM_PARAMS_SET_LOGS, "/Custom/Logs/Path", DEFAULT_SAVE_DIRECTORY, DEFAULT_CONFIG_DIRECTORY)]
        [TestCase(EnvironmentVariablePaths.CUSTOM_PARAMETERS_VAR, CUSTOM_PARAMS_SET_SAVES, DEFAULT_LOG_DIRECTORY, "/Custom/Save/Path", DEFAULT_CONFIG_DIRECTORY)]
        [TestCase(EnvironmentVariablePaths.CUSTOM_PARAMETERS_VAR, CUSTOM_PARAMS_SET_CONFIG, DEFAULT_LOG_DIRECTORY, DEFAULT_SAVE_DIRECTORY, "/Custom/Config/Path")]
        public void WhenInitialized_TheDirectoryPathsAreOverriddenCorrectly(string environmentVariableName, string environmentVariableValue, string expectedLogDirectory, string expectedSaveDirectory, string expectedConfigDirectory) {
            _environment.Setup(m => m.GetEnvironmentVariable(environmentVariableName)).Returns(environmentVariableValue);

            var envPaths = new EnvironmentVariablePaths(_paths.Object, _environment.Object);

            Expect(envPaths.LogDirectory).To.Equal(expectedLogDirectory);
            Expect(envPaths.ConfigurationDirectory).To.Equal(expectedConfigDirectory);
            Expect(envPaths.SaveFileDirectory).To.Equal(expectedSaveDirectory);
        }
    }
}
