using Noir.Pooling;
using System.Collections.Generic;
using UnityEngine;

namespace Noir.Audio {
    /// <summary>
    /// A pool for <see cref="AudioSource"/> components, allowing efficient reuse of audio sources.
    /// </summary>
    public class AudioSourcePool : BehaviourPoolBase<AudioSource> {
        [SerializeField] private string _itemNamePrefix = "";

        private readonly List<AudioSource> _readyToReturn = new();

        /// <summary>
        /// Creates a new <see cref="AudioSource"/> instance for the pool.
        /// </summary>
        /// <returns>A freshly created <see cref="AudioSource"/> component.</returns>
        protected override AudioSource CreateNewPoolItem() {
            var itemName = $"{_itemNamePrefix}AudioSource.{TotalItems + 1}";
            var go = new GameObject(itemName);
            var sfxSource = go.AddComponent<AudioSource>();
            sfxSource.playOnAwake = false;
            return sfxSource;
        }

        /// <summary>
        /// Resets the given <see cref="AudioSource"/> to default values before returning it to the pool.
        /// </summary>
        /// <param name="item">The <see cref="AudioSource"/> to reset.</param>
        /// <returns>The reset <see cref="AudioSource"/>.</returns>
        protected override AudioSource ResetItemToDefaults(AudioSource item) {
            item.loop = false;
            item.playOnAwake = false;
            item.outputAudioMixerGroup = null;
            item.gameObject.transform.position = transform.position;
            item.pitch = 1f;
            item.clip = null;
            item.volume = 1f;
            item.spatialBlend = 0f;
            item.panStereo = 0f;
            item.minDistance = 1;
            item.maxDistance = 100;
            return item;
        }

        private void Update() {
            if (GameTime.frameCount % 2 == 0) {
                MarkSourcesReadyForReturn();
            } else ReturnReadySources();
        }

        private void ReturnReadySources() {
            foreach (var source in _readyToReturn) {
                ReturnItemToPool(source);
            }
            _readyToReturn.Clear();
        }

        private void MarkSourcesReadyForReturn() {
            foreach (var source in GetActiveItems()) {
                if (source.isPlaying || (source.loop && source.clip)) continue;
                if (!_readyToReturn.Contains(source)) {
                    _readyToReturn.Add(source);
                }
            }
        }
    }
}