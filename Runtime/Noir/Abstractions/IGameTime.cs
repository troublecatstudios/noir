namespace Noir.Abstractions {
    public interface IGameTime {
        /// <inheritdoc cref="UnityEngine.Time.deltaTime"/>
        float deltaTime { get; }
        /// <inheritdoc cref="UnityEngine.Time.fixedDeltaTime"/>
        float fixedDeltaTime { get; }
        /// <inheritdoc cref="UnityEngine.Time.frameCount"/>
        int frameCount { get; }
        /// <inheritdoc cref="UnityEngine.Time.time"/>
        float time { get; }
        /// <inheritdoc cref="UnityEngine.Time.realtimeSinceStartup"/>
        float realtimeSinceStartup { get; }
    }
}