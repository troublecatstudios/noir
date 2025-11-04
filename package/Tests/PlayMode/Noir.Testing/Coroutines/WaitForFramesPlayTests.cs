using Noir.Testing;
using Noir.Testing.Assertions;
using Noir.Testing.Coroutines;
using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;

namespace NoirPlayModeTests.Noir.Testing.Coroutines {
    public class WaitForFramesPlayTests : NoirPlayModeTestCase {

        [UnityTest]
        public IEnumerator ShouldSkipTheSpecifiedNumberOfFrames() {
            var startFrame = Time.frameCount;

            yield return new WaitForFrames(10);

            var endFrame = Time.frameCount;

            Asserts.That(endFrame).IsEqualTo(startFrame + 10 + 1);
        }

        [UnityTest]
        public IEnumerator IfExclusive_ShouldSkipToTheLastSpecifiedFrame() {
            var startFrame = Time.frameCount;

            yield return new WaitForFrames(10, inclusive: false);

            var endFrame = Time.frameCount;

            Asserts.That(endFrame).IsEqualTo(startFrame + 10);
        }

    }
}