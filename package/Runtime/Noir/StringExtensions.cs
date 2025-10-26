namespace Noir {
    /// <summary>
    /// Provides extension methods for working with <see cref="string"/> instances.
    /// </summary>
    public static class StringExtensions {
        /// <summary>
        /// Counts the number of times a specific character occurs in the string.
        /// </summary>
        /// <param name="input">The string to search.</param>
        /// <param name="character">The character to count occurrences of.</param>
        /// <returns>The number of times <paramref name="character"/> appears in <paramref name="input"/>.</returns>
        public static int CountOccurrences(this string input, char character) {
            int count = 0;
            if (string.IsNullOrEmpty(input)) return 0;
            foreach (char c in input)  {
                if (c == character) {
                    count++;
                }
            }
            return count;
        }
    }
}