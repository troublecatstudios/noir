# EngineCallbackType

**Namespace:** Noir.Attributes <br>
**Assembly:** Noir.dll

```csharp
public sealed enum EngineCallbackType : Enum, IComparable, ISpanFormattable, IFormattable, IConvertible
```

Engine callback triggers

**Implements:** _[Enum](https://learn.microsoft.com/en-us/dotnet/api/System.Enum?view=net-7.0), [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=net-7.0), [ISpanFormattable](https://learn.microsoft.com/en-us/dotnet/api/System.ISpanFormattable?view=net-7.0), [IFormattable](https://learn.microsoft.com/en-us/dotnet/api/System.IFormattable?view=net-7.0), [IConvertible](https://learn.microsoft.com/en-us/dotnet/api/System.IConvertible?view=net-7.0)_

### 📦 Properties
#### ConfigureServices
```csharp
public static const EngineCallbackType ConfigureServices;
```

ConfigureServices is called after the engine configures its own internal dependency injection.

**Returns** <br>
[EngineCallbackType](../../Noir/Attributes/EngineCallbackType.html) <br>
#### Initialize
```csharp
public static const EngineCallbackType Initialize;
```

Initialize occurs as soon as the engine starts up.

**Returns** <br>
[EngineCallbackType](../../Noir/Attributes/EngineCallbackType.html) <br>
#### Start
```csharp
public static const EngineCallbackType Start;
```

Start is called after all Noir library setup is finished.

**Returns** <br>
[EngineCallbackType](../../Noir/Attributes/EngineCallbackType.html) <br>
