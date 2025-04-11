# IEnumerableExtensions

**Namespace:** Noir <br>
**Assembly:** Noir.dll

```csharp
public static class IEnumerableExtensions
```

### ⛹️‍♀️ Methods
#### ContainsAny(IEnumerable<T>, string, StringComparison)
```csharp
public bool ContainsAny(IEnumerable<T> sequence, string element, StringComparison comparisonType)
```

**Parameters** <br>
`sequence` [IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>
`element` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`comparisonType` [StringComparison](https://learn.microsoft.com/en-us/dotnet/api/System.StringComparison?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### IsEmptySafe(IEnumerable)
```csharp
public bool IsEmptySafe(IEnumerable enumerable)
```

Determines if the enumerable has any items without throwing a NullReferenceException.

**Parameters** <br>
`enumerable` [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable?view=net-7.0) <br>
 <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

#### IndexWhere(IEnumerable<T>, Func<T, TResult>)
```csharp
public int IndexWhere(IEnumerable<T> source, Func<T, TResult> predicate)
```

**Parameters** <br>
`source` [IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>
`predicate` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

#### Random(IEnumerable<T>)
```csharp
public T Random(IEnumerable<T> sequence)
```

**Parameters** <br>
`sequence` [IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>

**Returns** <br>
[T](../) <br>

#### RandomElementByWeight(IEnumerable<T>, Func<T, TResult>)
```csharp
public T RandomElementByWeight(IEnumerable<T> sequence, Func<T, TResult> weightSelector)
```

**Parameters** <br>
`sequence` [IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>
`weightSelector` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>

**Returns** <br>
[T](../) <br>

