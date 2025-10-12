# NoirAudioManager

<!-- tc:namespace Noir.Audio -->

<!-- tc:assembly Noir.dll -->


```csharp
public class NoirAudioManager : NoirSingletonBehaviour<T>, INoirAudioManager, INoirEventListener<T>, IEventSystemHandler, INoirEventListener<T>
```

**Implements:** _[NoirSingletonBehaviour\<T\>](/noir/reference/Noir/NoirSingletonBehaviour-1/), [INoirAudioManager](/noir/reference/Noir/Audio/INoirAudioManager/), [INoirEventListener\<T\>](/noir/reference/Noir/Events/INoirEventListener-1/), [IEventSystemHandler](https://docs.unity3d.com/ScriptReference/EventSystems.IEventSystemHandler.html), [INoirEventListener\<T\>](/noir/reference/Noir/Events/INoirEventListener-1/)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public NoirAudioManager()

```

## Methods

<a name="TryPlaySoundEffect"></a>

### `TryPlaySoundEffect(SoundEffect, Transform, float, float, float, bool, AudioMixerGroup)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool TryPlaySoundEffect(SoundEffect effect, Transform sourceObject,
                                float delay, float volume, float pitch,
                                bool loop, AudioMixerGroup mixerGroup)


```

**Parameters** <br>
`effect` [SoundEffect](/noir/reference/Noir/Audio/SoundEffect/) <br>
`sourceObject` [Transform](https://docs.unity3d.com/ScriptReference/Transform.html) <br>
`delay` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`volume` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`pitch` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`loop` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`mixerGroup` [AudioMixerGroup](https://docs.unity3d.com/ScriptReference/Audio.AudioMixerGroup.html) <br>

<a name="TryPlaySoundEffect"></a>

### `TryPlaySoundEffect(string, T?, float, float, float, bool, AudioMixerGroup)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool TryPlaySoundEffect(string effectName, T? origin, float delay,
                                float volume, float pitch, bool loop,
                                AudioMixerGroup mixerGroup)


```

**Parameters** <br>
`effectName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`origin` [T?](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0) <br>
`delay` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`volume` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`pitch` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`loop` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`mixerGroup` [AudioMixerGroup](https://docs.unity3d.com/ScriptReference/Audio.AudioMixerGroup.html) <br>

<a name="TryPlayClip"></a>

### `TryPlayClip(AudioClip, T?, float, float, float, bool, AudioMixerGroup, float)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool TryPlayClip(AudioClip clip, T? origin, float delay,
                                 float volume, float pitch, bool loop,
                                 AudioMixerGroup mixerGroup, float spatialBlend)


```

**Parameters** <br>
`clip` [AudioClip](https://docs.unity3d.com/ScriptReference/AudioClip.html) <br>
`origin` [T?](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0) <br>
`delay` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`volume` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`pitch` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`loop` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`mixerGroup` [AudioMixerGroup](https://docs.unity3d.com/ScriptReference/Audio.AudioMixerGroup.html) <br>
`spatialBlend` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="TryPlaySoundEffect"></a>

### `TryPlaySoundEffect(SoundEffect, T?, float, float, float, bool, AudioMixerGroup)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool TryPlaySoundEffect(SoundEffect effect, T? origin,
                                        float delay, float volume, float pitch,
                                        bool loop, AudioMixerGroup mixerGroup)


```

**Parameters** <br>
`effect` [SoundEffect](/noir/reference/Noir/Audio/SoundEffect/) <br>
`origin` [T?](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0) <br>
`delay` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`volume` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`pitch` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`loop` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`mixerGroup` [AudioMixerGroup](https://docs.unity3d.com/ScriptReference/Audio.AudioMixerGroup.html) <br>

<a name="TryPlaySoundEffect"></a>

### `TryPlaySoundEffect(string, Transform, float, float, float, bool, AudioMixerGroup)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool TryPlaySoundEffect(string effectName, Transform sourceObject,
                                        float delay, float volume, float pitch,
                                        bool loop, AudioMixerGroup mixerGroup)


```

**Parameters** <br>
`effectName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`sourceObject` [Transform](https://docs.unity3d.com/ScriptReference/Transform.html) <br>
`delay` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`volume` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`pitch` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`loop` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`mixerGroup` [AudioMixerGroup](https://docs.unity3d.com/ScriptReference/Audio.AudioMixerGroup.html) <br>

<a name="StopAllEffects"></a>

### `StopAllEffects()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void StopAllEffects()

```

<a name="StopEffect"></a>

### `StopEffect(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void StopEffect(string name)

```

**Parameters** <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

