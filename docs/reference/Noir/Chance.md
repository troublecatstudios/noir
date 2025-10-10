# Chance

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Helper class for achieving random outcomes.


```csharp
public static class Chance
```

## Methods

<a name="CoinFlip"></a>

### `CoinFlip()`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Shortcut for 50/50 chance.


```csharp
public bool CoinFlip()

```

<a name="Odds"></a>

### `Odds(float, int)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Generates a number between 0.0 and 1.0, inclusive and returns <c>true</c> if that number is less than or equal to the given odds.


```csharp
public bool Odds(float odds, int attempts)

```

**Parameters** <br>
`odds` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`attempts` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>

**Exceptions** <br>
[ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/System.ArgumentException?view=net-7.0) <br>
 <br>
<a name="Odds"></a>

### `Odds(float)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Generates a number between 0.0 and 1.0, inclusive and returns <c>true</c> if that number is less than or equal to the given odds.


```csharp
public bool Odds(float odds)

```

**Parameters** <br>
`odds` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

**Exceptions** <br>
[ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/System.ArgumentException?view=net-7.0) <br>
 <br>
<a name="Odds"></a>

### `Odds(int)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Generates a number between 0 and 100, inclusive and returns <c>true</c> if that number is less than or equal to the given odds.


```csharp
public bool Odds(int odds)

```

**Parameters** <br>
`odds` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>

**Exceptions** <br>
[ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/System.ArgumentException?view=net-7.0) <br>
 <br>
