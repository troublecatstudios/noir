using Moq;
using Noir.Logging;
using Noir.Testing;
using NUnit.Framework;
using static NExpect.Expectations;

namespace NoirEditModeTests.Noir.Logging {
    public class LoggerSingletonEditModeTests : NoirEditModeTestCase {
        private readonly Mock<INoirLogger> _logger = new(MockBehavior.Loose);

        public override void Setup() {
            base.Setup();
            LoggerSingleton.SetWriter(_logger.Object);
        }

        [Test]
        public void WhenTestsAreRunning_LogWriterCanBeOverridden() {
            LoggerSingleton.Instance.Info("this is a test");
            _logger.Verify(m => m.Info("this is a test", null, null), Times.Once);
        }
    }
}