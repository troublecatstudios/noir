# PlaySoundEffectEvent

<!-- tc:namespace Noir.Audio.Events -->

<!-- tc:assembly Noir.dll -->

Represents an event used to play a [SoundEffect](/noir/reference/Noir/Audio/SoundEffect/) in the game,
            optionally with specific playback parameters such as position, volume, and delay.


```csharp
public class PlaySoundEffectEvent
```

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public PlaySoundEffectEvent()

```

## Properties

<a name="Delay"></a>

### `Delay`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets or sets the delay in seconds before the sound effect begins playback.


```csharp
public float Delay { get; public set; }

```

<a name="Loop"></a>

### `Loop`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets or sets a value indicating whether the sound effect should loop continuously.


```csharp
public bool Loop { get; public set; }

```

<a name="MixerGroup"></a>

### `MixerGroup`
<!-- tc:scope public -->
<!-- tc:return_type AudioMixerGroup https://docs.unity3d.com/ScriptReference/Audio.AudioMixerGroup.html -->
<!-- tc:version 1.0.0 -->
Gets or sets the audio mixer group that the sound effect should be routed through.


```csharp
public AudioMixerGroup MixerGroup { get; public set; }

```

<a name="Pitch"></a>

### `Pitch`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets or sets the playback pitch multiplier for the sound effect.
            A value of <c>1.0</c> plays the sound effect at its original pitch.


```csharp
public float Pitch { get; public set; }

```

<a name="SoundEffectName"></a>

### `SoundEffectName`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets or sets the name of the sound effect to be played.


```csharp
public string SoundEffectName { get; public set; }

```

<a name="Volume"></a>

### `Volume`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets or sets the playback volume of the sound effect.
            A value of <c>1.0</c> represents the sound effect’s original volume.


```csharp
public float Volume { get; public set; }

```

<a name="WorldPosition"></a>

### `WorldPosition`
<!-- tc:scope public -->
<!-- tc:return_type T? https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets or sets the world position where the sound effect should be played.
            If <c>null</c>, the clip is played in a non-spatial (2D) context.


```csharp
public T? WorldPosition { get; public set; }

```

## More information

* [Noir.Audio.SoundEffect](/noir/reference/Noir/Audio/SoundEffect/)
