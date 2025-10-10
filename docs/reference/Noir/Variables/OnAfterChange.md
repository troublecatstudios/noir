# OnAfterChange

<!-- tc:namespace Noir.Variables -->

<!-- tc:assembly Noir.dll -->


```csharp
public sealed class OnAfterChange : MulticastDelegate, ICloneable, ISerializable
```

**Implements:** _[MulticastDelegate](https://learn.microsoft.com/en-us/dotnet/api/System.MulticastDelegate?view=net-7.0), [ICloneable](https://learn.microsoft.com/en-us/dotnet/api/System.ICloneable?view=net-7.0), [ISerializable](https://learn.microsoft.com/en-us/dotnet/api/System.Runtime.Serialization.ISerializable?view=net-7.0)_

## Constructors

<a name=".ctor"></a>

### `.ctor(Object, IntPtr)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public OnAfterChange(Object object, IntPtr method)

```

**Parameters** <br>
`object` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`method` [IntPtr](https://learn.microsoft.com/en-us/dotnet/api/System.IntPtr?view=net-7.0) <br>

## Properties

<a name="Method"></a>

### `Method`
<!-- tc:scope public -->
<!-- tc:return_type MethodInfo https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public MethodInfo Method { get; }

```

<a name="Target"></a>

### `Target`
<!-- tc:scope public -->
<!-- tc:return_type Object https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public Object Target { get; }

```

## Methods

<a name="CombineImpl"></a>

### `CombineImpl(Delegate)`
<!-- tc:scope private -->
<!-- tc:return_type Delegate https://learn.microsoft.com/en-us/dotnet/api/System.Delegate?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual Delegate CombineImpl(Delegate follow)

```

**Parameters** <br>
`follow` [Delegate](https://learn.microsoft.com/en-us/dotnet/api/System.Delegate?view=net-7.0) <br>

<a name="RemoveImpl"></a>

### `RemoveImpl(Delegate)`
<!-- tc:scope private -->
<!-- tc:return_type Delegate https://learn.microsoft.com/en-us/dotnet/api/System.Delegate?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual Delegate RemoveImpl(Delegate value)

```

**Parameters** <br>
`value` [Delegate](https://learn.microsoft.com/en-us/dotnet/api/System.Delegate?view=net-7.0) <br>

<a name="GetMethodImpl"></a>

### `GetMethodImpl()`
<!-- tc:scope private -->
<!-- tc:return_type MethodInfo https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual MethodInfo GetMethodImpl()

```

<a name="DynamicInvokeImpl"></a>

### `DynamicInvokeImpl(Object[])`
<!-- tc:scope private -->
<!-- tc:return_type Object https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual Object DynamicInvokeImpl(Object[] args)

```

**Parameters** <br>
`args` [Object[]](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

<a name="DynamicInvoke"></a>

### `DynamicInvoke(Object[])`
<!-- tc:scope public -->
<!-- tc:return_type Object https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public Object DynamicInvoke(Object[] args)

```

**Parameters** <br>
`args` [Object[]](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

<a name="Equals"></a>

### `Equals(Object)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Equals(Object obj)

```

**Parameters** <br>
`obj` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

<a name="GetInvocationList"></a>

### `GetInvocationList()`
<!-- tc:scope public -->
<!-- tc:return_type Delegate[] https://learn.microsoft.com/en-us/dotnet/api/System.Delegate?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual Delegate[] GetInvocationList()

```

<a name="BeginInvoke"></a>

### `BeginInvoke(AsyncCallback, Object)`
<!-- tc:scope public -->
<!-- tc:return_type IAsyncResult https://learn.microsoft.com/en-us/dotnet/api/System.IAsyncResult?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual IAsyncResult BeginInvoke(AsyncCallback callback, Object object)

```

**Parameters** <br>
`callback` [AsyncCallback](https://learn.microsoft.com/en-us/dotnet/api/System.AsyncCallback?view=net-7.0) <br>
`object` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

<a name="GetHashCode"></a>

### `GetHashCode()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual int GetHashCode()

```

<a name="Clone"></a>

### `Clone()`
<!-- tc:scope public -->
<!-- tc:return_type Object https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual Object Clone()

```

<a name="EndInvoke"></a>

### `EndInvoke(IAsyncResult)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void EndInvoke(IAsyncResult result)

```

**Parameters** <br>
`result` [IAsyncResult](https://learn.microsoft.com/en-us/dotnet/api/System.IAsyncResult?view=net-7.0) <br>

<a name="GetObjectData"></a>

### `GetObjectData(SerializationInfo, StreamingContext)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void GetObjectData(SerializationInfo info,
                                   StreamingContext context)


```

**Parameters** <br>
`info` [SerializationInfo](https://learn.microsoft.com/en-us/dotnet/api/System.Runtime.Serialization.SerializationInfo?view=net-7.0) <br>
`context` [StreamingContext](https://learn.microsoft.com/en-us/dotnet/api/System.Runtime.Serialization.StreamingContext?view=net-7.0) <br>

<a name="Invoke"></a>

### `Invoke()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Invoke()

```

