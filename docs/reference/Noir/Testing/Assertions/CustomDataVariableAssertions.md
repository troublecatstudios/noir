# CustomDataVariableAssertions

<!-- tc:namespace Noir.Testing.Assertions -->

<!-- tc:assembly NoirEditor.dll -->

Provides assertion extensions for verifying the state and contents of [DataVariable<T>](/noir/reference/Noir/Variables/DataVariable-1/) instances.


```csharp
public static class CustomDataVariableAssertions
```

## Methods

<a name="HasValue"></a>

### `HasValue(IAssertionContext<T>, T, string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void HasValue(IAssertionContext<T> context, T value, string message)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
`value` [T](/noir/reference/) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

## More information

* [Noir.Variables.DataVariable`1](/noir/reference/Noir/Variables/DataVariable-1/)
