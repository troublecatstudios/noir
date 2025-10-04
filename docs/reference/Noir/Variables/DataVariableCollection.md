# DataVariableCollection

<!-- tc:namespace Noir.Variables -->

<!-- tc:assembly Noir.dll -->


```csharp
public class DataVariableCollection : ScriptableObject
```

**Implements:** _[ScriptableObject](https://docs.unity3d.com/ScriptReference/ScriptableObject.html)_

## Constructors

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public DataVariableCollection()

```

## Properties

### `hideFlags`
<!-- tc:scope public -->
<!-- tc:return_type [HideFlags](https://docs.unity3d.com/ScriptReference/HideFlags.html) -->
<!-- tc:version 1.0.0 -->

```csharp
public HideFlags hideFlags { get; public set; }

```

### `name`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public string name { get; public set; }

```

### `Variables`
<!-- tc:scope private -->
<!-- tc:return_type [List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public List<T> Variables;

```

## Methods

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

