# IAssertionContext\<T\>

<!-- tc:namespace Noir.Testing -->

<!-- tc:assembly NoirEditor.dll -->


```csharp
public abstract IAssertionContext<T>
```

## Properties

### `AdditionalContexts`
<!-- tc:scope public -->
<!-- tc:return_type [Object[]](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) -->
<!-- tc:version 0.0.0 -->
Gets any additional contexts that will be used by the assertions.


```csharp
public abstract virtual Object[] AdditionalContexts { get; }

```

### `Target`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 0.0.0 -->
Gets the target that the assertions will be run against.


```csharp
public abstract virtual T Target { get; }

```

