using NUnit.Framework;

namespace Noir.Testing {
    /// <summary>
    /// Base class for all Noir unit test classes.
    /// </summary>
    public abstract class NoirEditModeTestCase {

        /// <summary>
        /// Gets the <see cref="NoirAssertions"/> instance for this test class.
        /// </summary>
        public readonly NoirAssertions Asserts = new();

        /// <summary>
        /// Performed once before all the tests within the class are run.
        /// </summary>
        [OneTimeSetUp]
        public virtual void SetupAll() {

        }

        /// <summary>
        /// Performed once after all tests within the class have been run.
        /// </summary>
        [OneTimeTearDown]
        public virtual void TearDownAll() {

        }

        /// <summary>
        /// Performed before each test within the class is run.
        /// </summary>
        [SetUp]
        public virtual void Setup() {

        }
    }
}