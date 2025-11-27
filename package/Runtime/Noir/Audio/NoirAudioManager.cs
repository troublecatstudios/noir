using System;
using System.Collections;
using Noir.Attributes;
using Noir.Audio.Events;
using Noir.DataObjects;
using Noir.Events;
using UnityEngine;
using UnityEngine.Audio;

namespace Noir.Audio {
    /// <summary>
    /// Central audio manager for playing sound effects and audio clips within the game.
    /// Handles pooling of <see cref="AudioSource"/>s and spatialized audio playback.
    /// Implements <see cref="INoirAudioManager"/> and listens to <see cref="PlayAudioClipEvent"/> and <see cref="PlaySoundEffectEvent"/>.
    /// </summary>
    public class NoirAudioManager :
        NoirSingletonBehaviour<NoirAudioManager>,
        INoirAudioManager,
        INoirEventListener<PlayAudioClipEvent>,
        INoirEventListener<PlaySoundEffectEvent> {

        /// <summary>
        /// Pool of audio sources used to play sound effects.
        /// </summary>
        [SerializeField]
        [GetComponent]
        private AudioSourcePool _soundEffectPool;

        /// <summary>
        /// Default audio mixer group used for playback if no other group is specified.
        /// </summary>
        private AudioMixerGroup _playbackMixerGroup;

        /// <inheritdoc/>
        protected override void SingletonAwake() {
            base.SingletonAwake();
            ServiceLocator.RegisterService<INoirAudioManager>(this);
            RegisterListener<PlaySoundEffectEvent>();
            RegisterListener<PlayAudioClipEvent>();
        }

        /// <inheritdoc/>
        protected override void SingletonStart() {
            base.SingletonStart();
            _playbackMixerGroup = NoirProjectConfiguration.Instance.DefaultAudioMixerGroup;
        }

        /// <inheritdoc/>
        public bool TryPlaySoundEffect(string effectName, Transform sourceObject = null, float delay = 0f, float volume = 1, float pitch = 1, bool loop = false, AudioMixerGroup mixerGroup = null) {
            var effect = GetEffectByName(effectName);
            return TryPlaySoundEffect(effect, sourceObject?.transform.position ?? transform.position, delay, volume, pitch, loop, mixerGroup);
        }

        /// <summary>
        /// Attempts to play a sound effect by name.
        /// </summary>
        /// <param name="effectName">The name of the sound effect to play.</param>
        /// <param name="origin">Optional: The world position from which the sound should originate.</param>
        /// <param name="delay">Optional: Delay in seconds before playback begins.</param>
        /// <param name="volume">Optional: Playback volume (default is 1).</param>
        /// <param name="pitch">Optional: Playback pitch (default is 1).</param>
        /// <param name="loop">Optional: Whether the sound should loop.</param>
        /// <param name="mixerGroup">Optional: The <see cref="AudioMixerGroup"/> to route the sound through.</param>
        /// <returns><c>true</c> if the sound was successfully played; otherwise, <c>false</c>.</returns>
        public bool TryPlaySoundEffect(string effectName, Vector3? origin = null, float delay = 0f, float volume = 1, float pitch = 1, bool loop = false, AudioMixerGroup mixerGroup = null) {
            var effect = GetEffectByName(effectName);
            return TryPlaySoundEffect(effect, origin, delay, volume, pitch, loop, mixerGroup);
        }

        /// <summary>
        /// Attempts to play a sound effect by name.
        /// </summary>
        /// <param name="effect">The sound effect to play.</param>
        /// <param name="sourceObject">Optional: The <see cref="Transform"/> from which the sound should originate.</param>
        /// <param name="delay">Optional: Delay in seconds before playback begins.</param>
        /// <param name="volume">Optional: Playback volume (default is 1).</param>
        /// <param name="pitch">Optional: Playback pitch (default is 1).</param>
        /// <param name="loop">Optional: Whether the sound should loop.</param>
        /// <param name="mixerGroup">Optional: The <see cref="AudioMixerGroup"/> to route the sound through.</param>
        /// <returns><c>true</c> if the sound was successfully played; otherwise, <c>false</c>.</returns>
        public bool TryPlaySoundEffect(SoundEffect effect, Transform sourceObject = null, float delay = 0f, float volume = 1, float pitch = 1, bool loop = false, AudioMixerGroup mixerGroup = null) {
            return TryPlaySoundEffect(effect, sourceObject?.transform.position ?? transform.position, delay, volume, pitch, loop, mixerGroup);
        }

        /// <inheritdoc/>
        public bool TryPlaySoundEffect(SoundEffect effect, Vector3? origin = null, float delay = 0f, float volume = 1, float pitch = 1, bool loop = false, AudioMixerGroup mixerGroup = null) {
            var clip = effect.GetClip();
            var position = transform.position;
            var listener = GameObject.FindObjectOfType<AudioListener>();
            if (effect.DelayStart) {
                delay = Mathf.Max(delay, effect.Delay);
            }

            mixerGroup = mixerGroup ?? effect.MixerGroup ?? _playbackMixerGroup;

            // account for volume setting on SoundEffect
            volume *= effect.VolumeScale;
            pitch *= effect.Pitch;

            var maxDist = 100f;
            if (listener && origin != null) {
                maxDist = effect.MaxAudibleDistance;
                var distance = Vector3.Distance(listener.transform.position, origin.Value)/3f;
                position = origin.Value;
                volume = (1f - (distance / maxDist)) * effect.VolumeScale;
                if (distance > maxDist) {
                    Logger.Warn($"audio effect max distance exceeded. effect={effect.name}, distance={distance}, maxDist={maxDist}, listenerPosition={listener.transform.position.ToLogString()}, effectPosition={origin.Value.ToLogString()}");
                    volume = 0f;
                }
            }

            return TryPlayClip(clip, origin ?? position, delay, volume, pitch, loop, mixerGroup, effect.SpatialBlend);
        }

        /// <inheritdoc/>
        public bool TryPlayClip(AudioClip clip, Vector3? origin = null, float delay = 0f, float volume = 1, float pitch = 1, bool loop = false, AudioMixerGroup mixerGroup = null, float spatialBlend = 0f) {
#if UNITY_EDITOR
            if (!Application.isPlaying) return false;
#endif
            if (!clip) return false;

            var clipPosition = origin ?? transform.position;
            var maxDist = 100f;

            if (!_soundEffectPool.TryGetItemFromPool(out var source)) {
                Logger.Warn($"Unable to find an available audio source for effect. clip={clip}");
                return false;
            }

            Action playAction = () => {
                PlayClip(clip, source, mixerGroup, clipPosition, volume, pitch, pan: 0, spatialBlend: spatialBlend, minDist: 0, maxDist: maxDist, loop: loop);
            };
            if (delay > 0f) {
                StartCoroutine(Delay(delay, () => {
                    playAction();
                }));
                return true;
            }
            playAction();
            return true;
        }

        /// <inheritdoc/>
        public void StopEffect(string name) {
            var fx = GetEffectByName(name);
            foreach (var source in _soundEffectPool.GetActiveItems()) {
                if (source.clip && fx.AudioClips.Contains(source.clip)) {
                    source.Stop();
                }
            }
        }

        /// <inheritdoc/>
        public void StopAllEffects() {
            foreach (AudioSource source in _soundEffectPool.GetActiveItems()) {
                if (source) source.Stop();
            }
        }

        private SoundEffect GetEffectByName(string effectName) {
            return NoirDataLibrary.Instance.GetSoundEffectByName(effectName);
        }

        private IEnumerator Delay(float delay, Action callback) {
            yield return new WaitForSeconds(delay);
            callback?.Invoke();
        }

        private void PlayClip(AudioClip clip, AudioSource source, AudioMixerGroup mixer,
            Vector3 position,
            float volume = 1,
            float pitch = 1,
            float pan = 0,
            float spatialBlend = 0,
            float minDist = 1,
            float maxDist = 100,
            bool loop = false) {
            if (volume <= 0f) return;
            source.gameObject.transform.position = position;
            source.pitch = pitch;
            source.clip = clip;
            source.volume = volume;
            source.spatialBlend = spatialBlend;
            source.panStereo = spatialBlend > 0f ? 0.5f : pan;
            source.minDistance = minDist;
            source.maxDistance = maxDist;
            source.outputAudioMixerGroup = mixer;
            source.loop = loop;
            source.Play();
        }

        void INoirEventListener<PlayAudioClipEvent>.EventReceived(PlayAudioClipEvent eventData) {
            TryPlayClip(eventData.Clip, origin: eventData.WorldPosition, delay: eventData.Delay, volume: eventData.Volume,  pitch: eventData.Pitch, loop: eventData.Loop, mixerGroup: eventData.MixerGroup);
        }

        void INoirEventListener<PlaySoundEffectEvent>.EventReceived(PlaySoundEffectEvent eventData) {
            TryPlaySoundEffect(eventData.SoundEffectName, origin: eventData.WorldPosition, delay: eventData.Delay, volume: eventData.Volume,  pitch: eventData.Pitch, loop: eventData.Loop, mixerGroup: eventData.MixerGroup);
        }
    }
}