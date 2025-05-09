# OnPoolItemReturnedEvent

<!-- tc:namespace Noir.Pooling -->
<!-- tc:assembly Noir.dll -->

Occurs when an item is returned to the pool


```csharp
public sealed class OnPoolItemReturnedEvent : MulticastDelegate, ICloneable, ISerializable
```

**Implements:** _[MulticastDelegate](https://learn.microsoft.com/en-us/dotnet/api/System.MulticastDelegate?view=net-7.0), [ICloneable](https://learn.microsoft.com/en-us/dotnet/api/System.ICloneable?view=net-7.0), [ISerializable](https://learn.microsoft.com/en-us/dotnet/api/System.Runtime.Serialization.ISerializable?view=net-7.0)_

## Constructors

### `.ctor(Object, IntPtr)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public OnPoolItemReturnedEvent(Object object, IntPtr method)
```

**Parameters** <br>
`object` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`method` [IntPtr](https://learn.microsoft.com/en-us/dotnet/api/System.IntPtr?view=net-7.0) <br>

## Properties

### `Method`
<!-- tc:scope public -->
<!-- tc:return_type MethodInfo https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public MethodInfo Method { get; }
```

### `Target`
<!-- tc:scope public -->
<!-- tc:return_type Object https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public Object Target { get; }
```

## Methods

### `CombineImpl(Delegate)`
<!-- tc:scope private -->
<!-- tc:return_type Delegate https://learn.microsoft.com/en-us/dotnet/api/System.Delegate?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual Delegate CombineImpl(Delegate follow)
```

**Parameters** <br>
`follow` [Delegate](https://learn.microsoft.com/en-us/dotnet/api/System.Delegate?view=net-7.0) <br>

### `RemoveImpl(Delegate)`
<!-- tc:scope private -->
<!-- tc:return_type Delegate https://learn.microsoft.com/en-us/dotnet/api/System.Delegate?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual Delegate RemoveImpl(Delegate value)
```

**Parameters** <br>
`value` [Delegate](https://learn.microsoft.com/en-us/dotnet/api/System.Delegate?view=net-7.0) <br>

### `GetMethodImpl()`
<!-- tc:scope private -->
<!-- tc:return_type MethodInfo https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual MethodInfo GetMethodImpl()
```

### `DynamicInvokeImpl(Object[])`
<!-- tc:scope private -->
<!-- tc:return_type Object https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual Object DynamicInvokeImpl(Object[] args)
```

**Parameters** <br>
`args` [Object[]](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

### `DynamicInvoke(Object[])`
<!-- tc:scope public -->
<!-- tc:return_type Object https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public Object DynamicInvoke(Object[] args)
```

**Parameters** <br>
`args` [Object[]](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

### `Equals(Object)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Equals(Object obj)
```

**Parameters** <br>
`obj` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

### `GetInvocationList()`
<!-- tc:scope public -->
<!-- tc:return_type Delegate[] https://learn.microsoft.com/en-us/dotnet/api/System.Delegate?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual Delegate[] GetInvocationList()
```

### `BeginInvoke(ObjectPoolItemSystem, AsyncCallback, Object)`
<!-- tc:scope public -->
<!-- tc:return_type IAsyncResult https://learn.microsoft.com/en-us/dotnet/api/System.IAsyncResult?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual IAsyncResult BeginInvoke(ObjectPoolItemSystem objectPoolItem, AsyncCallback callback, Object object)
```

**Parameters** <br>
`objectPoolItem` [ObjectPoolItemSystem](../../Noir/Pooling/ObjectPoolItemSystem.html) <br>
`callback` [AsyncCallback](https://learn.microsoft.com/en-us/dotnet/api/System.AsyncCallback?view=net-7.0) <br>
`object` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

### `GetHashCode()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual int GetHashCode()
```

### `Clone()`
<!-- tc:scope public -->
<!-- tc:return_type Object https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual Object Clone()
```

### `EndInvoke(IAsyncResult)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void EndInvoke(IAsyncResult result)
```

**Parameters** <br>
`result` [IAsyncResult](https://learn.microsoft.com/en-us/dotnet/api/System.IAsyncResult?view=net-7.0) <br>

### `GetObjectData(SerializationInfo, StreamingContext)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
```

**Parameters** <br>
`info` [SerializationInfo](https://learn.microsoft.com/en-us/dotnet/api/System.Runtime.Serialization.SerializationInfo?view=net-7.0) <br>
`context` [StreamingContext](https://learn.microsoft.com/en-us/dotnet/api/System.Runtime.Serialization.StreamingContext?view=net-7.0) <br>

### `Invoke(ObjectPoolItemSystem)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Invoke(ObjectPoolItemSystem objectPoolItem)
```

**Parameters** <br>
`objectPoolItem` [ObjectPoolItemSystem](../../Noir/Pooling/ObjectPoolItemSystem.html) <br>

