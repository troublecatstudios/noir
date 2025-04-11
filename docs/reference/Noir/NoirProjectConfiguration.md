# NoirProjectConfiguration

**Namespace:** Noir <br>
**Assembly:** Noir.dll

```csharp
public class NoirProjectConfiguration : ScriptableObject
```

**Implements:** _[ScriptableObject](../)_

### 🛠 Constructors
```csharp
public NoirProjectConfiguration()
```

### 📦 Properties
#### DefaultAudioMixerGroup
```csharp
public AudioMixerGroup DefaultAudioMixerGroup { get; }
```

**Returns** <br>
[AudioMixerGroup](../) <br>
#### GameManagerPrefab
```csharp
public NoirGameManager GameManagerPrefab { get; }
```

**Returns** <br>
[NoirGameManager](../Noir/NoirGameManager.html) <br>
#### hideFlags
```csharp
public HideFlags hideFlags { get; public set; }
```

**Returns** <br>
[HideFlags](../) <br>
#### Instance
```csharp
public static NoirProjectConfiguration Instance { get; }
```

**Returns** <br>
[NoirProjectConfiguration](../Noir/NoirProjectConfiguration.html) <br>
#### IsAutomaticSpawnEnabled
```csharp
public bool IsAutomaticSpawnEnabled { get; }
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### IsCodeGenerationEnabled
```csharp
public bool IsCodeGenerationEnabled { get; }
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### IsFramerateLocked
```csharp
public bool IsFramerateLocked { get; }
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### LockedFrameRate
```csharp
public int LockedFrameRate { get; }
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
#### name
```csharp
public string name { get; public set; }
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
### ⛹️‍♀️ Methods
#### CheckFirstTimeSetupComplete()
```csharp
public bool CheckFirstTimeSetupComplete()
```

Returns a value indicating whether the first-time setup of the noir library has been completed or not.

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

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

