# LoggerSingleton

**Namespace:** Noir.Logging <br>
**Assembly:** Noir.dll

```csharp
public sealed class LoggerSingleton
```

### 📦 Properties
#### Instance
```csharp
public static LoggerSingleton Instance { get; }
```

**Returns** <br>
[LoggerSingleton](../../Noir/Logging/LoggerSingleton.html) <br>
### ⛹️‍♀️ Methods
#### Debug(string, Object, string)
```csharp
public void Debug(string message, Object context, string subsystem)
```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### Debug(string, string)
```csharp
public void Debug(string message, string subsystem)
```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### DisableSubsystem(string)
```csharp
public void DisableSubsystem(string system)
```

**Parameters** <br>
`system` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### EnableSubsystem(string)
```csharp
public void EnableSubsystem(string system)
```

**Parameters** <br>
`system` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### EndAllTraces()
```csharp
public void EndAllTraces()
```

#### EndTrace(string)
```csharp
public void EndTrace(string traceName)
```

**Parameters** <br>
`traceName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### Error(string, Object, string)
```csharp
public void Error(string message, Object context, string subsystem)
```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### Error(string, string)
```csharp
public void Error(string message, string subsystem)
```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### Info(string, Object, string)
```csharp
public void Info(string message, Object context, string subsystem)
```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### Info(string, string)
```csharp
public void Info(string message, string subsystem)
```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### Sample(string, float, string)
```csharp
public void Sample(string token, float rate, string message)
```

**Parameters** <br>
`token` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`rate` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### StartTrace(string)
```csharp
public void StartTrace(string traceName)
```

**Parameters** <br>
`traceName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### Trace(string, string, Object, string)
```csharp
public void Trace(string trace, string message, Object context, string subsystem)
```

**Parameters** <br>
`trace` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### Trace(string, string, string)
```csharp
public void Trace(string trace, string message, string subsystem)
```

**Parameters** <br>
`trace` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### Verify(bool, string, Object, string)
```csharp
public void Verify(bool condition, string label, Object context, string subsystem)
```

**Parameters** <br>
`condition` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`label` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### Verify(bool, string, string)
```csharp
public void Verify(bool condition, string label, string subsystem)
```

**Parameters** <br>
`condition` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`label` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### Verify(Func<TResult>, string, Object, string)
```csharp
public void Verify(Func<TResult> condition, string label, Object context, string subsystem)
```

**Parameters** <br>
`condition` [Func\<TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-1?view=net-7.0) <br>
`label` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### Verify(Func<TResult>, string, string)
```csharp
public void Verify(Func<TResult> condition, string label, string subsystem)
```

**Parameters** <br>
`condition` [Func\<TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-1?view=net-7.0) <br>
`label` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### Warn(string, Object, string)
```csharp
public void Warn(string message, Object context, string subsystem)
```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### Warn(string, string)
```csharp
public void Warn(string message, string subsystem)
```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### WriteLog(string, LogLevel, Object, string, string)
```csharp
public void WriteLog(string message, LogLevel level, Object context, string subsystem, string trace)
```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`level` [LogLevel](../../Noir/Logging/LogLevel.html) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`trace` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

