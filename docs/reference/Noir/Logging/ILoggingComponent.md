# ILoggingComponent

<!-- tc:namespace Noir.Logging -->

<!-- tc:assembly Noir.dll -->

Defines a unified interface for components that can produce structured log output.
The [ILoggingComponent](/noir/reference/Noir/Logging/ILoggingComponent/) interface standardizes logging methods across Noir systems,
            providing a consistent set of operations for verification, diagnostics, and subsystem-level tracing.


```csharp
public abstract ILoggingComponent
```

## Methods

<a name="Debug"></a>

### `Debug(string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes a debug-level message to the log, typically used for development or testing.


```csharp
public abstract void Debug(string message, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="Error"></a>

### `Error(string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes an error message to the log, indicating a critical or unrecoverable problem.


```csharp
public abstract void Error(string message, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="Info"></a>

### `Info(string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes an informational message to the log.


```csharp
public abstract void Info(string message, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="Trace"></a>

### `Trace(string, string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes a trace message associated with a named trace context.


```csharp
public abstract void Trace(string trace, string message, string subsystem)

```

**Parameters** <br>
`trace` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="Verify"></a>

### `Verify(bool, string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Verifies that a condition is true, logging a failure if it evaluates to false.


```csharp
public abstract void Verify(bool condition, string label, string subsystem)

```

**Parameters** <br>
`condition` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>
`label` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="Verify"></a>

### `Verify(Func<TResult>, string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Verifies that a condition is true, logging a failure if the delegate returns false.


```csharp
public abstract void Verify(Func<TResult> condition, string label,
                             string subsystem)


```

**Parameters** <br>
`condition` [Func\<TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-1?view=net-7.0) <br>
 <br>
`label` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="Warn"></a>

### `Warn(string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes a warning message to the log, indicating potential issues or unexpected states.


```csharp
public abstract void Warn(string message, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="WriteLog"></a>

### `WriteLog(string, LogLevel, string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Writes a log message with a specified severity, optionally scoped to a subsystem or trace.


```csharp
public abstract void WriteLog(string message, LogLevel level, string subsystem,
                               string trace)


```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`level` [LogLevel](/noir/reference/Noir/Logging/LogLevel/) <br>
 <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`trace` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

## More information

* [Noir.Logging.ILoggingComponent](/noir/reference/Noir/Logging/ILoggingComponent/)
