# INoirAudioManager

<!-- tc:namespace Noir.Audio -->

<!-- tc:assembly Noir.dll -->

Interface for managing audio playback, including sound effects and audio clips.


```csharp
public abstract INoirAudioManager
```

## Methods

<a name="TryPlayClip"></a>

### `TryPlayClip(AudioClip, T?, float, float, float, bool, AudioMixerGroup, float)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Attempts to play a raw [AudioClip](https://docs.unity3d.com/ScriptReference/AudioClip.html).


```csharp
public abstract bool TryPlayClip(AudioClip clip, T? origin, float delay,
                                  float volume, float pitch, bool loop,
                                  AudioMixerGroup mixerGroup,
                                  float spatialBlend)


```

**Parameters** <br>
`clip` [AudioClip](https://docs.unity3d.com/ScriptReference/AudioClip.html) <br>
 <br>
`origin` [T?](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0) <br>
 <br>
`delay` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`volume` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`pitch` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`loop` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>
`mixerGroup` [AudioMixerGroup](https://docs.unity3d.com/ScriptReference/Audio.AudioMixerGroup.html) <br>
 <br>
`spatialBlend` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

<a name="TryPlaySoundEffect"></a>

### `TryPlaySoundEffect(SoundEffect, T?, float, float, float, bool, AudioMixerGroup)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Attempts to play a [SoundEffect](/noir/reference/Noir/Audio/SoundEffect/) instance.


```csharp
public abstract bool TryPlaySoundEffect(SoundEffect effect, T? origin,
                                         float delay, float volume, float pitch,
                                         bool loop, AudioMixerGroup mixerGroup)


```

**Parameters** <br>
`effect` [SoundEffect](/noir/reference/Noir/Audio/SoundEffect/) <br>
 <br>
`origin` [T?](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0) <br>
 <br>
`delay` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`volume` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`pitch` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`loop` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>
`mixerGroup` [AudioMixerGroup](https://docs.unity3d.com/ScriptReference/Audio.AudioMixerGroup.html) <br>
 <br>

<a name="TryPlaySoundEffect"></a>

### `TryPlaySoundEffect(string, Transform, float, float, float, bool, AudioMixerGroup)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Attempts to play a sound effect by name.


```csharp
public abstract bool TryPlaySoundEffect(string effectName,
                                         Transform sourceObject, float delay,
                                         float volume, float pitch, bool loop,
                                         AudioMixerGroup mixerGroup)


```

**Parameters** <br>
`effectName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`sourceObject` [Transform](https://docs.unity3d.com/ScriptReference/Transform.html) <br>
 <br>
`delay` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`volume` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`pitch` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`loop` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>
`mixerGroup` [AudioMixerGroup](https://docs.unity3d.com/ScriptReference/Audio.AudioMixerGroup.html) <br>
 <br>

<a name="StopAllEffects"></a>

### `StopAllEffects()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Stops all currently playing sound effects.


```csharp
public abstract void StopAllEffects()

```

<a name="StopEffect"></a>

### `StopEffect(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Stops the sound effect with the given name if it is currently playing.


```csharp
public abstract void StopEffect(string name)

```

**Parameters** <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

