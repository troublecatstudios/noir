namespace Noir.Pooling {
    /// <summary>
    /// Represents the current state of a <see cref="ObjectPoolItemSystem"/> within a <see cref="ObjectPoolSystem"/>.
    /// </summary>
    public enum ObjectPoolItemState {
        /// <summary>
        /// The item is not currently in use
        /// </summary>
        Inactive,
        /// <summary>
        /// The item is currently in use by the game
        /// </summary>
        Active,
        /// <summary>
        /// The item is currently being returned to the pool
        /// </summary>
        Returning,
    }
}