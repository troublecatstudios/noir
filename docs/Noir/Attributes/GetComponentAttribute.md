# GetComponentAttribute

**Namespace:** Noir.Attributes <br>
**Assembly:** Noir.dll

```csharp
public class GetComponentAttribute : PropertyAttribute
```

Automatically wires up the first component that matches the annotated field type.

**Implements:** _[PropertyAttribute](../../)_

### 🛠 Constructors
```csharp
public GetComponentAttribute(GetComponentSearchArea searchArea)
```

**Parameters** <br>
`searchArea` [GetComponentSearchArea](../../Noir/Attributes/GetComponentSearchArea.html) <br>

### 📦 Properties
#### order
```csharp
public int order { get; public set; }
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
#### SearchArea
```csharp
public GetComponentSearchArea SearchArea { get; private set; }
```

**Returns** <br>
[GetComponentSearchArea](../../Noir/Attributes/GetComponentSearchArea.html) <br>
#### TypeId
```csharp
public virtual Object TypeId { get; }
```

**Returns** <br>
[Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
