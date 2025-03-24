using System.Collections.Generic;

namespace Noir {
    public static class DictionaryExtensions {
        public static void Upsert<T, K>(this Dictionary<T, K> dict, KeyValuePair<T, K> kvp) {
            dict.Upsert(kvp.Key, kvp.Value);
        }

        public static void Upsert<T, K>(this Dictionary<T, K> dict, T key, K value) {
            if (dict.ContainsKey(key)) {
                dict[key] = value;
                return;
            }
            dict.Add(key, value);
        }

        public static void Upsert<T, K>(this Dictionary<T, K> target, IDictionary<T, K> source) {
            foreach (var entry in source) {
                target.Upsert(entry);
            }
        }
    }
}