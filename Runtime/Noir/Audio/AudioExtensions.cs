using UnityEngine;

namespace Noir.Audio {
    public static class AudioExtensions {
        public static float GetAudioPlayedPercentage(this AudioSource source) {
            if (source.clip == null || source.time == 0f) {
                return 0f;
            }
            return source.time / source.clip.length * 100f;
        }

        public static bool IsAudioPaused(this AudioSource source) {
            return !source.isPlaying && GetAudioPlayedPercentage(source) > 0f;
        }

        public static bool IsClipReadyToPlay(this AudioClip clip) {
            return clip.loadType != AudioClipLoadType.Streaming;
        }
    }
}