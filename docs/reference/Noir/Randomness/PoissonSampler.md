# PoissonSampler

<!-- tc:namespace Noir.Randomness -->

<!-- tc:assembly Noir.dll -->


```csharp
public class PoissonSampler
```

## Constructors

<a name=".ctor"></a>

### `.ctor(PoissonSettings, PoissonBags)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public PoissonSampler(PoissonSettings settings, PoissonBags bags)

```

**Parameters** <br>
`settings` [PoissonSettings](/noir/reference/Noir/Randomness/PoissonSettings/) <br>
`bags` [PoissonBags](/noir/reference/Noir/Randomness/PoissonBags/) <br>

## Properties

<a name="ActivePoints"></a>

### `ActivePoints`
<!-- tc:scope public -->
<!-- tc:return_type List\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public List<T> ActivePoints { get; }

```

<a name="Points"></a>

### `Points`
<!-- tc:scope public -->
<!-- tc:return_type List\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public List<T> Points { get; }

```

<a name="StartingPoint"></a>

### `StartingPoint`
<!-- tc:scope public -->
<!-- tc:return_type T? https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public T? StartingPoint { get; private set; }

```

## Methods

<a name="Next"></a>

### `Next(out Int32&)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool Next(Int32& iterations)

```

**Parameters** <br>
`iterations` [int&](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

