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

<a name="hideFlags"></a>

### `hideFlags`
<!-- tc:scope public -->
<!-- tc:return_type HideFlags https://docs.unity3d.com/ScriptReference/HideFlags.html -->
<!-- tc:version 1.0.0 -->

```csharp
public HideFlags hideFlags { get; public set; }

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

<a name="name"></a>

### `name`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string name { get; public set; }

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

<a name="SetDirty"></a>

### `SetDirty()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SetDirty()

```

