# FakeGameTime

**Namespace:** Noir.Testing <br>
**Assembly:** NoirEditor.dll

```csharp
public class FakeGameTime : IGameTime
```

**Implements:** _[IGameTime](../../Noir/Abstractions/IGameTime.html)_

### 🛠 Constructors
```csharp
public FakeGameTime()
```

### 📦 Properties
#### deltaTime
```csharp
public virtual float deltaTime { get; public set; }
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### fixedDeltaTime
```csharp
public virtual float fixedDeltaTime { get; public set; }
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### frameCount
```csharp
public virtual int frameCount { get; public set; }
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
#### realtimeSinceStartup
```csharp
public virtual float realtimeSinceStartup { get; public set; }
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### time
```csharp
public virtual float time { get; public set; }
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
### ⛹️‍♀️ Methods
#### StepFrame()
```csharp
public void StepFrame()
```

#### StepFrames(int)
```csharp
public void StepFrames(int frames)
```

**Parameters** <br>
`frames` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

