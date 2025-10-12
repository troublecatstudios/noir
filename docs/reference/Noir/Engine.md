# Engine

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Initializes core features of the Noir Library
<br />
            The Noir engine can invoke methods within developer's game code at specific points during the startup lifecycle.
            
  <br />
            Initialize is invoked during the [SubSystemRegistration](https://docs.unity3d.com/ScriptReference/RuntimeInitializeLoadType.html) phase of the UnityEngine initialization lifecycle.
            
  <br />
            ConfigureServices is invoked after all the assemblies have been loaded by the UnityEngine. Developer's can utilize
            this callback to register types and instances with Noir's [ServiceLocator](/noir/reference/Noir/ServiceLocator/).
            
  <br />
            Start is invoked after all the first Scene has been loaded by Unity.
            
  <br />
            Noir engine callbacks are global, the library performs a scan of the loaded assemblies at startup, looking for
            all the static members that are decorated with a [EngineCallbackAttribute](/noir/reference/Noir/Attributes/EngineCallbackAttribute/).


```csharp
public sealed class Engine
```

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public Engine()

```

## More information

* [SubSystemRegistration](https://docs.unity3d.com/ScriptReference/RuntimeInitializeLoadType.html#SubsystemRegistration)
* [Noir.ServiceLocator](/noir/reference/Noir/ServiceLocator/)
* [Noir.Attributes.EngineCallbackAttribute](/noir/reference/Noir/Attributes/EngineCallbackAttribute/)
