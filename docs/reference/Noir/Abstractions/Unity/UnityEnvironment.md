# UnityEnvironment

<!-- tc:namespace Noir.Abstractions.Unity -->

<!-- tc:assembly Noir.dll -->

Provides access to environment variables using the standard
            [Environment](https://learn.microsoft.com/en-us/dotnet/api/System.Environment?view=net-7.0) API within the Unity runtime environment.


```csharp
public class UnityEnvironment : IEnvironment
```

**Implements:** _[IEnvironment](/noir/reference/Noir/Abstractions/IEnvironment/)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public UnityEnvironment()

```

## Methods

<a name="GetEnvironmentVariable"></a>

### `GetEnvironmentVariable(string)`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual string GetEnvironmentVariable(string name)

```

**Parameters** <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

## More information

* [System.Environment](https://learn.microsoft.com/en-us/dotnet/api/System.Environment?view=net-7.0)
