using System.Collections.Generic;

namespace Noir.Testing.Assertions {
    public static class DictionaryAssertions {
        public static IAssertionContext<KeyValuePair<TKey, TValue>> Entry<TKey, TValue>(this IAssertionContext<IDictionary<TKey, TValue>> context, TKey key) {
            var pair = new KeyValuePair<TKey, TValue>(key, default(TValue));
            if (context.Target.TryGetValue(key, out var value)) {
                pair = new KeyValuePair<TKey, TValue>(key, value);
            }
            return new AssertionContext<KeyValuePair<TKey, TValue>>() { Target = pair };
        }
    }

    public static class KeyValuePairAssertions {
        public static IAssertionContext<TKey> Key<TKey, TValue>(this IAssertionContext<KeyValuePair<TKey, TValue>> context) {
            return new AssertionContext<TKey>() { Target = context.Target.Key };
        }
        public static IAssertionContext<TValue> Value<TKey, TValue>(this IAssertionContext<KeyValuePair<TKey, TValue>> context) {
            return new AssertionContext<TValue>() { Target = context.Target.Value };
        }
    }
}
