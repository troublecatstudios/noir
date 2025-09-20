# NoirGizmos

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->


```csharp
public static class NoirGizmos
```

## ⛹️‍♀️ Methods

### `DrawArrow(Vector3, Vector3, float, float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void DrawArrow(Vector3 pos, Vector3 direction, float arrowHeadLength, float arrowHeadAngle)
```

**Parameters** <br>
`pos` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
`direction` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
`arrowHeadLength` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`arrowHeadAngle` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

### `DrawArrow(Vector3, Vector3, Color, float, float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void DrawArrow(Vector3 pos, Vector3 direction, Color color, float arrowHeadLength, float arrowHeadAngle)
```

**Parameters** <br>
`pos` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
`direction` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
`color` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
`arrowHeadLength` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`arrowHeadAngle` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

### `DrawBezierCurve(Vector3, BezierCurve, int, float, T?)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void DrawBezierCurve(Vector3 origin, BezierCurve curve, int numberOfPoints, float pointRadius, T? direction)
```

**Parameters** <br>
`origin` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
`curve` [BezierCurve](/noir/reference/Noir/BezierCurve/) <br>
`numberOfPoints` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
`pointRadius` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`direction` [T?](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0) <br>

### `DrawLinesToTargets(GameObject, UnityEvent, Vector3)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void DrawLinesToTargets(GameObject parent, UnityEvent ev, Vector3 offset)
```

**Parameters** <br>
`parent` [GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html) <br>
`ev` [UnityEvent](https://docs.unity3d.com/ScriptReference/Events.UnityEvent.html) <br>
`offset` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>

### `DrawTypeIcon(Vector3, string, float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void DrawTypeIcon(Vector3 position, string label, float iconSize)
```

**Parameters** <br>
`position` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
`label` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`iconSize` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

### `DrawWireArc(Vector3, Vector3, float, float, float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Draws a wire arc.


```csharp
public void DrawWireArc(Vector3 position, Vector3 dir, float anglesRange, float radius, float maxSteps)
```

**Parameters** <br>
`position` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>
`dir` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>
`anglesRange` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`radius` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`maxSteps` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

### `DrawWireCircle(Vector3, float, int)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void DrawWireCircle(Vector3 circleCenter, float circleRadius, int segments)
```

**Parameters** <br>
`circleCenter` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
`circleRadius` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`segments` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

### `DrawWireCircle(Vector3, float, Vector3, int)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void DrawWireCircle(Vector3 circleCenter, float circleRadius, Vector3 circleNormal, int segments)
```

**Parameters** <br>
`circleCenter` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
`circleRadius` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`circleNormal` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
`segments` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

### `DrawX(Vector2, float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void DrawX(Vector2 point, float size)
```

**Parameters** <br>
`point` [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) <br>
`size` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

