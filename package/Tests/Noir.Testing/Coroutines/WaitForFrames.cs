using UnityEngine;

namespace Noir.Testing.Coroutines {
    public class WaitForFrames : CustomYieldInstruction {
        private readonly int _numberOfFrames;
        private int _frameCount;
        private readonly bool _inclusive;

        public WaitForFrames(int numberOfFrames = 1, bool inclusive = true) {
            _numberOfFrames = numberOfFrames;
            _frameCount = Time.frameCount;
            _inclusive = inclusive;
        }

        public override void Reset() {
            base.Reset();
            _frameCount = Time.frameCount;
        }

        public override bool keepWaiting =>
            Time.frameCount - _frameCount <= (_inclusive ? _numberOfFrames : _numberOfFrames - 1);
    }
}