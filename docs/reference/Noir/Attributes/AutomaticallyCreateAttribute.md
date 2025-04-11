# AutomaticallyCreateAttribute

**Namespace:** Noir.Attributes <br>
**Assembly:** Noir.dll

```csharp
public class AutomaticallyCreateAttribute : Attribute
```

**Implements:** _[Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=net-7.0)_

### 🛠 Constructors
```csharp
public AutomaticallyCreateAttribute(string customPathPrefix, string assetNameOverride)
```

Declare that this ScriptableObject should be automatically created at build time.

**Parameters** <br>
`customPathPrefix` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`assetNameOverride` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

### 📦 Properties
#### AssetNameOverride
```csharp
public string AssetNameOverride { get; private set; }
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### CreatePathPrefix
```csharp
public string CreatePathPrefix { get; private set; }
```

Gets the custom folder path to store the created asset. Is automatically prefixed with "Assets/".

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### TypeId
```csharp
public virtual Object TypeId { get; }
```

**Returns** <br>
[Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
