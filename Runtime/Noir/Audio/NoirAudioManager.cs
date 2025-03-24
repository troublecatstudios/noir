using System;
using System.Collections;
using Noir.Attributes;
using Noir.Audio.Events;
using Noir.DataObjects;
using Noir.Events;
using UnityEngine;
using UnityEngine.Audio;

namespace Noir.Audio {
    public class NoirAudioManager : NoirSingletonBehaviour<NoirAudioManager>, INoirAudioManager, INoirEventListener<PlaySoundEffectEvent>, INoirEventListener<PlayDetachedSoundEffectEvent> {
        [SerializeField]
        [GetComponent]
        private AudioSourcePool _soundEffectPool;

        [SerializeField] private AudioMixerGroup _defaultEffectMixerGroup;

        protected override void SingletonAwake() {
            base.SingletonAwake();
            ServiceLocator.RegisterService<INoirAudioManager>(this);
            ServiceLocator.GetService<INoirEventRegistry>().Register<PlaySoundEffectEvent>(gameObject);
            ServiceLocator.GetService<INoirEventRegistry>().Register<PlayDetachedSoundEffectEvent>(gameObject);
        }

        public bool TryPlaySoundEffect(string effectName, Transform sourceObject = null, float delay = 0f, float volume = 1, float pitch = 1, bool loop = false, AudioMixerGroup mixerGroup = null) {
            var effect = GetEffectByName(effectName);
            return TryPlaySoundEffect(effect, sourceObject?.transform.position ?? transform.position, delay, volume, pitch, loop, mixerGroup);
        }

        public bool TryPlaySoundEffect(string effectName, Vector3? origin = null, float delay = 0f, float volume = 1, float pitch = 1, bool loop = false, AudioMixerGroup mixerGroup = null) {
            var effect = GetEffectByName(effectName);
            return TryPlaySoundEffect(effect, origin, delay, volume, pitch, loop, mixerGroup);
        }

        public bool TryPlaySoundEffect(SoundEffect effect, Transform sourceObject = null, float delay = 0f, float volume = 1, float pitch = 1, bool loop = false, AudioMixerGroup mixerGroup = null) {

            return TryPlaySoundEffect(effect, sourceObject?.transform.position ?? transform.position, delay, volume, pitch, loop, mixerGroup);
        }

        public bool TryPlaySoundEffect(SoundEffect effect, Vector3? origin = null, float delay = 0f, float volume = 1, float pitch = 1, bool loop = false, AudioMixerGroup mixerGroup = null) {

#if UNITY_EDITOR
            if (!Application.isPlaying) return false;
#endif
            if (!effect) return false;
            var listener = GameObject.FindObjectOfType<AudioListener>();
            int id = effect.GetInstanceID();
            if (!_soundEffectPool.TryGetItemFromPool(out var source)) {
                Logger.Warn($"Unable to find an available audio source for effect. effect={effect.name}, effectId={id}");
                return false;
            }

            // account for volume setting on SoundEffect
            volume *= effect.VolumeScale;
            pitch *= effect.Pitch;
            var position = transform.position;
            if (origin != null) position = origin.Value;

            var clip = effect.GetClip();
            mixerGroup = mixerGroup ?? effect.MixerGroup ?? _defaultEffectMixerGroup;

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

            Action playAction = () => {
                PlayClip(clip, source, mixerGroup, position, volume, pitch, pan: 0, spatialBlend: effect.SpatialBlend, minDist: 0, maxDist: maxDist, loop: loop);
            };
            if (delay > 0f || effect.DelayStart) {
                delay = Mathf.Max(delay, effect.Delay);
                StartCoroutine(Delay(delay, () => {
                    playAction();
                }));
                return true;
            }
            playAction();
            return true;
        }

        public void StopEffect(string name) {
            var fx = GetEffectByName(name);
            foreach (var source in _soundEffectPool.GetActiveItems()) {
                if (source.clip && fx.AudioClips.Contains(source.clip)) {
                    source.Stop();
                }
            }
        }

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

        void INoirEventListener<PlaySoundEffectEvent>.EventReceived(PlaySoundEffectEvent eventData) {
            TryPlaySoundEffect(eventData.SoundEffectName, origin: eventData.WorldPosition, delay: eventData.Delay, volume: eventData.Volume,  pitch: eventData.Pitch, loop: eventData.Loop, mixerGroup: eventData.MixerGroup);
        }

        void INoirEventListener<PlayDetachedSoundEffectEvent>.EventReceived(PlayDetachedSoundEffectEvent eventData) {
            TryPlaySoundEffect(eventData.SoundEffectName, sourceObject: null, delay: eventData.Delay, volume: eventData.Volume,  pitch: eventData.Pitch, loop: eventData.Loop, mixerGroup: eventData.MixerGroup);
        }
    }
}