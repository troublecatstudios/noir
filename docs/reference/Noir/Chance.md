# Chance

**Namespace:** Noir <br>
**Assembly:** Noir.dll

```csharp
public static class Chance
```

Helper class for achieving random outcomes.

### ⛹️‍♀️ Methods
#### CoinFlip()
```csharp
public bool CoinFlip()
```

Shortcut for 50/50 chance.

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

#### Odds(float, int)
```csharp
public bool Odds(float odds, int attempts)
```

Generates a number between 0.0 and 1.0, inclusive and returns <c>true</c> if that number is less than or equal to the given odds.

**Parameters** <br>
`odds` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`attempts` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

**Exceptions** <br>
[ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/System.ArgumentException?view=net-7.0) <br>
 <br>
#### Odds(float)
```csharp
public bool Odds(float odds)
```

Generates a number between 0.0 and 1.0, inclusive and returns <c>true</c> if that number is less than or equal to the given odds.

**Parameters** <br>
`odds` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

**Exceptions** <br>
[ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/System.ArgumentException?view=net-7.0) <br>
 <br>
#### Odds(int)
```csharp
public bool Odds(int odds)
```

Generates a number between 0 and 100, inclusive and returns <c>true</c> if that number is less than or equal to the given odds.

**Parameters** <br>
`odds` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

**Exceptions** <br>
[ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/System.ArgumentException?view=net-7.0) <br>
 <br>
