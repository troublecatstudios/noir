using System.Collections.Generic;

namespace Noir.Testing.Assertions {
    public static class DictionaryAssertions {
        public static ICustomAssertionContext<KeyValuePair<TKey, TValue>> Entry<TKey, TValue>(this ICustomAssertionContext<IDictionary<TKey, TValue>> context, TKey key) {
            var pair = new KeyValuePair<TKey, TValue>(key, default(TValue));
            if (context.Target.TryGetValue(key, out var value)) {
                pair = new KeyValuePair<TKey, TValue>(key, value);
            }
            return new CustomAssertionContext<KeyValuePair<TKey, TValue>>() { Target = pair };
        }
    }

    public static class KeyValuePairAssertions {
        public static ICustomAssertionContext<TKey> Key<TKey, TValue>(this ICustomAssertionContext<KeyValuePair<TKey, TValue>> context) {
            return new CustomAssertionContext<TKey>() { Target = context.Target.Key };
        }
        public static ICustomAssertionContext<TValue> Value<TKey, TValue>(this ICustomAssertionContext<KeyValuePair<TKey, TValue>> context) {
            return new CustomAssertionContext<TValue>() { Target = context.Target.Value };
        }
    }
}