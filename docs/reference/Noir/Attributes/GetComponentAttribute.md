# GetComponentAttribute

<!-- tc:namespace Noir.Attributes -->

<!-- tc:assembly Noir.dll -->

Automatically wires up the first component that matches the annotated field type.
Wiring is done at edit time so there is no startup cost.


```csharp
public class GetComponentAttribute : PropertyAttribute
```

**Implements:** _[PropertyAttribute](https://docs.unity3d.com/ScriptReference/PropertyAttribute.html)_

## Constructors

<a name=".ctor"></a>

### `.ctor(GetComponentSearchArea)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public GetComponentAttribute(GetComponentSearchArea searchArea)

```

**Parameters** <br>
`searchArea` [GetComponentSearchArea](/noir/reference//noir/reference/Noir/Attributes/GetComponentSearchArea/) <br>

## Properties

<a name="order"></a>

### `order`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int order { get; public set; }

```

<a name="SearchArea"></a>

### `SearchArea`
<!-- tc:scope public -->
<!-- tc:return_type GetComponentSearchArea /noir/reference//noir/reference/Noir/Attributes/GetComponentSearchArea/ -->
<!-- tc:version 1.0.0 -->

```csharp
public GetComponentSearchArea SearchArea { get; private set; }

```

<a name="TypeId"></a>

### `TypeId`
<!-- tc:scope public -->
<!-- tc:return_type Object https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual Object TypeId { get; }

```

## More information

* [UnityEngine.PropertyAttribute](https://docs.unity3d.com/ScriptReference/PropertyAttribute.html)
* [Original implementation of AutohookAttribute by Lotte](https://gist.github.com/LotteMakesStuff/d6a9a4944fc667e557083108606b7d22)
