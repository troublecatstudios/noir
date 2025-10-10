# ServiceLocator

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Provides access to services by finding an appropriate provider while hiding both the provider’s concrete type and the process used to locate it.
<list type="bullet">
    <item>It's best to limit calls to ServiceLocator methods the startup of your components: <c>Awake()</c>, <c>Start()</c>, <c>OnEnable()</c> are all good points to register and get services.</item>
    <item>Avoid calling the service locator within loops or <c>Update()</c> and <c>LateUpdate()</c>.</item>
    <item>When registering with the service locator, it's best to register an interface or abstract class as the lookup type.</item>
  </list>


```csharp
public sealed class ServiceLocator : IServiceLocator
```

**Implements:** _[IServiceLocator](/noir/reference/Noir/IServiceLocator/)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public ServiceLocator()

```

## Methods

<a name="IsServiceRegistered"></a>

### `IsServiceRegistered()`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns a value indicating whether the given service type has an implementation in the service registry.


```csharp
public bool IsServiceRegistered()

```

<a name="TryGetService"></a>

### `TryGetService(out TServiceType&)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool TryGetService(TServiceType& instance)

```

**Parameters** <br>
`instance` [TServiceType&](/noir/reference/) <br>

<a name="GetService"></a>

### `GetService()`
<!-- tc:scope public -->
<!-- tc:return_type TServiceType -->
<!-- tc:version 1.0.0 -->
Gets an implementation for the given type from the service registry.


```csharp
public TServiceType GetService()

```

**Exceptions** <br>
[NullReferenceException](https://learn.microsoft.com/en-us/dotnet/api/System.NullReferenceException?view=net-7.0) <br>
 <br>
<a name="RegisterService"></a>

### `RegisterService()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Registers a service type and its implementation in the service registry.
The TImplementationType must be able to instantiated via an empty constructor, e.g. new TImplementationType()
### Code example
<example>
            Registering a service.
                
```csharp
<![CDATA[
                    ServiceLocator.RegisterService<TServiceType, TImplementationType>();
                ]]>
```
</example>


```csharp
public void RegisterService()

```

<a name="RegisterService"></a>

### `RegisterService(Func<TResult>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void RegisterService(Func<TResult> factory)

```

**Parameters** <br>
`factory` [Func\<TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-1?view=net-7.0) <br>

<a name="RegisterService"></a>

### `RegisterService(TServiceType)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void RegisterService(TServiceType instance)

```

**Parameters** <br>
`instance` [TServiceType](/noir/reference/) <br>

<a name="UnregisterService"></a>

### `UnregisterService()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Removes a service implementation from the service registry.


```csharp
public void UnregisterService()

```

