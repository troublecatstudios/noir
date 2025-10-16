# NoirSingletonBehaviour\<T\>

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Abstract base class for singleton behaviours in Noir.
            Ensures that only one instance of type <typeparamref name="T" /> exists in the scene.


```csharp
public abstract class NoirSingletonBehaviour<T> : NoirBehaviour
```

**Implements:** _[NoirBehaviour](/noir/reference/Noir/NoirBehaviour/)_

## Properties

<a name="Instance"></a>

### `Instance`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 1.0.0 -->
Gets the singleton instance of type <typeparamref name="T" />.
            Searches for an instance in the scene if not already set.


```csharp
public static T Instance { get; }

```

