# DataVariable\<T\>

<!-- tc:namespace Noir.Variables -->

<!-- tc:assembly Noir.dll -->


```csharp
public class DataVariable<T> : DataVariable, IDataVariable, IEquatable<T>
```

**Implements:** _[DataVariable](/noir/reference/Noir/Variables/DataVariable/), [IDataVariable](/noir/reference/Noir/Variables/IDataVariable/), [IEquatable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=net-7.0)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public DataVariable<T>()

```

## Properties

<a name="Value"></a>

### `Value`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 1.0.0 -->
The value for the current variable.


```csharp
public virtual T Value { get; public set; }

```

## Events

<a name="OnDataVariableChanged"></a>

### `OnDataVariableChanged`
<!-- tc:scope private -->
<!-- tc:return_type DataVariableChanged\<T\> /noir/reference/Noir/Variables/DataVariableChanged-1/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event DataVariableChanged<T> OnDataVariableChanged;

```

## Methods

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

