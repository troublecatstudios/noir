using Noir.Abstractions;

namespace Noir.Testing {
    public class FakeGameTime : IGameTime {
        public float deltaTime { get; set; } = 0.0166667f;
        public float fixedDeltaTime { get; set; } = 0.0333333f;
        public int frameCount { get; set; } = 0;
        public float time { get; set; } = 0f;
        public float realtimeSinceStartup { get; set; } = 0f;

        public void StepFrame() {
            frameCount++;
            time += deltaTime;
            realtimeSinceStartup += deltaTime;
        }

        public void StepFrames(int frames) {
            frameCount += frames;
            time += deltaTime * frames;
            realtimeSinceStartup += deltaTime * frames;
        }
    }
}
