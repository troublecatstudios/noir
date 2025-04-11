# GameObjectExtensions

**Namespace:** Noir <br>
**Assembly:** Noir.dll

```csharp
public static class GameObjectExtensions
```

### ⛹️‍♀️ Methods
#### GetGameObjectHierarchy(GameObject)
```csharp
public IEnumerable<T> GetGameObjectHierarchy(GameObject gameObject)
```

Walks the current GameObjects hierarchy back out to the root, yielding each parent GameObject along the way.

**Parameters** <br>
`gameObject` [GameObject](../) <br>
 <br>

**Returns** <br>
[IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>
 <br>

#### GetGameObjectHierarchyPath(GameObject)
```csharp
public string GetGameObjectHierarchyPath(GameObject gameObject)
```

Gets the current GameObjects hierarchy as a path expression.

**Parameters** <br>
`gameObject` [GameObject](../) <br>
 <br>

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

