using System.Collections.Generic;

namespace Noir.Testing.Assertions {
    /// <summary>
    /// Provides assertion extensions for working with <see cref="IDictionary{TKey, TValue}"/> instances.
    /// </summary>
    public static class DictionaryAssertions {
        /// <summary>
        /// Creates a new assertion context for the dictionary entry associated with the specified key.
        /// </summary>
        /// <typeparam name="TKey">The type of the dictionary’s keys.</typeparam>
        /// <typeparam name="TValue">The type of the dictionary’s values.</typeparam>
        /// <param name="context">The assertion context containing the target dictionary.</param>
        /// <param name="key">The key of the entry to create an assertion context for.</param>
        /// <returns>
        /// An <see cref="IAssertionContext{T}"/> containing a <see cref="KeyValuePair{TKey, TValue}"/>
        /// representing the specified key and its corresponding value (or the default value if the key does not exist).
        /// </returns>
        public static IAssertionContext<KeyValuePair<TKey, TValue>> Entry<TKey, TValue>(this IAssertionContext<IDictionary<TKey, TValue>> context, TKey key) {
            var pair = new KeyValuePair<TKey, TValue>(key, default(TValue));
            if (context.Target.TryGetValue(key, out var value)) {
                pair = new KeyValuePair<TKey, TValue>(key, value);
            }
            return new AssertionContext<KeyValuePair<TKey, TValue>>() { Target = pair };
        }
    }

    /// <summary>
    /// Provides assertion extensions for working with <see cref="KeyValuePair{TKey, TValue}"/> instances.
    /// </summary>
    public static class KeyValuePairAssertions {
        /// <summary>
        /// Creates a new assertion context for the <see cref="KeyValuePair{TKey, TValue}.Key"/> value.
        /// </summary>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="context">The assertion context containing the target key-value pair.</param>
        /// <returns>
        /// An <see cref="IAssertionContext{T}"/> containing the key component of the key-value pair.
        /// </returns>
        public static IAssertionContext<TKey> Key<TKey, TValue>(this IAssertionContext<KeyValuePair<TKey, TValue>> context) {
            return new AssertionContext<TKey>() { Target = context.Target.Key };
        }

        /// <summary>
        /// Creates a new assertion context for the <see cref="KeyValuePair{TKey, TValue}.Value"/> value.
        /// </summary>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="context">The assertion context containing the target key-value pair.</param>
        /// <returns>
        /// An <see cref="IAssertionContext{T}"/> containing the value component of the key-value pair.
        /// </returns>
        public static IAssertionContext<TValue> Value<TKey, TValue>(this IAssertionContext<KeyValuePair<TKey, TValue>> context) {
            return new AssertionContext<TValue>() { Target = context.Target.Value };
        }
    }
}