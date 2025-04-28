# Procedural generation

## Fast noise

## Poisson disc sampling

## Halton sequence

## Mersenne twister

Mersenne twister is a PRNG (**P**suedo **R**andom **N**umber **G**enerator) is useful when you need to generate 32bit integers that are randomly generated but need to follow the same generation sequence given the same seed.

### When is it useful?

Mersenne wwister is most useful in situations where you need to have numbers chosen various clients, but each client must agree on the chosen numbers. For example, a multiplayer game where damage amounts are determined by dice rolls. Each client connected to the game would use the same seed value in the mersenne twister algorithm which would garauntee the values would follow the same pattern.

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
