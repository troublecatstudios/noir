# NoirTestCase

<!-- tc:namespace Noir.Testing -->

<!-- tc:assembly NoirEditor.dll -->

Base class for all Noir unit test classes.


```csharp
public abstract class NoirTestCase
```

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope private -->
<!-- tc:version 0.0.0 -->

```csharp
protected NoirTestCase()

```

## Properties

<a name="Asserts"></a>

### `Asserts`
<!-- tc:scope private -->
<!-- tc:return_type NoirAssertions /noir/reference//noir/reference/Noir/Testing/NoirAssertions/ -->
<!-- tc:version 0.0.0 -->
Gets the [NoirAssertions](/noir/reference//noir/reference/Noir/Testing/NoirAssertions/) instance for this test class.


```csharp
public readonly NoirAssertions Asserts;

```

## Methods

<a name="Setup"></a>

### `Setup()`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Performed before each test within the class is run.


```csharp
public virtual void Setup()

```

<a name="SetupAll"></a>

### `SetupAll()`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Performed once before all the tests within the class are run.


```csharp
public virtual void SetupAll()

```

<a name="TearDownAll"></a>

### `TearDownAll()`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Performed once after all tests within the class have been run.


```csharp
public virtual void TearDownAll()

```

