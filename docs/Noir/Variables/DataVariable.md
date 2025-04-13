# DataVariable

**Namespace:** Noir.Variables <br>
**Assembly:** Noir.dll

```csharp
public abstract class DataVariable : ScriptableObject
```

**Implements:** _[ScriptableObject](../../)_

### 🛠 Constructors
```csharp
protected DataVariable()
```

### 📦 Properties
#### Description
```csharp
public string Description { get; public set; }
```

The description of the variable.

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### FriendlyName
```csharp
public string FriendlyName { get; public set; }
```

The friendly name of the variable.

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### hideFlags
```csharp
public HideFlags hideFlags { get; public set; }
```

**Returns** <br>
[HideFlags](../../) <br>
#### IsPersistant
```csharp
public bool IsPersistant { get; public set; }
```

Gets or sets a value indicating whether this instance is persisted to disk when changed.

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### name
```csharp
public string name { get; public set; }
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### Name
```csharp
public string Name { get; }
```

The variable name.

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
### ⚡ Events
#### OnAfterVariableChanged
```csharp
public event OnAfterChange OnAfterVariableChanged;
```

**Returns** <br>
[OnAfterChange](../../Noir/Variables/OnAfterChange.html) <br>
#### OnBeforeVariableChanged
```csharp
public event OnBeforeChange OnBeforeVariableChanged;
```

**Returns** <br>
[OnBeforeChange](../../Noir/Variables/OnBeforeChange.html) <br>
### ⛹️‍♀️ Methods
#### OnAfterSave(Object, Object)
```csharp
protected virtual void OnAfterSave(Object previousValue, Object newValue)
```

**Parameters** <br>
`previousValue` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`newValue` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

#### OnBeforeChange()
```csharp
protected virtual void OnBeforeChange()
```

#### TrySetValue(Object, bool)
```csharp
public abstract bool TrySetValue(Object value, bool silently)
```

Tries to set the given [value]() into the variable.

**Parameters** <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>
`silently` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

#### ToObject()
```csharp
public abstract Object ToObject()
```

**Returns** <br>
[Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

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

