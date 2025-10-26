using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Noir {
    /// <summary>
    /// Provides extension methods for working with <see cref="IEnumerable"/> sequences.
    /// </summary>
    public static class IEnumerableExtensions {

        /// <summary>
        /// Determines whether the sequence contains any string that equals the specified element,
        /// using the provided <see cref="StringComparison"/> type.
        /// </summary>
        /// <param name="sequence">The sequence of strings to search.</param>
        /// <param name="element">The string to compare against elements in the sequence.</param>
        /// <param name="comparisonType">The type of string comparison to use.</param>
        /// <returns><c>true</c> if any string in the sequence matches the element; otherwise, <c>false</c>.</returns>
        public static bool ContainsAny(this IEnumerable<string> sequence, string element, StringComparison comparisonType) {
            return sequence.Any((s) => s.Equals(element, comparisonType));
        }

        /// <summary>
        /// Returns the index of the first element in the sequence that satisfies the specified predicate.
        /// </summary>
        /// <typeparam name="T">The type of elements in the sequence.</typeparam>
        /// <param name="source">The sequence to search.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>
        /// The zero-based index of the first element that matches the predicate;
        /// or -1 if no element matches.
        /// </returns>
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

        /// <summary>
        /// Selects a random element from the sequence based on weighted probabilities.
        /// </summary>
        /// <typeparam name="T">The type of elements in the sequence.</typeparam>
        /// <param name="sequence">The sequence from which to select an element.</param>
        /// <param name="weightSelector">A function that returns the weight of each element.</param>
        /// <returns>
        /// A randomly selected element, where elements with higher weights have a greater chance of being chosen.
        /// Returns the default value of <typeparamref name="T"/> if the sequence is empty.
        /// </returns>
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
        /// Determines if the enumerable has any items without throwing a <see cref="NullReferenceException"/>.
        /// </summary>
        /// <param name="enumerable">The enumerable to check.</param>
        /// <returns><c>true</c> if the enumerable is null or has no items; otherwise, <c>false</c>.</returns>
        public static bool IsEmptySafe(this IEnumerable enumerable) {
            if (enumerable == null) return true;
            var e = enumerable.GetEnumerator();
            if (e.MoveNext()) return false;
            return true;
        }

        /// <summary>
        /// Returns a random element from the sequence, using a pseudo-random distribution
        /// that provides more even coverage across smaller sequences.
        /// </summary>
        /// <typeparam name="T">The type of elements in the sequence.</typeparam>
        /// <param name="sequence">The sequence from which to select an element.</param>
        /// <returns>
        /// A randomly selected element from the sequence, or the default value of <typeparamref name="T"/> if the sequence is null or empty.
        /// </returns>
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