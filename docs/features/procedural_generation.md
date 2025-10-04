# Procedural generation

It can take a lot of data to create the vast and diverse worlds, enemy behaviors and interactable objects that players have come to expect from their games. Procedural generation is a method of creating data algorithmically instead of manually, combining human-generated content with computer-generated randomness and processing power.

## Noise

Noise is an extremely powerful procedural algorithm that is used often in content generation in games and other visual media such as movies. Noise can be used for creating procedural terrain (Minecraft, for example uses Perlin Noise for its terrain generation), fire, smoke, water effects or even clouds.

???+ info
    The implementation included in Noir is based on [:fontawesome-brands-github: Auburn/FastNoiseLite][fastnoise], which is licensed under the MIT license.


### When is it useful?

Noise is used in many different ways in game development. It can simulate imperfections, surface irregularities, or natural randomness found in real-world objects. It can generate procedural terrain or skyboxes. It's also used in shader development to create incredible visual effects.

### Examples

Here's an example for creating a 128x128 array of OpenSimplex2 noise

```csharp
// Create and configure FastNoise object
FastNoiseLite noise = new FastNoiseLite();
noise.SetNoiseType(FastNoiseLite.NoiseType.OpenSimplex2);

// Gather noise data
float[,] noiseData = new float[128, 128];

for (int x = 0; x < 128; x++)
{
    for (int y = 0; y < 128; y++)
    {
        noiseData[x, y] = noise.GetNoise(x, y);
    }
}


// Do something with this data...
```

## Poisson-disc sampling

Poisson-disc sampling produces points that are tightly-packed, but no closer to each other than a specified minimum distance, resulting in a more natural pattern. The high level view of the algorithm is to section up the space into a grid, and each iteration will randomly choose a point closest to the last and check that this point is not within a certain distance to any other point on the grid.

### When is it useful?

Poisson-disc is perfect for deterministically placing objects in the game world, like trees, points of interest or even enemy spawn points.

???+ warning
    Poisson-disc sampling is more suited towards low dimensions and sampling size due to its iterative nature and memory requirements. Selecting a small radius with a high dimension would mean that the space could contain more samples than using lower dimension or a bigger radius.

### Examples

```csharp
private IEnumerator PlaceTrees() {
    var settings = PoissonDisc.CreateSettings(Vector2.zero, dimensions, radius, seed: seed);
    var sampler = new PoissonSampler(settings);
    var ops = 0;
    while (sampler.Next(out _)) {
        yield return null;
        ops++;
        if (ops % 12 == 0) {
            // generate 12 samples per frame
            yield return null;
        }
    }
    var points = sampler.Points;
    foreach(var point in points) {
        var translatedPoint = transform.position + new Vector3(point.x, 0, point.y) - new Vector3(_dimensions.x / 2, 0, _dimensions.y / 2);
        var go = GameObject.Instantiate(tree, translatedPoint, Quaternion.identity, transform);
        yield return null;
    }
}
```

### Further reading

- [Poisson Disc Sampling in Arbitrary Dimensions](https://www.cs.ubc.ca/~rbridson/docs/bridson-siggraph07-poissondisk.pdf) by Robert Bridson
- [Recursive Wang Tiles for Real-Time Blue Noise](https://johanneskopf.de/publications/blue_noise/)
- [Mitchell’s Best-Candidate Algorithm](https://gist.github.com/mbostock/1893974) by Mike Bostock

## Halton sequence

In statistics, Halton sequences are sequences used to generate points in space for numerical methods such as
Monte Carlo simulations. Although these sequences are deterministic, they are of low discrepancy, that is,
appear to be random for many purposes. They were first introduced in 1960 and are an example of a quasi-random
number sequence. They generalize the one-dimensional van der Corput sequences.

### When is it useful?

Halton sequences are useful for generating points within a space when you want a seemingly random but even
distribution of the points. For example, procedurally placing trees within a level.

### Examples

```csharp
HaltonSequence.GeneratePoints(10, 2, 3); //#(1)!
```

1. Generates 10 points where the X axis will use 2 as its base and y will use 3.


## Mersenne twister

Mersenne twister is a PRNG (**P**suedo **R**andom **N**umber **G**enerator) is useful when you need to generate 32bit integers that are randomly generated but need to follow the same generation sequence given the same seed.

### When is it useful?

Mersenne wwister is most useful in situations where you need to have numbers chosen various clients, but each client must agree on the chosen numbers. For example, a multiplayer game where damage amounts are determined by dice rolls. Each client connected to the game would use the same seed value in the mersenne twister algorithm which would garauntee the values would follow the same pattern.

???+ info
    The implementation included in Noir is based on [:fontawesome-brands-github: diggingforfire/SharpTwister][sharptwister], which is licensed under the MIT license.

### Examples

=== "Basic Example"

    ```csharp
    var mersenneTwister = new MersenneTwister(seedValue);

    var nextInt = mersenneTwister.Next(); //#(1)!
    ```

    1. Returns a 32-bit unsigned integer that is greater than or
       equal to 0 and less than uint.MaxValue

=== "Deterministic integer set"

    Noir includes a helper class to generate random numbers from a pre-determined set.

    ```csharp
    var set = new DeterministicIntegerSet(seedValue, 0, 1, 3, 5, 7, 9);

    var val = set.Next(); //#(1)!
    ```

    1. This will always return one of the original values passed, all
       `DeterministicIntegerSets` created with the same seed and set
       of numbers will return values in the same order.

=== "Deterministic Random"

    Noir includes a static helper class that uses mersenne twister to generate random numbers within a given range.

    ```csharp
    var val = DeterministicRandom.InRange(10, 20); //#(1)!
    ```

    1. Returns a value between 10 and 20 (inclusive).

[sharptwister]: https://github.com/diggingforfire/SharpTwister
[fastnoise]: https://github.com/Auburn/FastNoiseLite
