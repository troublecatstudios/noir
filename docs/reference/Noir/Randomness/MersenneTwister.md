# MersenneTwister

**Namespace:** Noir.Randomness <br>
**Assembly:** Noir.dll

```csharp
public class MersenneTwister
```

Pseudo-number generator based on the Mersenne Twister algorithm.

### 🛠 Constructors
```csharp
public MersenneTwister()
```

Initializes a new instance of the <see cref="T:SharpTwister.MersenneTwister"></see> class, using a time-dependent default seed value.

```csharp
public MersenneTwister(uint seed)
```

Initializes a new instance of the <see cref="T:SharpTwister.MersenneTwister"></see> class, using the specified seed value.

**Parameters** <br>
`seed` [uint](https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0) <br>
 <br>

### ⛹️‍♀️ Methods
#### NextDouble()
```csharp
public double NextDouble()
```

Returns a random floating-point number that is greater than or equal to 0.0, and less than 1.0.

**Returns** <br>
[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=net-7.0) <br>
 <br>

#### Next()
```csharp
public uint Next()
```

Returns a non-negative random integer.

**Returns** <br>
[uint](https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0) <br>
 <br>

#### Next(uint)
```csharp
public uint Next(uint maxValue)
```

Returns a non-negative random integer that is less than the specified maximum.

**Parameters** <br>
`maxValue` [uint](https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0) <br>
 <br>

**Returns** <br>
[uint](https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0) <br>
 <br>

#### Seed(uint)
```csharp
public void Seed(uint seed)
```

Sets the starting value for the pseudo-random number sequence.

**Parameters** <br>
`seed` [uint](https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0) <br>
 <br>

