# Primitives

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Provides utility methods for working with various UnityEngine structures.


```csharp
public static class Primitives
```

## Methods

<a name="RectFromSane3DValues"></a>

### `RectFromSane3DValues(Vector3, Vector3)`
<!-- tc:scope public -->
<!-- tc:return_type Rect https://docs.unity3d.com/ScriptReference/Rect.html -->
<!-- tc:version 1.0.0 -->
Creates a [Rect](https://docs.unity3d.com/ScriptReference/Rect.html) offset down and to the left by half the size, so it can use the same values we use for literally
            every other position calculation within unity.
This method uses the Z axis in the given <see cref="T:UnityEngine.Vector3" /> as the Y axis within the new [Rect](https://docs.unity3d.com/ScriptReference/Rect.html).


```csharp
public Rect RectFromSane3DValues(Vector3 center, Vector3 size)

```

**Parameters** <br>
`center` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
`size` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>

<a name="RectFromSaneValues"></a>

### `RectFromSaneValues(Vector2, Vector2)`
<!-- tc:scope public -->
<!-- tc:return_type Rect https://docs.unity3d.com/ScriptReference/Rect.html -->
<!-- tc:version 1.0.0 -->
Creates a [Rect](https://docs.unity3d.com/ScriptReference/Rect.html) offset down and to the left by half the size, so it can use the same values we use for literally
            every other position calculation within unity.


```csharp
public Rect RectFromSaneValues(Vector2 center, Vector2 size)

```

**Parameters** <br>
`center` [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) <br>
 <br>
`size` [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) <br>
 <br>

