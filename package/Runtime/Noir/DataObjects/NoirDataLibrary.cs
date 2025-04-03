using System;
using System.Collections.Generic;
using System.Linq;
using Noir.Attributes;
using Noir.Audio;
using Noir.Logging;
using Noir.Variables;
using UnityEngine;

namespace Noir.DataObjects {
    [AutomaticallyCreate(customPathPrefix: "TroubleCatStudios/Noir/Resources/")]
    public class NoirDataLibrary : ScriptableObject {
        private static NoirDataLibrary _instance;
        public static NoirDataLibrary Instance {
            get {
                if (!_instance) _instance = Resources.Load<NoirDataLibrary>(nameof(NoirDataLibrary));
                return _instance;
            }
        }

        private Dictionary<string, object> _lookupCache = new Dictionary<string, object>();

        public List<SoundEffect> SoundEffects;
        public List<DataVariable> Variables;

        public SoundEffect GetSoundEffectByName(string name) => GetCachedObject<SoundEffect>(name, SoundEffects);

        /// <summary>
        /// Gets a variable by name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public T GetVariableByName<T>(string name) where T : DataVariable => (T)GetCachedObject<DataVariable>(name, Variables);

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