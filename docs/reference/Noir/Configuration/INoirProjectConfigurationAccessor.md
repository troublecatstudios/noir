# INoirProjectConfigurationAccessor

<!-- tc:namespace Noir.Configuration -->

<!-- tc:assembly Noir.dll -->

Defines a contract for accessing the active [NoirProjectConfiguration](/noir/reference/Noir/NoirProjectConfiguration/) instance.
Implementations of this interface provide a centralized way to retrieve
            the current project configuration data used throughout the application or game.
            This abstraction helps decouple configuration retrieval from specific storage or loading mechanisms.


```csharp
public abstract INoirProjectConfigurationAccessor
```

## Methods

<a name="GetProjectConfiguration"></a>

### `GetProjectConfiguration()`
<!-- tc:scope public -->
<!-- tc:return_type NoirProjectConfiguration /noir/reference/Noir/NoirProjectConfiguration/ -->
<!-- tc:version 1.0.0 -->
Retrieves the current project configuration.


```csharp
public abstract NoirProjectConfiguration GetProjectConfiguration()

```

## More information

* [Noir.NoirProjectConfiguration](/noir/reference/Noir/NoirProjectConfiguration/)
