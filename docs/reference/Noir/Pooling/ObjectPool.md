# ObjectPool

**Namespace:** Noir.Pooling <br>
**Assembly:** Noir.dll

```csharp
public class ObjectPool : IDisposable
```

Allows easy reuse of Unity objects.

**Implements:** _[IDisposable](https://learn.microsoft.com/en-us/dotnet/api/System.IDisposable?view=net-7.0)_

### 🛠 Constructors
```csharp
public ObjectPool(ObjectPoolItemSystem prefab, uint capacity)
```

Initializes a new instance of the [ObjectPool](../../Noir/Pooling/ObjectPool.html) class.

**Parameters** <br>
`prefab` [ObjectPoolItemSystem](../../Noir/Pooling/ObjectPoolItemSystem.html) <br>
 <br>
`capacity` [uint](https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0) <br>
 <br>

**Exceptions** <br>
[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/System.ArgumentNullException?view=net-7.0) <br>
 <br>
```csharp
public ObjectPool(GameObject prefab, uint capacity)
```

Initializes a new instance of the [ObjectPool](../../Noir/Pooling/ObjectPool.html) class.

**Parameters** <br>
`prefab` [GameObject](../../) <br>
 <br>
`capacity` [uint](https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0) <br>
 <br>

**Exceptions** <br>
[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/System.ArgumentNullException?view=net-7.0) <br>
 <br>
### 📦 Properties
#### _disposedValue
```csharp
protected bool _disposedValue;
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### _prefab
```csharp
protected readonly ObjectPoolItemSystem _prefab;
```

**Returns** <br>
[ObjectPoolItemSystem](../../Noir/Pooling/ObjectPoolItemSystem.html) <br>
#### ActiveCount
```csharp
public uint ActiveCount { get; }
```

Gets the active count.

**Returns** <br>
[uint](https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0) <br>
#### InactiveCount
```csharp
public uint InactiveCount { get; }
```

Gets the inactive count.

**Returns** <br>
[uint](https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0) <br>
#### IsPreWarmed
```csharp
public bool IsPreWarmed { get; private set; }
```

Gets whether or not the pool has been pre-warmed.

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### MaxCapacity
```csharp
public uint MaxCapacity { get; private set; }
```

Gets the maximum capacity.

**Returns** <br>
[uint](https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0) <br>
#### PoolUtilization
```csharp
public float PoolUtilization { get; }
```

Gets the pool utilization.

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### TotalItems
```csharp
public uint TotalItems { get; }
```

Gets the total items.

**Returns** <br>
[uint](https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0) <br>
### ⚡ Events
#### OnPoolItemCreated
```csharp
public event OnPoolItemCreatedEvent OnPoolItemCreated;
```

**Returns** <br>
[OnPoolItemCreatedEvent](../../Noir/Pooling/OnPoolItemCreatedEvent.html) <br>
#### OnPoolItemRerieved
```csharp
public event OnPoolItemRetrievedEvent OnPoolItemRerieved;
```

**Returns** <br>
[OnPoolItemRetrievedEvent](../../Noir/Pooling/OnPoolItemRetrievedEvent.html) <br>
#### OnPoolItemResetToDefaults
```csharp
public event OnPoolItemResetToDefaultsEvent OnPoolItemResetToDefaults;
```

**Returns** <br>
[OnPoolItemResetToDefaultsEvent](../../Noir/Pooling/OnPoolItemResetToDefaultsEvent.html) <br>
#### OnPoolItemReturned
```csharp
public event OnPoolItemReturnedEvent OnPoolItemReturned;
```

**Returns** <br>
[OnPoolItemReturnedEvent](../../Noir/Pooling/OnPoolItemReturnedEvent.html) <br>
### ⛹️‍♀️ Methods
#### CreateNewPoolItem()
```csharp
protected virtual ObjectPoolItemSystem CreateNewPoolItem()
```

**Returns** <br>
[ObjectPoolItemSystem](../../Noir/Pooling/ObjectPoolItemSystem.html) <br>

#### Dispose(bool)
```csharp
protected virtual void Dispose(bool disposing)
```

**Parameters** <br>
`disposing` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### OnItemCreated(ObjectPoolItemSystem, bool)
```csharp
protected virtual void OnItemCreated(ObjectPoolItemSystem item, bool isPreWarm)
```

Called when an item has been created for the first time.

**Parameters** <br>
`item` [ObjectPoolItemSystem](../../Noir/Pooling/ObjectPoolItemSystem.html) <br>
 <br>
`isPreWarm` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

#### OnItemRetrieved(ObjectPoolItemSystem)
```csharp
protected virtual void OnItemRetrieved(ObjectPoolItemSystem item)
```

Called when an inactive item is retrieved from the pool.

**Parameters** <br>
`item` [ObjectPoolItemSystem](../../Noir/Pooling/ObjectPoolItemSystem.html) <br>
 <br>

#### OnItemReturned(ObjectPoolItemSystem, bool)
```csharp
protected virtual void OnItemReturned(ObjectPoolItemSystem item, bool isPreWarm)
```

Called when an active item is returned to the pool.

**Parameters** <br>
`item` [ObjectPoolItemSystem](../../Noir/Pooling/ObjectPoolItemSystem.html) <br>
 <br>
`isPreWarm` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

#### OnResetToDefaults(ObjectPoolItemSystem)
```csharp
protected virtual void OnResetToDefaults(ObjectPoolItemSystem item)
```

Called when the item should be reset to its default state.

**Parameters** <br>
`item` [ObjectPoolItemSystem](../../Noir/Pooling/ObjectPoolItemSystem.html) <br>
 <br>

#### ReturnToPool(ObjectPoolItemSystem, bool)
```csharp
protected virtual void ReturnToPool(ObjectPoolItemSystem item, bool isPreWarm)
```

**Parameters** <br>
`item` [ObjectPoolItemSystem](../../Noir/Pooling/ObjectPoolItemSystem.html) <br>
`isPreWarm` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### TryGet(out ObjectPoolItemSystem&)
```csharp
public bool TryGet(ObjectPoolItemSystem& item)
```

**Parameters** <br>
`item` [ObjectPoolItemSystem&](../../Noir/Pooling/ObjectPoolItemSystem.html) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### GetActiveItems()
```csharp
public IEnumerable<T> GetActiveItems()
```

Returns an [ObjectPoolItemSystem](../../Noir/Pooling/ObjectPoolItemSystem.html) objects in the pool.

**Returns** <br>
[IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>
 <br>

#### Dispose()
```csharp
public virtual void Dispose()
```

Releases unmanaged and managed resources.

#### PreWarm()
```csharp
public void PreWarm()
```

Prewarms the object pool.

#### Return(ObjectPoolItemSystem)
```csharp
public void Return(ObjectPoolItemSystem item)
```

Returns the specified item to the pool.

**Parameters** <br>
`item` [ObjectPoolItemSystem](../../Noir/Pooling/ObjectPoolItemSystem.html) <br>
 <br>

#### ReturnAll()
```csharp
public void ReturnAll()
```

Iterates through all the active objects, calling [ObjectPoolItemSystem.ReturnToPool](../../Noir/Pooling/ObjectPoolItemSystem.html#returntopool) on each.

#### SetParent(GameObject)
```csharp
public void SetParent(GameObject gameObject)
```

Sets the parent.

**Parameters** <br>
`gameObject` [GameObject](../../) <br>
 <br>

#### SetParent(Transform)
```csharp
public void SetParent(Transform transform)
```

Sets the parent.

**Parameters** <br>
`transform` [Transform](../../) <br>
 <br>

