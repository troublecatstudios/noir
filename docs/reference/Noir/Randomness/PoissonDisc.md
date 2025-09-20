# PoissonDisc

<!-- tc:namespace Noir.Randomness -->

<!-- tc:assembly Noir.dll -->


```csharp
public class PoissonDisc
```

## 🛠 Constructors

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public PoissonDisc()
```

## 📦 Properties

### `DefaultIterationPerPoint`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public static const int DefaultIterationPerPoint;
```

### `InvertRootTwo`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public static const float InvertRootTwo;
```

## ⛹️‍♀️ Methods

### `CreateSettings(Vector2, Vector2, float, T?, int, int)`
<!-- tc:scope public -->
<!-- tc:return_type PoissonSettings /noir/reference/Noir/Randomness/PoissonSettings/ -->
<!-- tc:version 1.0.0 -->

```csharp
public PoissonSettings CreateSettings(Vector2 bottomLeft, Vector2 topRight, float min, T? startingPoint, int seed, int iterations)
```

**Parameters** <br>
`bottomLeft` [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) <br>
`topRight` [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) <br>
`min` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`startingPoint` [T?](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0) <br>
`seed` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
`iterations` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

### `GetGridIndex(Vector2, PoissonSettings)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2Int https://docs.unity3d.com/ScriptReference/Vector2Int.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector2Int GetGridIndex(Vector2 point, PoissonSettings set)
```

**Parameters** <br>
`point` [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) <br>
`set` [PoissonSettings](/noir/reference/Noir/Randomness/PoissonSettings/) <br>

