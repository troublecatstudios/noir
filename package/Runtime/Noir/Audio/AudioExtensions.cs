using UnityEngine;

namespace Noir.Audio {
    public static class AudioExtensions {
        public static float GetAudioPlayedPercentage(this AudioSource source) {
            if (source.clip == null || source.time == 0f) {
                return 0f;
            }
            return source.time / source.clip.length * 100f;
        }

        /// <summary>
        /// Returns a value indicating whether the <see cref="AudioSource"/> is stopped with any play time remaining.
        /// </summary>
        /// <param name="source">The audio source.</param>
        /// <returns><c>true</c> if the audio source is stopped and has time remaining, <c>false</c> otherwise.</returns>
        public static bool IsAudioPaused(this AudioSource source) {
            return !source.isPlaying && GetAudioPlayedPercentage(source) > 0f;
        }

        /// <summary>
        /// Returns a value indicating whether the <see cref="AudioClip"/> is ready to be played.
        /// </summary>
        /// <param name="clip">The audio clip to check.</param>
        /// <returns><c>true</c> if the clip is ready to be played, <c>false</c> otherwise.</returns>
        public static bool IsClipReadyToPlay(this AudioClip clip) {
            return clip.loadType != AudioClipLoadType.Streaming;
        }
    }
}