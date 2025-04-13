# Vector2Variable

**Namespace:** Noir.Variables <br>
**Assembly:** Noir.dll

```csharp
public class Vector2Variable : DataVariable<T>, IDataVariable, IEquatable<T>
```

**Implements:** _[DataVariable\<T\>](../../Noir/Variables/DataVariable-1.html), [IDataVariable](../../Noir/Variables/IDataVariable.html), [IEquatable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=net-7.0)_

### 🛠 Constructors
```csharp
public Vector2Variable()
```

### 📦 Properties
#### Description
```csharp
public string Description { get; public set; }
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### FriendlyName
```csharp
public string FriendlyName { get; public set; }
```

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

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### Value
```csharp
public virtual Vector2 Value { get; public set; }
```

**Returns** <br>
[Vector2](../../) <br>
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
#### OnDataVariableChanged
```csharp
public event DataVariableChanged<T> OnDataVariableChanged;
```

**Returns** <br>
[DataVariableChanged\<T\>](../../Noir/Variables/DataVariableChanged-1.html) <br>
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

#### TrySetValue(Object, bool)
```csharp
public virtual bool TrySetValue(Object value, bool silently)
```

**Parameters** <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`silently` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### GetHashCode()
```csharp
public virtual int GetHashCode()
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

#### ToObject()
```csharp
public virtual Object ToObject()
```

**Returns** <br>
[Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

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

