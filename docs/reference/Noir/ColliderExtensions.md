# ColliderExtensions

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Extension methods for Unity [Collider](https://docs.unity3d.com/ScriptReference/Collider.html) components.


```csharp
public static class ColliderExtensions
```

## Methods

<a name="SetDimensions"></a>

### `SetDimensions(Collider, Vector2)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets the dimensions of the collider based on the specified size.
            The behavior depends on the specific collider type:
            <list type="bullet"><item>[CapsuleCollider](https://docs.unity3d.com/ScriptReference/CapsuleCollider.html): Sets the radius to x and the height to y.</item></list>


```csharp
public void SetDimensions(Collider collider, Vector2 size)

```

**Parameters** <br>
`collider` [Collider](https://docs.unity3d.com/ScriptReference/Collider.html) <br>
 <br>
`size` [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) <br>
 <br>

**Exceptions** <br>
[InvalidOperationException](https://learn.microsoft.com/en-us/dotnet/api/System.InvalidOperationException?view=net-7.0) <br>
 <br>
## More information

* [UnityEngine.Collider](https://docs.unity3d.com/ScriptReference/Collider.html)
