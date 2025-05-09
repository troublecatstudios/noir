# BezierCurve

<!-- tc:namespace Noir -->
<!-- tc:assembly Noir.dll -->


```csharp
public sealed struct BezierCurve
```

## Properties

### `ArcHeight`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float ArcHeight { get; public set; }
```

### `ControlPoint`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector3 ControlPoint { get; }
```

### `End`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector3 End { get; public set; }
```

### `Start`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector3 Start { get; public set; }
```

## Methods

### `Create(int, int)`
<!-- tc:scope public -->
<!-- tc:return_type BezierCurve ../Noir/BezierCurve.html -->
<!-- tc:version 1.0.0 -->

```csharp
public BezierCurve Create(int distance, int height)
```

**Parameters** <br>
`distance` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
`height` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

### `CreateMovement(int, int, float, float)`
<!-- tc:scope public -->
<!-- tc:return_type BezierCurveMovement[] ../Noir/BezierCurveMovement.html -->
<!-- tc:version 1.0.0 -->

```csharp
public BezierCurveMovement[] CreateMovement(int initialDistance, int initialArcHeight, float initialDuration, float bounciness)
```

**Parameters** <br>
`initialDistance` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
`initialArcHeight` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
`initialDuration` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`bounciness` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

