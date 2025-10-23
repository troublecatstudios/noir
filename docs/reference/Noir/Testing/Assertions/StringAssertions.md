# StringAssertions

<!-- tc:namespace Noir.Testing.Assertions -->

<!-- tc:assembly NoirEditor.dll -->

Provides assertion extensions for validating string values.


```csharp
public static class StringAssertions
```

## Methods

<a name="Contains"></a>

### `Contains(IAssertionContext<T>, string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Asserts that the target string contains the specified expected substring.


```csharp
public void Contains(IAssertionContext<T> context, string expected)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
 <br>
`expected` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="EndsWith"></a>

### `EndsWith(IAssertionContext<T>, string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Asserts that the target string ends with the specified expected string.


```csharp
public void EndsWith(IAssertionContext<T> context, string expected)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
 <br>
`expected` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="IsExactly"></a>

### `IsExactly(IAssertionContext<T>, string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Asserts that the target string is exactly equal to the expected string.


```csharp
public void IsExactly(IAssertionContext<T> context, string expected)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
 <br>
`expected` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="StartsWith"></a>

### `StartsWith(IAssertionContext<T>, string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Asserts that the target string starts with the specified expected string.


```csharp
public void StartsWith(IAssertionContext<T> context, string expected)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
 <br>
`expected` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

