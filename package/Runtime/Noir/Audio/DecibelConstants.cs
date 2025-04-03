namespace Noir.Audio {
    public static class DecibelConstants {
        /// <summary>
        /// Ambient noise of a perfectly quiet night in the countryside
        /// </summary>
        public const int Whisper = 20;
        /// <summary>
        /// Ambient noise of a perfectly quiet night, in a suburban neighborhood
        /// </summary>
        public const int Rain = 40;
        /// <summary>
        /// Conversation at 3ft distance
        /// </summary>
        public const int Conversation = 60;
        /// <summary>
        /// Also: A jackhammer at 50ft
        /// </summary>
        public const int LoudRadio = 80;
        /// <summary>
        /// Also: construction site
        /// </summary>
        public const int SubwayTrain = 100;
        /// <summary>
        /// Also: jet aircraft engine during takeoff from 200ft
        /// </summary>
        public const int Concert = 120;
        public const int Discomfort = 120;
        public const int Pain = 130;

        /// <summary>
        /// Estimates the distance based on the principle that sound intensity decreases by 6 decibels each time the distance from the source doubles
        /// </summary>
        /// <param name="db">the initial db level of the sound</param>
        /// <returns>the distance that the sound is "hearable", if unobstructed, in meters</returns>
        public static float DecibelToDistance(float db) {
            return db / 6.0f;
        }
    }
}