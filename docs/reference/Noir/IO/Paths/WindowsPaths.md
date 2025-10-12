# WindowsPaths

<!-- tc:namespace Noir.IO.Paths -->

<!-- tc:assembly Noir.dll -->


```csharp
public class WindowsPaths : PathsBase, IPlatformPaths
```

**Implements:** _[PathsBase](/noir/reference/Noir/IO/Paths/PathsBase/), [IPlatformPaths](/noir/reference/Noir/IO/Paths/IPlatformPaths/)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public WindowsPaths()

```

## Properties

<a name="ConfigurationDirectory"></a>

### `ConfigurationDirectory`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual string ConfigurationDirectory { get; private set; }

```

<a name="LogDirectory"></a>

### `LogDirectory`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual string LogDirectory { get; private set; }

```

<a name="SaveFileDirectory"></a>

### `SaveFileDirectory`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual string SaveFileDirectory { get; private set; }

```

