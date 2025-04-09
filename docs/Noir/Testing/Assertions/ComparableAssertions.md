# ComparableAssertions

**Namespace:** Noir.Testing.Assertions <br>
**Assembly:** NoirEditor.dll

```csharp
public static class ComparableAssertions
```

### ⛹️‍♀️ Methods
#### IsEqualTo(ICustomAssertionContext<T>, T, string)
```csharp
public void IsEqualTo(ICustomAssertionContext<T> context, T expectedValue, string message)
```

**Parameters** <br>
`context` [ICustomAssertionContext\<T\>](../../../Noir/Testing/ICustomAssertionContext-1.html) <br>
`expectedValue` [T](../../../) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### IsGreaterThan(ICustomAssertionContext<T>, T)
```csharp
public void IsGreaterThan(ICustomAssertionContext<T> context, T expectedValue)
```

**Parameters** <br>
`context` [ICustomAssertionContext\<T\>](../../../Noir/Testing/ICustomAssertionContext-1.html) <br>
`expectedValue` [T](../../../) <br>

#### IsLessThan(ICustomAssertionContext<T>, T)
```csharp
public void IsLessThan(ICustomAssertionContext<T> context, T expectedValue)
```

**Parameters** <br>
`context` [ICustomAssertionContext\<T\>](../../../Noir/Testing/ICustomAssertionContext-1.html) <br>
`expectedValue` [T](../../../) <br>

#### IsNotEqualTo(ICustomAssertionContext<T>, T, string)
```csharp
public void IsNotEqualTo(ICustomAssertionContext<T> context, T expectedValue, string message)
```

**Parameters** <br>
`context` [ICustomAssertionContext\<T\>](../../../Noir/Testing/ICustomAssertionContext-1.html) <br>
`expectedValue` [T](../../../) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### IsWithinRange(ICustomAssertionContext<T>, T, T, bool)
```csharp
public void IsWithinRange(ICustomAssertionContext<T> context, T min, T max, bool inclusive)
```

**Parameters** <br>
`context` [ICustomAssertionContext\<T\>](../../../Noir/Testing/ICustomAssertionContext-1.html) <br>
`min` [T](../../../) <br>
`max` [T](../../../) <br>
`inclusive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

