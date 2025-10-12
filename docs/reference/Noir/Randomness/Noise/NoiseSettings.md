# NoiseSettings

<!-- tc:namespace Noir.Randomness.Noise -->

<!-- tc:assembly Noir.dll -->


```csharp
public sealed struct NoiseSettings : IEquatable<T>
```

**Implements:** _[IEquatable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=net-7.0)_

## Fields

<a name="CellularDistance"></a>

### `CellularDistance`
<!-- tc:scope private -->
<!-- tc:return_type CellularDistanceFunction /noir/reference/Noir/Randomness/CellularDistanceFunction/ -->
<!-- tc:version 1.0.0 -->

```csharp
public CellularDistanceFunction CellularDistance;

```

<a name="CellularJitter"></a>

### `CellularJitter`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float CellularJitter;

```

<a name="CellularReturnType"></a>

### `CellularReturnType`
<!-- tc:scope private -->
<!-- tc:return_type CellularReturnType /noir/reference/Noir/Randomness/CellularReturnType/ -->
<!-- tc:version 1.0.0 -->

```csharp
public CellularReturnType CellularReturnType;

```

<a name="DomainWarp"></a>

### `DomainWarp`
<!-- tc:scope private -->
<!-- tc:return_type DomainWarpType /noir/reference/Noir/Randomness/DomainWarpType/ -->
<!-- tc:version 1.0.0 -->

```csharp
public DomainWarpType DomainWarp;

```

<a name="DomainWarpAmplitude"></a>

### `DomainWarpAmplitude`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float DomainWarpAmplitude;

```

<a name="Empty"></a>

### `Empty`
<!-- tc:scope private -->
<!-- tc:return_type NoiseSettings /noir/reference/Noir/Randomness/Noise/NoiseSettings/ -->
<!-- tc:version 1.0.0 -->

```csharp
public readonly static NoiseSettings Empty;

```

<a name="FractalGain"></a>

### `FractalGain`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float FractalGain;

```

<a name="FractalLacunarity"></a>

### `FractalLacunarity`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float FractalLacunarity;

```

<a name="FractalOctaves"></a>

### `FractalOctaves`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int FractalOctaves;

```

<a name="FractalPingPongStrength"></a>

### `FractalPingPongStrength`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float FractalPingPongStrength;

```

<a name="FractalType"></a>

### `FractalType`
<!-- tc:scope private -->
<!-- tc:return_type FractalType /noir/reference/Noir/Randomness/FractalType/ -->
<!-- tc:version 1.0.0 -->

```csharp
public FractalType FractalType;

```

<a name="FractalWeightedStrength"></a>

### `FractalWeightedStrength`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float FractalWeightedStrength;

```

<a name="Frequency"></a>

### `Frequency`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int Frequency;

```

<a name="NoiseType"></a>

### `NoiseType`
<!-- tc:scope private -->
<!-- tc:return_type NoiseType /noir/reference/Noir/Randomness/NoiseType/ -->
<!-- tc:version 1.0.0 -->

```csharp
public NoiseType NoiseType;

```

<a name="Offset"></a>

### `Offset`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float Offset;

```

<a name="Scale"></a>

### `Scale`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float Scale;

```

<a name="Seed"></a>

### `Seed`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int Seed;

```

<a name="Weight"></a>

### `Weight`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int Weight;

```

## Properties

<a name="FrequencyCalc"></a>

### `FrequencyCalc`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float FrequencyCalc { get; }

```

## Methods

<a name="Equals"></a>

### `Equals(NoiseSettings)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Equals(NoiseSettings other)

```

**Parameters** <br>
`other` [NoiseSettings](/noir/reference/Noir/Randomness/Noise/NoiseSettings/) <br>

<a name="Equals"></a>

### `Equals(Object)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Equals(Object obj)

```

**Parameters** <br>
`obj` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

<a name="GetHashCode"></a>

### `GetHashCode()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual int GetHashCode()

```

<a name="ToString"></a>

### `ToString()`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual string ToString()

```

