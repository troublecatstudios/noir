# HaltonSequence

<!-- tc:namespace Noir.Randomness -->

<!-- tc:assembly Noir.dll -->

Helper methods for generating numbers/points based on the Halton Sequence algorithm.
In statistics, Halton sequences are sequences used to generate points in space for numerical methods such as
             Monte Carlo simulations. Although these sequences are deterministic, they are of low discrepancy, that is,
             appear to be random for many purposes. They were first introduced in 1960 and are an example of a quasi-random
             number sequence. They generalize the one-dimensional van der Corput sequences.
            
             See https://en.wikipedia.org/wiki/Halton_sequence for more information.


```csharp
public static class HaltonSequence
```

## Methods

<a name="GetIndex"></a>

### `GetIndex(int, int)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public float GetIndex(int index, int baseNum)

```

**Parameters** <br>
`index` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
`baseNum` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

<a name="GeneratePoints"></a>

### `GeneratePoints(int, int, int)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2[] https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->
Returns an array of points based on the Halton Sequence algorithm.


```csharp
public Vector2[] GeneratePoints(int count, int base1, int base2)

```

**Parameters** <br>
`count` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>
`base1` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>
`base2` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>

