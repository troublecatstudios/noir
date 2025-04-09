# ObjectPoolItemState

**Namespace:** Noir.Pooling <br>
**Assembly:** Noir.dll

```csharp
public sealed enum ObjectPoolItemState : Enum, IComparable, ISpanFormattable, IFormattable, IConvertible
```

Represents the current state of a [ObjectPoolSystem](../../Noir/Pooling/ObjectPoolSystem.html).

**Implements:** _[Enum](https://learn.microsoft.com/en-us/dotnet/api/System.Enum?view=net-7.0), [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=net-7.0), [ISpanFormattable](https://learn.microsoft.com/en-us/dotnet/api/System.ISpanFormattable?view=net-7.0), [IFormattable](https://learn.microsoft.com/en-us/dotnet/api/System.IFormattable?view=net-7.0), [IConvertible](https://learn.microsoft.com/en-us/dotnet/api/System.IConvertible?view=net-7.0)_

### 📦 Properties
#### Active
```csharp
public static const ObjectPoolItemState Active;
```

The item is currently in use by the game

**Returns** <br>
[ObjectPoolItemState](../../Noir/Pooling/ObjectPoolItemState.html) <br>
#### Inactive
```csharp
public static const ObjectPoolItemState Inactive;
```

The item is not currently in use

**Returns** <br>
[ObjectPoolItemState](../../Noir/Pooling/ObjectPoolItemState.html) <br>
#### Returning
```csharp
public static const ObjectPoolItemState Returning;
```

The item is currently being returned to the pool

**Returns** <br>
[ObjectPoolItemState](../../Noir/Pooling/ObjectPoolItemState.html) <br>
