# IEnumerableExtensions

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->


```csharp
public static class IEnumerableExtensions
```

## Methods

### `ContainsAny(IEnumerable<T>, string, StringComparison)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool ContainsAny(IEnumerable<T> sequence, string element,
                         StringComparison comparisonType)


```

**Parameters** <br>
`sequence` [IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>
`element` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`comparisonType` [StringComparison](https://learn.microsoft.com/en-us/dotnet/api/System.StringComparison?view=net-7.0) <br>

### `IsEmptySafe(IEnumerable)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Determines if the enumerable has any items without throwing a NullReferenceException.


```csharp
public bool IsEmptySafe(IEnumerable enumerable)

```

**Parameters** <br>
`enumerable` [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable?view=net-7.0) <br>
 <br>

### `IndexWhere(IEnumerable<T>, Func<T, TResult>)`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int IndexWhere(IEnumerable<T> source, Func<T, TResult> predicate)

```

**Parameters** <br>
`source` [IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>
`predicate` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>

### `Random(IEnumerable<T>)`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 1.0.0 -->

```csharp
public T Random(IEnumerable<T> sequence)

```

**Parameters** <br>
`sequence` [IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>

### `RandomElementByWeight(IEnumerable<T>, Func<T, TResult>)`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 1.0.0 -->

```csharp
public T RandomElementByWeight(IEnumerable<T> sequence, Func<T,
                                TResult> weightSelector)


```

**Parameters** <br>
`sequence` [IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>
`weightSelector` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>

