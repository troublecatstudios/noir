# SerializedDictionary\<TKey, TValue\>

**Namespace:** Noir <br>
**Assembly:** Noir.dll

```csharp
public class SerializedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<T>, IEnumerable<T>, IEnumerable, ISerializationCallbackReceiver
```

An [IDictionary<TKey, TValue>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2?view=net-7.0) that can be serialized as
            part of a Unity object.

**Implements:** _[IDictionary\<TKey, TValue\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2?view=net-7.0), [ICollection\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1?view=net-7.0), [IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0), [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable?view=net-7.0), [ISerializationCallbackReceiver](../)_

### 🛠 Constructors
```csharp
public SerializedDictionary<TKey, TValue>()
```

### 📦 Properties
#### Count
```csharp
public virtual int Count { get; }
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
#### IsReadOnly
```csharp
public virtual bool IsReadOnly { get; }
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### Item
```csharp
public virtual TValue Item { get; public set; }
```

**Returns** <br>
[TValue](../) <br>
#### Keys
```csharp
public virtual ICollection<T> Keys { get; }
```

**Returns** <br>
[ICollection\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1?view=net-7.0) <br>
#### Values
```csharp
public virtual ICollection<T> Values { get; }
```

**Returns** <br>
[ICollection\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1?view=net-7.0) <br>
### ⛹️‍♀️ Methods
#### From(Dictionary<TKey, TValue>)
```csharp
public SerializedDictionary<TKey, TValue> From(Dictionary<TKey, TValue> dictionary)
```

**Parameters** <br>
`dictionary` [Dictionary\<TKey, TValue\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=net-7.0) <br>

**Returns** <br>
[SerializedDictionary\<TKey, TValue\>](../Noir/SerializedDictionary-2.html) <br>

#### Contains(KeyValuePair<TKey, TValue>)
```csharp
public virtual bool Contains(KeyValuePair<TKey, TValue> item)
```

**Parameters** <br>
`item` [KeyValuePair\<TKey, TValue\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### ContainsKey(TKey)
```csharp
public virtual bool ContainsKey(TKey key)
```

**Parameters** <br>
`key` [TKey](../) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### Remove(KeyValuePair<TKey, TValue>)
```csharp
public virtual bool Remove(KeyValuePair<TKey, TValue> item)
```

**Parameters** <br>
`item` [KeyValuePair\<TKey, TValue\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### Remove(TKey)
```csharp
public virtual bool Remove(TKey key)
```

**Parameters** <br>
`key` [TKey](../) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### TryGetValue(TKey, out TValue&)
```csharp
public virtual bool TryGetValue(TKey key, TValue& value)
```

**Parameters** <br>
`key` [TKey](../) <br>
`value` [TValue&](../) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### GetEnumerator()
```csharp
public virtual IEnumerator<T> GetEnumerator()
```

**Returns** <br>
[IEnumerator\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1?view=net-7.0) <br>

#### Add(KeyValuePair<TKey, TValue>)
```csharp
public virtual void Add(KeyValuePair<TKey, TValue> item)
```

**Parameters** <br>
`item` [KeyValuePair\<TKey, TValue\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=net-7.0) <br>

#### Add(TKey, TValue)
```csharp
public virtual void Add(TKey key, TValue value)
```

**Parameters** <br>
`key` [TKey](../) <br>
`value` [TValue](../) <br>

#### Clear()
```csharp
public virtual void Clear()
```

#### CopyTo(KeyValuePair`2[], int)
```csharp
public virtual void CopyTo(KeyValuePair`2[] array, int arrayIndex)
```

**Parameters** <br>
`array` [KeyValuePair\<TKey, TValue\>[]](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=net-7.0) <br>
`arrayIndex` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

