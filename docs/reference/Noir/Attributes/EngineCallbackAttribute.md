# EngineCallbackAttribute

<!-- tc:namespace Noir.Attributes -->

<!-- tc:assembly Noir.dll -->

Allows static methods to be invoked at specific points during the Noir Library startup lifecycle.


```csharp
public class EngineCallbackAttribute : Attribute
```

**Implements:** _[Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=net-7.0)_

## Constructors

<a name=".ctor"></a>

### `.ctor(EngineCallbackType)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Creates a new [EngineCallbackAttribute](/noir/reference/Noir/Attributes/EngineCallbackAttribute/) with the specified callback type.


```csharp
public EngineCallbackAttribute(EngineCallbackType callbackType)

```

**Parameters** <br>
`callbackType` [EngineCallbackType](/noir/reference/Noir/Attributes/EngineCallbackType/) <br>
 <br>

## Properties

<a name="CallbackType"></a>

### `CallbackType`
<!-- tc:scope public -->
<!-- tc:return_type EngineCallbackType /noir/reference/Noir/Attributes/EngineCallbackType/ -->
<!-- tc:version 1.0.0 -->
Gets or sets a value indicating when the decorated method should be invoked by the Noir library.


```csharp
public EngineCallbackType CallbackType { get; public set; }

```

