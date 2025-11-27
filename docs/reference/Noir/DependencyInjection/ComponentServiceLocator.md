# ComponentServiceLocator

<!-- tc:namespace Noir.DependencyInjection -->

<!-- tc:assembly Noir.dll -->

Provides local component-based service resolution within a specific GameObject hierarchy.
The [ComponentServiceLocator](/noir/reference/Noir/DependencyInjection/ComponentServiceLocator/) is a lightweight dependency resolver that integrates with
             the global [ServiceLocator](/noir/reference/Noir/ServiceLocator/) pattern. It first attempts to retrieve a requested service
             from the globally registered container, and if unavailable, searches for matching components in the
             provided GameObject, its parents, or its children.
            
             This allows systems to mix global and local dependency injection patterns seamlessly —
             e.g., when a system requires context-specific components like localized managers or scene-level services.


```csharp
public class ComponentServiceLocator
```

## Constructors

<a name=".ctor"></a>

### `.ctor(GameObject)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Initializes a new instance of the [ComponentServiceLocator](/noir/reference/Noir/DependencyInjection/ComponentServiceLocator/) class, binding it to a
            specified GameObject hierarchy.
If the provided GameObject or any of its parents implement [IDependencyRoot](/noir/reference/Noir/DependencyInjection/IDependencyRoot/),
            that GameObject becomes the dependency root for all future resolutions.


```csharp
public ComponentServiceLocator(GameObject container)

```

**Parameters** <br>
`container` [GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html) <br>
 <br>

## Methods

<a name="TryGetService"></a>

### `TryGetService(out T&)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool TryGetService(T& instance)

```

**Parameters** <br>
`instance` [T&](/noir/reference/) <br>

<a name="GetService"></a>

### `GetService()`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 1.0.0 -->
Resolves a service or component of the specified type.
The lookup order is:
            <list type="number"><item><description>Global [ServiceLocator](/noir/reference/Noir/ServiceLocator/)</description></item><item><description>Attached component on the dependency root</description></item><item><description>Child components</description></item><item><description>Parent components</description></item></list>


```csharp
public T GetService()

```

## More information

* [Noir.DependencyInjection.ComponentServiceLocator](/noir/reference/Noir/DependencyInjection/ComponentServiceLocator/)
* [Noir.ServiceLocator](/noir/reference/Noir/ServiceLocator/)
