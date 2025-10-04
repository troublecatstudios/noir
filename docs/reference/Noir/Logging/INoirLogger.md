# INoirLogger

<!-- tc:namespace Noir.Logging -->

<!-- tc:assembly Noir.dll -->


```csharp
public abstract INoirLogger
```

## Methods

### `Debug(string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void Debug(string message, Object context, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `DisableSubsystem(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void DisableSubsystem(string system)

```

**Parameters** <br>
`system` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `EnableSubsystem(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void EnableSubsystem(string system)

```

**Parameters** <br>
`system` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `EndAllTraces()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void EndAllTraces()

```

### `EndTrace(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void EndTrace(string traceName)

```

**Parameters** <br>
`traceName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `Error(string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void Error(string message, Object context, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `Info(string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void Info(string message, Object context, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `StartTrace(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void StartTrace(string traceName)

```

**Parameters** <br>
`traceName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `Trace(string, string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void Trace(string trace, string message, Object context,
                            string subsystem)


```

**Parameters** <br>
`trace` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `Verify(bool, string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void Verify(bool condition, string label, Object context,
                             string subsystem)


```

**Parameters** <br>
`condition` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`label` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `Verify(Func<TResult>, string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void Verify(Func<TResult> condition, string label,
                             Object context, string subsystem)


```

**Parameters** <br>
`condition` [Func\<TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-1?view=net-7.0) <br>
`label` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `Warn(string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void Warn(string message, Object context, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `WriteLog(string, LogLevel, Object, string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void WriteLog(string message, LogLevel level, Object context,
                               string subsystem, string trace)


```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`level` [LogLevel](/noir/reference//noir/reference/Noir/Logging/LogLevel/) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`trace` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

