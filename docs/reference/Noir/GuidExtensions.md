# GuidExtensions

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Provides extension methods for working with [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=net-7.0) values.


```csharp
public static class GuidExtensions
```

## Methods

<a name="ToInt"></a>

### `ToInt(Guid)`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Converts a [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=net-7.0) to an integer representation by hashing its character values.


```csharp
public int ToInt(Guid guid)

```

**Parameters** <br>
`guid` [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=net-7.0) <br>
 <br>

## More information

* [System.Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=net-7.0)
