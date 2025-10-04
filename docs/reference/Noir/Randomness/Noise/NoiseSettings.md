# NoiseSettings

<!-- tc:namespace Noir.Randomness.Noise -->

<!-- tc:assembly Noir.dll -->


```csharp
public sealed struct NoiseSettings : IEquatable<T>
```

**Implements:** _[IEquatable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=net-7.0)_

## Properties

### `CellularDistance`
<!-- tc:scope private -->
<!-- tc:return_type CellularDistanceFunction /noir/reference//noir/reference//noir/reference/Noir/Randomness/CellularDistanceFunction/ -->
<!-- tc:version 1.0.0 -->

```csharp
public CellularDistanceFunction CellularDistance;

```

### `CellularJitter`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float CellularJitter;

```

### `CellularReturnType`
<!-- tc:scope private -->
<!-- tc:return_type CellularReturnType /noir/reference//noir/reference//noir/reference/Noir/Randomness/CellularReturnType/ -->
<!-- tc:version 1.0.0 -->

```csharp
public CellularReturnType CellularReturnType;

```

### `DomainWarp`
<!-- tc:scope private -->
<!-- tc:return_type DomainWarpType /noir/reference//noir/reference//noir/reference/Noir/Randomness/DomainWarpType/ -->
<!-- tc:version 1.0.0 -->

```csharp
public DomainWarpType DomainWarp;

```

### `DomainWarpAmplitude`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float DomainWarpAmplitude;

```

### `Empty`
<!-- tc:scope private -->
<!-- tc:return_type NoiseSettings /noir/reference//noir/reference//noir/reference/Noir/Randomness/Noise/NoiseSettings/ -->
<!-- tc:version 1.0.0 -->

```csharp
public readonly static NoiseSettings Empty;

```

### `FractalGain`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float FractalGain;

```

### `FractalLacunarity`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float FractalLacunarity;

```

### `FractalOctaves`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int FractalOctaves;

```

### `FractalPingPongStrength`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float FractalPingPongStrength;

```

### `FractalType`
<!-- tc:scope private -->
<!-- tc:return_type FractalType /noir/reference//noir/reference//noir/reference/Noir/Randomness/FractalType/ -->
<!-- tc:version 1.0.0 -->

```csharp
public FractalType FractalType;

```

### `FractalWeightedStrength`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float FractalWeightedStrength;

```

### `Frequency`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int Frequency;

```

### `FrequencyCalc`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float FrequencyCalc { get; }

```

### `NoiseType`
<!-- tc:scope private -->
<!-- tc:return_type NoiseType /noir/reference//noir/reference//noir/reference/Noir/Randomness/NoiseType/ -->
<!-- tc:version 1.0.0 -->

```csharp
public NoiseType NoiseType;

```

### `Offset`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float Offset;

```

### `Scale`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float Scale;

```

### `Seed`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int Seed;

```

### `Weight`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int Weight;

```

## Methods

### `Equals(NoiseSettings)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Equals(NoiseSettings other)

```

**Parameters** <br>
`other` [NoiseSettings](/noir/reference//noir/reference//noir/reference/Noir/Randomness/Noise/NoiseSettings/) <br>

### `Equals(Object)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Equals(Object obj)

```

**Parameters** <br>
`obj` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

### `GetHashCode()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual int GetHashCode()

```

### `ToString()`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual string ToString()

```

