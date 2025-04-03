using Noir.Abstractions;
using UnityEngine;

namespace Noir {
    public class GameTime : IGameTime {
        public const float FPS60 = 16.66667f;
        public const long FPS60L = 16;
        public const float FPS30 = 33.33334f;
        public const long FPS30L = 33;
        public const float FPS24 = 41.66667f;
        public const long FPS24L = 41;
        public const float FPS12 = 83.33334f;
        public const long FPS12L = 83;

        public static readonly GameTime Instance = new();
        public float deltaTime => Time.deltaTime;
        public float fixedDeltaTime => Time.fixedDeltaTime;
        public int frameCount => Time.frameCount;
        public float time => Time.time;
        public float realtimeSinceStartup => Time.realtimeSinceStartup;
    }
}