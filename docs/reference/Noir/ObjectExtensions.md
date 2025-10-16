# ObjectExtensions

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Provides extension methods for safely converting objects to strings.


```csharp
public static class ObjectExtensions
```

## Methods

<a name="ToStringSafe"></a>

### `ToStringSafe(Object, Func<T, TResult>)`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns the string representation of the object, or a custom string if the object is null.


```csharp
public string ToStringSafe(Object o, Func<T, TResult> valueDelegate)

```

**Parameters** <br>
`o` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>
`valueDelegate` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>
 <br>

<a name="ToStringSafe"></a>

### `ToStringSafe(Object)`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns the string representation of the object, or "NULL" if the object is null.


```csharp
public string ToStringSafe(Object o)

```

**Parameters** <br>
`o` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>

