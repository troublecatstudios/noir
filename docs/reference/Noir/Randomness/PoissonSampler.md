# PoissonSampler

**Namespace:** Noir.Randomness <br>
**Assembly:** Noir.dll

```csharp
public class PoissonSampler
```

### 🛠 Constructors
```csharp
public PoissonSampler(PoissonSettings settings, PoissonBags bags)
```

**Parameters** <br>
`settings` [PoissonSettings](../../Noir/Randomness/PoissonSettings.html) <br>
`bags` [PoissonBags](../../Noir/Randomness/PoissonBags.html) <br>

### 📦 Properties
#### ActivePoints
```csharp
public List<T> ActivePoints { get; }
```

**Returns** <br>
[List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>
#### Points
```csharp
public List<T> Points { get; }
```

**Returns** <br>
[List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>
#### StartingPoint
```csharp
public T? StartingPoint { get; private set; }
```

**Returns** <br>
[T?](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0) <br>
### ⛹️‍♀️ Methods
#### Next(out Int32&)
```csharp
public bool Next(Int32& iterations)
```

**Parameters** <br>
`iterations` [int&](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

