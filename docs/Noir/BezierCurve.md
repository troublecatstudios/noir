# BezierCurve

**Namespace:** Noir <br>
**Assembly:** Noir.dll

```csharp
public sealed struct BezierCurve
```

### 📦 Properties
#### ArcHeight
```csharp
public float ArcHeight { get; public set; }
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### ControlPoint
```csharp
public Vector3 ControlPoint { get; }
```

**Returns** <br>
[Vector3](../) <br>
#### End
```csharp
public Vector3 End { get; public set; }
```

**Returns** <br>
[Vector3](../) <br>
#### Start
```csharp
public Vector3 Start { get; public set; }
```

**Returns** <br>
[Vector3](../) <br>
### ⛹️‍♀️ Methods
#### Create(int, int)
```csharp
public BezierCurve Create(int distance, int height)
```

**Parameters** <br>
`distance` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
`height` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

**Returns** <br>
[BezierCurve](../Noir/BezierCurve.html) <br>

#### CreateMovement(int, int, float, float)
```csharp
public BezierCurveMovement[] CreateMovement(int initialDistance, int initialArcHeight, float initialDuration, float bounciness)
```

**Parameters** <br>
`initialDistance` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
`initialArcHeight` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
`initialDuration` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`bounciness` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

**Returns** <br>
[BezierCurveMovement[]](../Noir/BezierCurveMovement.html) <br>

