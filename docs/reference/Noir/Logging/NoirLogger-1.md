# NoirLogger\<T\>

<!-- tc:namespace Noir.Logging -->

<!-- tc:assembly Noir.dll -->


```csharp
public class NoirLogger<T>
```

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public NoirLogger<T>()

```

## Methods

<a name="Debug"></a>

### `Debug(string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Debug(string message, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="Error"></a>

### `Error(string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Error(string message, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="Info"></a>

### `Info(string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Info(string message, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="Trace"></a>

### `Trace(string, string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Trace(string trace, string message, string subsystem)

```

**Parameters** <br>
`trace` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="Verify"></a>

### `Verify(bool, string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Verify(bool condition, string label, string subsystem)

```

**Parameters** <br>
`condition` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`label` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="Verify"></a>

### `Verify(Func<TResult>, string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Verify(Func<TResult> condition, string label, string subsystem)

```

**Parameters** <br>
`condition` [Func\<TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-1?view=net-7.0) <br>
`label` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="Warn"></a>

### `Warn(string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Warn(string message, string subsystem)

```

**Parameters** <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`subsystem` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

