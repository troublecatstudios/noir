using UnityEngine.Audio;

namespace Noir.Audio.Events {
    public class PlayDetachedSoundEffectEvent {
        public string SoundEffectName { get; set; }
        public float Delay { get; set; } = 0f;
        public float Volume { get; set; } = 1f;
        public float Pitch { get; set; } = 1f;
        public bool Loop { get; set; } = false;
        public AudioMixerGroup MixerGroup { get; set; }
    }
}