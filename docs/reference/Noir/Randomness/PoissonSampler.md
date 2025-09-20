# PoissonSampler

<!-- tc:namespace Noir.Randomness -->

<!-- tc:assembly Noir.dll -->


```csharp
public class PoissonSampler
```

## 🛠 Constructors

### `.ctor(PoissonSettings, PoissonBags)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public PoissonSampler(PoissonSettings settings, PoissonBags bags)
```

**Parameters** <br>
`settings` [PoissonSettings](/noir/reference//noir/reference/Noir/Randomness/PoissonSettings/) <br>
`bags` [PoissonBags](/noir/reference//noir/reference/Noir/Randomness/PoissonBags/) <br>

## 📦 Properties

### `ActivePoints`
<!-- tc:scope public -->
<!-- tc:return_type List\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public List<T> ActivePoints { get; }
```

### `Points`
<!-- tc:scope public -->
<!-- tc:return_type List\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public List<T> Points { get; }
```

### `StartingPoint`
<!-- tc:scope public -->
<!-- tc:return_type T? https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public T? StartingPoint { get; private set; }
```

## ⛹️‍♀️ Methods

### `Next(out Int32&)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool Next(Int32& iterations)
```

**Parameters** <br>
`iterations` [int&](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

