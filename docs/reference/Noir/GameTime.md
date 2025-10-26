# GameTime

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Represents a wrapper for Unity's [Time](https://docs.unity3d.com/ScriptReference/Time.html) class, providing
            convenient access to frame timing values and constants for common frame rates.


```csharp
public class GameTime : IGameTime
```

**Implements:** _[IGameTime](/noir/reference/Noir/Abstractions/IGameTime/)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public GameTime()

```

## Fields

<a name="FPS12"></a>

### `FPS12`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public static const float FPS12;

```

<a name="FPS12L"></a>

### `FPS12L`
<!-- tc:scope private -->
<!-- tc:return_type long https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public static const long FPS12L;

```

<a name="FPS24"></a>

### `FPS24`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public static const float FPS24;

```

<a name="FPS24L"></a>

### `FPS24L`
<!-- tc:scope private -->
<!-- tc:return_type long https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public static const long FPS24L;

```

<a name="FPS30"></a>

### `FPS30`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public static const float FPS30;

```

<a name="FPS30L"></a>

### `FPS30L`
<!-- tc:scope private -->
<!-- tc:return_type long https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public static const long FPS30L;

```

<a name="FPS60"></a>

### `FPS60`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public static const float FPS60;

```

<a name="FPS60L"></a>

### `FPS60L`
<!-- tc:scope private -->
<!-- tc:return_type long https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public static const long FPS60L;

```

<a name="Instance"></a>

### `Instance`
<!-- tc:scope private -->
<!-- tc:return_type GameTime /noir/reference/Noir/GameTime/ -->
<!-- tc:version 1.0.0 -->

```csharp
public readonly static GameTime Instance;

```

## Properties

<a name="deltaTime"></a>

### `deltaTime`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the time in seconds it took to complete the last frame.


```csharp
public virtual float deltaTime { get; }

```

<a name="fixedDeltaTime"></a>

### `fixedDeltaTime`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the fixed time step in seconds between physics updates.


```csharp
public virtual float fixedDeltaTime { get; }

```

<a name="frameCount"></a>

### `frameCount`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the total number of frames that have been rendered since the start of the game.


```csharp
public virtual int frameCount { get; }

```

<a name="realtimeSinceStartup"></a>

### `realtimeSinceStartup`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the real time in seconds since the game started, unaffected by time scale.


```csharp
public virtual float realtimeSinceStartup { get; }

```

<a name="time"></a>

### `time`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the time in seconds since the start of the game.


```csharp
public virtual float time { get; }

```

## More information

* [UnityEngine.Time](https://docs.unity3d.com/ScriptReference/Time.html)
