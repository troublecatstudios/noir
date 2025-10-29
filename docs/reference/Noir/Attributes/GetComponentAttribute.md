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
Creates a new [GetComponentAttribute](/noir/reference/Noir/Attributes/GetComponentAttribute/) with the specified search area.


```csharp
public GetComponentAttribute(GetComponentSearchArea searchArea)

```

**Parameters** <br>
`searchArea` [GetComponentSearchArea](/noir/reference/Noir/Attributes/GetComponentSearchArea/) <br>
 <br>

## Properties

<a name="SearchArea"></a>

### `SearchArea`
<!-- tc:scope public -->
<!-- tc:return_type GetComponentSearchArea /noir/reference/Noir/Attributes/GetComponentSearchArea/ -->
<!-- tc:version 1.0.0 -->
Specifies where the component should be searched for (e.g., on the same GameObject, parent, or children).


```csharp
public GetComponentSearchArea SearchArea { get; private set; }

```

## More information

* [UnityEngine.PropertyAttribute](https://docs.unity3d.com/ScriptReference/PropertyAttribute.html)
* [Original implementation of AutohookAttribute by Lotte](https://gist.github.com/LotteMakesStuff/d6a9a4944fc667e557083108606b7d22)
