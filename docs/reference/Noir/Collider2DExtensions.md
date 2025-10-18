# Collider2DExtensions

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Extension methods for Unity [Collider2D](https://docs.unity3d.com/ScriptReference/Collider2D.html) components.


```csharp
public static class Collider2DExtensions
```

## Methods

<a name="SetDimensions"></a>

### `SetDimensions(Collider2D, Vector2)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets the dimensions of the 2D collider based on the specified size.
            The behavior depends on the specific collider type:
            <list type="bullet"><item>[PolygonCollider2D](https://docs.unity3d.com/ScriptReference/PolygonCollider2D.html): Throws an exception as dimensions cannot be set directly.</item></list>


```csharp
public void SetDimensions(Collider2D collider, Vector2 size)

```

**Parameters** <br>
`collider` [Collider2D](https://docs.unity3d.com/ScriptReference/Collider2D.html) <br>
 <br>
`size` [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) <br>
 <br>

**Exceptions** <br>
[InvalidOperationException](https://learn.microsoft.com/en-us/dotnet/api/System.InvalidOperationException?view=net-7.0) <br>
 <br>
## More information

* [UnityEngine.Collider2D](https://docs.unity3d.com/ScriptReference/Collider2D.html)
