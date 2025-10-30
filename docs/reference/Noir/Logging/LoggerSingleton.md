# LoggerSingleton

<!-- tc:namespace Noir.Logging -->

<!-- tc:assembly Noir.dll -->

A globally accessible singleton logger that provides centralized logging, tracing, and subsystem management
            for the Noir framework. This acts as a façade over the configured [INoirLogger](/noir/reference/Noir/Logging/INoirLogger/) implementation.


```csharp
public sealed class LoggerSingleton
```

## Properties

<a name="Instance"></a>

### `Instance`
<!-- tc:scope public -->
<!-- tc:return_type LoggerSingleton /noir/reference/Noir/Logging/LoggerSingleton/ -->
<!-- tc:version 1.0.0 -->
Gets the global [LoggerSingleton](/noir/reference/Noir/Logging/LoggerSingleton/) instance.


```csharp
public static LoggerSingleton Instance { get; }

```

## Methods

<a name="Debug"></a>

### `Debug(string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes a debug message to the log.


```csharp
public void Debug(string message, Object context, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="Debug"></a>

### `Debug(string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes a debug message associated with a specific type as context.


```csharp
public void Debug(string message, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="DisableSubsystem"></a>

### `DisableSubsystem(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Disables logging output for a specific subsystem.


```csharp
public void DisableSubsystem(string system)

```

**Parameters** <br>
`system` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="EnableSubsystem"></a>

### `EnableSubsystem(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Enables logging output for a specific subsystem.


```csharp
public void EnableSubsystem(string system)

```

**Parameters** <br>
`system` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="EndAllTraces"></a>

### `EndAllTraces()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Ends all currently active traces.


```csharp
public void EndAllTraces()

```

<a name="EndTrace"></a>

### `EndTrace(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Ends a trace previously started with [LoggerSingleton.StartTrace(System.String)](/noir/reference/Noir/Logging/LoggerSingleton/#starttrace(string).


```csharp
public void EndTrace(string traceName)

```

**Parameters** <br>
`traceName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="Error"></a>

### `Error(string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes an error message to the log.


```csharp
public void Error(string message, Object context, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="Error"></a>

### `Error(string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes an error message associated with a specific type as context.


```csharp
public void Error(string message, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="Info"></a>

### `Info(string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes an informational message to the log.


```csharp
public void Info(string message, Object context, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="Info"></a>

### `Info(string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes an informational message associated with a specific type as context.


```csharp
public void Info(string message, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="Sample"></a>

### `Sample(string, float, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Logs a message only at a specified sample rate, to prevent log spam from frequently occurring events.


```csharp
public void Sample(string token, float rate, string message)

```

**Parameters** <br>
`token` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`rate` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="StartTrace"></a>

### `StartTrace(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Starts a named trace, allowing performance or behavior to be tracked across log events.


```csharp
public void StartTrace(string traceName)

```

**Parameters** <br>
`traceName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="Trace"></a>

### `Trace(string, string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes a trace message associated with a named trace.


```csharp
public void Trace(string trace, string message, Object context,
                   string subsystem)


```

**Parameters** <br>
`trace` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="Trace"></a>

### `Trace(string, string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes a trace message associated with a specific type as context.


```csharp
public void Trace(string trace, string message, string subsystem)

```

**Parameters** <br>
`trace` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="Verify"></a>

### `Verify(bool, string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Verifies that a condition is true and logs the result.


```csharp
public void Verify(bool condition, string label, Object context,
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

### `Verify(bool, string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Verifies a condition for a given type context and logs the result.


```csharp
public void Verify(bool condition, string label, string subsystem)

```

**Parameters** <br>
`condition` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`label` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="Verify"></a>

### `Verify(Func<TResult>, string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Verifies that a condition is true and logs the result. The condition is provided as a function delegate.


```csharp
public void Verify(Func<TResult> condition, string label, Object context,
                    string subsystem)


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

<a name="Verify"></a>

### `Verify(Func<TResult>, string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Verifies a condition (provided as a delegate) for a given type context and logs the result.


```csharp
public void Verify(Func<TResult> condition, string label, string subsystem)

```

**Parameters** <br>
`condition` [Func\<TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-1?view=net-7.0) <br>
`label` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="Warn"></a>

### `Warn(string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes a warning message to the log.


```csharp
public void Warn(string message, Object context, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="Warn"></a>

### `Warn(string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes a warning message associated with a specific type as context.


```csharp
public void Warn(string message, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="WriteLog"></a>

### `WriteLog(string, LogLevel, Object, string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes a log message at a specified level, optionally including context, subsystem, and trace information.


```csharp
public void WriteLog(string message, LogLevel level, Object context,
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
