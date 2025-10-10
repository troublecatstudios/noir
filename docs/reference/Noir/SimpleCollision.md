# SimpleCollision

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->


```csharp
public static class SimpleCollision
```

## Methods

<a name="Check"></a>

### `Check(Vector3, Vector3, float, LayerMask, CollisionCheckMethod, int)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Performs a 2D or 3D collision check via raycast within the Unity Physics Engine.


```csharp
public bool Check(Vector3 origin, Vector3 direction, float length,
                   LayerMask mask, CollisionCheckMethod method,
                   int hitThreshold)


```

**Parameters** <br>
`origin` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>
`direction` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>
`length` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`mask` [LayerMask](https://docs.unity3d.com/ScriptReference/LayerMask.html) <br>
 <br>
`method` [CollisionCheckMethod](/noir/reference/Noir/CollisionCheckMethod/) <br>
 <br>
`hitThreshold` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>

<a name="CheckPosition"></a>

### `CheckPosition(Collider2D, Vector2)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool CheckPosition(Collider2D collider, Vector2 position)

```

**Parameters** <br>
`collider` [Collider2D](https://docs.unity3d.com/ScriptReference/Collider2D.html) <br>
`position` [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) <br>

<a name="TryGetHit"></a>

### `TryGetHit(Vector3, Vector3, float, LayerMask, CollisionCheckMethod, out Vector3&)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool TryGetHit(Vector3 origin, Vector3 direction, float length,
                       LayerMask mask, CollisionCheckMethod method,
                       Vector3& hitPosition)


```

**Parameters** <br>
`origin` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
`direction` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
`length` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`mask` [LayerMask](https://docs.unity3d.com/ScriptReference/LayerMask.html) <br>
`method` [CollisionCheckMethod](/noir/reference/Noir/CollisionCheckMethod/) <br>
`hitPosition` [Vector3&](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>

<a name="GetContactPointFast"></a>

### `GetContactPointFast(Bounds, Bounds)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector2 GetContactPointFast(Bounds attackBounds, Bounds defenseBounds)

```

**Parameters** <br>
`attackBounds` [Bounds](https://docs.unity3d.com/ScriptReference/Bounds.html) <br>
`defenseBounds` [Bounds](https://docs.unity3d.com/ScriptReference/Bounds.html) <br>

<a name="GetRandomPointWithinCollider"></a>

### `GetRandomPointWithinCollider(BoxCollider2D)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector2 GetRandomPointWithinCollider(BoxCollider2D collider)

```

**Parameters** <br>
`collider` [BoxCollider2D](https://docs.unity3d.com/ScriptReference/BoxCollider2D.html) <br>

<a name="GetRandomPointWithinCollider"></a>

### `GetRandomPointWithinCollider(CircleCollider2D)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector2 GetRandomPointWithinCollider(CircleCollider2D collider)

```

**Parameters** <br>
`collider` [CircleCollider2D](https://docs.unity3d.com/ScriptReference/CircleCollider2D.html) <br>

