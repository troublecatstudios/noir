# INoirAudioManager

**Namespace:** Noir.Audio <br>
**Assembly:** Noir.dll

```csharp
public abstract INoirAudioManager
```

### ⛹️‍♀️ Methods
#### TryPlayClip(AudioClip, T?, float, float, float, bool, AudioMixerGroup, float)
```csharp
public abstract bool TryPlayClip(AudioClip clip, T? origin, float delay, float volume, float pitch, bool loop, AudioMixerGroup mixerGroup, float spatialBlend)
```

**Parameters** <br>
`clip` [AudioClip](../../) <br>
`origin` [T?](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0) <br>
`delay` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`volume` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`pitch` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`loop` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`mixerGroup` [AudioMixerGroup](../../) <br>
`spatialBlend` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### TryPlaySoundEffect(SoundEffect, T?, float, float, float, bool, AudioMixerGroup)
```csharp
public abstract bool TryPlaySoundEffect(SoundEffect effect, T? origin, float delay, float volume, float pitch, bool loop, AudioMixerGroup mixerGroup)
```

**Parameters** <br>
`effect` [SoundEffect](../../Noir/Audio/SoundEffect.html) <br>
`origin` [T?](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0) <br>
`delay` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`volume` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`pitch` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`loop` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`mixerGroup` [AudioMixerGroup](../../) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### TryPlaySoundEffect(string, Transform, float, float, float, bool, AudioMixerGroup)
```csharp
public abstract bool TryPlaySoundEffect(string effectName, Transform sourceObject, float delay, float volume, float pitch, bool loop, AudioMixerGroup mixerGroup)
```

**Parameters** <br>
`effectName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`sourceObject` [Transform](../../) <br>
`delay` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`volume` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`pitch` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`loop` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`mixerGroup` [AudioMixerGroup](../../) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### StopAllEffects()
```csharp
public abstract void StopAllEffects()
```

#### StopEffect(string)
```csharp
public abstract void StopEffect(string name)
```

**Parameters** <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

