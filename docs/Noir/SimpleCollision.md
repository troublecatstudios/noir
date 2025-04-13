# SimpleCollision

**Namespace:** Noir <br>
**Assembly:** Noir.dll

```csharp
public static class SimpleCollision
```

### ⛹️‍♀️ Methods
#### Check(Vector3, Vector3, float, LayerMask, CollisionCheckMethod, int)
```csharp
public bool Check(Vector3 origin, Vector3 direction, float length, LayerMask mask, CollisionCheckMethod method, int hitThreshold)
```

Performs a 2D or 3D collision check via raycast within the Unity Physics Engine.

**Parameters** <br>
`origin` [Vector3](../) <br>
 <br>
`direction` [Vector3](../) <br>
 <br>
`length` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`mask` [LayerMask](../) <br>
 <br>
`method` [CollisionCheckMethod](../Noir/CollisionCheckMethod.html) <br>
 <br>
`hitThreshold` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

#### CheckPosition(Collider2D, Vector2)
```csharp
public bool CheckPosition(Collider2D collider, Vector2 position)
```

**Parameters** <br>
`collider` [Collider2D](../) <br>
`position` [Vector2](../) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### TryGetHit(Vector3, Vector3, float, LayerMask, CollisionCheckMethod, out Vector3&)
```csharp
public bool TryGetHit(Vector3 origin, Vector3 direction, float length, LayerMask mask, CollisionCheckMethod method, Vector3& hitPosition)
```

**Parameters** <br>
`origin` [Vector3](../) <br>
`direction` [Vector3](../) <br>
`length` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`mask` [LayerMask](../) <br>
`method` [CollisionCheckMethod](../Noir/CollisionCheckMethod.html) <br>
`hitPosition` [Vector3&](../) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### GetContactPointFast(Bounds, Bounds)
```csharp
public Vector2 GetContactPointFast(Bounds attackBounds, Bounds defenseBounds)
```

**Parameters** <br>
`attackBounds` [Bounds](../) <br>
`defenseBounds` [Bounds](../) <br>

**Returns** <br>
[Vector2](../) <br>

#### GetRandomPointWithinCollider(BoxCollider2D)
```csharp
public Vector2 GetRandomPointWithinCollider(BoxCollider2D collider)
```

**Parameters** <br>
`collider` [BoxCollider2D](../) <br>

**Returns** <br>
[Vector2](../) <br>

#### GetRandomPointWithinCollider(CircleCollider2D)
```csharp
public Vector2 GetRandomPointWithinCollider(CircleCollider2D collider)
```

**Parameters** <br>
`collider` [CircleCollider2D](../) <br>

**Returns** <br>
[Vector2](../) <br>

