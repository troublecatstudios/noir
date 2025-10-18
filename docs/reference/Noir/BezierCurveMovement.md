# BezierCurveMovement

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Represents movement along a Bezier curve over a specified duration.


```csharp
public class BezierCurveMovement
```

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public BezierCurveMovement()

```

## Properties

<a name="Curve"></a>

### `Curve`
<!-- tc:scope public -->
<!-- tc:return_type BezierCurve /noir/reference/Noir/BezierCurve/ -->
<!-- tc:version 1.0.0 -->
Gets or sets the Bezier curve to use for movement.


```csharp
public BezierCurve Curve { get; public set; }

```

<a name="Duration"></a>

### `Duration`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets or sets the duration of the movement along the curve, in seconds.


```csharp
public float Duration { get; public set; }

```

