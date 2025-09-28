using System.Collections.Generic;

namespace Noir.Testing.Assertions {
    public static class DictionaryAssertions {
        /// <summary>
        /// Creates a new assertion context for the dictionary entry with the given key.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="key"></param>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static IAssertionContext<KeyValuePair<TKey, TValue>> Entry<TKey, TValue>(this IAssertionContext<IDictionary<TKey, TValue>> context, TKey key) {
            var pair = new KeyValuePair<TKey, TValue>(key, default(TValue));
            if (context.Target.TryGetValue(key, out var value)) {
                pair = new KeyValuePair<TKey, TValue>(key, value);
            }
            return new AssertionContext<KeyValuePair<TKey, TValue>>() { Target = pair };
        }
    }

    public static class KeyValuePairAssertions {
        /// <summary>
        /// Creates a new assertion context for the Key of the KeyValuePair.
        /// </summary>
        /// <param name="context"></param>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static IAssertionContext<TKey> Key<TKey, TValue>(this IAssertionContext<KeyValuePair<TKey, TValue>> context) {
            return new AssertionContext<TKey>() { Target = context.Target.Key };
        }

        /// <summary>
        /// Creates a new assertion context for the Value of the KeyValuePair.
        /// </summary>
        /// <param name="context"></param>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static IAssertionContext<TValue> Value<TKey, TValue>(this IAssertionContext<KeyValuePair<TKey, TValue>> context) {
            return new AssertionContext<TValue>() { Target = context.Target.Value };
        }
    }
}