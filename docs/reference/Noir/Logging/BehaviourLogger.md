# BehaviourLogger

<!-- tc:namespace Noir.Logging -->

<!-- tc:assembly Noir.dll -->


```csharp
public class BehaviourLogger : ILogWriter
```

**Implements:** _[ILogWriter](/noir/reference//noir/reference/Noir/Logging/ILogWriter.html)_

## Constructors

### `.ctor(MonoBehaviour)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public BehaviourLogger(MonoBehaviour context)

```

**Parameters** <br>
`context` [MonoBehaviour](https://docs.unity3d.com/ScriptReference/MonoBehaviour.html) <br>

## Methods

### `Debug(string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Debug(string message, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `Error(string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Error(string message, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `Info(string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Info(string message, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `Trace(string, string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Trace(string trace, string message, string subsystem)

```

**Parameters** <br>
`trace` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `Verify(bool, string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Verify(bool condition, string label, string subsystem)

```

**Parameters** <br>
`condition` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`label` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `Verify(Func<TResult>, string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Verify(Func<TResult> condition, string label,
                            string subsystem)


```

**Parameters** <br>
`condition` [Func\<TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-1?view=net-7.0) <br>
`label` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `Warn(string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Warn(string message, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `WriteLog(string, LogLevel, string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void WriteLog(string message, LogLevel level, string subsystem,
                              string trace)


```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`level` [LogLevel](/noir/reference//noir/reference/Noir/Logging/LogLevel.html) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`trace` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

