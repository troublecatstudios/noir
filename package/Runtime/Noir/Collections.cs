using System;

namespace Noir {
    public static class Collections {
        /// <summary>
        /// Performs an insertion sort on the given collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="length"></param>
        /// <returns></returns>
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