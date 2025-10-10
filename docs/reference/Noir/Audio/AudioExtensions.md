# AudioExtensions

<!-- tc:namespace Noir.Audio -->

<!-- tc:assembly Noir.dll -->


```csharp
public static class AudioExtensions
```

## Methods

<a name="IsAudioPaused"></a>

### `IsAudioPaused(AudioSource)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns a value indicating whether the [AudioSource](https://docs.unity3d.com/ScriptReference/AudioSource.html) is stopped with any play time remaining.


```csharp
public bool IsAudioPaused(AudioSource source)

```

**Parameters** <br>
`source` [AudioSource](https://docs.unity3d.com/ScriptReference/AudioSource.html) <br>
 <br>

<a name="IsClipReadyToPlay"></a>

### `IsClipReadyToPlay(AudioClip)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns a value indicating whether the [AudioClip](https://docs.unity3d.com/ScriptReference/AudioClip.html) is ready to be played.


```csharp
public bool IsClipReadyToPlay(AudioClip clip)

```

**Parameters** <br>
`clip` [AudioClip](https://docs.unity3d.com/ScriptReference/AudioClip.html) <br>
 <br>

<a name="GetAudioPlayedPercentage"></a>

### `GetAudioPlayedPercentage(AudioSource)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float GetAudioPlayedPercentage(AudioSource source)

```

**Parameters** <br>
`source` [AudioSource](https://docs.unity3d.com/ScriptReference/AudioSource.html) <br>

