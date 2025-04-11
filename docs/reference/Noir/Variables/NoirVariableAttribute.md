# NoirVariableAttribute

**Namespace:** Noir.Variables <br>
**Assembly:** Noir.dll

```csharp
public class NoirVariableAttribute : Attribute
```

Declares that this variable field should be bound automatically to a named variable in the asset library.

**Implements:** _[Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=net-7.0)_

### 🛠 Constructors
```csharp
public NoirVariableAttribute(string variableName)
```

Declares that this variable field should be bound automatically to a named variable in the asset library.

**Parameters** <br>
`variableName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

### 📦 Properties
#### TypeId
```csharp
public virtual Object TypeId { get; }
```

**Returns** <br>
[Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
#### VariableName
```csharp
public string VariableName { get; private set; }
```

The variable name to use when looking up the event asset in the asset library.

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
