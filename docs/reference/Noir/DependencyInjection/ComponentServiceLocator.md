# ComponentServiceLocator

<!-- tc:namespace Noir.DependencyInjection -->

<!-- tc:assembly Noir.dll -->


```csharp
public class ComponentServiceLocator
```

## 🛠 Constructors

### `.ctor(GameObject)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public ComponentServiceLocator(GameObject container)
```

**Parameters** <br>
`container` [GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html) <br>

## ⛹️‍♀️ Methods

### `TryGetService(out T&)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool TryGetService(T& instance)
```

**Parameters** <br>
`instance` [T&](/noir/reference/) <br>

### `GetService()`
<!-- tc:scope public -->
<!-- tc:return_type T /noir/reference/ -->
<!-- tc:version 1.0.0 -->

```csharp
public T GetService()
```

