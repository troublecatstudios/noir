using UnityEngine;
using UnityEngine.Audio;

namespace Noir.Audio {
    /// <summary>
    /// Interface for managing audio playback, including sound effects and audio clips.
    /// </summary>
    public interface INoirAudioManager {
        /// <summary>
        /// Attempts to play a sound effect by name.
        /// </summary>
        /// <param name="effectName">The name of the sound effect to play.</param>
        /// <param name="sourceObject">Optional: The <see cref="Transform"/> from which the sound should originate.</param>
        /// <param name="delay">Optional: Delay in seconds before playback begins.</param>
        /// <param name="volume">Optional: Playback volume (default is 1).</param>
        /// <param name="pitch">Optional: Playback pitch (default is 1).</param>
        /// <param name="loop">Optional: Whether the sound should loop.</param>
        /// <param name="mixerGroup">Optional: The <see cref="AudioMixerGroup"/> to route the sound through.</param>
        /// <returns><c>true</c> if the sound was successfully played; otherwise, <c>false</c>.</returns>
        bool TryPlaySoundEffect(string effectName, Transform sourceObject = null, float delay = 0f, float volume = 1, float pitch = 1, bool loop = false, AudioMixerGroup mixerGroup = null);

        /// <summary>
        /// Attempts to play a <see cref="SoundEffect"/> instance.
        /// </summary>
        /// <param name="effect">The sound effect to play.</param>
        /// <param name="origin">Optional: The world position from which the sound should originate.</param>
        /// <param name="delay">Optional: Delay in seconds before playback begins.</param>
        /// <param name="volume">Optional: Playback volume (default is 1).</param>
        /// <param name="pitch">Optional: Playback pitch (default is 1).</param>
        /// <param name="loop">Optional: Whether the sound should loop.</param>
        /// <param name="mixerGroup">Optional: The <see cref="AudioMixerGroup"/> to route the sound through.</param>
        /// <returns><c>true</c> if the sound was successfully played; otherwise, <c>false</c>.</returns>
        bool TryPlaySoundEffect(SoundEffect effect, Vector3? origin = null, float delay = 0f, float volume = 1, float pitch = 1, bool loop = false, AudioMixerGroup mixerGroup = null);

        /// <summary>
        /// Attempts to play a raw <see cref="AudioClip"/>.
        /// </summary>
        /// <param name="clip">The audio clip to play.</param>
        /// <param name="origin">Optional: The world position from which the sound should originate.</param>
        /// <param name="delay">Optional: Delay in seconds before playback begins.</param>
        /// <param name="volume">Optional: Playback volume (default is 1).</param>
        /// <param name="pitch">Optional: Playback pitch (default is 1).</param>
        /// <param name="loop">Optional: Whether the sound should loop.</param>
        /// <param name="mixerGroup">Optional: The <see cref="AudioMixerGroup"/> to route the sound through.</param>
        /// <param name="spatialBlend">Optional: Blend between 2D and 3D spatialization (0 = 2D, 1 = 3D).</param>
        /// <returns><c>true</c> if the clip was successfully played; otherwise, <c>false</c>.</returns>
        bool TryPlayClip(AudioClip clip, Vector3? origin = null, float delay = 0f, float volume = 1, float pitch = 1, bool loop = false, AudioMixerGroup mixerGroup = null, float spatialBlend = 0f);

        /// <summary>
        /// Stops the sound effect with the given name if it is currently playing.
        /// </summary>
        /// <param name="name">The name of the sound effect to stop.</param>
        void StopEffect(string name);

        /// <summary>
        /// Stops all currently playing sound effects.
        /// </summary>
        void StopAllEffects();
    }
}