# ScriptableObjectExtensions

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Provides extension methods for working with [ScriptableObject](https://docs.unity3d.com/ScriptReference/ScriptableObject.html) instances.


```csharp
public static class ScriptableObjectExtensions
```

## Methods

<a name="ToLogStringSafe"></a>

### `ToLogStringSafe(ScriptableObject)`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns a safe string representation of the [ScriptableObject](https://docs.unity3d.com/ScriptReference/ScriptableObject.html),
            using its name if available, or "null" if the object is not set.


```csharp
public string ToLogStringSafe(ScriptableObject so)

```

**Parameters** <br>
`so` [ScriptableObject](https://docs.unity3d.com/ScriptReference/ScriptableObject.html) <br>
 <br>

## More information

* [UnityEngine.ScriptableObject](https://docs.unity3d.com/ScriptReference/ScriptableObject.html)
