# PlayAudioClipEvent

<!-- tc:namespace Noir.Audio.Events -->

<!-- tc:assembly Noir.dll -->

Represents an event used to play an audio clip in the game,
            optionally with specific playback parameters such as position, volume, and delay.


```csharp
public class PlayAudioClipEvent
```

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public PlayAudioClipEvent()

```

## Properties

<a name="Clip"></a>

### `Clip`
<!-- tc:scope public -->
<!-- tc:return_type AudioClip https://docs.unity3d.com/ScriptReference/AudioClip.html -->
<!-- tc:version 1.0.0 -->
Gets or sets the audio clip to be played.


```csharp
public AudioClip Clip { get; public set; }

```

<a name="Delay"></a>

### `Delay`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets or sets the delay in seconds before the audio begins playback.


```csharp
public float Delay { get; public set; }

```

<a name="Loop"></a>

### `Loop`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets or sets a value indicating whether the audio clip should loop continuously.


```csharp
public bool Loop { get; public set; }

```

<a name="MixerGroup"></a>

### `MixerGroup`
<!-- tc:scope public -->
<!-- tc:return_type AudioMixerGroup https://docs.unity3d.com/ScriptReference/Audio.AudioMixerGroup.html -->
<!-- tc:version 1.0.0 -->
Gets or sets the audio mixer group that the clip should be routed through.


```csharp
public AudioMixerGroup MixerGroup { get; public set; }

```

<a name="Pitch"></a>

### `Pitch`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets or sets the playback pitch multiplier for the audio clip.
            A value of <c>1.0</c> plays the clip at its original pitch.


```csharp
public float Pitch { get; public set; }

```

<a name="Volume"></a>

### `Volume`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets or sets the playback volume of the audio clip.
            A value of <c>1.0</c> represents the clip’s original volume.


```csharp
public float Volume { get; public set; }

```

<a name="WorldPosition"></a>

### `WorldPosition`
<!-- tc:scope public -->
<!-- tc:return_type T? https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets or sets the world position where the audio should be played.
            If <c>null</c>, the clip is played in a non-spatial (2D) context.


```csharp
public T? WorldPosition { get; public set; }

```

