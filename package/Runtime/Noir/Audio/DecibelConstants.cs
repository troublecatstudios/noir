namespace Noir.Audio {
    /// <summary>
    /// Provides common decibel (dB) values for various sounds and utility methods for working with sound intensity.
    /// </summary>
    public static class DecibelConstants {
        /// <summary>
        /// Ambient noise of a perfectly quiet night in the countryside (~20 dB).
        /// </summary>
        public const int Whisper = 20;

        /// <summary>
        /// Ambient noise of a quiet night in a suburban neighborhood (~40 dB).
        /// </summary>
        public const int Rain = 40;

        /// <summary>
        /// Typical conversation at 3 feet distance (~60 dB).
        /// </summary>
        public const int Conversation = 60;

        /// <summary>
        /// Also equivalent to a jackhammer at 50 feet (~80 dB).
        /// </summary>
        public const int LoudRadio = 80;

        /// <summary>
        /// Also similar to a construction site or subway train (~100 dB).
        /// </summary>
        public const int SubwayTrain = 100;

        /// <summary>
        /// Also similar to a jet aircraft engine during takeoff from 200 feet (~120 dB).
        /// </summary>
        public const int Concert = 120;

        /// <summary>
        /// Sound intensity that typically causes discomfort (~120 dB).
        /// </summary>
        public const int Discomfort = 120;

        /// <summary>
        /// Sound intensity that typically causes pain (~130 dB).
        /// </summary>
        public const int Pain = 130;

        /// <summary>
        /// Estimates the distance at which a sound is "hearable" based on the principle that
        /// sound intensity decreases by 6 decibels each time the distance from the source doubles.
        /// </summary>
        /// <param name="db">The initial decibel (dB) level of the sound.</param>
        /// <returns>The approximate distance (in meters) the sound can be heard, if unobstructed.</returns>
        public static float DecibelToDistance(float db) {
            return db / 6.0f;
        }
    }
}