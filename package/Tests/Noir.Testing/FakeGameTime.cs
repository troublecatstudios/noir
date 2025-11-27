using Noir.Abstractions;

namespace Noir.Testing {
    /// <summary>
    /// A fake or stubbed instance of <see cref="IGameTime"/> for use within tests.
    /// </summary>
    public class FakeGameTime : IGameTime {
        /// <inheritdoc />
        public float deltaTime { get; set; } = 0.0166667f;

        /// <inheritdoc />
        public float fixedDeltaTime { get; set; } = 0.0333333f;

        /// <inheritdoc />
        public int frameCount { get; set; } = 0;

        /// <inheritdoc />
        public float time { get; set; } = 0f;

        /// <inheritdoc />
        public float realtimeSinceStartup { get; set; } = 0f;

        /// <summary>
        /// Increments the frame count by 1 and advances the internal time by the <see cref="deltaTime"/> value.
        /// </summary>
        public void StepFrame() {
            frameCount++;
            time += deltaTime;
            realtimeSinceStartup += deltaTime;
        }

        /// <summary>
        /// Increments the frame count by the given number of frames. The internal time is advanced by the
        /// <see cref="deltaTime"/> value multiplied by the given number of frames.
        /// </summary>
        /// <param name="frames">The number of frames to advance</param>
        public void StepFrames(int frames) {
            frameCount += frames;
            time += deltaTime * frames;
            realtimeSinceStartup += deltaTime * frames;
        }
    }
}