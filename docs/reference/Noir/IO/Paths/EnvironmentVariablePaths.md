# EnvironmentVariablePaths

**Namespace:** Noir.IO.Paths <br>
**Assembly:** Noir.dll

```csharp
public class EnvironmentVariablePaths : IPlatformPaths
```

**Implements:** _[IPlatformPaths](../../../Noir/IO/Paths/IPlatformPaths.html)_

### 🛠 Constructors
```csharp
public EnvironmentVariablePaths(IPlatformPaths fallback, AbstractEnvironment environment)
```

**Parameters** <br>
`fallback` [IPlatformPaths](../../../Noir/IO/Paths/IPlatformPaths.html) <br>
`environment` [AbstractEnvironment](../../../Noir/Abstractions/AbstractEnvironment.html) <br>

### 📦 Properties
#### ConfigurationDirectory
```csharp
public virtual string ConfigurationDirectory { get; private set; }
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### LogDirectory
```csharp
public virtual string LogDirectory { get; private set; }
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### SaveFileDirectory
```csharp
public virtual string SaveFileDirectory { get; private set; }
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
