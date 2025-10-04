# NoirProjectConfiguration

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->


```csharp
public class NoirProjectConfiguration : ScriptableObject
```

**Implements:** _[ScriptableObject](https://docs.unity3d.com/ScriptReference/ScriptableObject.html)_

## Constructors

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public NoirProjectConfiguration()

```

## Properties

### `DefaultAudioMixerGroup`
<!-- tc:scope public -->
<!-- tc:return_type [AudioMixerGroup](https://docs.unity3d.com/ScriptReference/Audio.AudioMixerGroup.html) -->
<!-- tc:version 1.0.0 -->

```csharp
public AudioMixerGroup DefaultAudioMixerGroup { get; }

```

### `GameManagerPrefab`
<!-- tc:scope public -->
<!-- tc:return_type [NoirGameManager](/noir/reference/Noir/NoirGameManager.html) -->
<!-- tc:version 1.0.0 -->

```csharp
public NoirGameManager GameManagerPrefab { get; }

```

### `hideFlags`
<!-- tc:scope public -->
<!-- tc:return_type [HideFlags](https://docs.unity3d.com/ScriptReference/HideFlags.html) -->
<!-- tc:version 1.0.0 -->

```csharp
public HideFlags hideFlags { get; public set; }

```

### `Instance`
<!-- tc:scope public -->
<!-- tc:return_type [NoirProjectConfiguration](/noir/reference/Noir/NoirProjectConfiguration.html) -->
<!-- tc:version 1.0.0 -->

```csharp
public static NoirProjectConfiguration Instance { get; }

```

### `IsAutomaticSpawnEnabled`
<!-- tc:scope public -->
<!-- tc:return_type [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public bool IsAutomaticSpawnEnabled { get; }

```

### `IsCodeGenerationEnabled`
<!-- tc:scope public -->
<!-- tc:return_type [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public bool IsCodeGenerationEnabled { get; }

```

### `IsFramerateLocked`
<!-- tc:scope public -->
<!-- tc:return_type [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public bool IsFramerateLocked { get; }

```

### `LockedFrameRate`
<!-- tc:scope public -->
<!-- tc:return_type [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public int LockedFrameRate { get; }

```

### `name`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public string name { get; public set; }

```

## Methods

### `CheckFirstTimeSetupComplete()`
<!-- tc:scope public -->
<!-- tc:return_type [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) -->
<!-- tc:version 1.0.0 -->
Returns a value indicating whether the first-time setup of the noir library has been completed or not.


```csharp
public bool CheckFirstTimeSetupComplete()

```

### `GetInstanceID()`
<!-- tc:scope public -->
<!-- tc:return_type [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public int GetInstanceID()

```

### `Equals(Object)`
<!-- tc:scope public -->
<!-- tc:return_type [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Equals(Object other)

```

**Parameters** <br>
`other` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

### `GetHashCode()`
<!-- tc:scope public -->
<!-- tc:return_type [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual int GetHashCode()

```

### `ToString()`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual string ToString()

```

### `SetDirty()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SetDirty()

```

