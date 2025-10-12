# ObjectPoolItemSystem

<!-- tc:namespace Noir.Pooling -->

<!-- tc:assembly Noir.dll -->

Represents an object that is owned by a [ObjectPool](/noir/reference/Noir/Pooling/ObjectPool/).


```csharp
public class ObjectPoolItemSystem : NoirBehaviour
```

**Implements:** _[NoirBehaviour](/noir/reference/Noir/NoirBehaviour/)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public ObjectPoolItemSystem()

```

## Properties

<a name="Id"></a>

### `Id`
<!-- tc:scope public -->
<!-- tc:return_type uint https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public uint Id { get; }

```

<a name="IsReturned"></a>

### `IsReturned`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool IsReturned { get; }

```

<a name="State"></a>

### `State`
<!-- tc:scope public -->
<!-- tc:return_type ObjectPoolItemState /noir/reference/Noir/Pooling/ObjectPoolItemState/ -->
<!-- tc:version 1.0.0 -->

```csharp
public ObjectPoolItemState State { get; }

```

## Events

<a name="OnCreated"></a>

### `OnCreated`
<!-- tc:scope private -->
<!-- tc:return_type OnPoolItemCreatedEvent /noir/reference/Noir/Pooling/OnPoolItemCreatedEvent/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnPoolItemCreatedEvent OnCreated;

```

<a name="OnRerievedFromPool"></a>

### `OnRerievedFromPool`
<!-- tc:scope private -->
<!-- tc:return_type OnPoolItemRetrievedEvent /noir/reference/Noir/Pooling/OnPoolItemRetrievedEvent/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnPoolItemRetrievedEvent OnRerievedFromPool;

```

<a name="OnReturnedToPool"></a>

### `OnReturnedToPool`
<!-- tc:scope private -->
<!-- tc:return_type OnPoolItemReturnedEvent /noir/reference/Noir/Pooling/OnPoolItemReturnedEvent/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnPoolItemReturnedEvent OnReturnedToPool;

```

## Methods

<a name="ReturnToPool"></a>

### `ReturnToPool()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Returns the current object back to the pool.
This should be called after any cleanup has been run within the objects other components.


```csharp
public void ReturnToPool()

```

## More information

* [Noir.Pooling.ObjectPool](/noir/reference/Noir/Pooling/ObjectPool/)
* [Noir.NoirBehaviour](/noir/reference/Noir/NoirBehaviour/)
