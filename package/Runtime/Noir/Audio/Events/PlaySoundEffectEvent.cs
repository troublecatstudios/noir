using UnityEngine;
using UnityEngine.Audio;

namespace Noir.Audio.Events {
    /// <summary>
    /// Represents an event used to play a <see cref="SoundEffect"/> in the game,
    /// optionally with specific playback parameters such as position, volume, and delay.
    /// </summary>
    public class PlaySoundEffectEvent {
        /// <summary>
        /// Gets or sets the name of the sound effect to be played.
        /// </summary>
        public string SoundEffectName { get; set; }

        /// <summary>
        /// Gets or sets the world position where the sound effect should be played.
        /// If <c>null</c>, the clip is played in a non-spatial (2D) context.
        /// </summary>
        public Vector3? WorldPosition { get; set; }

        /// <summary>
        /// Gets or sets the delay in seconds before the sound effect begins playback.
        /// </summary>
        public float Delay { get; set; } = 0f;

        /// <summary>
        /// Gets or sets the playback volume of the sound effect.
        /// A value of <c>1.0</c> represents the sound effect’s original volume.
        /// </summary>
        public float Volume { get; set; } = 1f;

        /// <summary>
        /// Gets or sets the playback pitch multiplier for the sound effect.
        /// A value of <c>1.0</c> plays the sound effect at its original pitch.
        /// </summary>
        public float Pitch { get; set; } = 1f;

        /// <summary>
        /// Gets or sets a value indicating whether the sound effect should loop continuously.
        /// </summary>
        public bool Loop { get; set; } = false;

        /// <summary>
        /// Gets or sets the audio mixer group that the sound effect should be routed through.
        /// </summary>
        public AudioMixerGroup MixerGroup { get; set; }
    }
}