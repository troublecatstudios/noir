# BehaviourPoolBase\<T\>

<!-- tc:namespace Noir.Pooling -->

<!-- tc:assembly Noir.dll -->

Allows easy, cached reuse of MonoBehaviours


```csharp
public abstract class BehaviourPoolBase<T> : NoirBehaviour
```

**Implements:** _[NoirBehaviour](/noir/reference/Noir/NoirBehaviour/)_

## Properties

<a name="ActiveItems"></a>

### `ActiveItems`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the number of active items in the pool.
Active items are items that are still active within the game scene and have not been returned to the pool.


```csharp
public int ActiveItems { get; }

```

<a name="InactiveItems"></a>

### `InactiveItems`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the number of inactive items in the pool.
Inactive items will be reused before new items are created.


```csharp
public int InactiveItems { get; }

```

<a name="IsPreWarmEnabled"></a>

### `IsPreWarmEnabled`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets a value that indicates whether the pool should pre-warm during its [BehaviourPoolBase<T>.Start](/noir/reference/Noir/Pooling/BehaviourPoolBase-1/) lifecycle.


```csharp
public bool IsPreWarmEnabled { get; }

```

<a name="MaxItems"></a>

### `MaxItems`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the max number of items that can be created by this pool.


```csharp
public int MaxItems { get; }

```

<a name="PoolUtilization"></a>

### `PoolUtilization`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets a value that indicates the percentage of active vs total items in the pool.


```csharp
public float PoolUtilization { get; }

```

<a name="TotalItems"></a>

### `TotalItems`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the sum of [BehaviourPoolBase<T>.ActiveItems](/noir/reference/Noir/Pooling/BehaviourPoolBase-1/#activeitems).


```csharp
public int TotalItems { get; }

```

## Methods

<a name="GetActiveItems"></a>

### `GetActiveItems()`
<!-- tc:scope public -->
<!-- tc:return_type IEnumerable\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns an [Component](https://docs.unity3d.com/ScriptReference/Component.html) objects in the pool.


```csharp
public IEnumerable<T> GetActiveItems()

```

<a name="TryGetItemFromPool"></a>

### `TryGetItemFromPool(out T&)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool TryGetItemFromPool(T& item)

```

**Parameters** <br>
`item` [T&](/noir/reference/) <br>

<a name="ReturnItemToPool"></a>

### `ReturnItemToPool(T)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void ReturnItemToPool(T item)

```

**Parameters** <br>
`item` [T](/noir/reference/) <br>

