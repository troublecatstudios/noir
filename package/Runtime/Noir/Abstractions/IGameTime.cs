// ReSharper disable InconsistentNaming
namespace Noir.Abstractions {
    /// <summary>
    /// Provides an abstraction layer over Unity's <see cref="UnityEngine.Time"/> API,
    /// exposing commonly used time-related properties such as <see cref="deltaTime"/> and <see cref="time"/>.
    /// This interface allows game systems to access time values without directly depending on Unity's static <see cref="UnityEngine.Time"/> class,
    /// making it easier to create deterministic simulations, mock time in tests, or implement custom time sources.
    /// </summary>
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