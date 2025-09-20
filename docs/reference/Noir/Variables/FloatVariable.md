# FloatVariable

<!-- tc:namespace Noir.Variables -->

<!-- tc:assembly Noir.dll -->


```csharp
public class FloatVariable : DataVariable<T>, IDataVariable, IEquatable<T>, IEquatable<T>, IEquatable<T>
```

**Implements:** _[DataVariable\<T\>](/noir/reference//noir/reference/Noir/Variables/DataVariable-1/), [IDataVariable](/noir/reference//noir/reference/Noir/Variables/IDataVariable/), [IEquatable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=net-7.0), [IEquatable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=net-7.0), [IEquatable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=net-7.0)_

## 🛠 Constructors

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public FloatVariable()
```

## 📦 Properties

### `Description`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string Description { get; public set; }
```

### `FriendlyName`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string FriendlyName { get; public set; }
```

### `hideFlags`
<!-- tc:scope public -->
<!-- tc:return_type HideFlags https://docs.unity3d.com/ScriptReference/HideFlags.html -->
<!-- tc:version 1.0.0 -->

```csharp
public HideFlags hideFlags { get; public set; }
```

### `IsPersistant`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool IsPersistant { get; public set; }
```

### `name`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string name { get; public set; }
```

### `Name`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string Name { get; }
```

### `Value`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual float Value { get; public set; }
```

## ⚡ Events

### `OnAfterVariableChanged`
<!-- tc:scope private -->
<!-- tc:return_type OnAfterChange /noir/reference//noir/reference/Noir/Variables/OnAfterChange/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnAfterChange OnAfterVariableChanged;
```

### `OnBeforeVariableChanged`
<!-- tc:scope private -->
<!-- tc:return_type OnBeforeChange /noir/reference//noir/reference/Noir/Variables/OnBeforeChange/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnBeforeChange OnBeforeVariableChanged;
```

### `OnDataVariableChanged`
<!-- tc:scope private -->
<!-- tc:return_type DataVariableChanged\<T\> /noir/reference//noir/reference/Noir/Variables/DataVariableChanged-1/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event DataVariableChanged<T> OnDataVariableChanged;
```

## ⛹️‍♀️ Methods

### `OnAfterSave(Object, Object)`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual void OnAfterSave(Object previousValue, Object newValue)
```

**Parameters** <br>
`previousValue` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`newValue` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

### `OnBeforeChange()`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual void OnBeforeChange()
```

### `GetInstanceID()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int GetInstanceID()
```

### `Equals(Object)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Equals(Object other)
```

**Parameters** <br>
`other` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

### `TrySetValue(Object, bool)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool TrySetValue(Object value, bool silently)
```

**Parameters** <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`silently` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

### `GetHashCode()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual int GetHashCode()
```

### `ToObject()`
<!-- tc:scope public -->
<!-- tc:return_type Object https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual Object ToObject()
```

### `ToString()`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual string ToString()
```

### `SetDirty()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SetDirty()
```

