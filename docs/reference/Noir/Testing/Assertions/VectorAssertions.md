# VectorAssertions

<!-- tc:namespace Noir.Testing.Assertions -->

<!-- tc:assembly NoirEditor.dll -->

Provides assertion extensions for validating [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) values.


```csharp
public static class VectorAssertions
```

## Methods

<a name="IsZero"></a>

### `IsZero(IAssertionContext<T>, string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Asserts that the given [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) has all x, y, and z components equal to <c>0</c>.


```csharp
public void IsZero(IAssertionContext<T> context, string message)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
 <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

## More information

* [UnityEngine.Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html)
* [UnityEngine.Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html)
