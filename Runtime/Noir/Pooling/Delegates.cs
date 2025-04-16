namespace Noir.Pooling {
    /// <summary>
    /// Occurs when an item is first created within the pool
    /// </summary>
    public delegate void OnPoolItemCreatedEvent(ObjectPoolItemSystem objectPoolItem);

    /// <summary>
    /// Occurs when an item is retrieved from the pool, before it is spawned
    /// </summary>
    public delegate void OnPoolItemRetrievedEvent(ObjectPoolItemSystem objectPoolItem);

    /// <summary>
    /// Occurs when an item is returned to the pool
    /// </summary>
    public delegate void OnPoolItemReturnedEvent(ObjectPoolItemSystem objectPoolItem);

    /// <summary>
    /// Occurs when an item is reset to its default state
    /// </summary>
    public delegate void OnPoolItemResetToDefaultsEvent(ObjectPoolItemSystem objectPoolItem);
}