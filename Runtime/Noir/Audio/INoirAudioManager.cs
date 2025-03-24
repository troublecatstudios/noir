using UnityEngine;
using UnityEngine.Audio;

namespace Noir.Audio {
    public interface INoirAudioManager {
        bool TryPlaySoundEffect(string effectName, Transform sourceObject = null, float delay = 0f, float volume = 1, float pitch = 1, bool loop = false, AudioMixerGroup mixerGroup = null);
        bool TryPlaySoundEffect(SoundEffect effect, Vector3? origin = null, float delay = 0f, float volume = 1, float pitch = 1, bool loop = false, AudioMixerGroup mixerGroup = null);
        void StopEffect(string name);
        void StopAllEffects();
    }
}