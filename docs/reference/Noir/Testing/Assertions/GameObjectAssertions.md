# GameObjectAssertions

<!-- tc:namespace Noir.Testing.Assertions -->

<!-- tc:assembly NoirEditor.dll -->


```csharp
public static class GameObjectAssertions
```

## Methods

### `HasComponent(IAssertionContext<T>, string)`
<!-- tc:scope public -->
<!-- tc:return_type IAssertionContext\<T\> /noir/reference//noir/reference//noir/reference/Noir/Testing/IAssertionContext-1/ -->
<!-- tc:version 0.0.0 -->
Asserts that the game object has the given component.


```csharp
public IAssertionContext<T> HasComponent(IAssertionContext<T> context,
                                          string message)


```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference//noir/reference//noir/reference/Noir/Testing/IAssertionContext-1/) <br>
 <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

### `IsActive(IAssertionContext<T>, string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Asserts that the game object is active within the scene hierarchy.


```csharp
public void IsActive(IAssertionContext<T> context, string message)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference//noir/reference//noir/reference/Noir/Testing/IAssertionContext-1/) <br>
 <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

### `IsEnabled(IAssertionContext<T>, string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void IsEnabled(IAssertionContext<T> context, string message)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference//noir/reference//noir/reference/Noir/Testing/IAssertionContext-1/) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `IsNotActive(IAssertionContext<T>, string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Asserts that the game object is not active within the scene hierarchy.


```csharp
public void IsNotActive(IAssertionContext<T> context, string message)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference//noir/reference//noir/reference/Noir/Testing/IAssertionContext-1/) <br>
 <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

