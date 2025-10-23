# Vector4Int

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Represents a four-dimensional vector with integer components.
            Provides basic arithmetic operations, conversions, and equality comparisons.


```csharp
public sealed struct Vector4Int : IEquatable<T>
```

**Implements:** _[IEquatable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=net-7.0)_

## Constructors

<a name=".ctor"></a>

### `.ctor(int, int, int, int)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Initializes a new instance of the [Vector4Int](/noir/reference/Noir/Vector4Int/) struct with the specified components.


```csharp
public Vector4Int(int x, int y, int z, int w)

```

**Parameters** <br>
`x` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>
`y` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>
`z` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>
`w` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>

## Fields

<a name="down"></a>

### `down`
<!-- tc:scope private -->
<!-- tc:return_type Vector4Int /noir/reference/Noir/Vector4Int/ -->
<!-- tc:version 1.0.0 -->

```csharp
public readonly static Vector4Int down;

```

<a name="left"></a>

### `left`
<!-- tc:scope private -->
<!-- tc:return_type Vector4Int /noir/reference/Noir/Vector4Int/ -->
<!-- tc:version 1.0.0 -->

```csharp
public readonly static Vector4Int left;

```

<a name="right"></a>

### `right`
<!-- tc:scope private -->
<!-- tc:return_type Vector4Int /noir/reference/Noir/Vector4Int/ -->
<!-- tc:version 1.0.0 -->

```csharp
public readonly static Vector4Int right;

```

<a name="up"></a>

### `up`
<!-- tc:scope private -->
<!-- tc:return_type Vector4Int /noir/reference/Noir/Vector4Int/ -->
<!-- tc:version 1.0.0 -->

```csharp
public readonly static Vector4Int up;

```

<a name="w"></a>

### `w`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int w;

```

<a name="x"></a>

### `x`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int x;

```

<a name="y"></a>

### `y`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int y;

```

<a name="z"></a>

### `z`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int z;

```

<a name="zero"></a>

### `zero`
<!-- tc:scope private -->
<!-- tc:return_type Vector4Int /noir/reference/Noir/Vector4Int/ -->
<!-- tc:version 1.0.0 -->

```csharp
public readonly static Vector4Int zero;

```

## Properties

<a name="sqrMagnitude"></a>

### `sqrMagnitude`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the squared magnitude of the vector.


```csharp
public int sqrMagnitude { get; }

```

## Methods

<a name="Equals"></a>

### `Equals(Vector4Int)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Determines whether this vector is equal to another [Vector4Int](/noir/reference/Noir/Vector4Int/).


```csharp
public virtual bool Equals(Vector4Int other)

```

**Parameters** <br>
`other` [Vector4Int](/noir/reference/Noir/Vector4Int/) <br>
 <br>

<a name="Equals"></a>

### `Equals(Object)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Determines whether this instance is equal to another object.


```csharp
public virtual bool Equals(Object obj)

```

**Parameters** <br>
`obj` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>

<a name="GetHashCode"></a>

### `GetHashCode()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns a hash code for the current [Vector4Int](/noir/reference/Noir/Vector4Int/) instance.


```csharp
public virtual int GetHashCode()

```

<a name="ToString"></a>

### `ToString()`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns a string representation of the vector in the format "(x=..., y=..., z=..., w=...)".


```csharp
public virtual string ToString()

```

