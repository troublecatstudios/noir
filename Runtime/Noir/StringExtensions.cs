namespace Noir {
    public static class StringExtensions {
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