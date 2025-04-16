# DataVariableChanged\<T\>

**Namespace:** Noir.Variables <br>
**Assembly:** Noir.dll

```csharp
public sealed class DataVariableChanged<T> : MulticastDelegate, ICloneable, ISerializable
```

**Implements:** _[MulticastDelegate](https://learn.microsoft.com/en-us/dotnet/api/System.MulticastDelegate?view=net-7.0), [ICloneable](https://learn.microsoft.com/en-us/dotnet/api/System.ICloneable?view=net-7.0), [ISerializable](https://learn.microsoft.com/en-us/dotnet/api/System.Runtime.Serialization.ISerializable?view=net-7.0)_

### 🛠 Constructors
```csharp
public DataVariableChanged<T>(Object object, IntPtr method)
```

**Parameters** <br>
`object` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`method` [IntPtr](https://learn.microsoft.com/en-us/dotnet/api/System.IntPtr?view=net-7.0) <br>

### 📦 Properties
#### Method
```csharp
public MethodInfo Method { get; }
```

**Returns** <br>
[MethodInfo](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo?view=net-7.0) <br>
#### Target
```csharp
public Object Target { get; }
```

**Returns** <br>
[Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
### ⛹️‍♀️ Methods
#### CombineImpl(Delegate)
```csharp
protected virtual Delegate CombineImpl(Delegate follow)
```

**Parameters** <br>
`follow` [Delegate](https://learn.microsoft.com/en-us/dotnet/api/System.Delegate?view=net-7.0) <br>

**Returns** <br>
[Delegate](https://learn.microsoft.com/en-us/dotnet/api/System.Delegate?view=net-7.0) <br>

#### RemoveImpl(Delegate)
```csharp
protected virtual Delegate RemoveImpl(Delegate value)
```

**Parameters** <br>
`value` [Delegate](https://learn.microsoft.com/en-us/dotnet/api/System.Delegate?view=net-7.0) <br>

**Returns** <br>
[Delegate](https://learn.microsoft.com/en-us/dotnet/api/System.Delegate?view=net-7.0) <br>

#### GetMethodImpl()
```csharp
protected virtual MethodInfo GetMethodImpl()
```

**Returns** <br>
[MethodInfo](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo?view=net-7.0) <br>

#### DynamicInvokeImpl(Object[])
```csharp
protected virtual Object DynamicInvokeImpl(Object[] args)
```

**Parameters** <br>
`args` [Object[]](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

**Returns** <br>
[Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

#### DynamicInvoke(Object[])
```csharp
public Object DynamicInvoke(Object[] args)
```

**Parameters** <br>
`args` [Object[]](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

**Returns** <br>
[Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

#### Equals(Object)
```csharp
public virtual bool Equals(Object obj)
```

**Parameters** <br>
`obj` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### GetInvocationList()
```csharp
public virtual Delegate[] GetInvocationList()
```

**Returns** <br>
[Delegate[]](https://learn.microsoft.com/en-us/dotnet/api/System.Delegate?view=net-7.0) <br>

#### BeginInvoke(T, T, AsyncCallback, Object)
```csharp
public virtual IAsyncResult BeginInvoke(T oldValue, T newValue, AsyncCallback callback, Object object)
```

**Parameters** <br>
`oldValue` [T](../../) <br>
`newValue` [T](../../) <br>
`callback` [AsyncCallback](https://learn.microsoft.com/en-us/dotnet/api/System.AsyncCallback?view=net-7.0) <br>
`object` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

**Returns** <br>
[IAsyncResult](https://learn.microsoft.com/en-us/dotnet/api/System.IAsyncResult?view=net-7.0) <br>

#### GetHashCode()
```csharp
public virtual int GetHashCode()
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

#### Clone()
```csharp
public virtual Object Clone()
```

**Returns** <br>
[Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

#### EndInvoke(IAsyncResult)
```csharp
public virtual void EndInvoke(IAsyncResult result)
```

**Parameters** <br>
`result` [IAsyncResult](https://learn.microsoft.com/en-us/dotnet/api/System.IAsyncResult?view=net-7.0) <br>

#### GetObjectData(SerializationInfo, StreamingContext)
```csharp
public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
```

**Parameters** <br>
`info` [SerializationInfo](https://learn.microsoft.com/en-us/dotnet/api/System.Runtime.Serialization.SerializationInfo?view=net-7.0) <br>
`context` [StreamingContext](https://learn.microsoft.com/en-us/dotnet/api/System.Runtime.Serialization.StreamingContext?view=net-7.0) <br>

#### Invoke(T, T)
```csharp
public virtual void Invoke(T oldValue, T newValue)
```

**Parameters** <br>
`oldValue` [T](../../) <br>
`newValue` [T](../../) <br>

