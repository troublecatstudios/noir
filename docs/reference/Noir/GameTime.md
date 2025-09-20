# GameTime

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->


```csharp
public class GameTime : IGameTime
```

**Implements:** _[IGameTime](/noir/reference/Noir/Abstractions/IGameTime/)_

## 🛠 Constructors

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public GameTime()
```

## 📦 Properties

### `deltaTime`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual float deltaTime { get; }
```

### `fixedDeltaTime`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual float fixedDeltaTime { get; }
```

### `FPS12`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public static const float FPS12;
```

### `FPS12L`
<!-- tc:scope private -->
<!-- tc:return_type long https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public static const long FPS12L;
```

### `FPS24`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public static const float FPS24;
```

### `FPS24L`
<!-- tc:scope private -->
<!-- tc:return_type long https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public static const long FPS24L;
```

### `FPS30`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public static const float FPS30;
```

### `FPS30L`
<!-- tc:scope private -->
<!-- tc:return_type long https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public static const long FPS30L;
```

### `FPS60`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public static const float FPS60;
```

### `FPS60L`
<!-- tc:scope private -->
<!-- tc:return_type long https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public static const long FPS60L;
```

### `frameCount`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual int frameCount { get; }
```

### `Instance`
<!-- tc:scope private -->
<!-- tc:return_type GameTime /noir/reference/Noir/GameTime/ -->
<!-- tc:version 1.0.0 -->

```csharp
public readonly static GameTime Instance;
```

### `realtimeSinceStartup`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual float realtimeSinceStartup { get; }
```

### `time`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual float time { get; }
```

