# UnityRectExtensions

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Provides extension methods for working with [Rect](https://docs.unity3d.com/ScriptReference/Rect.html) structures in Unity.


```csharp
public static class UnityRectExtensions
```

## Methods

<a name="GetRandomPositionInside"></a>

### `GetRandomPositionInside(Rect, Vector2)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->
Returns a random position within the bounds of the rectangle, considering the specified padding.


```csharp
public Vector2 GetRandomPositionInside(Rect rect, Vector2 padding)

```

**Parameters** <br>
`rect` [Rect](https://docs.unity3d.com/ScriptReference/Rect.html) <br>
 <br>
`padding` [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) <br>
 <br>

<a name="GetRandomPositionInside"></a>

### `GetRandomPositionInside(Rect)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->
Returns a random position within the bounds of the rectangle.


```csharp
public Vector2 GetRandomPositionInside(Rect rect)

```

**Parameters** <br>
`rect` [Rect](https://docs.unity3d.com/ScriptReference/Rect.html) <br>
 <br>

<a name="TopLeft"></a>

### `TopLeft(Rect)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->
Returns the top-left corner position of the rectangle.


```csharp
public Vector2 TopLeft(Rect rect)

```

**Parameters** <br>
`rect` [Rect](https://docs.unity3d.com/ScriptReference/Rect.html) <br>
 <br>

## More information

* [UnityEngine.Rect](https://docs.unity3d.com/ScriptReference/Rect.html)
