# DataVariableCollection

**Namespace:** Noir.Variables <br>
**Assembly:** Noir.dll

```csharp
public class DataVariableCollection : ScriptableObject
```

**Implements:** _[ScriptableObject](../../)_

### 🛠 Constructors
```csharp
public DataVariableCollection()
```

### 📦 Properties
#### hideFlags
```csharp
public HideFlags hideFlags { get; public set; }
```

**Returns** <br>
[HideFlags](../../) <br>
#### name
```csharp
public string name { get; public set; }
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### Variables
```csharp
public List<T> Variables;
```

**Returns** <br>
[List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>
### ⛹️‍♀️ Methods
#### GetInstanceID()
```csharp
public int GetInstanceID()
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

#### Equals(Object)
```csharp
public virtual bool Equals(Object other)
```

**Parameters** <br>
`other` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### GetHashCode()
```csharp
public virtual int GetHashCode()
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

#### ToString()
```csharp
public virtual string ToString()
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### SetDirty()
```csharp
public void SetDirty()
```

