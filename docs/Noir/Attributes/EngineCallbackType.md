# EngineCallbackType

<!-- tc:namespace Noir.Attributes -->

<!-- tc:assembly Noir.dll -->

Engine callback triggers


```csharp
public sealed enum EngineCallbackType : Enum, IComparable, ISpanFormattable, IFormattable, IConvertible
```

**Implements:** _[Enum](https://learn.microsoft.com/en-us/dotnet/api/System.Enum?view=net-7.0), [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=net-7.0), [ISpanFormattable](https://learn.microsoft.com/en-us/dotnet/api/System.ISpanFormattable?view=net-7.0), [IFormattable](https://learn.microsoft.com/en-us/dotnet/api/System.IFormattable?view=net-7.0), [IConvertible](https://learn.microsoft.com/en-us/dotnet/api/System.IConvertible?view=net-7.0)_

## 📦 Properties

### `ConfigureServices`
<!-- tc:scope private -->
<!-- tc:return_type EngineCallbackType /noir/reference//noir/reference/Noir/Attributes/EngineCallbackType/ -->
<!-- tc:version 1.0.0 -->
ConfigureServices is called after the engine configures its own internal dependency injection.


```csharp
public static const EngineCallbackType ConfigureServices;
```

### `Initialize`
<!-- tc:scope private -->
<!-- tc:return_type EngineCallbackType /noir/reference//noir/reference/Noir/Attributes/EngineCallbackType/ -->
<!-- tc:version 1.0.0 -->
Initialize occurs as soon as the engine starts up.


```csharp
public static const EngineCallbackType Initialize;
```

### `Start`
<!-- tc:scope private -->
<!-- tc:return_type EngineCallbackType /noir/reference//noir/reference/Noir/Attributes/EngineCallbackType/ -->
<!-- tc:version 1.0.0 -->
Start is called after all Noir library setup is finished.


```csharp
public static const EngineCallbackType Start;
```

