# ComparableAssertions

**Namespace:** Noir.Testing.Assertions <br>
**Assembly:** NoirEditor.dll

```csharp
public static class ComparableAssertions
```

### ⛹️‍♀️ Methods
#### IsEqualTo(IAssertionContext<T>, T, string)
```csharp
public void IsEqualTo(IAssertionContext<T> context, T expectedValue, string message)
```

**Parameters** <br>
`context` [IAssertionContext\<T\>](../../../Noir/Testing/IAssertionContext-1.html) <br>
`expectedValue` [T](../../../) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### IsGreaterThan(IAssertionContext<T>, T)
```csharp
public void IsGreaterThan(IAssertionContext<T> context, T expectedValue)
```

**Parameters** <br>
`context` [IAssertionContext\<T\>](../../../Noir/Testing/IAssertionContext-1.html) <br>
`expectedValue` [T](../../../) <br>

#### IsLessThan(IAssertionContext<T>, T)
```csharp
public void IsLessThan(IAssertionContext<T> context, T expectedValue)
```

**Parameters** <br>
`context` [IAssertionContext\<T\>](../../../Noir/Testing/IAssertionContext-1.html) <br>
`expectedValue` [T](../../../) <br>

#### IsNotEqualTo(IAssertionContext<T>, T, string)
```csharp
public void IsNotEqualTo(IAssertionContext<T> context, T expectedValue, string message)
```

**Parameters** <br>
`context` [IAssertionContext\<T\>](../../../Noir/Testing/IAssertionContext-1.html) <br>
`expectedValue` [T](../../../) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### IsWithinRange(IAssertionContext<T>, T, T, bool)
```csharp
public void IsWithinRange(IAssertionContext<T> context, T min, T max, bool inclusive)
```

**Parameters** <br>
`context` [IAssertionContext\<T\>](../../../Noir/Testing/IAssertionContext-1.html) <br>
`min` [T](../../../) <br>
`max` [T](../../../) <br>
`inclusive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

