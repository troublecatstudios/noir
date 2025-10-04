# ObjectPoolItemState

<!-- tc:namespace Noir.Pooling -->

<!-- tc:assembly Noir.dll -->

Represents the current state of a [ObjectPoolSystem](/noir/reference//noir/reference/Noir/Pooling/ObjectPoolSystem/).


```csharp
public sealed enum ObjectPoolItemState : Enum, IComparable, ISpanFormattable, IFormattable, IConvertible
```

**Implements:** _[Enum](https://learn.microsoft.com/en-us/dotnet/api/System.Enum?view=net-7.0), [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=net-7.0), [ISpanFormattable](https://learn.microsoft.com/en-us/dotnet/api/System.ISpanFormattable?view=net-7.0), [IFormattable](https://learn.microsoft.com/en-us/dotnet/api/System.IFormattable?view=net-7.0), [IConvertible](https://learn.microsoft.com/en-us/dotnet/api/System.IConvertible?view=net-7.0)_

## Properties

### `Active`
<!-- tc:scope private -->
<!-- tc:return_type ObjectPoolItemState /noir/reference//noir/reference/Noir/Pooling/ObjectPoolItemState/ -->
<!-- tc:version 1.0.0 -->
The item is currently in use by the game


```csharp
public static const ObjectPoolItemState Active;

```

### `Inactive`
<!-- tc:scope private -->
<!-- tc:return_type ObjectPoolItemState /noir/reference//noir/reference/Noir/Pooling/ObjectPoolItemState/ -->
<!-- tc:version 1.0.0 -->
The item is not currently in use


```csharp
public static const ObjectPoolItemState Inactive;

```

### `Returning`
<!-- tc:scope private -->
<!-- tc:return_type ObjectPoolItemState /noir/reference//noir/reference/Noir/Pooling/ObjectPoolItemState/ -->
<!-- tc:version 1.0.0 -->
The item is currently being returned to the pool


```csharp
public static const ObjectPoolItemState Returning;

```

## More information

* [](T:Noir.Pooling.ObjectPoolItemSystem)
* [](T:Noir.Pooling.ObjectPoolSystem)
