using NExpect;
using Noir;
using Noir.Testing;
using NUnit.Framework;
using System.Collections;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.TestTools;
using static NExpect.Expectations;

namespace NoirEditModeTests.Noir {
    public class GameTimeTests : NoirTestCase {
        [UnityTest]
        public IEnumerator AfterUpdate_DeltaTimeMatchesUnity() {
            var time = new GameTime();
            yield return null;
            Expect(time.deltaTime).To.Approximately.Equal(Time.deltaTime);
        }
        
        [UnityTest]
        public IEnumerator AfterUpdate_FrameCountMatchesUnity() {
            var time = new GameTime();
            yield return null;
            Expect(time.frameCount).To.Equal(Time.frameCount);
        }
        
        [UnityTest]
        public IEnumerator AfterUpdate_TimeMatchesUnity() {
            var time = new GameTime();
            yield return null;
            Expect(time.time).To.Equal(Time.time);
        }
        
        [UnityTest]
        public IEnumerator AfterUpdate_FixedDeltaTimeMatchesUnity() {
            var time = new GameTime();
            yield return new WaitForFixedUpdate();
            Expect(time.fixedDeltaTime).To.Approximately.Equal(Time.fixedDeltaTime);
        }
    }
}