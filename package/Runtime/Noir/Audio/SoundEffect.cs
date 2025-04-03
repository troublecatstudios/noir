using System;
using System.Collections.Generic;
using Noir.Events;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;
using UnityEngine.Audio;

namespace Noir.Audio {
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


        public float MaxAudibleDistance => _maxAudibleDistance;

        public List<AudioClip> AudioClips;
        public AudioMixerGroup MixerGroup;

        public float VolumeScale => UnityEngine.Random.Range(_minVolume, _maxVolume);
        public float Pitch => UnityEngine.Random.Range(_minPitch, _maxPitch);

        [Range(1, 64)]
        public int ConcurrentLimit = 16;

        public bool DelayStart;

#if ODIN_INSPECTOR
        [ShowIf("DelayStart")]
        [MinMaxSlider(0.01f, 1f)]
#endif
        public Vector2 DelayRange;

        public float Delay {
            get {
                if (!DelayStart) return 0f;
                return UnityEngine.Random.Range(DelayRange.x, DelayRange.y);
            }
        }

        public float SpatialBlend => _spatialBlend;

        public enum SoundEffectPlayStyle {
            Sequential,
            Random,
        }

        public SoundEffectPlayStyle Style;

        public AudioClip GetClip() {
            if (Style == SoundEffectPlayStyle.Random)
                return AudioClips.Random();
            _index++;
            if (_index >= AudioClips.Count) _index = 0;
            return AudioClips[_index];
        }

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