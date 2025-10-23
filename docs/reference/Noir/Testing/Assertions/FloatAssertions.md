# FloatAssertions

<!-- tc:namespace Noir.Testing.Assertions -->

<!-- tc:assembly NoirEditor.dll -->

Provides assertion extensions for validating approximate equality between floating-point values.


```csharp
public static class FloatAssertions
```

## Methods

<a name="IsApproximately"></a>

### `IsApproximately(IAssertionContext<T>, float, float, string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Asserts that the target float value is approximately equal to the specified expected value,
            within a given tolerance (<paramref name="epsilon" />).


```csharp
public void IsApproximately(IAssertionContext<T> context, float value,
                             float epsilon, string message)


```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
 <br>
`value` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`epsilon` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

**Exceptions** <br>
[AssertionException](/noir/reference/) <br>
 <br>
