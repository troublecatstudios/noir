using System;
using System.Collections.Generic;
using System.Linq;

namespace Noir {
    /// <summary>
    /// Provides helper methods for interacting with <see cref="System.Enum"/> values.
    /// </summary>
    public static class NoirEnum {

        /// <summary>
        /// Returns an enumerable collection of all possible values of the specified enum type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">
        /// The enum type to retrieve values for. Must be an enumeration type.
        /// </typeparam>
        /// <returns>
        /// An <see cref="IEnumerable{T}"/> containing all values defined in the enum <typeparamref name="T"/>.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Thrown if <typeparamref name="T"/> is not an enum type.
        /// </exception>
        public static IEnumerable<T> AllValuesFor<T>() {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}