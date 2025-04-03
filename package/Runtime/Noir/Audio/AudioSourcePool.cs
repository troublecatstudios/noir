using Noir.Pooling;
using System.Collections.Generic;
using UnityEngine;

namespace Noir.Audio {
    public class AudioSourcePool : BehaviourPoolBase<AudioSource> {
        [SerializeField] private string _itemNamePrefix = "";

        private readonly List<AudioSource> _readyToReturn = new();

        protected override AudioSource CreateNewPoolItem() {
            var itemName = $"{_itemNamePrefix}AudioSource.{TotalItems + 1}";
            var go = new GameObject(itemName);
            var sfxSource = go.AddComponent<AudioSource>();
            sfxSource.playOnAwake = false;
            return sfxSource;
        }

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