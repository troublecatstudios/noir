# SoundEffect

<!-- tc:namespace Noir.Audio -->

<!-- tc:assembly Noir.dll -->


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

## Properties

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

<a name="Delay"></a>

### `Delay`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float Delay { get; }

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

<a name="hideFlags"></a>

### `hideFlags`
<!-- tc:scope public -->
<!-- tc:return_type HideFlags https://docs.unity3d.com/ScriptReference/HideFlags.html -->
<!-- tc:version 1.0.0 -->

```csharp
public HideFlags hideFlags { get; public set; }

```

<a name="MaxAudibleDistance"></a>

### `MaxAudibleDistance`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float MaxAudibleDistance { get; }

```

<a name="MixerGroup"></a>

### `MixerGroup`
<!-- tc:scope private -->
<!-- tc:return_type AudioMixerGroup https://docs.unity3d.com/ScriptReference/Audio.AudioMixerGroup.html -->
<!-- tc:version 1.0.0 -->

```csharp
public AudioMixerGroup MixerGroup;

```

<a name="name"></a>

### `name`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string name { get; public set; }

```

<a name="Pitch"></a>

### `Pitch`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float Pitch { get; }

```

<a name="SpatialBlend"></a>

### `SpatialBlend`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float SpatialBlend { get; }

```

<a name="Style"></a>

### `Style`
<!-- tc:scope private -->
<!-- tc:return_type SoundEffectPlayStyle /noir/reference//noir/reference/Noir/Audio/SoundEffectPlayStyle/ -->
<!-- tc:version 1.0.0 -->

```csharp
public SoundEffectPlayStyle Style;

```

<a name="VolumeScale"></a>

### `VolumeScale`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float VolumeScale { get; }

```

## Methods

<a name="GetClip"></a>

### `GetClip()`
<!-- tc:scope public -->
<!-- tc:return_type AudioClip https://docs.unity3d.com/ScriptReference/AudioClip.html -->
<!-- tc:version 1.0.0 -->

```csharp
public AudioClip GetClip()

```

<a name="GetInstanceID"></a>

### `GetInstanceID()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int GetInstanceID()

```

<a name="Equals"></a>

### `Equals(Object)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Equals(Object other)

```

**Parameters** <br>
`other` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

<a name="GetHashCode"></a>

### `GetHashCode()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual int GetHashCode()

```

<a name="ToString"></a>

### `ToString()`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual string ToString()

```

<a name="Play"></a>

### `Play(SoundEffect, AudioSource, T?, bool)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Play(SoundEffect effect, AudioSource source, T? volumeScale,
                  bool interrupt)


```

**Parameters** <br>
`effect` [SoundEffect](/noir/reference//noir/reference/Noir/Audio/SoundEffect/) <br>
`source` [AudioSource](https://docs.unity3d.com/ScriptReference/AudioSource.html) <br>
`volumeScale` [T?](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0) <br>
`interrupt` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

<a name="SetDirty"></a>

### `SetDirty()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SetDirty()

```

