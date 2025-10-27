# Noise

<!-- tc:namespace Noir.Audio -->

<!-- tc:assembly Noir.dll -->

Provides utility methods for converting between linear audio amplitude and decibel levels.


```csharp
public static class Noise
```

## Methods

<a name="DecibelToLinear"></a>

### `DecibelToLinear(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Converts a decibel (dB) value to a linear amplitude.


```csharp
public float DecibelToLinear(float db)

```

**Parameters** <br>
`db` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

<a name="LinearToDecibel"></a>

### `LinearToDecibel(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Converts a linear amplitude value to decibels (dB).


```csharp
public float LinearToDecibel(float linear)

```

**Parameters** <br>
`linear` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

