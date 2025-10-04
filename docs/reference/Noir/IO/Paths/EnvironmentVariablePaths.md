# EnvironmentVariablePaths

<!-- tc:namespace Noir.IO.Paths -->

<!-- tc:assembly Noir.dll -->


```csharp
public class EnvironmentVariablePaths : IPlatformPaths
```

**Implements:** _[IPlatformPaths](/noir/reference//noir/reference//noir/reference/Noir/IO/Paths/IPlatformPaths.html)_

## Constructors

### `.ctor(IPlatformPaths, AbstractEnvironment)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public EnvironmentVariablePaths(IPlatformPaths fallback,
                                 AbstractEnvironment environment)


```

**Parameters** <br>
`fallback` [IPlatformPaths](/noir/reference//noir/reference//noir/reference/Noir/IO/Paths/IPlatformPaths.html) <br>
`environment` [AbstractEnvironment](/noir/reference//noir/reference//noir/reference/Noir/Abstractions/AbstractEnvironment.html) <br>

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

