# DictionaryExtensions

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->


```csharp
public static class DictionaryExtensions
```

## Methods

### `Upsert(Dictionary<TKey, TValue>, KeyValuePair<TKey, TValue>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Upsert(Dictionary<TKey, TValue> dict, KeyValuePair<TKey,
                    TValue> kvp)


```

**Parameters** <br>
`dict` [Dictionary\<TKey, TValue\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=net-7.0) <br>
`kvp` [KeyValuePair\<TKey, TValue\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=net-7.0) <br>

### `Upsert(Dictionary<TKey, TValue>, T, K)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Upsert(Dictionary<TKey, TValue> dict, T key, K value)

```

**Parameters** <br>
`dict` [Dictionary\<TKey, TValue\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=net-7.0) <br>
`key` [T](/noir/reference/) <br>
`value` [K](/noir/reference/) <br>

### `Upsert(Dictionary<TKey, TValue>, IDictionary<TKey, TValue>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Upsert(Dictionary<TKey, TValue> target, IDictionary<TKey,
                    TValue> source)


```

**Parameters** <br>
`target` [Dictionary\<TKey, TValue\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=net-7.0) <br>
`source` [IDictionary\<TKey, TValue\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2?view=net-7.0) <br>

