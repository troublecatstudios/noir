# EditorSingleton\<T\>

**Namespace:** NoirEditor <br>
**Assembly:** NoirEditor.dll

```csharp
public abstract class EditorSingleton<T> : ScriptableObject
```

ScriptableObject-based singleton for GUI-less editor plug-ins.

**Implements:** _[ScriptableObject](../)_

### 🛠 Constructors
```csharp
protected EditorSingleton<T>()
```

### 📦 Properties
#### hideFlags
```csharp
public HideFlags hideFlags { get; public set; }
```

**Returns** <br>
[HideFlags](../) <br>
#### instance
```csharp
public static T instance { get; }
```

**Returns** <br>
[T](../) <br>
#### name
```csharp
public string name { get; public set; }
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
### ⛹️‍♀️ Methods
#### Initialize()
```csharp
protected T Initialize()
```

Finds or creates the singleton instance and stores it in _instance.

**Returns** <br>
[T](../) <br>
 <br>

#### Awake()
```csharp
protected virtual void Awake()
```

Called once during creation of this instance

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

