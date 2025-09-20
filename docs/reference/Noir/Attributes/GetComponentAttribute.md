# GetComponentAttribute

<!-- tc:namespace Noir.Attributes -->

<!-- tc:assembly Noir.dll -->

Automatically wires up the first component that matches the annotated field type.


```csharp
public class GetComponentAttribute : PropertyAttribute
```

**Implements:** _[PropertyAttribute](https://docs.unity3d.com/ScriptReference/PropertyAttribute.html)_

## 🛠 Constructors

### `.ctor(GetComponentSearchArea)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public GetComponentAttribute(GetComponentSearchArea searchArea)
```

**Parameters** <br>
`searchArea` [GetComponentSearchArea](/noir/reference/Noir/Attributes/GetComponentSearchArea/) <br>

## 📦 Properties

### `order`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int order { get; public set; }
```

### `SearchArea`
<!-- tc:scope public -->
<!-- tc:return_type GetComponentSearchArea /noir/reference/Noir/Attributes/GetComponentSearchArea/ -->
<!-- tc:version 1.0.0 -->

```csharp
public GetComponentSearchArea SearchArea { get; private set; }
```

### `TypeId`
<!-- tc:scope public -->
<!-- tc:return_type Object https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual Object TypeId { get; }
```

## More information

* [](T:UnityEngine.PropertyAttribute)
* [Original implementation of AutohookAttribute by Lotte](https://gist.github.com/LotteMakesStuff/d6a9a4944fc667e557083108606b7d22)
