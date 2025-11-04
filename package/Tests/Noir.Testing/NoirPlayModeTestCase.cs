using NUnit.Framework;
using System.Collections;
using UnityEngine.TestTools;

namespace Noir.Testing {
    /// <summary>
    /// Base class for all Noir play-mode (integration) test classes.
    /// </summary>
    [TestFixture]
    public abstract class NoirPlayModeTestCase {
        /// <summary>
        /// Gets the <see cref="NoirAssertions"/> instance for this test class.
        /// </summary>
        public readonly NoirAssertions Asserts = new();

        [UnitySetUp]
        public virtual IEnumerator SetupAsync() {
            yield return null;
        }

        [UnityTearDown]
        public virtual IEnumerator TearDownAsync() {
            yield return null;
        }

    }
}