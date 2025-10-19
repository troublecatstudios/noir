using Noir.Abstractions;
using UnityEngine;

namespace Noir {
    /// <summary>
    /// Represents a wrapper for Unity's <see cref="Time"/> class, providing
    /// convenient access to frame timing values and constants for common frame rates.
    /// </summary>
    public class GameTime : IGameTime {
        /// <summary>
        /// The duration of one frame at 60 frames per second, in milliseconds.
        /// </summary>
        public const float FPS60 = 16.66667f;

        /// <summary>
        /// The integer duration of one frame at 60 frames per second, in milliseconds.
        /// </summary>
        public const long FPS60L = 16;

        /// <summary>
        /// The duration of one frame at 30 frames per second, in milliseconds.
        /// </summary>
        public const float FPS30 = 33.33334f;

        /// <summary>
        /// The integer duration of one frame at 30 frames per second, in milliseconds.
        /// </summary>
        public const long FPS30L = 33;

        /// <summary>
        /// The duration of one frame at 24 frames per second, in milliseconds.
        /// </summary>
        public const float FPS24 = 41.66667f;

        /// <summary>
        /// The integer duration of one frame at 24 frames per second, in milliseconds.
        /// </summary>
        public const long FPS24L = 41;

        /// <summary>
        /// The duration of one frame at 12 frames per second, in milliseconds.
        /// </summary>
        public const float FPS12 = 83.33334f;

        /// <summary>
        /// The integer duration of one frame at 12 frames per second, in milliseconds.
        /// </summary>
        public const long FPS12L = 83;

        /// <summary>
        /// A shared singleton instance of the <see cref="GameTime"/> class.
        /// </summary>
        public static readonly GameTime Instance = new();

        /// <summary>
        /// Gets the time in seconds it took to complete the last frame.
        /// </summary>
        public float deltaTime => Time.deltaTime;

        /// <summary>
        /// Gets the fixed time step in seconds between physics updates.
        /// </summary>
        public float fixedDeltaTime => Time.fixedDeltaTime;

        /// <summary>
        /// Gets the total number of frames that have been rendered since the start of the game.
        /// </summary>
        public int frameCount => Time.frameCount;

        /// <summary>
        /// Gets the time in seconds since the start of the game.
        /// </summary>
        public float time => Time.time;

        /// <summary>
        /// Gets the real time in seconds since the game started, unaffected by time scale.
        /// </summary>
        public float realtimeSinceStartup => Time.realtimeSinceStartup;
    }
}