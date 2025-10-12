# ObjectPoolComponent

<!-- tc:namespace Noir.Pooling -->

<!-- tc:assembly Noir.dll -->

Configures an object for use with a [ObjectPoolSystem](/noir/reference/Noir/Pooling/ObjectPoolSystem/).


```csharp
public class ObjectPoolComponent : NoirBehaviour
```

**Implements:** _[NoirBehaviour](/noir/reference/Noir/NoirBehaviour/)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public ObjectPoolComponent()

```

## Properties

<a name="Capacity"></a>

### `Capacity`
<!-- tc:scope public -->
<!-- tc:return_type uint https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
The max size of the pool


```csharp
public uint Capacity { get; }

```

<a name="IsParentForSpawnedObjects"></a>

### `IsParentForSpawnedObjects`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Should the [ObjectPoolSystem](/noir/reference/Noir/Pooling/ObjectPoolSystem/) gameobject be the parent for spawned objects?


```csharp
public bool IsParentForSpawnedObjects { get; }

```

<a name="IsPreWarmEnabled"></a>

### `IsPreWarmEnabled`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Should the object pool pre-generate all the items at startup?


```csharp
public bool IsPreWarmEnabled { get; }

```

<a name="Prefab"></a>

### `Prefab`
<!-- tc:scope public -->
<!-- tc:return_type ObjectPoolItemSystem /noir/reference/Noir/Pooling/ObjectPoolItemSystem/ -->
<!-- tc:version 1.0.0 -->
The gameobject to spawn using the object pool


```csharp
public ObjectPoolItemSystem Prefab { get; }

```

## More information

* [Noir.Pooling.ObjectPoolSystem](/noir/reference/Noir/Pooling/ObjectPoolSystem/)
