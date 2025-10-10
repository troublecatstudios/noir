# EnvironmentVariablePaths

<!-- tc:namespace Noir.IO.Paths -->

<!-- tc:assembly Noir.dll -->


```csharp
public class EnvironmentVariablePaths : IPlatformPaths
```

**Implements:** _[IPlatformPaths](/noir/reference//noir/reference//noir/reference/Noir/IO/Paths/IPlatformPaths/)_

## Constructors

<a name=".ctor"></a>

### `.ctor(IPlatformPaths, AbstractEnvironment)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public EnvironmentVariablePaths(IPlatformPaths fallback,
                                 AbstractEnvironment environment)


```

**Parameters** <br>
`fallback` [IPlatformPaths](/noir/reference//noir/reference//noir/reference/Noir/IO/Paths/IPlatformPaths/) <br>
`environment` [AbstractEnvironment](/noir/reference//noir/reference//noir/reference/Noir/Abstractions/AbstractEnvironment/) <br>

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

