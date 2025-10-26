# IServiceLocator

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Defines a contract for a service locator that provides registration,
            retrieval, and management of services by type.


```csharp
public abstract IServiceLocator
```

## Methods

<a name="IsServiceRegistered"></a>

### `IsServiceRegistered()`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Determines whether a service of the specified type is registered.


```csharp
public abstract bool IsServiceRegistered()

```

<a name="TryGetService"></a>

### `TryGetService(out T&)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract bool TryGetService(T& instance)

```

**Parameters** <br>
`instance` [T&](/noir/reference/) <br>

<a name="GetService"></a>

### `GetService()`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 1.0.0 -->
Retrieves a registered service of the specified type.


```csharp
public abstract T GetService()

```

<a name="RegisterService"></a>

### `RegisterService(Func<TResult>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void RegisterService(Func<TResult> factory)

```

**Parameters** <br>
`factory` [Func\<TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-1?view=net-7.0) <br>

<a name="RegisterService"></a>

### `RegisterService(T)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void RegisterService(T instance)

```

**Parameters** <br>
`instance` [T](/noir/reference/) <br>

<a name="UnregisterService"></a>

### `UnregisterService()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Unregisters a previously registered service of the specified type.


```csharp
public abstract void UnregisterService()

```

