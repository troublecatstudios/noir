# ToggleButtonsAttribute

**Namespace:** Noir.Attributes <br>
**Assembly:** Noir.dll

```csharp
public class ToggleButtonsAttribute : Attribute
```

**Implements:** _[Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=net-7.0)_

### 🛠 Constructors
```csharp
public ToggleButtonsAttribute(string trueText, string falseText, bool singleButton, float sizeCompensation, string trueTooltip, string falseTooltip, string trueColor, string falseColor, string trueIcon, string falseIcon)
```

Attribute to draw boolean as buttons

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

### 📦 Properties
#### FalseColor
```csharp
public string FalseColor;
```

Color of false button

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### FalseIcon
```csharp
public string FalseIcon;
```

Icon for false button

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### FalseText
```csharp
public string FalseText;
```

Text for false button. Can be resolved string

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### FalseTooltip
```csharp
public string FalseTooltip;
```

Tooltip for false button. Can be resolved string

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### IsSingleButton
```csharp
public bool IsSingleButton;
```

If set to true, only one button matching bool value will be shown

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### SizeCompensation
```csharp
public float SizeCompensation;
```

Amount by which smaller button size is lerped to match bigger button.
            0 - original size of smaller button (takes the least space).
            1 - matches size of bigger button.

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
#### TrueColor
```csharp
public string TrueColor;
```

Color of true button

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### TrueIcon
```csharp
public string TrueIcon;
```

Icon for true button

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### TrueText
```csharp
public string TrueText;
```

Text for true button. Can be resolved string

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### TrueTooltip
```csharp
public string TrueTooltip;
```

Tooltip for true button. Can be resolved string

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### TypeId
```csharp
public virtual Object TypeId { get; }
```

**Returns** <br>
[Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
