# PoissonDisc

**Namespace:** Noir.Randomness <br>
**Assembly:** Noir.dll

```csharp
public class PoissonDisc
```

### 🛠 Constructors
```csharp
public PoissonDisc()
```

### 📦 Properties
#### DefaultIterationPerPoint
```csharp
public static const int DefaultIterationPerPoint;
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
#### InvertRootTwo
```csharp
public static const float InvertRootTwo;
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
### ⛹️‍♀️ Methods
#### CreateSettings(Vector2, Vector2, float, T?, int, int)
```csharp
public PoissonSettings CreateSettings(Vector2 bottomLeft, Vector2 topRight, float min, T? startingPoint, int seed, int iterations)
```

**Parameters** <br>
`bottomLeft` [Vector2](../../) <br>
`topRight` [Vector2](../../) <br>
`min` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`startingPoint` [T?](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0) <br>
`seed` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
`iterations` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

**Returns** <br>
[PoissonSettings](../../Noir/Randomness/PoissonSettings.html) <br>

#### GetGridIndex(Vector2, PoissonSettings)
```csharp
public Vector2Int GetGridIndex(Vector2 point, PoissonSettings set)
```

**Parameters** <br>
`point` [Vector2](../../) <br>
`set` [PoissonSettings](../../Noir/Randomness/PoissonSettings.html) <br>

**Returns** <br>
[Vector2Int](../../) <br>

