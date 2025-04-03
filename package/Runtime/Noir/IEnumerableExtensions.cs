using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Noir {
    public static class IEnumerableExtensions {
        public static bool ContainsAny(this IEnumerable<string> sequence, string element, StringComparison comparisonType) {
            return sequence.Any((s) => s.Equals(element, comparisonType));
        }

        public static int IndexWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate) {
            int index = 0;
            var e = source.GetEnumerator();
            while (e.MoveNext()) {
                if (predicate(e.Current)) {
                    return index;
                }
                index++;
            }

            return -1;
        }

        public static T RandomElementByWeight<T>(this IEnumerable<T> sequence, Func<T, float> weightSelector) {
            float totalWeight = sequence.Sum(weightSelector);
            // The weight we are after...
            float itemWeightIndex = ((float)new System.Random().NextDouble()) * totalWeight;
            float currentWeightIndex = 0;

            foreach (var item in from weightedItem in sequence select new { Value = weightedItem, Weight = weightSelector(weightedItem) }) {
                currentWeightIndex += item.Weight;

                // If we've hit or passed the weight we are after for this item then it's the one we want....
                if (currentWeightIndex >= itemWeightIndex)
                    return item.Value;
            }

            return default;
        }

        /// <summary>
        /// Determines if the enumerable has any items without throwing a NullReferenceException.
        /// </summary>
        /// <param name="enumerable"></param>
        /// <returns><c>true</c> if the enumerable is null or has no items, <c>false</c> otherwise.</returns>
        public static bool IsEmptySafe(this IEnumerable enumerable) {
            if (enumerable == null) return true;
            var e = enumerable.GetEnumerator();
            if (e.MoveNext()) return false;
            return true;
        }

        public static T Random<T>(this IEnumerable<T> sequence) {
            if (sequence == null || sequence.Count() == 0) return default(T);
            // this ensures a more random distribution of items across smaller sequences
            int max = sequence.Count();
            int rate = UnityEngine.Random.Range(0, 101);
            int idx = Mathf.Clamp(Mathf.RoundToInt(max * rate / 100f), 0, max - 1);
            return sequence.Skip(idx).First();
        }
    }
}