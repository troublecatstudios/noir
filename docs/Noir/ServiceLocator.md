# ServiceLocator

**Namespace:** Noir <br>
**Assembly:** Noir.dll

```csharp
public sealed class ServiceLocator : IServiceLocator
```

Provides access to services by finding an appropriate provider while hiding both the provider’s concrete type and the process used to locate it.

**Implements:** _[IServiceLocator](../Noir/IServiceLocator.html)_

### 🛠 Constructors
```csharp
public ServiceLocator()
```

### ⛹️‍♀️ Methods
#### IsServiceRegistered()
```csharp
public bool IsServiceRegistered()
```

Returns a value indicating whether the given service type has an implementation in the service registry.

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

#### TryGetService(out TServiceType&)
```csharp
public bool TryGetService(TServiceType& instance)
```

**Parameters** <br>
`instance` [TServiceType&](../) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### GetService()
```csharp
public TServiceType GetService()
```

Gets an implementation for the given type from the service registry.

**Returns** <br>
[TServiceType](../) <br>
 <br>

**Exceptions** <br>
[NullReferenceException](https://learn.microsoft.com/en-us/dotnet/api/System.NullReferenceException?view=net-7.0) <br>
 <br>
#### RegisterService()
```csharp
public void RegisterService()
```

Registers a service type and its implementation in the service registry.

#### RegisterService(Func<TResult>)
```csharp
public void RegisterService(Func<TResult> factory)
```

**Parameters** <br>
`factory` [Func\<TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-1?view=net-7.0) <br>

#### RegisterService(TServiceType)
```csharp
public void RegisterService(TServiceType instance)
```

**Parameters** <br>
`instance` [TServiceType](../) <br>

#### UnregisterService()
```csharp
public void UnregisterService()
```

Removes a service implementation from the service registry.

