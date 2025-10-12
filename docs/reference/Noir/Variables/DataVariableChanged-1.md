# DataVariableChanged\<T\>

<!-- tc:namespace Noir.Variables -->

<!-- tc:assembly Noir.dll -->


```csharp
public sealed class DataVariableChanged<T> : MulticastDelegate, ICloneable, ISerializable
```

**Implements:** _[MulticastDelegate](https://learn.microsoft.com/en-us/dotnet/api/System.MulticastDelegate?view=net-7.0), [ICloneable](https://learn.microsoft.com/en-us/dotnet/api/System.ICloneable?view=net-7.0), [ISerializable](https://learn.microsoft.com/en-us/dotnet/api/System.Runtime.Serialization.ISerializable?view=net-7.0)_

## Constructors

<a name=".ctor"></a>

### `.ctor(Object, IntPtr)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public DataVariableChanged<T>(Object object, IntPtr method)

```

**Parameters** <br>
`object` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`method` [IntPtr](https://learn.microsoft.com/en-us/dotnet/api/System.IntPtr?view=net-7.0) <br>

## Methods

<a name="BeginInvoke"></a>

### `BeginInvoke(T, T, AsyncCallback, Object)`
<!-- tc:scope public -->
<!-- tc:return_type IAsyncResult https://learn.microsoft.com/en-us/dotnet/api/System.IAsyncResult?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual IAsyncResult BeginInvoke(T oldValue, T newValue,
                                         AsyncCallback callback, Object object)


```

**Parameters** <br>
`oldValue` [T](/noir/reference/) <br>
`newValue` [T](/noir/reference/) <br>
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

### `Invoke(T, T)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Invoke(T oldValue, T newValue)

```

**Parameters** <br>
`oldValue` [T](/noir/reference/) <br>
`newValue` [T](/noir/reference/) <br>

