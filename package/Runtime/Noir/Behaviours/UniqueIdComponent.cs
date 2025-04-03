using System;
using UnityEngine;

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif

namespace Noir.Behaviours {
    public class UniqueIdComponent : NoirBehaviour {
#if ODIN_INSPECTOR
        [ReadOnly]
        [LabelText("Object ID")]
#endif
        [SerializeField] private string _uniqueIdentifier;

        /// <summary>
        /// A generated GUID that uniquely identifies this entity in the game.
        /// </summary>
        public string UID => _uniqueIdentifier;

#if ODIN_INSPECTOR
        [ReadOnly]
        [ShowInInspector]
#endif
        public Guid Guid => Guid.Parse(_uniqueIdentifier);

#if ODIN_INSPECTOR
        [ReadOnly]
        [ShowInInspector]
#endif
        public SeparatedGuid Separated => Guid.Parse(_uniqueIdentifier);

#if ODIN_INSPECTOR
        [ReadOnly]
        [ShowInInspector]
#endif
        public string ShortId => _uniqueIdentifier.Substring(0, 4) + _uniqueIdentifier.Substring(_uniqueIdentifier.Length - 4);

#if ODIN_INSPECTOR
        [Button("Regenerate ID")]
#endif
        public void GenerateUUID() {
            _uniqueIdentifier = System.Guid.NewGuid().ToString();
        }

#if UNITY_EDITOR
        private void OnValidate() {
            if (string.IsNullOrEmpty(_uniqueIdentifier)) {
                GenerateUUID();
            }
        }
#endif
    }
}