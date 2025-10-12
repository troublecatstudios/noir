# ObjectPoolSystem

<!-- tc:namespace Noir.Pooling -->

<!-- tc:assembly Noir.dll -->

Provides the ability to create, and manage the lifetime of a [ObjectPool](/noir/reference/Noir/Pooling/ObjectPool/).


```csharp
public class ObjectPoolSystem : NoirBehaviour
```

**Implements:** _[NoirBehaviour](/noir/reference/Noir/NoirBehaviour/)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public ObjectPoolSystem()

```

## Properties

<a name="ActiveItems"></a>

### `ActiveItems`
<!-- tc:scope public -->
<!-- tc:return_type uint https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the number of active items in the pool.


```csharp
public uint ActiveItems { get; }

```

<a name="InactiveItems"></a>

### `InactiveItems`
<!-- tc:scope public -->
<!-- tc:return_type uint https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the number of inactive items in the pool.


```csharp
public uint InactiveItems { get; }

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

<a name="Utilization"></a>

### `Utilization`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the pool utilization.


```csharp
public float Utilization { get; }

```

## Events

<a name="OnPoolItemCreated"></a>

### `OnPoolItemCreated`
<!-- tc:scope private -->
<!-- tc:return_type OnPoolItemCreatedEvent /noir/reference/Noir/Pooling/OnPoolItemCreatedEvent/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnPoolItemCreatedEvent OnPoolItemCreated;

```

<a name="OnPoolItemRerieved"></a>

### `OnPoolItemRerieved`
<!-- tc:scope private -->
<!-- tc:return_type OnPoolItemRetrievedEvent /noir/reference/Noir/Pooling/OnPoolItemRetrievedEvent/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnPoolItemRetrievedEvent OnPoolItemRerieved;

```

<a name="OnPoolItemResetToDefaults"></a>

### `OnPoolItemResetToDefaults`
<!-- tc:scope private -->
<!-- tc:return_type OnPoolItemResetToDefaultsEvent /noir/reference/Noir/Pooling/OnPoolItemResetToDefaultsEvent/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnPoolItemResetToDefaultsEvent OnPoolItemResetToDefaults;

```

<a name="OnPoolItemReturned"></a>

### `OnPoolItemReturned`
<!-- tc:scope private -->
<!-- tc:return_type OnPoolItemReturnedEvent /noir/reference/Noir/Pooling/OnPoolItemReturnedEvent/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnPoolItemReturnedEvent OnPoolItemReturned;

```

## Methods

<a name="GetActiveItems"></a>

### `GetActiveItems()`
<!-- tc:scope public -->
<!-- tc:return_type IEnumerable\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public IEnumerable<T> GetActiveItems()

```

<a name="TryGet"></a>

### `TryGet(out ObjectPoolItemSystem&)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool TryGet(ObjectPoolItemSystem& item)

```

**Parameters** <br>
`item` [ObjectPoolItemSystem&](/noir/reference/Noir/Pooling/ObjectPoolItemSystem/) <br>

<a name="Return"></a>

### `Return(ObjectPoolItemSystem)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Return(ObjectPoolItemSystem item)

```

**Parameters** <br>
`item` [ObjectPoolItemSystem](/noir/reference/Noir/Pooling/ObjectPoolItemSystem/) <br>

<a name="ReturnAll"></a>

### `ReturnAll()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void ReturnAll()

```

## More information

* [Noir.Pooling.ObjectPool](/noir/reference/Noir/Pooling/ObjectPool/)
