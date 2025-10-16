# NoirEnum

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Provides helper methods for interacting with [Enum](https://learn.microsoft.com/en-us/dotnet/api/System.Enum?view=net-7.0) values.


```csharp
public static class NoirEnum
```

## Methods

<a name="AllValuesFor"></a>

### `AllValuesFor()`
<!-- tc:scope public -->
<!-- tc:return_type IEnumerable\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns an enumerable collection of all possible values of the specified enum type <typeparamref name="T" />.


```csharp
public IEnumerable<T> AllValuesFor()

```

**Exceptions** <br>
[ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/System.ArgumentException?view=net-7.0) <br>
 <br>
## More information

* [System.Enum](https://learn.microsoft.com/en-us/dotnet/api/System.Enum?view=net-7.0)
