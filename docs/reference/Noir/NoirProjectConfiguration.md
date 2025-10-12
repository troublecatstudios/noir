# NoirProjectConfiguration

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->


```csharp
public class NoirProjectConfiguration : ScriptableObject
```

**Implements:** _[ScriptableObject](https://docs.unity3d.com/ScriptReference/ScriptableObject.html)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public NoirProjectConfiguration()

```

## Properties

<a name="DefaultAudioMixerGroup"></a>

### `DefaultAudioMixerGroup`
<!-- tc:scope public -->
<!-- tc:return_type AudioMixerGroup https://docs.unity3d.com/ScriptReference/Audio.AudioMixerGroup.html -->
<!-- tc:version 1.0.0 -->

```csharp
public AudioMixerGroup DefaultAudioMixerGroup { get; }

```

<a name="GameManagerPrefab"></a>

### `GameManagerPrefab`
<!-- tc:scope public -->
<!-- tc:return_type NoirGameManager /noir/reference/Noir/NoirGameManager/ -->
<!-- tc:version 1.0.0 -->

```csharp
public NoirGameManager GameManagerPrefab { get; }

```

<a name="Instance"></a>

### `Instance`
<!-- tc:scope public -->
<!-- tc:return_type NoirProjectConfiguration /noir/reference/Noir/NoirProjectConfiguration/ -->
<!-- tc:version 1.0.0 -->

```csharp
public static NoirProjectConfiguration Instance { get; }

```

<a name="IsAutomaticSpawnEnabled"></a>

### `IsAutomaticSpawnEnabled`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool IsAutomaticSpawnEnabled { get; }

```

<a name="IsCodeGenerationEnabled"></a>

### `IsCodeGenerationEnabled`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool IsCodeGenerationEnabled { get; }

```

<a name="IsFramerateLocked"></a>

### `IsFramerateLocked`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool IsFramerateLocked { get; }

```

<a name="LockedFrameRate"></a>

### `LockedFrameRate`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int LockedFrameRate { get; }

```

## Methods

<a name="CheckFirstTimeSetupComplete"></a>

### `CheckFirstTimeSetupComplete()`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns a value indicating whether the first-time setup of the noir library has been completed or not.


```csharp
public bool CheckFirstTimeSetupComplete()

```

