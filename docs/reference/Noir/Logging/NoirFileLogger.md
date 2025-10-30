# NoirFileLogger

<!-- tc:namespace Noir.Logging -->

<!-- tc:assembly Noir.dll -->

Writes log messages to both Unity’s console (in the Editor) and a persistent log file.
[NoirFileLogger](/noir/reference/Noir/Logging/NoirFileLogger/) is the primary backend for persistent log output in Noir.
             It captures runtime messages, trace sequences, and subsystem-specific logs, storing them
             in a structured log file under the platform’s configured log directory.
            
             In Editor mode, messages are also echoed to the Unity Console for immediate visibility.


```csharp
public class NoirFileLogger : INoirLogger
```

**Implements:** _[INoirLogger](/noir/reference/Noir/Logging/INoirLogger/)_

## Constructors

<a name=".ctor"></a>

### `.ctor(IPlatformPaths)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Creates a new instance of the [NoirFileLogger](/noir/reference/Noir/Logging/NoirFileLogger/) using the specified platform paths.


```csharp
public NoirFileLogger(IPlatformPaths paths)

```

**Parameters** <br>
`paths` [IPlatformPaths](/noir/reference/Noir/IO/Paths/IPlatformPaths/) <br>
 <br>

## Methods

<a name="Debug"></a>

### `Debug(string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Debug(string message, Object context, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="DisableSubsystem"></a>

### `DisableSubsystem(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Disables logging for the specified subsystem.


```csharp
public virtual void DisableSubsystem(string system)

```

**Parameters** <br>
`system` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="EnableSubsystem"></a>

### `EnableSubsystem(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Enables logging for the specified subsystem.


```csharp
public virtual void EnableSubsystem(string system)

```

**Parameters** <br>
`system` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="EndAllTraces"></a>

### `EndAllTraces()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Ends all currently active trace sessions.
This also disables trace mode globally until a new trace is started.


```csharp
public virtual void EndAllTraces()

```

<a name="EndTrace"></a>

### `EndTrace(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Ends a specific trace sequence by name.


```csharp
public virtual void EndTrace(string traceName)

```

**Parameters** <br>
`traceName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="Error"></a>

### `Error(string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Error(string message, Object context, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="Info"></a>

### `Info(string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Info(string message, Object context, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="StartTrace"></a>

### `StartTrace(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Begins a new trace sequence with the specified name.


```csharp
public virtual void StartTrace(string traceName)

```

**Parameters** <br>
`traceName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="Trace"></a>

### `Trace(string, string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Trace(string trace, string message, Object context,
                           string subsystem)


```

**Parameters** <br>
`trace` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="Verify"></a>

### `Verify(bool, string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Performs a verification check and logs a failure if the condition is false.


```csharp
public virtual void Verify(bool condition, string label, Object context,
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
Performs a verification check using a delegate and logs a failure if it returns false.


```csharp
public virtual void Verify(Func<TResult> condition, string label, Object context,
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

<a name="Warn"></a>

### `Warn(string, Object, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Warn(string message, Object context, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="WriteLog"></a>

### `WriteLog(string, LogLevel, Object, string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void WriteLog(string message, LogLevel level, Object context,
                              string subsystem, string trace)


```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`level` [LogLevel](/noir/reference/Noir/Logging/LogLevel/) <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`trace` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

## More information

* [Noir.Logging.NoirFileLogger](/noir/reference/Noir/Logging/NoirFileLogger/)
