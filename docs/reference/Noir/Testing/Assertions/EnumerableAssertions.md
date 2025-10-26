# EnumerableAssertions

<!-- tc:namespace Noir.Testing.Assertions -->

<!-- tc:assembly NoirEditor.dll -->

Provides assertion extensions for verifying the contents and structure of [IEnumerable<T>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) collections.


```csharp
public static class EnumerableAssertions
```

## Methods

<a name="Contains"></a>

### `Contains(IAssertionContext<T>, T)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void Contains(IAssertionContext<T> context, T item)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
`item` [T](/noir/reference/) <br>

<a name="HasLength"></a>

### `HasLength(IAssertionContext<T>, int)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Asserts that the enumerable contains the expected number of elements.


```csharp
public void HasLength(IAssertionContext<T> context, int length)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
 <br>
`length` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
 <br>

**Exceptions** <br>
[AssertionException](/noir/reference/) <br>
 <br>
<a name="HasSameContents"></a>

### `HasSameContents(IAssertionContext<T>, IEnumerable)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Asserts that the enumerable contains the same elements in the same order as another enumerable.


```csharp
public void HasSameContents(IAssertionContext<T> context, IEnumerable expected)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
 <br>
`expected` [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable?view=net-7.0) <br>
 <br>

**Exceptions** <br>
[AssertionException](/noir/reference/) <br>
 <br>
## More information

* [System.Collections.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable?view=net-7.0)
* [System.Collections.Generic.IEnumerable`1](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0)
