# PlatformHelper

<!-- tc:namespace NoirEditor -->

<!-- tc:assembly NoirEditor.dll -->


```csharp
public class PlatformHelper
```

## Properties

<a name="Instance"></a>

### `Instance`
<!-- tc:scope private -->
<!-- tc:return_type PlatformHelper /noir/reference/NoirEditor/PlatformHelper/ -->
<!-- tc:version 0.0.0 -->
Gets a singleton instance of the [PlatformHelper](/noir/reference/NoirEditor/PlatformHelper/).


```csharp
public readonly static PlatformHelper Instance;

```

## Methods

<a name="NormalizePath"></a>

### `NormalizePath(string)`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 0.0.0 -->
Converts a path that uses <c>\</c> as its path separator to a path that uses <c>/</c>.


```csharp
public string NormalizePath(string fileSystemPath)

```

**Parameters** <br>
`fileSystemPath` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

