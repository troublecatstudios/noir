# FastNoiseLite

**Namespace:** Noir.Randomness <br>
**Assembly:** Noir.dll

```csharp
public class FastNoiseLite
```

### 🛠 Constructors
```csharp
public FastNoiseLite(int seed)
```

Create new FastNoise object with optional seed

**Parameters** <br>
`seed` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

### ⛹️‍♀️ Methods
#### GetNoise(float, float, float)
```csharp
public float GetNoise(float x, float y, float z)
```

3D noise at given position using current settings

**Parameters** <br>
`x` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`y` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`z` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

#### GetNoise(float, float)
```csharp
public float GetNoise(float x, float y)
```

2D noise at given position using current settings

**Parameters** <br>
`x` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`y` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

#### DomainWarp(Single&, Single&, Single&)
```csharp
public void DomainWarp(Single& x, Single& y, Single& z)
```

**Parameters** <br>
`x` [float&](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`y` [float&](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`z` [float&](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

#### DomainWarp(Single&, Single&)
```csharp
public void DomainWarp(Single& x, Single& y)
```

**Parameters** <br>
`x` [float&](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`y` [float&](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

#### SetCellularDistanceFunction(CellularDistanceFunction)
```csharp
public void SetCellularDistanceFunction(CellularDistanceFunction cellularDistanceFunction)
```

**Parameters** <br>
`cellularDistanceFunction` [CellularDistanceFunction](../../Noir/Randomness/CellularDistanceFunction.html) <br>

#### SetCellularJitter(float)
```csharp
public void SetCellularJitter(float cellularJitter)
```

Sets the maximum distance a cellular point can move from it's grid position

**Parameters** <br>
`cellularJitter` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

#### SetCellularReturnType(CellularReturnType)
```csharp
public void SetCellularReturnType(CellularReturnType cellularReturnType)
```

**Parameters** <br>
`cellularReturnType` [CellularReturnType](../../Noir/Randomness/CellularReturnType.html) <br>

#### SetDomainWarpAmp(float)
```csharp
public void SetDomainWarpAmp(float domainWarpAmp)
```

Sets the maximum warp distance from original position when using DomainWarp(...)

**Parameters** <br>
`domainWarpAmp` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

#### SetDomainWarpType(DomainWarpType)
```csharp
public void SetDomainWarpType(DomainWarpType domainWarpType)
```

**Parameters** <br>
`domainWarpType` [DomainWarpType](../../Noir/Randomness/DomainWarpType.html) <br>

#### SetFractalGain(float)
```csharp
public void SetFractalGain(float gain)
```

Sets octave gain for all fractal noise types

**Parameters** <br>
`gain` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

#### SetFractalLacunarity(float)
```csharp
public void SetFractalLacunarity(float lacunarity)
```

Sets octave lacunarity for all fractal noise types

**Parameters** <br>
`lacunarity` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

#### SetFractalOctaves(int)
```csharp
public void SetFractalOctaves(int octaves)
```

Sets octave count for all fractal noise types

**Parameters** <br>
`octaves` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

#### SetFractalPingPongStrength(float)
```csharp
public void SetFractalPingPongStrength(float pingPongStrength)
```

Sets strength of the fractal ping pong effect

**Parameters** <br>
`pingPongStrength` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

#### SetFractalType(FractalType)
```csharp
public void SetFractalType(FractalType fractalType)
```

**Parameters** <br>
`fractalType` [FractalType](../../Noir/Randomness/FractalType.html) <br>

#### SetFractalWeightedStrength(float)
```csharp
public void SetFractalWeightedStrength(float weightedStrength)
```

Sets octave weighting for all none DomainWarp fratal types

**Parameters** <br>
`weightedStrength` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

#### SetFrequency(float)
```csharp
public void SetFrequency(float frequency)
```

Sets frequency for all noise types

**Parameters** <br>
`frequency` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

#### SetNoiseType(NoiseType)
```csharp
public void SetNoiseType(NoiseType noiseType)
```

**Parameters** <br>
`noiseType` [NoiseType](../../Noir/Randomness/NoiseType.html) <br>

#### SetRotationType3D(RotationType3D)
```csharp
public void SetRotationType3D(RotationType3D rotationType3D)
```

**Parameters** <br>
`rotationType3D` [RotationType3D](../../Noir/Randomness/RotationType3D.html) <br>

#### SetSeed(int)
```csharp
public void SetSeed(int seed)
```

Sets seed used for all noise types

**Parameters** <br>
`seed` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

