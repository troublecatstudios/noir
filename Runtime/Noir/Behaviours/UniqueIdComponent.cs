using System;
using UnityEngine;

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif

namespace Noir.Behaviours {
    /// <summary>
    /// Provides a persistent, unique identifier for a GameObject or entity in the game world.
    /// </summary>
    /// <remarks>
    /// This component assigns a globally unique identifier (GUID) to each object it is attached to.
    /// The identifier remains consistent across play sessions unless regenerated manually.
    /// </remarks>
    public class UniqueIdComponent : NoirBehaviour {
#if ODIN_INSPECTOR
        [ReadOnly]
        [LabelText("Object ID")]
#endif
        [SerializeField] private string _uniqueIdentifier;

        /// <summary>
        /// Gets the raw string form of the unique identifier assigned to this object.
        /// </summary>
        /// <remarks>
        /// This string is a standard GUID, e.g., <c>550e8400-e29b-41d4-a716-446655440000</c>.
        /// </remarks>
        public string UID => _uniqueIdentifier;

        /// <summary>
        /// Gets the unique identifier as a <see cref="System.Guid"/> structure.
        /// </summary>
        /// <exception cref="FormatException">
        /// Thrown if the internal string cannot be parsed into a valid <see cref="Guid"/>.
        /// </exception>
#if ODIN_INSPECTOR
        [ReadOnly]
        [ShowInInspector]
#endif
        public Guid Guid => Guid.Parse(_uniqueIdentifier);

        /// <summary>
        /// Gets the unique identifier represented as a <see cref="SeparatedGuid"/>.
        /// </summary>
        /// <remarks>
        /// This format is used for systems that store GUIDs as separated or segmented components
        /// for serialization or data comparison purposes.
        /// </remarks>
#if ODIN_INSPECTOR
        [ReadOnly]
        [ShowInInspector]
#endif
        public SeparatedGuid Separated => Guid.Parse(_uniqueIdentifier);

        /// <summary>
        /// Gets a shortened representation of the identifier for debugging or display purposes.
        /// </summary>
        /// <remarks>
        /// The format is the first four and last four characters of the GUID, concatenated.
        /// </remarks>
#if ODIN_INSPECTOR
        [ReadOnly]
        [ShowInInspector]
#endif
        public string ShortId => _uniqueIdentifier.Substring(0, 4) + _uniqueIdentifier.Substring(_uniqueIdentifier.Length - 4);

        /// <summary>
        /// Generates a new globally unique identifier (GUID) for this object, replacing the existing one.
        /// </summary>
        /// <remarks>
        /// This method should generally only be used in the editor or during setup.
        /// Changing IDs at runtime can cause inconsistencies in systems relying on stable identifiers.
        /// </remarks>
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