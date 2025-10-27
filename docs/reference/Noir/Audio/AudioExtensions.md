# AudioExtensions

<!-- tc:namespace Noir.Audio -->

<!-- tc:assembly Noir.dll -->

Extension methods for Unity audio components.


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
Calculates the percentage of the current audio clip that has been played by the specified [AudioSource](https://docs.unity3d.com/ScriptReference/AudioSource.html).
This method is useful for determining playback progress for UI updates, such as progress bars or debugging information.


```csharp
public float GetAudioPlayedPercentage(AudioSource source)

```

**Parameters** <br>
`source` [AudioSource](https://docs.unity3d.com/ScriptReference/AudioSource.html) <br>
 <br>

