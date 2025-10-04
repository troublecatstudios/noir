# WindowsPaths

<!-- tc:namespace Noir.IO.Paths -->

<!-- tc:assembly Noir.dll -->


```csharp
public class WindowsPaths : PathsBase, IPlatformPaths
```

**Implements:** _[PathsBase](/noir/reference//noir/reference//noir/reference/Noir/IO/Paths/PathsBase.html), [IPlatformPaths](/noir/reference//noir/reference//noir/reference/Noir/IO/Paths/IPlatformPaths.html)_

## Constructors

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public WindowsPaths()

```

## Properties

### `ConfigurationDirectory`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual string ConfigurationDirectory { get; private set; }

```

### `LogDirectory`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual string LogDirectory { get; private set; }

```

### `SaveFileDirectory`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual string SaveFileDirectory { get; private set; }

```

