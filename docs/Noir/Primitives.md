# Primitives

**Namespace:** Noir <br>
**Assembly:** Noir.dll

```csharp
public static class Primitives
```

### ⛹️‍♀️ Methods
#### RectFromSane3DValues(Vector3, Vector3)
```csharp
public Rect RectFromSane3DValues(Vector3 center, Vector3 size)
```

Creates a [Rect](../) offset down and to the left by half the size, so it can use the same values we use for literally
            every other position calculation within unity.

**Parameters** <br>
`center` [Vector3](../) <br>
`size` [Vector3](../) <br>

**Returns** <br>
[Rect](../) <br>

#### RectFromSaneValues(Vector2, Vector2)
```csharp
public Rect RectFromSaneValues(Vector2 center, Vector2 size)
```

Creates a [Rect](../) offset down and to the left by half the size, so it can use the same values we use for literally
            every other position calculation within unity.

**Parameters** <br>
`center` [Vector2](../) <br>
 <br>
`size` [Vector2](../) <br>
 <br>

**Returns** <br>
[Rect](../) <br>
 <br>

