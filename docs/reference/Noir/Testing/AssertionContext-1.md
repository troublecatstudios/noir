# AssertionContext\<T\>

<!-- tc:namespace Noir.Testing -->

<!-- tc:assembly NoirEditor.dll -->


```csharp
public class AssertionContext<T> : IAssertionContext<T>
```

**Implements:** _[IAssertionContext\<T\>](/noir/reference//noir/reference/Noir/Testing/IAssertionContext-1/)_

## Constructors

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Creates a new assertion context.


```csharp
public AssertionContext<T>()

```

### `.ctor(T, Object[])`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public AssertionContext<T>(T target, Object[] additionalContexts)

```

**Parameters** <br>
`target` [T](/noir/reference//noir/reference/) <br>
`additionalContexts` [Object[]](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

## Properties

### `AdditionalContexts`
<!-- tc:scope public -->
<!-- tc:return_type Object[] https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public virtual Object[] AdditionalContexts { get; internal set; }

```

### `Target`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 0.0.0 -->

```csharp
public virtual T Target { get; internal set; }

```

