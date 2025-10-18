using System;

namespace Noir {
    /// <summary>
    /// Provides extension methods and utilities for working with collections.
    /// </summary>
    public static class Collections {
        /// <summary>
        /// Performs an insertion sort on the given array up to the specified length.
        /// </summary>
        /// <typeparam name="T">The type of elements in the array. Must implement <see cref="IComparable{T}"/> and <see cref="IEquatable{T}"/>.</typeparam>
        /// <param name="array">The array to sort.</param>
        /// <param name="length">The number of elements to sort from the start of the array.</param>
        /// <returns>The sorted array.</returns>
        public static T[] Sort<T>(T[] array, int length) where T : IComparable<T>, IEquatable<T> {
            for (int i = 1; i < length; i++) {
                var key = array[i];
                var flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;) {
                    if (key.CompareTo(array[j]) < 0) {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = key;
                    } else flag = 1;
                }
            }
            return array;
        }
    }
}