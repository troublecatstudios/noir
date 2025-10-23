# IEnvironment

<!-- tc:namespace Noir.Abstractions -->

<!-- tc:assembly Noir.dll -->

Provides an abstraction layer for accessing environment details.
            Implementations of this interface define how environment variables are retrieved,
            allowing for platform-specific behavior or easier testing through dependency injection.


```csharp
public abstract IEnvironment
```

## Methods

<a name="GetEnvironmentVariable"></a>

### `GetEnvironmentVariable(string)`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Retrieves the value of the specified environment variable.


```csharp
public abstract string GetEnvironmentVariable(string name)

```

**Parameters** <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

