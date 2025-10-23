# EquatableAssertions

<!-- tc:namespace Noir.Testing.Assertions -->

<!-- tc:assembly NoirEditor.dll -->

Provides assertion extensions for verifying equality between [IEquatable<T>](https://learn.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=net-7.0) objects.


```csharp
public static class EquatableAssertions
```

## Methods

<a name="IsEquatableTo"></a>

### `IsEquatableTo(IAssertionContext<T>, T)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void IsEquatableTo(IAssertionContext<T> context, T expectedValue)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
`expectedValue` [T](/noir/reference/) <br>

## More information

* [System.IEquatable`1](https://learn.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=net-7.0)
