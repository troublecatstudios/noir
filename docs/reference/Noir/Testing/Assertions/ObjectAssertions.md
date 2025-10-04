# ObjectAssertions

<!-- tc:namespace Noir.Testing.Assertions -->

<!-- tc:assembly NoirEditor.dll -->


```csharp
public static class ObjectAssertions
```

## Methods

### `IsNotNull(IAssertionContext<T>, string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void IsNotNull(IAssertionContext<T> context, string message)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference//noir/reference//noir/reference/Noir/Testing/IAssertionContext-1/) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `IsNull(IAssertionContext<T>, string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void IsNull(IAssertionContext<T> context, string message)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference//noir/reference//noir/reference/Noir/Testing/IAssertionContext-1/) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `IsSameAs(IAssertionContext<T>, T, string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void IsSameAs(IAssertionContext<T> context, T expectedValue,
                      string message)


```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference//noir/reference//noir/reference/Noir/Testing/IAssertionContext-1/) <br>
`expectedValue` [T](/noir/reference//noir/reference//noir/reference/) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

