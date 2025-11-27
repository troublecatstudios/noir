# INoirLogger

<!-- tc:namespace Noir.Logging -->

<!-- tc:assembly Noir.dll -->

Defines the contract for Noir's logging backend, providing structured, subsystem-aware log output.
Implementations of [INoirLogger](/noir/reference/Noir/Logging/INoirLogger/) handle core logging responsibilities across all systems,
            including verification, tracing, and dynamic subsystem control. Typical implementations include
            in-memory loggers, Unity console output, or file-based logging systems.


```csharp
public abstract INoirLogger
```

## Methods

<a name="Debug"></a>

### `Debug(string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes a debug-level message to the log, typically used for detailed diagnostics during development.


```csharp
public abstract void Debug(string message, Object context, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="DisableSubsystem"></a>

### `DisableSubsystem(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Disables logging for a specific subsystem.


```csharp
public abstract void DisableSubsystem(string system)

```

**Parameters** <br>
`system` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="EnableSubsystem"></a>

### `EnableSubsystem(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Enables logging for a specific subsystem.


```csharp
public abstract void EnableSubsystem(string system)

```

**Parameters** <br>
`system` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="EndAllTraces"></a>

### `EndAllTraces()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Ends all active trace contexts and disables trace mode.


```csharp
public abstract void EndAllTraces()

```

<a name="EndTrace"></a>

### `EndTrace(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Ends an active trace context by name.


```csharp
public abstract void EndTrace(string traceName)

```

**Parameters** <br>
`traceName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="Error"></a>

### `Error(string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes an error message to the log, indicating a critical or unrecoverable problem.


```csharp
public abstract void Error(string message, Object context, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="Info"></a>

### `Info(string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes an informational message to the log.


```csharp
public abstract void Info(string message, Object context, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="StartTrace"></a>

### `StartTrace(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Starts a new trace context for fine-grained debugging and performance tracking.


```csharp
public abstract void StartTrace(string traceName)

```

**Parameters** <br>
`traceName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="Trace"></a>

### `Trace(string, string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes a trace message associated with a named trace context.


```csharp
public abstract void Trace(string trace, string message, Object context,
                            string subsystem)


```

**Parameters** <br>
`trace` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="Verify"></a>

### `Verify(bool, string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Verifies that a condition is true, logging a failure if it evaluates to false.


```csharp
public abstract void Verify(bool condition, string label, Object context,
                             string subsystem)


```

**Parameters** <br>
`condition` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>
`label` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="Verify"></a>

### `Verify(Func<TResult>, string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Verifies that a condition is true, logging a failure if the delegate returns false.


```csharp
public abstract void Verify(Func<TResult> condition, string label,
                             Object context, string subsystem)


```

**Parameters** <br>
`condition` [Func\<TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-1?view=net-7.0) <br>
 <br>
`label` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="Warn"></a>

### `Warn(string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes a warning message to the log, indicating potential issues or unexpected behavior.


```csharp
public abstract void Warn(string message, Object context, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="WriteLog"></a>

### `WriteLog(string, LogLevel, Object, string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes a log message with a specified severity, optionally scoped to a subsystem or trace.


```csharp
public abstract void WriteLog(string message, LogLevel level, Object context,
                               string subsystem, string trace)


```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`level` [LogLevel](/noir/reference/Noir/Logging/LogLevel/) <br>
 <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`trace` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

## More information

* [Noir.Logging.INoirLogger](/noir/reference/Noir/Logging/INoirLogger/)
