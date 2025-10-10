# ColorVariable

<!-- tc:namespace Noir.Variables -->

<!-- tc:assembly Noir.dll -->


```csharp
public class ColorVariable : DataVariable<T>, IDataVariable, IEquatable<T>
```

**Implements:** _[DataVariable\<T\>](/noir/reference//noir/reference/Noir/Variables/DataVariable-1/), [IDataVariable](/noir/reference//noir/reference/Noir/Variables/IDataVariable/), [IEquatable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=net-7.0)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public ColorVariable()

```

## Properties

<a name="Description"></a>

### `Description`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string Description { get; public set; }

```

<a name="FriendlyName"></a>

### `FriendlyName`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string FriendlyName { get; public set; }

```

<a name="hideFlags"></a>

### `hideFlags`
<!-- tc:scope public -->
<!-- tc:return_type HideFlags https://docs.unity3d.com/ScriptReference/HideFlags.html -->
<!-- tc:version 1.0.0 -->

```csharp
public HideFlags hideFlags { get; public set; }

```

<a name="IsPersistant"></a>

### `IsPersistant`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool IsPersistant { get; public set; }

```

<a name="name"></a>

### `name`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string name { get; public set; }

```

<a name="Name"></a>

### `Name`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string Name { get; }

```

<a name="Value"></a>

### `Value`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual Color Value { get; public set; }

```

## Events

<a name="OnAfterVariableChanged"></a>

### `OnAfterVariableChanged`
<!-- tc:scope private -->
<!-- tc:return_type OnAfterChange /noir/reference//noir/reference/Noir/Variables/OnAfterChange/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnAfterChange OnAfterVariableChanged;

```

<a name="OnBeforeVariableChanged"></a>

### `OnBeforeVariableChanged`
<!-- tc:scope private -->
<!-- tc:return_type OnBeforeChange /noir/reference//noir/reference/Noir/Variables/OnBeforeChange/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnBeforeChange OnBeforeVariableChanged;

```

<a name="OnDataVariableChanged"></a>

### `OnDataVariableChanged`
<!-- tc:scope private -->
<!-- tc:return_type DataVariableChanged\<T\> /noir/reference//noir/reference/Noir/Variables/DataVariableChanged-1/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event DataVariableChanged<T> OnDataVariableChanged;

```

## Methods

<a name="OnAfterSave"></a>

### `OnAfterSave(Object, Object)`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual void OnAfterSave(Object previousValue, Object newValue)

```

**Parameters** <br>
`previousValue` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`newValue` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

<a name="OnBeforeChange"></a>

### `OnBeforeChange()`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual void OnBeforeChange()

```

<a name="GetInstanceID"></a>

### `GetInstanceID()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int GetInstanceID()

```

<a name="Equals"></a>

### `Equals(Object)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Equals(Object other)

```

**Parameters** <br>
`other` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

<a name="TrySetValue"></a>

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

<a name="GetHashCode"></a>

### `GetHashCode()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual int GetHashCode()

```

<a name="ToObject"></a>

### `ToObject()`
<!-- tc:scope public -->
<!-- tc:return_type Object https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual Object ToObject()

```

<a name="ToString"></a>

### `ToString()`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual string ToString()

```

<a name="SetDirty"></a>

### `SetDirty()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SetDirty()

```

