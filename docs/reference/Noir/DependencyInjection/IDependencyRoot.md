# IDependencyRoot

<!-- tc:namespace Noir.DependencyInjection -->

<!-- tc:assembly Noir.dll -->

Defines a root object for a localized dependency context within the Noir dependency system.
Classes implementing [IDependencyRoot](/noir/reference/Noir/DependencyInjection/IDependencyRoot/) mark a GameObject as the root boundary for
             dependency resolution when using the [ComponentServiceLocator](/noir/reference/Noir/DependencyInjection/ComponentServiceLocator/).
            
             This allows developers to define self-contained dependency contexts within prefabs,
             subsystems, or scenes — ensuring that [ComponentServiceLocator](/noir/reference/Noir/DependencyInjection/ComponentServiceLocator/) instances
             can resolve services relative to a specific hierarchy instead of always relying on
             the global [ServiceLocator](/noir/reference/Noir/ServiceLocator/).
            
             For example, a UI panel or scene controller may implement [IDependencyRoot](/noir/reference/Noir/DependencyInjection/IDependencyRoot/)
             so that its child components can find context-specific services (like data providers
             or local managers) without polluting the global dependency graph.


```csharp
public abstract IDependencyRoot
```

## Properties

<a name="gameObject"></a>

### `gameObject`
<!-- tc:scope public -->
<!-- tc:return_type GameObject https://docs.unity3d.com/ScriptReference/GameObject.html -->
<!-- tc:version 1.0.0 -->
The GameObject that defines the root of this dependency context.
Implementations should typically return the GameObject that the implementing component
            is attached to. This property allows the [ComponentServiceLocator](/noir/reference/Noir/DependencyInjection/ComponentServiceLocator/) to traverse
            hierarchies and identify the correct context root.


```csharp
public abstract virtual GameObject gameObject { get; }

```

## More information

* [Noir.DependencyInjection.IDependencyRoot](/noir/reference/Noir/DependencyInjection/IDependencyRoot/)
* [Noir.DependencyInjection.ComponentServiceLocator](/noir/reference/Noir/DependencyInjection/ComponentServiceLocator/)
* [Noir.DependencyInjection.ComponentServiceLocator](/noir/reference/Noir/DependencyInjection/ComponentServiceLocator/)
* [Noir.ServiceLocator](/noir/reference/Noir/ServiceLocator/)
* [Noir.DependencyInjection.IDependencyRoot](/noir/reference/Noir/DependencyInjection/IDependencyRoot/)
