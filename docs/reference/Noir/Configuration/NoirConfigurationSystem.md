# NoirConfigurationSystem

<!-- tc:namespace Noir.Configuration -->

<!-- tc:assembly Noir.dll -->

Provides access to the active [NoirProjectConfiguration](/noir/reference/Noir/NoirProjectConfiguration/) at runtime.
This class registers itself automatically with the global [ServiceLocator](/noir/reference/Noir/ServiceLocator/)
            during Unity's subsystem initialization, allowing other systems to retrieve the
            current [NoirProjectConfiguration](/noir/reference/Noir/NoirProjectConfiguration/) via dependency injection or service lookup.


```csharp
public class NoirConfigurationSystem : INoirProjectConfigurationAccessor
```

**Implements:** _[INoirProjectConfigurationAccessor](/noir/reference/Noir/Configuration/INoirProjectConfigurationAccessor/)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public NoirConfigurationSystem()

```

## Methods

<a name="GetProjectConfiguration"></a>

### `GetProjectConfiguration()`
<!-- tc:scope public -->
<!-- tc:return_type NoirProjectConfiguration /noir/reference/Noir/NoirProjectConfiguration/ -->
<!-- tc:version 1.0.0 -->
Retrieves the current project configuration.
This method provides a standardized access point for systems that need to
            query global project configuration settings.


```csharp
public virtual NoirProjectConfiguration GetProjectConfiguration()

```

## More information

* [Noir.NoirProjectConfiguration](/noir/reference/Noir/NoirProjectConfiguration/)
* [Noir.ServiceLocator](/noir/reference/Noir/ServiceLocator/)
* [Noir.NoirProjectConfiguration](/noir/reference/Noir/NoirProjectConfiguration/)
