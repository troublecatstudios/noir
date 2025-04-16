# NoiseSettings

**Namespace:** Noir.Randomness.Noise <br>
**Assembly:** Noir.dll

```csharp
public sealed struct NoiseSettings : IEquatable<T>
```

**Implements:** _[IEquatable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=net-7.0)_

### 📦 Properties
#### CellularDistance
```csharp
public CellularDistanceFunction CellularDistance;
```

**Returns** <br>
[CellularDistanceFunction](../../../Noir/Randomness/CellularDistanceFunction.html) <br>
#### CellularJitter
```csharp
public float CellularJitter;
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### CellularReturnType
```csharp
public CellularReturnType CellularReturnType;
```

**Returns** <br>
[CellularReturnType](../../../Noir/Randomness/CellularReturnType.html) <br>
#### DomainWarp
```csharp
public DomainWarpType DomainWarp;
```

**Returns** <br>
[DomainWarpType](../../../Noir/Randomness/DomainWarpType.html) <br>
#### DomainWarpAmplitude
```csharp
public float DomainWarpAmplitude;
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### Empty
```csharp
public readonly static NoiseSettings Empty;
```

**Returns** <br>
[NoiseSettings](../../../Noir/Randomness/Noise/NoiseSettings.html) <br>
#### FractalGain
```csharp
public float FractalGain;
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### FractalLacunarity
```csharp
public float FractalLacunarity;
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### FractalOctaves
```csharp
public int FractalOctaves;
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
#### FractalPingPongStrength
```csharp
public float FractalPingPongStrength;
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### FractalType
```csharp
public FractalType FractalType;
```

**Returns** <br>
[FractalType](../../../Noir/Randomness/FractalType.html) <br>
#### FractalWeightedStrength
```csharp
public float FractalWeightedStrength;
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### Frequency
```csharp
public int Frequency;
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
#### FrequencyCalc
```csharp
public float FrequencyCalc { get; }
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### NoiseType
```csharp
public NoiseType NoiseType;
```

**Returns** <br>
[NoiseType](../../../Noir/Randomness/NoiseType.html) <br>
#### Offset
```csharp
public float Offset;
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### Scale
```csharp
public float Scale;
```

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### Seed
```csharp
public int Seed;
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
#### Weight
```csharp
public int Weight;
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
### ⛹️‍♀️ Methods
#### Equals(NoiseSettings)
```csharp
public virtual bool Equals(NoiseSettings other)
```

**Parameters** <br>
`other` [NoiseSettings](../../../Noir/Randomness/Noise/NoiseSettings.html) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### Equals(Object)
```csharp
public virtual bool Equals(Object obj)
```

**Parameters** <br>
`obj` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### GetHashCode()
```csharp
public virtual int GetHashCode()
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

#### ToString()
```csharp
public virtual string ToString()
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

