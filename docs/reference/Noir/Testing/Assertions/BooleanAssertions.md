# BooleanAssertions

<!-- tc:namespace Noir.Testing.Assertions -->

<!-- tc:assembly NoirEditor.dll -->

Provides assertion extensions for boolean values,
            allowing expressive and readable test assertions.


```csharp
public static class BooleanAssertions
```

## Methods

<a name="IsFalse"></a>

### `IsFalse(IAssertionContext<T>, string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Asserts that the boolean value in the specified [IAssertionContext<T>](/noir/reference/Noir/Testing/IAssertionContext-1/) is <c>false</c>.


```csharp
public void IsFalse(IAssertionContext<T> context, string message)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
 <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

**Exceptions** <br>
[AssertionException](/noir/reference/) <br>
 <br>
<a name="IsTrue"></a>

### `IsTrue(IAssertionContext<T>, string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Asserts that the boolean value in the specified [IAssertionContext<T>](/noir/reference/Noir/Testing/IAssertionContext-1/) is <c>true</c>.


```csharp
public void IsTrue(IAssertionContext<T> context, string message)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
 <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

**Exceptions** <br>
[AssertionException](/noir/reference/) <br>
 <br>
