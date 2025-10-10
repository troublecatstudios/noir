# FastNoiseLite

<!-- tc:namespace Noir.Randomness -->

<!-- tc:assembly Noir.dll -->


```csharp
public class FastNoiseLite
```

## Constructors

<a name=".ctor"></a>

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

<a name="GetNoise"></a>

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

<a name="GetNoise"></a>

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

<a name="DomainWarp"></a>

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

<a name="DomainWarp"></a>

### `DomainWarp(Single&, Single&)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void DomainWarp(Single& x, Single& y)

```

**Parameters** <br>
`x` [float&](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`y` [float&](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="SetCellularDistanceFunction"></a>

### `SetCellularDistanceFunction(CellularDistanceFunction)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SetCellularDistanceFunction(CellularDistanceFunction cellularDistanceFunction)


```

**Parameters** <br>
`cellularDistanceFunction` [CellularDistanceFunction](/noir/reference//noir/reference/Noir/Randomness/CellularDistanceFunction/) <br>

<a name="SetCellularJitter"></a>

### `SetCellularJitter(float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets the maximum distance a cellular point can move from it's grid position
Default: 1.0
            Note: Setting this higher than 1 will cause artifacts


```csharp
public void SetCellularJitter(float cellularJitter)

```

**Parameters** <br>
`cellularJitter` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="SetCellularReturnType"></a>

### `SetCellularReturnType(CellularReturnType)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SetCellularReturnType(CellularReturnType cellularReturnType)

```

**Parameters** <br>
`cellularReturnType` [CellularReturnType](/noir/reference//noir/reference/Noir/Randomness/CellularReturnType/) <br>

<a name="SetDomainWarpAmp"></a>

### `SetDomainWarpAmp(float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets the maximum warp distance from original position when using DomainWarp(...)
Default: 1.0


```csharp
public void SetDomainWarpAmp(float domainWarpAmp)

```

**Parameters** <br>
`domainWarpAmp` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="SetDomainWarpType"></a>

### `SetDomainWarpType(DomainWarpType)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SetDomainWarpType(DomainWarpType domainWarpType)

```

**Parameters** <br>
`domainWarpType` [DomainWarpType](/noir/reference//noir/reference/Noir/Randomness/DomainWarpType/) <br>

<a name="SetFractalGain"></a>

### `SetFractalGain(float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets octave gain for all fractal noise types
Default: 0.5


```csharp
public void SetFractalGain(float gain)

```

**Parameters** <br>
`gain` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="SetFractalLacunarity"></a>

### `SetFractalLacunarity(float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets octave lacunarity for all fractal noise types
Default: 2.0


```csharp
public void SetFractalLacunarity(float lacunarity)

```

**Parameters** <br>
`lacunarity` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="SetFractalOctaves"></a>

### `SetFractalOctaves(int)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets octave count for all fractal noise types
Default: 3


```csharp
public void SetFractalOctaves(int octaves)

```

**Parameters** <br>
`octaves` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

<a name="SetFractalPingPongStrength"></a>

### `SetFractalPingPongStrength(float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets strength of the fractal ping pong effect
Default: 2.0


```csharp
public void SetFractalPingPongStrength(float pingPongStrength)

```

**Parameters** <br>
`pingPongStrength` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="SetFractalType"></a>

### `SetFractalType(FractalType)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SetFractalType(FractalType fractalType)

```

**Parameters** <br>
`fractalType` [FractalType](/noir/reference//noir/reference/Noir/Randomness/FractalType/) <br>

<a name="SetFractalWeightedStrength"></a>

### `SetFractalWeightedStrength(float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets octave weighting for all none DomainWarp fratal types
Default: 0.0
            Note: Keep between 0...1 to maintain -1...1 output bounding


```csharp
public void SetFractalWeightedStrength(float weightedStrength)

```

**Parameters** <br>
`weightedStrength` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="SetFrequency"></a>

### `SetFrequency(float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets frequency for all noise types
Default: 0.01


```csharp
public void SetFrequency(float frequency)

```

**Parameters** <br>
`frequency` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="SetNoiseType"></a>

### `SetNoiseType(NoiseType)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SetNoiseType(NoiseType noiseType)

```

**Parameters** <br>
`noiseType` [NoiseType](/noir/reference//noir/reference/Noir/Randomness/NoiseType/) <br>

<a name="SetRotationType3D"></a>

### `SetRotationType3D(RotationType3D)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SetRotationType3D(RotationType3D rotationType3D)

```

**Parameters** <br>
`rotationType3D` [RotationType3D](/noir/reference//noir/reference/Noir/Randomness/RotationType3D/) <br>

<a name="SetSeed"></a>

### `SetSeed(int)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets seed used for all noise types
Default: 1337


```csharp
public void SetSeed(int seed)

```

**Parameters** <br>
`seed` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

