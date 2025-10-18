using System.Collections.Generic;

namespace Noir {
    /// <summary>
    /// Provides extension methods for performing upsert operations on <see cref="Dictionary{TKey, TValue}"/>.
    /// </summary>
    public static class DictionaryExtensions {
        /// <summary>
        /// Inserts a key-value pair into the dictionary, or updates the value if the key already exists.
        /// </summary>
        /// <typeparam name="T">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="K">The type of the values in the dictionary.</typeparam>
        /// <param name="dict">The dictionary to operate on.</param>
        /// <param name="kvp">The key-value pair to upsert.</param>
        public static void Upsert<T, K>(this Dictionary<T, K> dict, KeyValuePair<T, K> kvp) {
            dict.Upsert(kvp.Key, kvp.Value);
        }

        /// <summary>
        /// Inserts a key and value into the dictionary, or updates the value if the key already exists.
        /// </summary>
        /// <typeparam name="T">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="K">The type of the values in the dictionary.</typeparam>
        /// <param name="dict">The dictionary to operate on.</param>
        /// <param name="key">The key to upsert.</param>
        /// <param name="value">The value to upsert.</param>
        public static void Upsert<T, K>(this Dictionary<T, K> dict, T key, K value) {
            if (dict.ContainsKey(key)) {
                dict[key] = value;
                return;
            }
            dict.Add(key, value);
        }

        /// <summary>
        /// Inserts or updates multiple key-value pairs from another dictionary into the target dictionary.
        /// </summary>
        /// <typeparam name="T">The type of the keys in the dictionaries.</typeparam>
        /// <typeparam name="K">The type of the values in the dictionaries.</typeparam>
        /// <param name="target">The target dictionary to receive upserts.</param>
        /// <param name="source">The source dictionary providing key-value pairs.</param>
        public static void Upsert<T, K>(this Dictionary<T, K> target, IDictionary<T, K> source) {
            foreach (var entry in source) {
                target.Upsert(entry);
            }
        }
    }
}