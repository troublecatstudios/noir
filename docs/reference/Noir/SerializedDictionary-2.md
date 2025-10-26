# SerializedDictionary\<TKey, TValue\>

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

An [IDictionary<TKey, TValue>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2?view=net-7.0) that can be serialized as
            part of a Unity object.
Prior to Unity 2020, dictionaries cannot be directly serialized by
            Unity. This class is a workaround; it provides an API identical to
            [Dictionary<TKey, TValue>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=net-7.0), and stores its contents as
            two [ one for <typeparamref name="TKey](),
            and one for <typeparamref name="TValue" />.


```csharp
public class SerializedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<T>, IEnumerable<T>, IEnumerable, ISerializationCallbackReceiver
```

**Implements:** _[IDictionary\<TKey, TValue\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2?view=net-7.0), [ICollection\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1?view=net-7.0), [IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0), [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable?view=net-7.0), [ISerializationCallbackReceiver](https://docs.unity3d.com/ScriptReference/ISerializationCallbackReceiver.html)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public SerializedDictionary<TKey, TValue>()

```

## Properties

<a name="Count"></a>

### `Count`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the number of key-value pairs contained in the dictionary.


```csharp
public virtual int Count { get; }

```

<a name="IsReadOnly"></a>

### `IsReadOnly`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets a value indicating whether the dictionary is read-only.


```csharp
public virtual bool IsReadOnly { get; }

```

<a name="Item"></a>

### `Item`
<!-- tc:scope public -->
<!-- tc:return_type TValue -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual TValue Item { get; public set; }

```

<a name="Keys"></a>

### `Keys`
<!-- tc:scope public -->
<!-- tc:return_type ICollection\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets a collection containing the keys in the dictionary.


```csharp
public virtual ICollection<T> Keys { get; }

```

<a name="Values"></a>

### `Values`
<!-- tc:scope public -->
<!-- tc:return_type ICollection\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets a collection containing the values in the dictionary.


```csharp
public virtual ICollection<T> Values { get; }

```

## Methods

<a name="From"></a>

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

<a name="Contains"></a>

### `Contains(KeyValuePair<TKey, TValue>)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Contains(KeyValuePair<TKey, TValue> item)

```

**Parameters** <br>
`item` [KeyValuePair\<TKey, TValue\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=net-7.0) <br>

<a name="ContainsKey"></a>

### `ContainsKey(TKey)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool ContainsKey(TKey key)

```

**Parameters** <br>
`key` [TKey](/noir/reference/) <br>

<a name="Remove"></a>

### `Remove(KeyValuePair<TKey, TValue>)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Remove(KeyValuePair<TKey, TValue> item)

```

**Parameters** <br>
`item` [KeyValuePair\<TKey, TValue\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=net-7.0) <br>

<a name="Remove"></a>

### `Remove(TKey)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Remove(TKey key)

```

**Parameters** <br>
`key` [TKey](/noir/reference/) <br>

<a name="TryGetValue"></a>

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

<a name="GetEnumerator"></a>

### `GetEnumerator()`
<!-- tc:scope public -->
<!-- tc:return_type IEnumerator\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Returns an enumerator that iterates through the dictionary.


```csharp
public virtual IEnumerator<T> GetEnumerator()

```

<a name="Add"></a>

### `Add(KeyValuePair<TKey, TValue>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Add(KeyValuePair<TKey, TValue> item)

```

**Parameters** <br>
`item` [KeyValuePair\<TKey, TValue\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=net-7.0) <br>

<a name="Add"></a>

### `Add(TKey, TValue)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Add(TKey key, TValue value)

```

**Parameters** <br>
`key` [TKey](/noir/reference/) <br>
`value` [TValue](/noir/reference/) <br>

<a name="Clear"></a>

### `Clear()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Removes all elements from the dictionary.


```csharp
public virtual void Clear()

```

<a name="CopyTo"></a>

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

* [System.Collections.Generic.IDictionary`2](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2?view=net-7.0)
* [System.Collections.Generic.Dictionary`2](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=net-7.0)
* [System.Collections.Generic.List`1](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0)
