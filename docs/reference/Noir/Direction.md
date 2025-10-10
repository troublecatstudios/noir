# Direction

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Represents a direction in two-dimensional or three-dimensional space. The horizontal and vertical axis are
            separated out into easier to read properties [Direction.Vertical](/noir/reference/Noir/Direction/#vertical) respectively.
Can be implicitly cast to a [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html).


```csharp
public sealed struct Direction : IEquatable<T>
```

**Implements:** _[IEquatable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=net-7.0)_

## Constructors

<a name=".ctor"></a>

### `.ctor(Vector2)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Initializes a new instance of the [Direction](/noir/reference/Noir/Direction/) struct.


```csharp
public Direction(Vector2 vector)

```

**Parameters** <br>
`vector` [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) <br>
 <br>

<a name=".ctor"></a>

### `.ctor(Vector3)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Initializes a new instance of the [Direction](/noir/reference/Noir/Direction/) struct.


```csharp
public Direction(Vector3 vector)

```

**Parameters** <br>
`vector` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>

## Properties

<a name="Horizontal"></a>

### `Horizontal`
<!-- tc:scope public -->
<!-- tc:return_type HorizontalDirections /noir/reference/Noir/HorizontalDirections/ -->
<!-- tc:version 1.0.0 -->
Gets the horizontal axis.


```csharp
public HorizontalDirections Horizontal { get; private set; }

```

<a name="None"></a>

### `None`
<!-- tc:scope private -->
<!-- tc:return_type Direction /noir/reference/Noir/Direction/ -->
<!-- tc:version 1.0.0 -->

```csharp
public readonly static Direction None;

```

<a name="Perpendicular"></a>

### `Perpendicular`
<!-- tc:scope public -->
<!-- tc:return_type PerpendicularDirections /noir/reference/Noir/PerpendicularDirections/ -->
<!-- tc:version 1.0.0 -->
Gets the perpendicular axis.


```csharp
public PerpendicularDirections Perpendicular { get; private set; }

```

<a name="Vertical"></a>

### `Vertical`
<!-- tc:scope public -->
<!-- tc:return_type VerticalDirections /noir/reference/Noir/VerticalDirections/ -->
<!-- tc:version 1.0.0 -->
Gets the vertical axis.


```csharp
public VerticalDirections Vertical { get; private set; }

```

## Methods

<a name="Equals"></a>

### `Equals(Direction)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Equals(Direction other)

```

**Parameters** <br>
`other` [Direction](/noir/reference/Noir/Direction/) <br>

<a name="Equals"></a>

### `Equals(Object)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Equals(Object obj)

```

**Parameters** <br>
`obj` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

<a name="GetHashCode"></a>

### `GetHashCode()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual int GetHashCode()

```

## More information

* [Noir.Direction.Horizontal](/noir/reference/Noir/Direction/#Horizontal)
* [Noir.Direction.Vertical](/noir/reference/Noir/Direction/#Vertical)
* [UnityEngine.Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html)
