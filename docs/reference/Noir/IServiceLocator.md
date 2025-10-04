# IServiceLocator

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->


```csharp
public abstract IServiceLocator
```

## Methods

### `IsServiceRegistered()`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract bool IsServiceRegistered()

```

### `TryGetService(out T&)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract bool TryGetService(T& instance)

```

**Parameters** <br>
`instance` [T&](/noir/reference/) <br>

### `GetService()`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract T GetService()

```

### `RegisterService(Func<TResult>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void RegisterService(Func<TResult> factory)

```

**Parameters** <br>
`factory` [Func\<TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-1?view=net-7.0) <br>

### `RegisterService(T)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void RegisterService(T instance)

```

**Parameters** <br>
`instance` [T](/noir/reference/) <br>

### `UnregisterService()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void UnregisterService()

```

