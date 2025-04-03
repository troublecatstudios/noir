using System;

namespace Noir {
    /// <summary>
    /// Helper class for achieving random outcomes.
    /// </summary>
    public static class Chance {
        /// <summary>
        /// Generates a number between 0.0 and 1.0, inclusive and returns <c>true</c> if that number is less than or equal to the given odds.
        /// </summary>
        /// <param name="odds">The odds of the function returning <c>true</c>.</param>
        /// <exception cref="ArgumentException">Thrown if <paramref name="odds"/> is less than 0.0 or greater than 1.0.</exception>
        /// <returns><c>true</c> if the generated number is less than or equal to the given odds, <c>false</c> otherwise.</returns>
        public static bool Odds(float odds) {
            if (odds > 1 || odds < 0) throw new ArgumentException($"Parameters '{nameof(odds)}' must be a float and cannot be greater than 1.0 or less than 0.0");
            return UnityEngine.Random.Range(0f, 1f) <= odds;
        }

        /// <summary>
        /// Generates a number between 0 and 100, inclusive and returns <c>true</c> if that number is less than or equal to the given odds.
        /// </summary>
        /// <param name="odds">The odds of the function returning <c>true</c>.</param>
        /// <exception cref="ArgumentException">Thrown if <paramref name="odds"/> is less than 0 or greater than 100.</exception>
        /// <returns><c>true</c> if the generated number is less than or equal to the given odds, <c>false</c> otherwise.</returns>
        public static bool Odds(int odds) {
            if (odds > 100 || odds < 0) throw new ArgumentException($"Parameters '{nameof(odds)}' must be a unsigned integer value and cannot be greater than 100");
            return UnityEngine.Random.Range(0, 100) <= odds;
        }

        /// <summary>
        /// Shortcut for 50/50 chance.
        /// </summary>
        /// <returns><c>true</c> if the coin flip succeeeds, <c>false</c> otherwise.</returns>
        public static bool CoinFlip() => Odds(0.5f);

        /// <summary>
        /// Generates a number between 0.0 and 1.0, inclusive and returns <c>true</c> if that number is less than or equal to the given odds.
        /// </summary>
        /// <param name="odds">The odds of the function returning <c>true</c>.</param>
        /// <param name="attempts">The number of attempts to make before returning <c>false</c>.</param>
        /// <exception cref="ArgumentException">Thrown if <paramref name="odds"/> is less than 0.0 or greater than 1.0.</exception>
        /// <returns><c>true</c> if the generated number is less than or equal to the given odds, <c>false</c> otherwise.</returns>
        public static bool Odds(float odds, int attempts) {
            var wins = 0;
            for(var i = 0; i < attempts; i++) {
                wins += Odds(odds) ? 1 : 0;
            }
            return wins >= attempts/2;
        }
    }
}
