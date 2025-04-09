# SoundEffect

**Namespace:** Noir.Audio <br>
**Assembly:** Noir.dll

```csharp
public class SoundEffect : ScriptableObject
```

**Implements:** _[ScriptableObject](../../)_

### 🛠 Constructors
```csharp
public SoundEffect()
```

### 📦 Properties
#### AudioClips
```csharp
public List<T> AudioClips;
```

**Returns** <br>
[List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>
#### ConcurrentLimit
```csharp
public int ConcurrentLimit;
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
#### Delay
```csharp
public float Delay { get; }
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### DelayRange
```csharp
public Vector2 DelayRange;
```

**Returns** <br>
[Vector2](../../) <br>
#### DelayStart
```csharp
public bool DelayStart;
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### hideFlags
```csharp
public HideFlags hideFlags { get; public set; }
```

**Returns** <br>
[HideFlags](../../) <br>
#### MaxAudibleDistance
```csharp
public float MaxAudibleDistance { get; }
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### MixerGroup
```csharp
public AudioMixerGroup MixerGroup;
```

**Returns** <br>
[AudioMixerGroup](../../) <br>
#### name
```csharp
public string name { get; public set; }
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### Pitch
```csharp
public float Pitch { get; }
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### SpatialBlend
```csharp
public float SpatialBlend { get; }
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### Style
```csharp
public SoundEffectPlayStyle Style;
```

**Returns** <br>
[SoundEffectPlayStyle](../../Noir/Audio/SoundEffectPlayStyle.html) <br>
#### VolumeScale
```csharp
public float VolumeScale { get; }
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
### ⛹️‍♀️ Methods
#### GetClip()
```csharp
public AudioClip GetClip()
```

**Returns** <br>
[AudioClip](../../) <br>

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

#### Play(SoundEffect, AudioSource, T?, bool)
```csharp
public void Play(SoundEffect effect, AudioSource source, T? volumeScale, bool interrupt)
```

**Parameters** <br>
`effect` [SoundEffect](../../Noir/Audio/SoundEffect.html) <br>
`source` [AudioSource](../../) <br>
`volumeScale` [T?](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0) <br>
`interrupt` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### SetDirty()
```csharp
public void SetDirty()
```

