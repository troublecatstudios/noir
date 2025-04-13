# GameTime

**Namespace:** Noir <br>
**Assembly:** Noir.dll

```csharp
public class GameTime : IGameTime
```

**Implements:** _[IGameTime](../Noir/Abstractions/IGameTime.html)_

### 🛠 Constructors
```csharp
public GameTime()
```

### 📦 Properties
#### deltaTime
```csharp
public virtual float deltaTime { get; }
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### fixedDeltaTime
```csharp
public virtual float fixedDeltaTime { get; }
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### FPS12
```csharp
public static const float FPS12;
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### FPS12L
```csharp
public static const long FPS12L;
```

**Returns** <br>
[long](https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=net-7.0) <br>
#### FPS24
```csharp
public static const float FPS24;
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### FPS24L
```csharp
public static const long FPS24L;
```

**Returns** <br>
[long](https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=net-7.0) <br>
#### FPS30
```csharp
public static const float FPS30;
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### FPS30L
```csharp
public static const long FPS30L;
```

**Returns** <br>
[long](https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=net-7.0) <br>
#### FPS60
```csharp
public static const float FPS60;
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### FPS60L
```csharp
public static const long FPS60L;
```

**Returns** <br>
[long](https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=net-7.0) <br>
#### frameCount
```csharp
public virtual int frameCount { get; }
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
#### Instance
```csharp
public readonly static GameTime Instance;
```

**Returns** <br>
[GameTime](../Noir/GameTime.html) <br>
#### realtimeSinceStartup
```csharp
public virtual float realtimeSinceStartup { get; }
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### time
```csharp
public virtual float time { get; }
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
