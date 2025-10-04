# HaltonSequence

<!-- tc:namespace Noir.Randomness -->

<!-- tc:assembly Noir.dll -->

Helper methods for generating numbers/points based on the Halton Sequence algorithm.


```csharp
public static class HaltonSequence
```

## Methods

### `GetIndex(int, int)`
<!-- tc:scope public -->
<!-- tc:return_type [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public float GetIndex(int index, int baseNum)

```

**Parameters** <br>
`index` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
`baseNum` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

### `GeneratePoints(int, int, int)`
<!-- tc:scope public -->
<!-- tc:return_type [Vector2[]](https://docs.unity3d.com/ScriptReference/Vector2.html) -->
<!-- tc:version 1.0.0 -->
Returns an array of points based on the Halton Sequence algorithm.


```csharp
public Vector2[] GeneratePoints(int count, int base1, int base2)

```

**Parameters** <br>
`count` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>
`base1` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>
`base2` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>

