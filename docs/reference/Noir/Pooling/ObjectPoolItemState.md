# ObjectPoolItemState

<!-- tc:namespace Noir.Pooling -->

<!-- tc:assembly Noir.dll -->

Represents the current state of a [ObjectPoolSystem](/noir/reference/Noir/Pooling/ObjectPoolSystem/).


```csharp
public sealed enum ObjectPoolItemState : Enum, IComparable, ISpanFormattable, IFormattable, IConvertible
```

**Implements:** _[Enum](https://learn.microsoft.com/en-us/dotnet/api/System.Enum?view=net-7.0), [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=net-7.0), [ISpanFormattable](https://learn.microsoft.com/en-us/dotnet/api/System.ISpanFormattable?view=net-7.0), [IFormattable](https://learn.microsoft.com/en-us/dotnet/api/System.IFormattable?view=net-7.0), [IConvertible](https://learn.microsoft.com/en-us/dotnet/api/System.IConvertible?view=net-7.0)_

## Fields

<a name="Active"></a>

### `Active`
<!-- tc:scope private -->
<!-- tc:return_type ObjectPoolItemState /noir/reference/Noir/Pooling/ObjectPoolItemState/ -->
<!-- tc:version 1.0.0 -->

```csharp
public static const ObjectPoolItemState Active;

```

<a name="Inactive"></a>

### `Inactive`
<!-- tc:scope private -->
<!-- tc:return_type ObjectPoolItemState /noir/reference/Noir/Pooling/ObjectPoolItemState/ -->
<!-- tc:version 1.0.0 -->

```csharp
public static const ObjectPoolItemState Inactive;

```

<a name="Returning"></a>

### `Returning`
<!-- tc:scope private -->
<!-- tc:return_type ObjectPoolItemState /noir/reference/Noir/Pooling/ObjectPoolItemState/ -->
<!-- tc:version 1.0.0 -->

```csharp
public static const ObjectPoolItemState Returning;

```

## More information

* [Noir.Pooling.ObjectPoolItemSystem](/noir/reference/Noir/Pooling/ObjectPoolItemSystem/)
* [Noir.Pooling.ObjectPoolSystem](/noir/reference/Noir/Pooling/ObjectPoolSystem/)
