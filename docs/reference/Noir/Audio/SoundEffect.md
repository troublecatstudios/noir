# SoundEffect

<!-- tc:namespace Noir.Audio -->

<!-- tc:assembly Noir.dll -->

Represents a configurable sound effect that can play multiple audio clips
            with randomized pitch, volume, and optional delays.


```csharp
public class SoundEffect : ScriptableObject
```

**Implements:** _[ScriptableObject](https://docs.unity3d.com/ScriptReference/ScriptableObject.html)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public SoundEffect()

```

## Fields

<a name="AudioClips"></a>

### `AudioClips`
<!-- tc:scope private -->
<!-- tc:return_type List\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public List<T> AudioClips;

```

<a name="ConcurrentLimit"></a>

### `ConcurrentLimit`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int ConcurrentLimit;

```

<a name="DelayRange"></a>

### `DelayRange`
<!-- tc:scope private -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector2 DelayRange;

```

<a name="DelayStart"></a>

### `DelayStart`
<!-- tc:scope private -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool DelayStart;

```

<a name="MixerGroup"></a>

### `MixerGroup`
<!-- tc:scope private -->
<!-- tc:return_type AudioMixerGroup https://docs.unity3d.com/ScriptReference/Audio.AudioMixerGroup.html -->
<!-- tc:version 1.0.0 -->

```csharp
public AudioMixerGroup MixerGroup;

```

<a name="Style"></a>

### `Style`
<!-- tc:scope private -->
<!-- tc:return_type SoundEffectPlayStyle /noir/reference/Noir/Audio/SoundEffectPlayStyle/ -->
<!-- tc:version 1.0.0 -->

```csharp
public SoundEffectPlayStyle Style;

```

## Properties

<a name="Delay"></a>

### `Delay`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Randomly calculated delay in seconds based on [SoundEffect.DelayRange](/noir/reference/Noir/Audio/SoundEffect/#delayrange).
            Returns 0 if [SoundEffect.DelayStart](/noir/reference/Noir/Audio/SoundEffect/#delaystart) is false.


```csharp
public float Delay { get; }

```

<a name="MaxAudibleDistance"></a>

### `MaxAudibleDistance`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Maximum distance at which the sound is audible.


```csharp
public float MaxAudibleDistance { get; }

```

<a name="Pitch"></a>

### `Pitch`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Randomized pitch between the configured min and max.


```csharp
public float Pitch { get; }

```

<a name="SpatialBlend"></a>

### `SpatialBlend`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
The spatial blend of the sound (0 = 2D, 1 = 3D).


```csharp
public float SpatialBlend { get; }

```

<a name="VolumeScale"></a>

### `VolumeScale`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Randomized volume between the configured min and max.


```csharp
public float VolumeScale { get; }

```

## Methods

<a name="GetClip"></a>

### `GetClip()`
<!-- tc:scope public -->
<!-- tc:return_type AudioClip https://docs.unity3d.com/ScriptReference/AudioClip.html -->
<!-- tc:version 1.0.0 -->
Returns an audio clip according to the [SoundEffect.Style](/noir/reference/Noir/Audio/SoundEffect/#style).
            Sequentially cycles through clips or selects a random clip.


```csharp
public AudioClip GetClip()

```

<a name="Play"></a>

### `Play(SoundEffect, AudioSource, T?, bool)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Plays this sound effect on a given [AudioSource](https://docs.unity3d.com/ScriptReference/AudioSource.html).


```csharp
public void Play(SoundEffect effect, AudioSource source, T? volumeScale,
                  bool interrupt)


```

**Parameters** <br>
`effect` [SoundEffect](/noir/reference/Noir/Audio/SoundEffect/) <br>
 <br>
`source` [AudioSource](https://docs.unity3d.com/ScriptReference/AudioSource.html) <br>
 <br>
`volumeScale` [T?](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0) <br>
 <br>
`interrupt` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

