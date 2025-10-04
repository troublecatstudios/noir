# DataVariable

<!-- tc:namespace Noir.Variables -->

<!-- tc:assembly Noir.dll -->


```csharp
public abstract class DataVariable : ScriptableObject
```

**Implements:** _[ScriptableObject](https://docs.unity3d.com/ScriptReference/ScriptableObject.html)_

## Constructors

### `.ctor()`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected DataVariable()

```

## Properties

### `Description`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
<!-- tc:version 1.0.0 -->
The description of the variable.


```csharp
public string Description { get; public set; }

```

### `FriendlyName`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
<!-- tc:version 1.0.0 -->
The friendly name of the variable.


```csharp
public string FriendlyName { get; public set; }

```

### `hideFlags`
<!-- tc:scope public -->
<!-- tc:return_type [HideFlags](https://docs.unity3d.com/ScriptReference/HideFlags.html) -->
<!-- tc:version 1.0.0 -->

```csharp
public HideFlags hideFlags { get; public set; }

```

### `IsPersistant`
<!-- tc:scope public -->
<!-- tc:return_type [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) -->
<!-- tc:version 1.0.0 -->
Gets or sets a value indicating whether this instance is persisted to disk when changed.


```csharp
public bool IsPersistant { get; public set; }

```

### `name`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public string name { get; public set; }

```

### `Name`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
<!-- tc:version 1.0.0 -->
The variable name.


```csharp
public string Name { get; }

```

## Events

### `OnAfterVariableChanged`
<!-- tc:scope private -->
<!-- tc:return_type [OnAfterChange](/noir/reference//noir/reference/Noir/Variables/OnAfterChange.html) -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnAfterChange OnAfterVariableChanged;

```

### `OnBeforeVariableChanged`
<!-- tc:scope private -->
<!-- tc:return_type [OnBeforeChange](/noir/reference//noir/reference/Noir/Variables/OnBeforeChange.html) -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnBeforeChange OnBeforeVariableChanged;

```

## Methods

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

### `TrySetValue(Object, bool)`
<!-- tc:scope public -->
<!-- tc:return_type [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) -->
<!-- tc:version 1.0.0 -->
Tries to set the given [value]() into the variable.


```csharp
public abstract bool TrySetValue(Object value, bool silently)

```

**Parameters** <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>
`silently` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

### `ToObject()`
<!-- tc:scope public -->
<!-- tc:return_type [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract Object ToObject()

```

### `GetInstanceID()`
<!-- tc:scope public -->
<!-- tc:return_type [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public int GetInstanceID()

```

### `Equals(Object)`
<!-- tc:scope public -->
<!-- tc:return_type [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Equals(Object other)

```

**Parameters** <br>
`other` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

### `GetHashCode()`
<!-- tc:scope public -->
<!-- tc:return_type [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual int GetHashCode()

```

### `ToString()`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
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

