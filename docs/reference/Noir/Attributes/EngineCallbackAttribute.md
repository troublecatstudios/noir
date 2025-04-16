# EngineCallbackAttribute

**Namespace:** Noir.Attributes <br>
**Assembly:** Noir.dll

```csharp
public class EngineCallbackAttribute : Attribute
```

Allows static methods to be invoked at specific points during the Noir Library startup lifecycle.

**Implements:** _[Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=net-7.0)_

### 🛠 Constructors
```csharp
public EngineCallbackAttribute(EngineCallbackType callbackType)
```

**Parameters** <br>
`callbackType` [EngineCallbackType](../../Noir/Attributes/EngineCallbackType.html) <br>

### 📦 Properties
#### CallbackType
```csharp
public EngineCallbackType CallbackType { get; public set; }
```

**Returns** <br>
[EngineCallbackType](../../Noir/Attributes/EngineCallbackType.html) <br>
#### TypeId
```csharp
public virtual Object TypeId { get; }
```

**Returns** <br>
[Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
