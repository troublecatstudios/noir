using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Noir {
    /// <summary>
    /// An <see cref="IDictionary{TKey,TValue}"/> that can be serialized as
    /// part of a Unity object.
    /// </summary>
    /// <remarks>
    /// Prior to Unity 2020, dictionaries cannot be directly serialized by
    /// Unity. This class is a workaround; it provides an API identical to
    /// <see cref="System.Collections.Generic.Dictionary{TKey,TValue}"/>, and stores its contents as
    /// two <see cref="System.Collections.Generic.List{T}"/>s: one for <typeparamref name="TKey"/>,
    /// and one for <typeparamref name="TValue"/>.
    /// </remarks>
    /// <typeparam name="TKey">The type of key used in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of value used in the dictionary.</typeparam>
    /// <inheritdoc cref="IDictionary{TKey, TValue}"/>
    [System.Serializable]
    public class SerializedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ISerializationCallbackReceiver
    {
        [SerializeField] private List<TKey> keys;
        [SerializeField] private List<TValue> values;

        private readonly Dictionary<TKey, TValue> table = new Dictionary<TKey, TValue>();

        /// <summary>
        /// Creates a new <see cref="SerializedDictionary{TKey, TValue}"/> populated with the contents of a standard <see cref="Dictionary{TKey, TValue}"/>.
        /// </summary>
        /// <param name="dictionary">The dictionary to copy entries from.</param>
        /// <returns>A new <see cref="SerializedDictionary{TKey, TValue}"/> containing the same key-value pairs.</returns>
        public static SerializedDictionary<TKey, TValue> From(Dictionary<TKey, TValue> dictionary) {
            var serializedDictionary = new SerializedDictionary<TKey, TValue>();
            serializedDictionary.Clear();
            foreach (var entry in dictionary) {
                serializedDictionary.Add(entry.Key, entry.Value);
            }
            return serializedDictionary;
        }

        /// <summary>
        /// Gets a collection containing the keys in the dictionary.
        /// </summary>
        public ICollection<TKey> Keys => ((IDictionary<TKey, TValue>)table).Keys;

        /// <summary>
        /// Gets a collection containing the values in the dictionary.
        /// </summary>
        public ICollection<TValue> Values => ((IDictionary<TKey, TValue>)table).Values;

        /// <summary>
        /// Gets the number of key-value pairs contained in the dictionary.
        /// </summary>
        public int Count => ((ICollection<KeyValuePair<TKey, TValue>>)table).Count;

        /// <summary>
        /// Gets a value indicating whether the dictionary is read-only.
        /// </summary>
        public bool IsReadOnly => ((ICollection<KeyValuePair<TKey, TValue>>)table).IsReadOnly;

        /// <summary>
        /// Gets or sets the value associated with the specified key.
        /// </summary>
        /// <param name="key">The key of the value to get or set.</param>
        /// <returns>The value associated with the specified key.</returns>
        public TValue this[TKey key] { get => ((IDictionary<TKey, TValue>)table)[key]; set => ((IDictionary<TKey, TValue>)table)[key] = value; }

        /// <summary>
        /// Adds a key-value pair to the dictionary.
        /// </summary>
        /// <param name="key">The key of the element to add.</param>
        /// <param name="value">The value of the element to add.</param>
        public void Add(TKey key, TValue value)
        {
            ((IDictionary<TKey, TValue>)table).Add(key, value);
        }

        /// <summary>
        /// Determines whether the dictionary contains the specified key.
        /// </summary>
        /// <param name="key">The key to locate in the dictionary.</param>
        /// <returns><c>true</c> if the dictionary contains an element with the specified key; otherwise, <c>false</c>.</returns>
        public bool ContainsKey(TKey key)
        {
            return ((IDictionary<TKey, TValue>)table).ContainsKey(key);
        }

        /// <summary>
        /// Removes the element with the specified key from the dictionary.
        /// </summary>
        /// <param name="key">The key of the element to remove.</param>
        /// <returns><c>true</c> if the element is successfully removed; otherwise, <c>false</c>.</returns>
        public bool Remove(TKey key)
        {
            ((IDictionary)table).Remove(key);
            return true;
        }

        /// <summary>
        /// Attempts to get the value associated with the specified key.
        /// </summary>
        /// <param name="key">The key of the value to get.</param>
        /// <param name="value">When this method returns, contains the value associated with the specified key, if found.</param>
        /// <returns><c>true</c> if the key was found; otherwise, <c>false</c>.</returns>
        public bool TryGetValue(TKey key, out TValue value)
        {
            return ((IDictionary<TKey, TValue>)table).TryGetValue(key, out value);
        }

        /// <summary>
        /// Adds the specified key-value pair to the dictionary.
        /// </summary>
        /// <param name="item">The key-value pair to add.</param>
        public void Add(KeyValuePair<TKey, TValue> item)
        {
            ((ICollection<KeyValuePair<TKey, TValue>>)table).Add(item);
        }

        /// <summary>
        /// Removes all elements from the dictionary.
        /// </summary>
        public void Clear()
        {
            ((ICollection<KeyValuePair<TKey, TValue>>)table).Clear();
        }

        /// <summary>
        /// Determines whether the dictionary contains the specified key-value pair.
        /// </summary>
        /// <param name="item">The key-value pair to locate in the dictionary.</param>
        /// <returns><c>true</c> if the key-value pair exists; otherwise, <c>false</c>.</returns>
        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return ((ICollection<KeyValuePair<TKey, TValue>>)table).Contains(item);
        }

        /// <summary>
        /// Copies the elements of the dictionary to an array, starting at a particular array index.
        /// </summary>
        /// <param name="array">The destination array.</param>
        /// <param name="arrayIndex">The zero-based index in the array at which to begin copying.</param>
        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            ((ICollection<KeyValuePair<TKey, TValue>>)table).CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Removes the specified key-value pair from the dictionary.
        /// </summary>
        /// <param name="item">The key-value pair to remove.</param>
        /// <returns><c>true</c> if the item was successfully removed; otherwise, <c>false</c>.</returns>
        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return ((ICollection<KeyValuePair<TKey, TValue>>)table).Remove(item);
        }

        /// <summary>
        /// Returns an enumerator that iterates through the dictionary.
        /// </summary>
        /// <returns>An enumerator for the dictionary.</returns>
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<TKey, TValue>>)table).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)table).GetEnumerator();
        }

        /// <summary>
        /// Invoked before serialization to populate key and value lists.
        /// </summary>
        void ISerializationCallbackReceiver.OnBeforeSerialize()
        {
            keys = new List<TKey>();
            values = new List<TValue>();

            if (table == null)
            {
                return;
            }

            foreach (var kvp in table)
            {
                keys.Add(kvp.Key);
                values.Add(kvp.Value);
            }
        }

        /// <summary>
        /// Invoked after deserialization to rebuild the dictionary from serialized key and value lists.
        /// </summary>
        void ISerializationCallbackReceiver.OnAfterDeserialize()
        {
            table.Clear();
            for (int i = 0; i != Mathf.Min(keys.Count, values.Count); i++)
            {
                table.Add(keys[i], values[i]);
            }
        }
    }
}