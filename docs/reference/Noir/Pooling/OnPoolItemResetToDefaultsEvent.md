# OnPoolItemResetToDefaultsEvent

<!-- tc:namespace Noir.Pooling -->

<!-- tc:assembly Noir.dll -->

Occurs when an item is reset to its default state


```csharp
public sealed class OnPoolItemResetToDefaultsEvent : MulticastDelegate, ICloneable, ISerializable
```

**Implements:** _[MulticastDelegate](https://learn.microsoft.com/en-us/dotnet/api/System.MulticastDelegate?view=net-7.0), [ICloneable](https://learn.microsoft.com/en-us/dotnet/api/System.ICloneable?view=net-7.0), [ISerializable](https://learn.microsoft.com/en-us/dotnet/api/System.Runtime.Serialization.ISerializable?view=net-7.0)_

## Constructors

<a name=".ctor"></a>

### `.ctor(Object, IntPtr)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public OnPoolItemResetToDefaultsEvent(Object object, IntPtr method)

```

**Parameters** <br>
`object` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`method` [IntPtr](https://learn.microsoft.com/en-us/dotnet/api/System.IntPtr?view=net-7.0) <br>

## Methods

<a name="BeginInvoke"></a>

### `BeginInvoke(ObjectPoolItemSystem, AsyncCallback, Object)`
<!-- tc:scope public -->
<!-- tc:return_type IAsyncResult https://learn.microsoft.com/en-us/dotnet/api/System.IAsyncResult?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual IAsyncResult BeginInvoke(ObjectPoolItemSystem objectPoolItem,
                                         AsyncCallback callback, Object object)


```

**Parameters** <br>
`objectPoolItem` [ObjectPoolItemSystem](/noir/reference/Noir/Pooling/ObjectPoolItemSystem/) <br>
`callback` [AsyncCallback](https://learn.microsoft.com/en-us/dotnet/api/System.AsyncCallback?view=net-7.0) <br>
`object` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

<a name="EndInvoke"></a>

### `EndInvoke(IAsyncResult)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void EndInvoke(IAsyncResult result)

```

**Parameters** <br>
`result` [IAsyncResult](https://learn.microsoft.com/en-us/dotnet/api/System.IAsyncResult?view=net-7.0) <br>

<a name="Invoke"></a>

### `Invoke(ObjectPoolItemSystem)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Invoke(ObjectPoolItemSystem objectPoolItem)

```

**Parameters** <br>
`objectPoolItem` [ObjectPoolItemSystem](/noir/reference/Noir/Pooling/ObjectPoolItemSystem/) <br>

