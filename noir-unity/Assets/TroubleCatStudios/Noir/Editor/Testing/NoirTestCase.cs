using NUnit.Framework;

namespace Noir.Testing {
    public abstract class NoirTestCase {
        public readonly CustomAssertions Asserts = new();

        [OneTimeSetUp]
        public virtual void SetupAll() {

        }

        [OneTimeTearDown]
        public virtual void TearDownAll() {

        }

        [SetUp]
        public virtual void Setup() {

        }
    }
}