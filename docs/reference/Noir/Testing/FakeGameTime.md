# FakeGameTime

<!-- tc:namespace Noir.Testing -->

<!-- tc:assembly NoirEditor.dll -->

A fake or stubbed instance of [IGameTime](/noir/reference/Noir/Abstractions/IGameTime/) for use within tests.


```csharp
public class FakeGameTime : IGameTime
```

**Implements:** _[IGameTime](/noir/reference/Noir/Abstractions/IGameTime/)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public FakeGameTime()

```

## Properties

<a name="deltaTime"></a>

### `deltaTime`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public virtual float deltaTime { get; public set; }

```

<a name="fixedDeltaTime"></a>

### `fixedDeltaTime`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public virtual float fixedDeltaTime { get; public set; }

```

<a name="frameCount"></a>

### `frameCount`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public virtual int frameCount { get; public set; }

```

<a name="realtimeSinceStartup"></a>

### `realtimeSinceStartup`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public virtual float realtimeSinceStartup { get; public set; }

```

<a name="time"></a>

### `time`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public virtual float time { get; public set; }

```

## Methods

<a name="StepFrame"></a>

### `StepFrame()`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void StepFrame()

```

<a name="StepFrames"></a>

### `StepFrames(int)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void StepFrames(int frames)

```

**Parameters** <br>
`frames` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

## More information

* [Noir.Abstractions.IGameTime](/noir/reference/Noir/Abstractions/IGameTime/)
