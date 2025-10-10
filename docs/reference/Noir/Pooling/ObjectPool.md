# ObjectPool

<!-- tc:namespace Noir.Pooling -->

<!-- tc:assembly Noir.dll -->

Allows easy reuse of Unity objects.


```csharp
public class ObjectPool : IDisposable
```

**Implements:** _[IDisposable](https://learn.microsoft.com/en-us/dotnet/api/System.IDisposable?view=net-7.0)_

## Constructors

<a name=".ctor"></a>

### `.ctor(ObjectPoolItemSystem, uint)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Initializes a new instance of the [ObjectPool](/noir/reference//noir/reference/Noir/Pooling/ObjectPool/) class.


```csharp
public ObjectPool(ObjectPoolItemSystem prefab, uint capacity)

```

**Parameters** <br>
`prefab` [ObjectPoolItemSystem](/noir/reference//noir/reference/Noir/Pooling/ObjectPoolItemSystem/) <br>
 <br>
`capacity` [uint](https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0) <br>
 <br>

**Exceptions** <br>
[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/System.ArgumentNullException?view=net-7.0) <br>
 <br>
<a name=".ctor"></a>

### `.ctor(GameObject, uint)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Initializes a new instance of the [ObjectPool](/noir/reference//noir/reference/Noir/Pooling/ObjectPool/) class.


```csharp
public ObjectPool(GameObject prefab, uint capacity)

```

**Parameters** <br>
`prefab` [GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html) <br>
 <br>
`capacity` [uint](https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0) <br>
 <br>

**Exceptions** <br>
[ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/System.ArgumentNullException?view=net-7.0) <br>
 <br>
## Properties

<a name="_disposedValue"></a>

### `_disposedValue`
<!-- tc:scope private -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
protected bool _disposedValue;

```

<a name="_prefab"></a>

### `_prefab`
<!-- tc:scope private -->
<!-- tc:return_type ObjectPoolItemSystem /noir/reference//noir/reference/Noir/Pooling/ObjectPoolItemSystem/ -->
<!-- tc:version 1.0.0 -->

```csharp
protected readonly ObjectPoolItemSystem _prefab;

```

<a name="ActiveCount"></a>

### `ActiveCount`
<!-- tc:scope public -->
<!-- tc:return_type uint https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the active count.


```csharp
public uint ActiveCount { get; }

```

<a name="InactiveCount"></a>

### `InactiveCount`
<!-- tc:scope public -->
<!-- tc:return_type uint https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the inactive count.


```csharp
public uint InactiveCount { get; }

```

<a name="IsPreWarmed"></a>

### `IsPreWarmed`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets whether or not the pool has been pre-warmed.


```csharp
public bool IsPreWarmed { get; private set; }

```

<a name="MaxCapacity"></a>

### `MaxCapacity`
<!-- tc:scope public -->
<!-- tc:return_type uint https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the maximum capacity.


```csharp
public uint MaxCapacity { get; private set; }

```

<a name="PoolUtilization"></a>

### `PoolUtilization`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the pool utilization.


```csharp
public float PoolUtilization { get; }

```

<a name="TotalItems"></a>

### `TotalItems`
<!-- tc:scope public -->
<!-- tc:return_type uint https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the total items.


```csharp
public uint TotalItems { get; }

```

## Events

<a name="OnPoolItemCreated"></a>

### `OnPoolItemCreated`
<!-- tc:scope private -->
<!-- tc:return_type OnPoolItemCreatedEvent /noir/reference//noir/reference/Noir/Pooling/OnPoolItemCreatedEvent/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnPoolItemCreatedEvent OnPoolItemCreated;

```

<a name="OnPoolItemRerieved"></a>

### `OnPoolItemRerieved`
<!-- tc:scope private -->
<!-- tc:return_type OnPoolItemRetrievedEvent /noir/reference//noir/reference/Noir/Pooling/OnPoolItemRetrievedEvent/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnPoolItemRetrievedEvent OnPoolItemRerieved;

```

<a name="OnPoolItemResetToDefaults"></a>

### `OnPoolItemResetToDefaults`
<!-- tc:scope private -->
<!-- tc:return_type OnPoolItemResetToDefaultsEvent /noir/reference//noir/reference/Noir/Pooling/OnPoolItemResetToDefaultsEvent/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnPoolItemResetToDefaultsEvent OnPoolItemResetToDefaults;

```

<a name="OnPoolItemReturned"></a>

### `OnPoolItemReturned`
<!-- tc:scope private -->
<!-- tc:return_type OnPoolItemReturnedEvent /noir/reference//noir/reference/Noir/Pooling/OnPoolItemReturnedEvent/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnPoolItemReturnedEvent OnPoolItemReturned;

```

## Methods

<a name="CreateNewPoolItem"></a>

### `CreateNewPoolItem()`
<!-- tc:scope private -->
<!-- tc:return_type ObjectPoolItemSystem /noir/reference//noir/reference/Noir/Pooling/ObjectPoolItemSystem/ -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual ObjectPoolItemSystem CreateNewPoolItem()

```

<a name="Dispose"></a>

### `Dispose(bool)`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual void Dispose(bool disposing)

```

**Parameters** <br>
`disposing` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

<a name="OnItemCreated"></a>

### `OnItemCreated(ObjectPoolItemSystem, bool)`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->
Called when an item has been created for the first time.


```csharp
protected virtual void OnItemCreated(ObjectPoolItemSystem item, bool isPreWarm)

```

**Parameters** <br>
`item` [ObjectPoolItemSystem](/noir/reference//noir/reference/Noir/Pooling/ObjectPoolItemSystem/) <br>
 <br>
`isPreWarm` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

<a name="OnItemRetrieved"></a>

### `OnItemRetrieved(ObjectPoolItemSystem)`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->
Called when an inactive item is retrieved from the pool.


```csharp
protected virtual void OnItemRetrieved(ObjectPoolItemSystem item)

```

**Parameters** <br>
`item` [ObjectPoolItemSystem](/noir/reference//noir/reference/Noir/Pooling/ObjectPoolItemSystem/) <br>
 <br>

<a name="OnItemReturned"></a>

### `OnItemReturned(ObjectPoolItemSystem, bool)`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->
Called when an active item is returned to the pool.


```csharp
protected virtual void OnItemReturned(ObjectPoolItemSystem item, bool isPreWarm)

```

**Parameters** <br>
`item` [ObjectPoolItemSystem](/noir/reference//noir/reference/Noir/Pooling/ObjectPoolItemSystem/) <br>
 <br>
`isPreWarm` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

<a name="OnResetToDefaults"></a>

### `OnResetToDefaults(ObjectPoolItemSystem)`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->
Called when the item should be reset to its default state.
This method can be called when the pool is being pre-warmed, when an item is created for the first time or when an item is returned to the pool. <br />
            The returned item from this method is then stored in the internal active or inactive collections depending on the action being taken. <br />
            This method is always called before [ObjectPool.OnItemReturned(Noir.Pooling.ObjectPoolItemSystem,System.Boolean)](/noir/reference//noir/reference/Noir/Pooling/ObjectPool/#onitemreturned(objectpoolitemsystem,).


```csharp
protected virtual void OnResetToDefaults(ObjectPoolItemSystem item)

```

**Parameters** <br>
`item` [ObjectPoolItemSystem](/noir/reference//noir/reference/Noir/Pooling/ObjectPoolItemSystem/) <br>
 <br>

<a name="ReturnToPool"></a>

### `ReturnToPool(ObjectPoolItemSystem, bool)`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual void ReturnToPool(ObjectPoolItemSystem item, bool isPreWarm)

```

**Parameters** <br>
`item` [ObjectPoolItemSystem](/noir/reference//noir/reference/Noir/Pooling/ObjectPoolItemSystem/) <br>
`isPreWarm` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

<a name="TryGet"></a>

### `TryGet(out ObjectPoolItemSystem&)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool TryGet(ObjectPoolItemSystem& item)

```

**Parameters** <br>
`item` [ObjectPoolItemSystem&](/noir/reference//noir/reference/Noir/Pooling/ObjectPoolItemSystem/) <br>

<a name="GetActiveItems"></a>

### `GetActiveItems()`
<!-- tc:scope public -->
<!-- tc:return_type IEnumerable\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns an [ObjectPoolItemSystem](/noir/reference//noir/reference/Noir/Pooling/ObjectPoolItemSystem/) objects in the pool.


```csharp
public IEnumerable<T> GetActiveItems()

```

<a name="Dispose"></a>

### `Dispose()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Releases unmanaged and managed resources.


```csharp
public virtual void Dispose()

```

<a name="PreWarm"></a>

### `PreWarm()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Prewarms the object pool.
This can cause stutters if the [ObjectPool.MaxCapacity](/noir/reference//noir/reference/Noir/Pooling/ObjectPool/#maxcapacity) is large.


```csharp
public void PreWarm()

```

<a name="Return"></a>

### `Return(ObjectPoolItemSystem)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Returns the specified item to the pool.


```csharp
public void Return(ObjectPoolItemSystem item)

```

**Parameters** <br>
`item` [ObjectPoolItemSystem](/noir/reference//noir/reference/Noir/Pooling/ObjectPoolItemSystem/) <br>
 <br>

<a name="ReturnAll"></a>

### `ReturnAll()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Iterates through all the active objects, calling [ObjectPoolItemSystem.ReturnToPool](/noir/reference//noir/reference/Noir/Pooling/ObjectPoolItemSystem/#returntopool) on each.


```csharp
public void ReturnAll()

```

<a name="SetParent"></a>

### `SetParent(GameObject)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets the parent.


```csharp
public void SetParent(GameObject gameObject)

```

**Parameters** <br>
`gameObject` [GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html) <br>
 <br>

<a name="SetParent"></a>

### `SetParent(Transform)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets the parent.


```csharp
public void SetParent(Transform transform)

```

**Parameters** <br>
`transform` [Transform](https://docs.unity3d.com/ScriptReference/Transform.html) <br>
 <br>

## More information

* [System.IDisposable](https://learn.microsoft.com/en-us/dotnet/api/System.IDisposable?view=net-7.0)
