# BezierCurve

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Used to create a set of discrete "control points" that define a smooth,
            continuous curve by means of a formula.


```csharp
public sealed struct BezierCurve
```

## Properties

<a name="ArcHeight"></a>

### `ArcHeight`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
The height of the arc for the curve.


```csharp
public float ArcHeight { get; public set; }

```

<a name="ControlPoint"></a>

### `ControlPoint`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 1.0.0 -->
Gets the computed control point for the curve.


```csharp
public Vector3 ControlPoint { get; }

```

<a name="End"></a>

### `End`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 1.0.0 -->
The ending point of the curve.


```csharp
public Vector3 End { get; public set; }

```

<a name="Start"></a>

### `Start`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 1.0.0 -->
The starting point of the curve.


```csharp
public Vector3 Start { get; public set; }

```

## Methods

<a name="Create"></a>

### `Create(int, int)`
<!-- tc:scope public -->
<!-- tc:return_type BezierCurve /noir/reference/Noir/BezierCurve/ -->
<!-- tc:version 1.0.0 -->
Creates a new <c>BezierCurve</c> that starts from <c>Vector3.zero</c>.


```csharp
public BezierCurve Create(int distance, int height)

```

**Parameters** <br>
`distance` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>
`height` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>

<a name="CreateMovement"></a>

### `CreateMovement(int, int, float, float)`
<!-- tc:scope public -->
<!-- tc:return_type BezierCurveMovement[] /noir/reference/Noir/BezierCurveMovement/ -->
<!-- tc:version 1.0.0 -->
Creates a [BezierCurveMovement](/noir/reference/Noir/BezierCurveMovement/) that starts from <c>Vector3.zero</c>.


```csharp
public BezierCurveMovement[] CreateMovement(int initialDistance,
                                             int initialArcHeight,
                                             float initialDuration,
                                             float bounciness)


```

**Parameters** <br>
`initialDistance` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>
`initialArcHeight` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>
`initialDuration` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`bounciness` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

## More information

* [Bézier curve on Wikipedia](https://en.wikipedia.org/wiki/B%C3%A9zier_curve)
