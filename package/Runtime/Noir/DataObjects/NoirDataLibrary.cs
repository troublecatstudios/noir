using System;
using System.Collections.Generic;
using System.Linq;
using Noir.Attributes;
using Noir.Audio;
using Noir.Logging;
using Noir.Variables;
using UnityEngine;

namespace Noir.DataObjects {
    /// <summary>
    /// Central data registry for Noir game assets and runtime-accessible variables.
    /// </summary>
    /// <remarks>
    /// The <see cref="NoirDataLibrary"/> acts as a globally accessible repository for
    /// <see cref="SoundEffect"/> and <see cref="DataVariable"/> assets.
    /// It automatically loads itself from the Unity <c>Resources</c> folder and provides
    /// cached lookups to improve performance during repeated access.
    /// </remarks>
    [AutomaticallyCreate(customPathPrefix: "TroubleCatStudios/Noir/Resources/")]
    public class NoirDataLibrary : ScriptableObject {
        private static NoirDataLibrary _instance;

        /// <summary>
        /// Gets the globally accessible instance of the <see cref="NoirDataLibrary"/>.
        /// </summary>
        /// <remarks>
        /// The instance is automatically loaded from the <c>Resources</c> folder at runtime.
        /// This ensures that systems referencing shared data—such as audio managers or
        /// gameplay logic—can access it without explicit references in the scene.
        /// </remarks>
        public static NoirDataLibrary Instance {
            get {
                if (!_instance) _instance = Resources.Load<NoirDataLibrary>(nameof(NoirDataLibrary));
                return _instance;
            }
        }

        private Dictionary<string, object> _lookupCache = new Dictionary<string, object>();

        /// <summary>
        /// Collection of sound effects available to the game.
        /// </summary>
        public List<SoundEffect> SoundEffects;

        /// <summary>
        /// Collection of data variables that may be referenced by scripts, systems, or configuration.
        /// </summary>
        public List<DataVariable> Variables;

        /// <summary>
        /// Retrieves a <see cref="SoundEffect"/> by name, using cached lookup when possible.
        /// </summary>
        /// <param name="name">The name of the sound effect asset.</param>
        /// <returns>
        /// The matching <see cref="SoundEffect"/> instance if found; otherwise, <c>null</c>.
        /// </returns>
        public SoundEffect GetSoundEffectByName(string name) => GetCachedObject<SoundEffect>(name, SoundEffects);

        /// <summary>
        /// Retrieves a <see cref="DataVariable"/> of the specified type by name.
        /// </summary>
        /// <typeparam name="T">The variable type, derived from <see cref="DataVariable"/>.</typeparam>
        /// <param name="name">The name of the variable to look up.</param>
        /// <returns>
        /// The variable instance of type <typeparamref name="T"/> if found; otherwise, <c>null</c>.
        /// </returns>
        /// <remarks>
        /// If the variable is not found, a warning is logged and <c>null</c> is returned.
        /// </remarks>
        public T GetVariableByName<T>(string name) where T : DataVariable => (T)GetCachedObject<DataVariable>(name, Variables);

        /// <summary>
        /// Retrieves an object of type <typeparamref name="T"/> from a provided list,
        /// using the cache to avoid redundant searches.
        /// </summary>
        /// <typeparam name="T">The Unity object type to retrieve.</typeparam>
        /// <param name="lookup">The object's name.</param>
        /// <param name="lookupSource">The list to search.</param>
        /// <returns>
        /// The matching object if found; otherwise, <c>null</c>.
        /// </returns>
        private T GetCachedObject<T>(string lookup, List<T> lookupSource) where T : UnityEngine.Object {
            var key = CreateKey(lookup, typeof(T));
            if (_lookupCache.TryGetValue(key, out var cached)) {
                return cached as T;
            }
            var item = lookupSource.FirstOrDefault(se => se.name == lookup);
            if (item) {
                _lookupCache.Add(key, item);
            } else {
                LoggerSingleton.Warn<NoirDataLibrary>($"Lookup for '{lookup}' of type '{typeof(T).Name}' failed. The library will return a default value. This may cause unwanted behaviour.");
            }
            return item;
        }

        private string CreateKey(string name, Type objectType) => $"{name}_{objectType}";
    }
}