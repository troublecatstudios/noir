# NoirVariableAttribute

<!-- tc:namespace Noir.Variables -->

<!-- tc:assembly Noir.dll -->

Declares that this variable field should be bound automatically to a named variable in the asset library.


```csharp
public class NoirVariableAttribute : Attribute
```

**Implements:** _[Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=net-7.0)_

## Constructors

### `.ctor(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Declares that this variable field should be bound automatically to a named variable in the asset library.


```csharp
public NoirVariableAttribute(string variableName)

```

**Parameters** <br>
`variableName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

## Properties

### `TypeId`
<!-- tc:scope public -->
<!-- tc:return_type [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual Object TypeId { get; }

```

### `VariableName`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
<!-- tc:version 1.0.0 -->
The variable name to use when looking up the event asset in the asset library.


```csharp
public string VariableName { get; private set; }

```

