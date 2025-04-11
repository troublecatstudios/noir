# DecibelConstants

**Namespace:** Noir.Audio <br>
**Assembly:** Noir.dll

```csharp
public static class DecibelConstants
```

### 📦 Properties
#### Concert
```csharp
public static const int Concert;
```

Also: jet aircraft engine during takeoff from 200ft

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
#### Conversation
```csharp
public static const int Conversation;
```

Conversation at 3ft distance

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
#### Discomfort
```csharp
public static const int Discomfort;
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
#### LoudRadio
```csharp
public static const int LoudRadio;
```

Also: A jackhammer at 50ft

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
#### Pain
```csharp
public static const int Pain;
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
#### Rain
```csharp
public static const int Rain;
```

Ambient noise of a perfectly quiet night, in a suburban neighborhood

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
#### SubwayTrain
```csharp
public static const int SubwayTrain;
```

Also: construction site

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
#### Whisper
```csharp
public static const int Whisper;
```

Ambient noise of a perfectly quiet night in the countryside

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
### ⛹️‍♀️ Methods
#### DecibelToDistance(float)
```csharp
public float DecibelToDistance(float db)
```

Estimates the distance based on the principle that sound intensity decreases by 6 decibels each time the distance from the source doubles

**Parameters** <br>
`db` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

