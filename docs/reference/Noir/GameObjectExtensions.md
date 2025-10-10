# GameObjectExtensions

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->


```csharp
public static class GameObjectExtensions
```

## Methods

<a name="GetGameObjectHierarchy"></a>

### `GetGameObjectHierarchy(GameObject)`
<!-- tc:scope public -->
<!-- tc:return_type IEnumerable\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Walks the current GameObjects hierarchy back out to the root, yielding each parent GameObject along the way.


```csharp
public IEnumerable<T> GetGameObjectHierarchy(GameObject gameObject)

```

**Parameters** <br>
`gameObject` [GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html) <br>
 <br>

<a name="GetGameObjectHierarchyPath"></a>

### `GetGameObjectHierarchyPath(GameObject)`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the current GameObjects hierarchy as a path expression.


```csharp
public string GetGameObjectHierarchyPath(GameObject gameObject)

```

**Parameters** <br>
`gameObject` [GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html) <br>
 <br>

