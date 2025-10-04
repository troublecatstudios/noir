# SerializedDictionary\<TKey, TValue\>

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

An [IDictionary<TKey, TValue>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2?view=net-7.0) that can be serialized as
            part of a Unity object.


```csharp
public class SerializedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<T>, IEnumerable<T>, IEnumerable, ISerializationCallbackReceiver
```

**Implements:** _[IDictionary\<TKey, TValue\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2?view=net-7.0), [ICollection\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1?view=net-7.0), [IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0), [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable?view=net-7.0), [ISerializationCallbackReceiver](https://docs.unity3d.com/ScriptReference/ISerializationCallbackReceiver.html)_

## Constructors

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public SerializedDictionary<TKey, TValue>()

```

## Properties

### `Count`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual int Count { get; }

```

### `IsReadOnly`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool IsReadOnly { get; }

```

### `Item`
<!-- tc:scope public -->
<!-- tc:return_type TValue -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual TValue Item { get; public set; }

```

### `Keys`
<!-- tc:scope public -->
<!-- tc:return_type ICollection\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual ICollection<T> Keys { get; }

```

### `Values`
<!-- tc:scope public -->
<!-- tc:return_type ICollection\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual ICollection<T> Values { get; }

```

## Methods

### `From(Dictionary<TKey, TValue>)`
<!-- tc:scope public -->
<!-- tc:return_type SerializedDictionary\<TKey, TValue\> /noir/reference/Noir/SerializedDictionary-2/ -->
<!-- tc:version 1.0.0 -->

```csharp
public SerializedDictionary<TKey, TValue> From(Dictionary<TKey,
                                                TValue> dictionary)


```

**Parameters** <br>
`dictionary` [Dictionary\<TKey, TValue\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=net-7.0) <br>

### `Contains(KeyValuePair<TKey, TValue>)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Contains(KeyValuePair<TKey, TValue> item)

```

**Parameters** <br>
`item` [KeyValuePair\<TKey, TValue\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=net-7.0) <br>

### `ContainsKey(TKey)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool ContainsKey(TKey key)

```

**Parameters** <br>
`key` [TKey](/noir/reference/) <br>

### `Remove(KeyValuePair<TKey, TValue>)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Remove(KeyValuePair<TKey, TValue> item)

```

**Parameters** <br>
`item` [KeyValuePair\<TKey, TValue\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=net-7.0) <br>

### `Remove(TKey)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Remove(TKey key)

```

**Parameters** <br>
`key` [TKey](/noir/reference/) <br>

### `TryGetValue(TKey, out TValue&)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool TryGetValue(TKey key, TValue& value)

```

**Parameters** <br>
`key` [TKey](/noir/reference/) <br>
`value` [TValue&](/noir/reference/) <br>

### `GetEnumerator()`
<!-- tc:scope public -->
<!-- tc:return_type IEnumerator\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual IEnumerator<T> GetEnumerator()

```

### `Add(KeyValuePair<TKey, TValue>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Add(KeyValuePair<TKey, TValue> item)

```

**Parameters** <br>
`item` [KeyValuePair\<TKey, TValue\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=net-7.0) <br>

### `Add(TKey, TValue)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Add(TKey key, TValue value)

```

**Parameters** <br>
`key` [TKey](/noir/reference/) <br>
`value` [TValue](/noir/reference/) <br>

### `Clear()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Clear()

```

### `CopyTo(KeyValuePair`2[], int)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void CopyTo(KeyValuePair`2[] array, int arrayIndex)

```

**Parameters** <br>
`array` [KeyValuePair\<TKey, TValue\>[]](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=net-7.0) <br>
`arrayIndex` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

## More information

* [](T:System.Collections.Generic.IDictionary`2)
* [](T:System.Collections.Generic.Dictionary`2)
* [](T:System.Collections.Generic.List`1)
