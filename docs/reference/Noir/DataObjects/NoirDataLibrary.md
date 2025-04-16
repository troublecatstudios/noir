# NoirDataLibrary

**Namespace:** Noir.DataObjects <br>
**Assembly:** Noir.dll

```csharp
public class NoirDataLibrary : ScriptableObject
```

**Implements:** _[ScriptableObject](../../)_

### 🛠 Constructors
```csharp
public NoirDataLibrary()
```

### 📦 Properties
#### hideFlags
```csharp
public HideFlags hideFlags { get; public set; }
```

**Returns** <br>
[HideFlags](../../) <br>
#### Instance
```csharp
public static NoirDataLibrary Instance { get; }
```

**Returns** <br>
[NoirDataLibrary](../../Noir/DataObjects/NoirDataLibrary.html) <br>
#### name
```csharp
public string name { get; public set; }
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### SoundEffects
```csharp
public List<T> SoundEffects;
```

**Returns** <br>
[List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>
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

#### GetSoundEffectByName(string)
```csharp
public SoundEffect GetSoundEffectByName(string name)
```

**Parameters** <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[SoundEffect](../../Noir/Audio/SoundEffect.html) <br>

#### GetVariableByName(string)
```csharp
public T GetVariableByName(string name)
```

Gets a variable by name.

**Parameters** <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

**Returns** <br>
[T](../../) <br>
 <br>

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

