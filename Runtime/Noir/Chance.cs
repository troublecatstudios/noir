using System;

namespace Noir {
    public static class Chance {
        public static bool Odds(float odds) {
            if (odds > 1 || odds < 0) throw new ArgumentException($"Parameters '{nameof(odds)}' must be a float and cannot be greater than 1.0 or less than 0.0");
            return UnityEngine.Random.Range(0f, 1f) <= odds;
        }

        public static bool Odds(int odds) {
            return Odds((ushort)odds);
        }

        public static bool Odds(uint odds) {
            return Odds((ushort)odds);
        }

        public static bool Odds(ushort odds) {
            if (odds > 100 || odds < 0) throw new ArgumentException($"Parameters '{nameof(odds)}' must be a unsigned integral value and cannot be greater than 100");
            return UnityEngine.Random.Range(0, 100) <= odds;
        }

        public static bool CoinFlip() => Odds(0.5f);

        public static bool Odds(float odds, int attempts) {
            var wins = 0;
            for(var i = 0; i < attempts; i++) {
                wins += Odds(odds) ? 1 : 0;
            }
            return wins >= attempts/2;
        }
    }
}