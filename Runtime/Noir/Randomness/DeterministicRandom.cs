namespace Noir.Randomness {
    public static class DeterministicRandom {
        private static readonly MersenneTwister _twister = new(2048);

        public static int InRange(int min, int max) {
            var range = (uint)(max - min);
            var val = _twister.Next(range);
            return min + (int)val;
        }
    }
}