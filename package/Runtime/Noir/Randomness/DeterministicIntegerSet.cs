namespace Noir.Randomness {
    public class DeterministicIntegerSet {
        private readonly MersenneTwister _twister;
        private readonly int[] _numbers;

        public DeterministicIntegerSet(uint seed, params int[] numbers) {
            _twister = new(seed);
            _numbers  = numbers;
        }

        public int Next() {
            var range = (uint)(_numbers.Length);
            var val = _twister.Next(range);
            return _numbers[val];
        }
    }
}