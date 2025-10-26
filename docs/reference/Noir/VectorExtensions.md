# VectorExtensions

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Extension methods for Unity Vector types.


```csharp
public static class VectorExtensions
```

## Methods

<a name="ToLogString"></a>

### `ToLogString(Vector2)`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns a formatted string representing the components of a [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html).


```csharp
public string ToLogString(Vector2 vector)

```

**Parameters** <br>
`vector` [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) <br>
 <br>

<a name="ToLogString"></a>

### `ToLogString(Vector2Int)`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns a formatted string representing the components of a [Vector2Int](https://docs.unity3d.com/ScriptReference/Vector2Int.html).


```csharp
public string ToLogString(Vector2Int vector)

```

**Parameters** <br>
`vector` [Vector2Int](https://docs.unity3d.com/ScriptReference/Vector2Int.html) <br>
 <br>

<a name="ToLogString"></a>

### `ToLogString(Vector3)`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns a formatted string representing the components of a [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html).


```csharp
public string ToLogString(Vector3 vector)

```

**Parameters** <br>
`vector` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>

<a name="ToLogString"></a>

### `ToLogString(Vector3Int)`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns a formatted string representing the components of a [Vector3Int](https://docs.unity3d.com/ScriptReference/Vector3Int.html).


```csharp
public string ToLogString(Vector3Int vector)

```

**Parameters** <br>
`vector` [Vector3Int](https://docs.unity3d.com/ScriptReference/Vector3Int.html) <br>
 <br>

<a name="Abs"></a>

### `Abs(Vector2)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->
Returns a new [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) with each component replaced by its absolute value.


```csharp
public Vector2 Abs(Vector2 vector)

```

**Parameters** <br>
`vector` [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) <br>
 <br>

<a name="DirectionTo"></a>

### `DirectionTo(Vector2, Vector2, bool)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->
Returns the direction vector between this Vector2 and another.


```csharp
public Vector2 DirectionTo(Vector2 vector, Vector2 other, bool normalize)

```

**Parameters** <br>
`vector` [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) <br>
 <br>
`other` [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) <br>
 <br>
`normalize` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

<a name="Sign"></a>

### `Sign(Vector2, bool)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->
Returns a new [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) with each component replaced by its sign (-1, 0, or 1).


```csharp
public Vector2 Sign(Vector2 vector, bool ignoreZeros)

```

**Parameters** <br>
`vector` [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) <br>
 <br>
`ignoreZeros` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

<a name="Abs"></a>

### `Abs(Vector3)`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 1.0.0 -->
Returns a new [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) with each component replaced by its absolute value.


```csharp
public Vector3 Abs(Vector3 vector)

```

**Parameters** <br>
`vector` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>

<a name="DirectionTo"></a>

### `DirectionTo(Vector3, Vector3, bool)`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 1.0.0 -->
Returns the direction vector between this Vector3 and another.


```csharp
public Vector3 DirectionTo(Vector3 vector, Vector3 other, bool normalize)

```

**Parameters** <br>
`vector` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>
`other` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>
`normalize` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

<a name="Sign"></a>

### `Sign(Vector3, bool)`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 1.0.0 -->
Returns a new [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) with each component replaced by its sign (-1, 0, or 1).


```csharp
public Vector3 Sign(Vector3 vector, bool ignoreZeros)

```

**Parameters** <br>
`vector` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>
`ignoreZeros` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

