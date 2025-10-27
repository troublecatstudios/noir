using System;
using System.Collections.Generic;
using Noir.Events;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;
using UnityEngine.Audio;

namespace Noir.Audio {
    /// <summary>
    /// Represents a configurable sound effect that can play multiple audio clips
    /// with randomized pitch, volume, and optional delays.
    /// </summary>
    [CreateAssetMenu(fileName = "SoundEffect.asset", menuName = "Noir/Sound Effect", order = 0)]
    public class SoundEffect : ScriptableObject {
        [SerializeField] private int _index = 0;
        [SerializeField] private float _minPitch = 0.9f;
        [SerializeField] private float _maxPitch = 1.2f;
        [SerializeField] private float _minVolume = 0.9f;
        [SerializeField] private float _maxVolume = 1.2f;
        [SerializeField] private float _spatialBlend = 0.0f;
        [Tooltip("Whether the sound is played only within the UI")]
        [SerializeField] private bool _isUiOnly = false;

#if ODIN_INSPECTOR
        [SuffixLabel("units")]
        [HideIf("@_isUiOnly")]
#endif
        [SerializeField] private int _maxAudibleDistance = 100;


        /// <summary>
        /// Maximum distance at which the sound is audible.
        /// </summary>
        public float MaxAudibleDistance => _maxAudibleDistance;

        /// <summary>
        /// The list of audio clips this sound effect can play.
        /// </summary>
        public List<AudioClip> AudioClips;

        /// <summary>
        /// Optional mixer group for the sound effect.
        /// </summary>
        public AudioMixerGroup MixerGroup;

        /// <summary>
        /// Randomized volume between the configured min and max.
        /// </summary>
        public float VolumeScale => UnityEngine.Random.Range(_minVolume, _maxVolume);

        /// <summary>
        /// Randomized pitch between the configured min and max.
        /// </summary>
        public float Pitch => UnityEngine.Random.Range(_minPitch, _maxPitch);

        /// <summary>
        /// Maximum number of concurrent instances allowed for this sound effect.
        /// </summary>
        [Range(1, 64)]
        public int ConcurrentLimit = 16;

        /// <summary>
        /// If true, playback will be delayed randomly within <see cref="DelayRange"/>.
        /// </summary>
        public bool DelayStart;

        /// <summary>
        /// Range of possible playback delays in seconds.
        /// </summary>
#if ODIN_INSPECTOR
        [ShowIf("DelayStart")]
        [MinMaxSlider(0.01f, 1f)]
#endif
        public Vector2 DelayRange;

        /// <summary>
        /// Randomly calculated delay in seconds based on <see cref="DelayRange"/>.
        /// Returns 0 if <see cref="DelayStart"/> is false.
        /// </summary>
        public float Delay {
            get {
                if (!DelayStart) return 0f;
                return UnityEngine.Random.Range(DelayRange.x, DelayRange.y);
            }
        }

        /// <summary>
        /// The spatial blend of the sound (0 = 2D, 1 = 3D).
        /// </summary>
        public float SpatialBlend => _spatialBlend;

        /// <summary>
        /// Playback style for selecting audio clips.
        /// </summary>
        public enum SoundEffectPlayStyle {
            /// <summary>
            /// The sound effect clips should be played in order
            /// </summary>
            Sequential,
            /// <summary>
            /// The played clip should be chosen at random
            /// </summary>
            Random,
        }

        /// <summary>
        /// Determines how audio clips are selected when playing.
        /// </summary>
        public SoundEffectPlayStyle Style;

        /// <summary>
        /// Returns an audio clip according to the <see cref="Style"/>.
        /// Sequentially cycles through clips or selects a random clip.
        /// </summary>
        /// <returns>An <see cref="AudioClip"/> to play.</returns>
        public AudioClip GetClip() {
            if (Style == SoundEffectPlayStyle.Random)
                return AudioClips.Random();
            _index++;
            if (_index >= AudioClips.Count) _index = 0;
            return AudioClips[_index];
        }

        /// <summary>
        /// Plays this sound effect on a given <see cref="AudioSource"/>.
        /// </summary>
        /// <param name="effect">The sound effect to play.</param>
        /// <param name="source">The <see cref="AudioSource"/> to play on.</param>
        /// <param name="volumeScale">Optional volume override.</param>
        /// <param name="interrupt">If true, stops any current clip and plays immediately.</param>
        public static void Play(SoundEffect effect, AudioSource source, float? volumeScale = null, bool interrupt = false) {
            source.outputAudioMixerGroup = effect.MixerGroup;
            if (!interrupt) source.PlayOneShot(effect.GetClip(), volumeScale ?? effect.VolumeScale);
            else {
                source.clip = effect.GetClip();
                source.volume = volumeScale ?? effect.VolumeScale;
                source.Play();
            }
        }
    }
}