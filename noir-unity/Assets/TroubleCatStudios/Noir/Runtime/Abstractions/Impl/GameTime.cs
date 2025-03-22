using UnityEngine;

namespace Noir.Unity.Abstractions.Impl {
    public class GameTime : IGameTime {
        public float deltaTime => Time.deltaTime;
        public float fixedDeltaTime => Time.fixedDeltaTime;
        public int frameCount => Time.frameCount;
        public float time => Time.time;
        public float realtimeSinceStartup => Time.realtimeSinceStartup;
    }
}