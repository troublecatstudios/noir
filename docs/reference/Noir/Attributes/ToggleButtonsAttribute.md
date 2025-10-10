# ToggleButtonsAttribute

<!-- tc:namespace Noir.Attributes -->

<!-- tc:assembly Noir.dll -->


```csharp
public class ToggleButtonsAttribute : Attribute
```

**Implements:** _[Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=net-7.0)_

## Constructors

<a name=".ctor"></a>

### `.ctor(string, string, bool, float, string, string, string, string, string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Attribute to draw boolean as buttons


```csharp
public ToggleButtonsAttribute(string trueText, string falseText,
                               bool singleButton, float sizeCompensation,
                               string trueTooltip, string falseTooltip,
                               string trueColor, string falseColor,
                               string trueIcon, string falseIcon)


```

**Parameters** <br>
`trueText` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`falseText` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`singleButton` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>
`sizeCompensation` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`trueTooltip` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`falseTooltip` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`trueColor` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`falseColor` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`trueIcon` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`falseIcon` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

## Properties

<a name="FalseColor"></a>

### `FalseColor`
<!-- tc:scope private -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Color of false button


```csharp
public string FalseColor;

```

<a name="FalseIcon"></a>

### `FalseIcon`
<!-- tc:scope private -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Icon for false button


```csharp
public string FalseIcon;

```

<a name="FalseText"></a>

### `FalseText`
<!-- tc:scope private -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Text for false button. Can be resolved string


```csharp
public string FalseText;

```

<a name="FalseTooltip"></a>

### `FalseTooltip`
<!-- tc:scope private -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Tooltip for false button. Can be resolved string


```csharp
public string FalseTooltip;

```

<a name="IsSingleButton"></a>

### `IsSingleButton`
<!-- tc:scope private -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
If set to true, only one button matching bool value will be shown


```csharp
public bool IsSingleButton;

```

<a name="SizeCompensation"></a>

### `SizeCompensation`
<!-- tc:scope private -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Amount by which smaller button size is lerped to match bigger button.
            0 - original size of smaller button (takes the least space).
            1 - matches size of bigger button.


```csharp
public float SizeCompensation;

```

<a name="TrueColor"></a>

### `TrueColor`
<!-- tc:scope private -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Color of true button


```csharp
public string TrueColor;

```

<a name="TrueIcon"></a>

### `TrueIcon`
<!-- tc:scope private -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Icon for true button


```csharp
public string TrueIcon;

```

<a name="TrueText"></a>

### `TrueText`
<!-- tc:scope private -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Text for true button. Can be resolved string


```csharp
public string TrueText;

```

<a name="TrueTooltip"></a>

### `TrueTooltip`
<!-- tc:scope private -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Tooltip for true button. Can be resolved string


```csharp
public string TrueTooltip;

```

<a name="TypeId"></a>

### `TypeId`
<!-- tc:scope public -->
<!-- tc:return_type Object https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual Object TypeId { get; }

```

