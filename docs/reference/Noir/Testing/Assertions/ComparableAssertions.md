# ComparableAssertions

<!-- tc:namespace Noir.Testing.Assertions -->

<!-- tc:assembly NoirEditor.dll -->


```csharp
public static class ComparableAssertions
```

## Methods

<a name="IsEqualTo"></a>

### `IsEqualTo(IAssertionContext<T>, T, string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void IsEqualTo(IAssertionContext<T> context, T expectedValue,
                       string message)


```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
`expectedValue` [T](/noir/reference/) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="IsGreaterThan"></a>

### `IsGreaterThan(IAssertionContext<T>, T)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void IsGreaterThan(IAssertionContext<T> context, T expectedValue)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
`expectedValue` [T](/noir/reference/) <br>

<a name="IsLessThan"></a>

### `IsLessThan(IAssertionContext<T>, T)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void IsLessThan(IAssertionContext<T> context, T expectedValue)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
`expectedValue` [T](/noir/reference/) <br>

<a name="IsNotEqualTo"></a>

### `IsNotEqualTo(IAssertionContext<T>, T, string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void IsNotEqualTo(IAssertionContext<T> context, T expectedValue,
                          string message)


```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
`expectedValue` [T](/noir/reference/) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="IsWithinRange"></a>

### `IsWithinRange(IAssertionContext<T>, T, T, bool)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void IsWithinRange(IAssertionContext<T> context, T min, T max,
                           bool inclusive)


```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
`min` [T](/noir/reference/) <br>
`max` [T](/noir/reference/) <br>
`inclusive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

