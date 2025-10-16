# NoirGizmos

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Provides helper methods for drawing gizmos and handles in Unity editor and runtime.


```csharp
public static class NoirGizmos
```

## Methods

<a name="DrawArrow"></a>

### `DrawArrow(Vector3, Vector3, float, float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Draws an arrow gizmo at the given position and direction using the current Gizmos color.


```csharp
public void DrawArrow(Vector3 pos, Vector3 direction, float arrowHeadLength,
                       float arrowHeadAngle)


```

**Parameters** <br>
`pos` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>
`direction` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>
`arrowHeadLength` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`arrowHeadAngle` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

<a name="DrawArrow"></a>

### `DrawArrow(Vector3, Vector3, Color, float, float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Draws an arrow gizmo at the given position and direction, with a specified color.


```csharp
public void DrawArrow(Vector3 pos, Vector3 direction, Color color,
                       float arrowHeadLength, float arrowHeadAngle)


```

**Parameters** <br>
`pos` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>
`direction` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>
`color` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>
`arrowHeadLength` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`arrowHeadAngle` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

<a name="DrawBezierCurve"></a>

### `DrawBezierCurve(Vector3, BezierCurve, int, float, T?)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Draws a quadratic Bezier curve using the specified origin and curve definition.


```csharp
public void DrawBezierCurve(Vector3 origin, BezierCurve curve,
                             int numberOfPoints, float pointRadius,
                             T? direction)


```

**Parameters** <br>
`origin` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>
`curve` [BezierCurve](/noir/reference/Noir/BezierCurve/) <br>
 <br>
`numberOfPoints` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>
`pointRadius` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`direction` [T?](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0) <br>
 <br>

<a name="DrawLinesToTargets"></a>

### `DrawLinesToTargets(GameObject, UnityEvent, Vector3)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Draws dotted lines from a parent GameObject to the targets of a UnityEvent in the Unity Editor.


```csharp
public void DrawLinesToTargets(GameObject parent, UnityEvent ev, Vector3 offset)

```

**Parameters** <br>
`parent` [GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html) <br>
 <br>
`ev` [UnityEvent](https://docs.unity3d.com/ScriptReference/Events.UnityEvent.html) <br>
 <br>
`offset` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>

<a name="DrawTypeIcon"></a>

### `DrawTypeIcon(Vector3, string, float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Draws an icon and label for the specified type at the given position in the scene view.
            Only works in the Unity Editor.


```csharp
public void DrawTypeIcon(Vector3 position, string label, float iconSize)

```

**Parameters** <br>
`position` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>
`label` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`iconSize` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

<a name="DrawWireArc"></a>

### `DrawWireArc(Vector3, Vector3, float, float, float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Draws a wire arc.


```csharp
public void DrawWireArc(Vector3 position, Vector3 dir, float anglesRange,
                         float radius, float maxSteps)


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

<a name="DrawWireCircle"></a>

### `DrawWireCircle(Vector3, float, int)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Draws a wireframe circle at the specified center and radius, oriented upwards.


```csharp
public void DrawWireCircle(Vector3 circleCenter, float circleRadius,
                            int segments)


```

**Parameters** <br>
`circleCenter` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>
`circleRadius` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`segments` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>

<a name="DrawWireCircle"></a>

### `DrawWireCircle(Vector3, float, Vector3, int)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Draws a wireframe circle at the specified center, radius, and normal direction.


```csharp
public void DrawWireCircle(Vector3 circleCenter, float circleRadius,
                            Vector3 circleNormal, int segments)


```

**Parameters** <br>
`circleCenter` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>
`circleRadius` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`circleNormal` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>
`segments` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>

<a name="DrawX"></a>

### `DrawX(Vector2, float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Draws an 'X' shape wireframe at a given 2D point.


```csharp
public void DrawX(Vector2 point, float size)

```

**Parameters** <br>
`point` [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) <br>
 <br>
`size` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

