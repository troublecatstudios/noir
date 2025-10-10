# Engine

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Initializes core features of the Noir Library
<para>
            The Noir engine can invoke methods within developer's game code at specific points during the startup lifecycle.
            </para>
  <para>
            Initialize is invoked during the <see cref="F:UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration">SubSystemRegistration</see> phase of the UnityEngine initialization lifecycle.
            </para>
  <para>
            ConfigureServices is invoked after all the assemblies have been loaded by the UnityEngine. Developer's can utilize
            this callback to register types and instances with Noir's [ServiceLocator](/noir/reference/Noir/ServiceLocator/).
            </para>
  <para>
            Start is invoked after all the first Scene has been loaded by Unity.
            </para>
  <para>
            Noir engine callbacks are global, the library performs a scan of the loaded assemblies at startup, looking for
            all the static members that are decorated with a [EngineCallbackAttribute](/noir/reference/Noir/Attributes/EngineCallbackAttribute/).
            </para>


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

* [SubSystemRegistration](F:UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)
* [Noir.ServiceLocator](/noir/reference/Noir/ServiceLocator/)
* [Noir.Attributes.EngineCallbackAttribute](/noir/reference//noir/reference/Noir/Attributes/EngineCallbackAttribute/)
