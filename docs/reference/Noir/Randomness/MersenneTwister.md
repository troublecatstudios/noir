# MersenneTwister

<!-- tc:namespace Noir.Randomness -->

<!-- tc:assembly Noir.dll -->

Pseudo-number generator based on the Mersenne Twister algorithm.


```csharp
public class MersenneTwister
```

## Constructors

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Initializes a new instance of the <see cref="T:SharpTwister.MersenneTwister"></see> class, using a time-dependent default seed value.


```csharp
public MersenneTwister()

```

### `.ctor(uint)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Initializes a new instance of the <see cref="T:SharpTwister.MersenneTwister"></see> class, using the specified seed value.


```csharp
public MersenneTwister(uint seed)

```

**Parameters** <br>
`seed` [uint](https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0) <br>
 <br>

## Methods

### `NextDouble()`
<!-- tc:scope public -->
<!-- tc:return_type double https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns a random floating-point number that is greater than or equal to 0.0, and less than 1.0.


```csharp
public double NextDouble()

```

### `Next()`
<!-- tc:scope public -->
<!-- tc:return_type uint https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns a non-negative random integer.


```csharp
public uint Next()

```

### `Next(uint)`
<!-- tc:scope public -->
<!-- tc:return_type uint https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns a non-negative random integer that is less than the specified maximum.


```csharp
public uint Next(uint maxValue)

```

**Parameters** <br>
`maxValue` [uint](https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0) <br>
 <br>

### `Seed(uint)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Sets the starting value for the pseudo-random number sequence.


```csharp
public void Seed(uint seed)

```

**Parameters** <br>
`seed` [uint](https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0) <br>
 <br>

