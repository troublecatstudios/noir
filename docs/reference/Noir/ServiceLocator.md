# ServiceLocator

<!-- tc:namespace Noir -->
<!-- tc:assembly Noir.dll -->

Provides access to services by finding an appropriate provider while hiding both the provider’s concrete type and the process used to locate it.


```csharp
public sealed class ServiceLocator : IServiceLocator
```

**Implements:** _[IServiceLocator](../Noir/IServiceLocator.html)_

## Constructors

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public ServiceLocator()
```

## Methods

### `IsServiceRegistered()`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns a value indicating whether the given service type has an implementation in the service registry.


```csharp
public bool IsServiceRegistered()
```

### `TryGetService(out TServiceType&)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool TryGetService(TServiceType& instance)
```

**Parameters** <br>
`instance` [TServiceType&](../) <br>

### `GetService()`
<!-- tc:scope public -->
<!-- tc:return_type TServiceType _na_ -->
<!-- tc:version 1.0.0 -->
Gets an implementation for the given type from the service registry.


```csharp
public TServiceType GetService()
```

**Exceptions** <br>
[NullReferenceException](https://learn.microsoft.com/en-us/dotnet/api/System.NullReferenceException?view=net-7.0) <br>
 <br>
### `RegisterService()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Registers a service type and its implementation in the service registry.


```csharp
public void RegisterService()
```

### `RegisterService(Func<TResult>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void RegisterService(Func<TResult> factory)
```

**Parameters** <br>
`factory` [Func\<TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-1?view=net-7.0) <br>

### `RegisterService(TServiceType)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void RegisterService(TServiceType instance)
```

**Parameters** <br>
`instance` [TServiceType](../) <br>

### `UnregisterService()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Removes a service implementation from the service registry.


```csharp
public void UnregisterService()
```

