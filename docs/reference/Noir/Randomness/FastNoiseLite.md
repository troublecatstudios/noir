# FastNoiseLite

<!-- tc:namespace Noir.Randomness -->

<!-- tc:assembly Noir.dll -->


```csharp
public class FastNoiseLite
```

## Constructors

### `.ctor(int)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Create new FastNoise object with optional seed


```csharp
public FastNoiseLite(int seed)

```

**Parameters** <br>
`seed` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

## Methods

### `GetNoise(float, float, float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
3D noise at given position using current settings


```csharp
public float GetNoise(float x, float y, float z)

```

**Parameters** <br>
`x` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`y` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`z` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

### `GetNoise(float, float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
2D noise at given position using current settings


```csharp
public float GetNoise(float x, float y)

```

**Parameters** <br>
`x` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`y` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

### `DomainWarp(Single&, Single&, Single&)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void DomainWarp(Single& x, Single& y, Single& z)

```

**Parameters** <br>
`x` [float&](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`y` [float&](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`z` [float&](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

### `DomainWarp(Single&, Single&)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void DomainWarp(Single& x, Single& y)

```

**Parameters** <br>
`x` [float&](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`y` [float&](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

### `SetCellularDistanceFunction(CellularDistanceFunction)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SetCellularDistanceFunction(CellularDistanceFunction cellularDistanceFunction)


```

**Parameters** <br>
`cellularDistanceFunction` [CellularDistanceFunction](/noir/reference//noir/reference/Noir/Randomness/CellularDistanceFunction/) <br>

### `SetCellularJitter(float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets the maximum distance a cellular point can move from it's grid position


```csharp
public void SetCellularJitter(float cellularJitter)

```

**Parameters** <br>
`cellularJitter` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

### `SetCellularReturnType(CellularReturnType)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SetCellularReturnType(CellularReturnType cellularReturnType)

```

**Parameters** <br>
`cellularReturnType` [CellularReturnType](/noir/reference//noir/reference/Noir/Randomness/CellularReturnType/) <br>

### `SetDomainWarpAmp(float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets the maximum warp distance from original position when using DomainWarp(...)


```csharp
public void SetDomainWarpAmp(float domainWarpAmp)

```

**Parameters** <br>
`domainWarpAmp` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

### `SetDomainWarpType(DomainWarpType)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SetDomainWarpType(DomainWarpType domainWarpType)

```

**Parameters** <br>
`domainWarpType` [DomainWarpType](/noir/reference//noir/reference/Noir/Randomness/DomainWarpType/) <br>

### `SetFractalGain(float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets octave gain for all fractal noise types


```csharp
public void SetFractalGain(float gain)

```

**Parameters** <br>
`gain` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

### `SetFractalLacunarity(float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets octave lacunarity for all fractal noise types


```csharp
public void SetFractalLacunarity(float lacunarity)

```

**Parameters** <br>
`lacunarity` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

### `SetFractalOctaves(int)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets octave count for all fractal noise types


```csharp
public void SetFractalOctaves(int octaves)

```

**Parameters** <br>
`octaves` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

### `SetFractalPingPongStrength(float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets strength of the fractal ping pong effect


```csharp
public void SetFractalPingPongStrength(float pingPongStrength)

```

**Parameters** <br>
`pingPongStrength` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

### `SetFractalType(FractalType)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SetFractalType(FractalType fractalType)

```

**Parameters** <br>
`fractalType` [FractalType](/noir/reference//noir/reference/Noir/Randomness/FractalType/) <br>

### `SetFractalWeightedStrength(float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets octave weighting for all none DomainWarp fratal types


```csharp
public void SetFractalWeightedStrength(float weightedStrength)

```

**Parameters** <br>
`weightedStrength` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

### `SetFrequency(float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets frequency for all noise types


```csharp
public void SetFrequency(float frequency)

```

**Parameters** <br>
`frequency` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

### `SetNoiseType(NoiseType)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SetNoiseType(NoiseType noiseType)

```

**Parameters** <br>
`noiseType` [NoiseType](/noir/reference//noir/reference/Noir/Randomness/NoiseType/) <br>

### `SetRotationType3D(RotationType3D)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SetRotationType3D(RotationType3D rotationType3D)

```

**Parameters** <br>
`rotationType3D` [RotationType3D](/noir/reference//noir/reference/Noir/Randomness/RotationType3D/) <br>

### `SetSeed(int)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets seed used for all noise types


```csharp
public void SetSeed(int seed)

```

**Parameters** <br>
`seed` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

