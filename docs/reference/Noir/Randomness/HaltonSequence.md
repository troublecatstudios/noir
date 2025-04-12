# HaltonSequence

**Namespace:** Noir.Randomness <br>
**Assembly:** Noir.dll

```csharp
public static class HaltonSequence
```

Helper methods for generating numbers/points based on the Halton Sequence algorithm.

### ⛹️‍♀️ Methods
#### GetIndex(int, int)
```csharp
public float GetIndex(int index, int baseNum)
```

**Parameters** <br>
`index` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
`baseNum` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

#### GeneratePoints(int, int, int)
```csharp
public Vector2[] GeneratePoints(int count, int base1, int base2)
```

Returns an array of points based on the Halton Sequence algorithm.

**Parameters** <br>
`count` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>
`base1` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>
`base2` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>

**Returns** <br>
[Vector2[]](../../) <br>
 <br>

