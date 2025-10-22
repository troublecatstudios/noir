# IGameTime

<!-- tc:namespace Noir.Abstractions -->

<!-- tc:assembly Noir.dll -->

Provides an abstraction layer over Unity's [Time](https://docs.unity3d.com/ScriptReference/Time.html) API,
            exposing commonly used time-related properties such as [IGameTime.time](/noir/reference/Noir/Abstractions/IGameTime/#time).
            This interface allows game systems to access time values without directly depending on Unity's static [Time](https://docs.unity3d.com/ScriptReference/Time.html) class,
            making it easier to create deterministic simulations, mock time in tests, or implement custom time sources.


```csharp
public abstract IGameTime
```

## Properties

<a name="deltaTime"></a>

### `deltaTime`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract virtual float deltaTime { get; }

```

<a name="fixedDeltaTime"></a>

### `fixedDeltaTime`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract virtual float fixedDeltaTime { get; }

```

<a name="frameCount"></a>

### `frameCount`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract virtual int frameCount { get; }

```

<a name="realtimeSinceStartup"></a>

### `realtimeSinceStartup`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract virtual float realtimeSinceStartup { get; }

```

<a name="time"></a>

### `time`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract virtual float time { get; }

```

## More information

* [UnityEngine.Time](https://docs.unity3d.com/ScriptReference/Time.html)
* [Noir.Abstractions.IGameTime.deltaTime](/noir/reference/Noir/Abstractions/IGameTime/#deltaTime)
* [Noir.Abstractions.IGameTime.time](/noir/reference/Noir/Abstractions/IGameTime/#time)
* [UnityEngine.Time](https://docs.unity3d.com/ScriptReference/Time.html)
