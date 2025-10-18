# ColorExtensions

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Extension methods for the [Color](https://docs.unity3d.com/ScriptReference/Color.html) type, including blending, vector conversion, and utility operations.


```csharp
public static class ColorExtensions
```

## Methods

<a name="BlendWith"></a>

### `BlendWith(Color, Color, ColorBlendMode)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Color BlendWith(Color a, Color b, ColorBlendMode mode)

```

**Parameters** <br>
`a` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
`b` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
`mode` [ColorBlendMode](/noir/reference/Noir/ColorBlendMode/) <br>

<a name="Darken"></a>

### `Darken(Color, Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->
Darkens the color by blending with another color.


```csharp
public Color Darken(Color a, Color b)

```

**Parameters** <br>
`a` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>
`b` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>

<a name="Darken"></a>

### `Darken(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->
Darkens the color by blending with black at 50% alpha.


```csharp
public Color Darken(Color a)

```

**Parameters** <br>
`a` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>

<a name="Difference"></a>

### `Difference(Color, Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->
Applies a difference blend between two colors.


```csharp
public Color Difference(Color a, Color b)

```

**Parameters** <br>
`a` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>
`b` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>

<a name="Exclusion"></a>

### `Exclusion(Color, Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->
Applies an exclusion blend between two colors.


```csharp
public Color Exclusion(Color a, Color b)

```

**Parameters** <br>
`a` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>
`b` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>

<a name="HardLight"></a>

### `HardLight(Color, Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->
Applies a hard light blend between two colors.


```csharp
public Color HardLight(Color a, Color b)

```

**Parameters** <br>
`a` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>
`b` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>

<a name="Lighten"></a>

### `Lighten(Color, Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->
Lightens the color by blending with another color.


```csharp
public Color Lighten(Color a, Color b)

```

**Parameters** <br>
`a` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>
`b` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>

<a name="Lighten"></a>

### `Lighten(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->
Lightens the color by blending with white at 50% alpha.


```csharp
public Color Lighten(Color a)

```

**Parameters** <br>
`a` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>

<a name="MaxWith"></a>

### `MaxWith(Color, Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->
Returns a new color with the maximum values from each channel of two colors.


```csharp
public Color MaxWith(Color c1, Color c2)

```

**Parameters** <br>
`c1` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>
`c2` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>

<a name="MinWith"></a>

### `MinWith(Color, Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->
Returns a new color with the minimum values from each channel of two colors.


```csharp
public Color MinWith(Color c1, Color c2)

```

**Parameters** <br>
`c1` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>
`c2` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>

<a name="Overlay"></a>

### `Overlay(Color, Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->
Applies an overlay blend between two colors.


```csharp
public Color Overlay(Color a, Color b)

```

**Parameters** <br>
`a` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>
`b` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>

<a name="SoftLight"></a>

### `SoftLight(Color, Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->
Applies a soft light blend between two colors.


```csharp
public Color SoftLight(Color a, Color b)

```

**Parameters** <br>
`a` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>
`b` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>

<a name="ToColor"></a>

### `ToColor(Vector4)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->
Converts a [Color](https://docs.unity3d.com/ScriptReference/Color.html).


```csharp
public Color ToColor(Vector4 vector)

```

**Parameters** <br>
`vector` [Vector4](https://docs.unity3d.com/ScriptReference/Vector4.html) <br>
 <br>

<a name="WithAlpha"></a>

### `WithAlpha(Color, float)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->
Returns a new color with the alpha channel set to the specified value.


```csharp
public Color WithAlpha(Color color, float alpha)

```

**Parameters** <br>
`color` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>
`alpha` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

<a name="FadeTo"></a>

### `FadeTo(Color, Color, float)`
<!-- tc:scope public -->
<!-- tc:return_type IEnumerator https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Fades a color to another color over the specified duration, yielding after each frame.


```csharp
public IEnumerator FadeTo(Color color, Color colorb, float duration)

```

**Parameters** <br>
`color` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>
`colorb` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>
`duration` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

<a name="XW"></a>

### `XW(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->
Gets a [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) containing the red and alpha channels.


```csharp
public Vector2 XW(Color c)

```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

<a name="XX"></a>

### `XX(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->
Gets a [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) containing the red channel twice.


```csharp
public Vector2 XX(Color c)

```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

<a name="XY"></a>

### `XY(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->
Gets a [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) containing the red and green channels.


```csharp
public Vector2 XY(Color c)

```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

<a name="XZ"></a>

### `XZ(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->
Gets a [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) containing the red and blue channels.


```csharp
public Vector2 XZ(Color c)

```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

<a name="YW"></a>

### `YW(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->
Gets a [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) containing the green and alpha channels.


```csharp
public Vector2 YW(Color c)

```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

<a name="YX"></a>

### `YX(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->
Gets a [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) containing the green and red channels.


```csharp
public Vector2 YX(Color c)

```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

<a name="YY"></a>

### `YY(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->
Gets a [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) containing the green channel twice.


```csharp
public Vector2 YY(Color c)

```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

<a name="YZ"></a>

### `YZ(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->
Gets a [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) containing the green and blue channels.


```csharp
public Vector2 YZ(Color c)

```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

<a name="ZW"></a>

### `ZW(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->
Gets a [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) containing the blue and alpha channels.


```csharp
public Vector2 ZW(Color c)

```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

<a name="ZX"></a>

### `ZX(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->
Gets a [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) containing the blue and red channels.


```csharp
public Vector2 ZX(Color c)

```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

<a name="ZY"></a>

### `ZY(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->
Gets a [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) containing the blue and green channels.


```csharp
public Vector2 ZY(Color c)

```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

<a name="ZZ"></a>

### `ZZ(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->
Gets a [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) containing the blue channel twice.


```csharp
public Vector2 ZZ(Color c)

```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

<a name="ToVector3"></a>

### `ToVector3(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 1.0.0 -->
Converts a color to a [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) using its RGBA channels.


```csharp
public Vector3 ToVector3(Color c)

```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>

<a name="XXX"></a>

### `XXX(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 1.0.0 -->
Gets a [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) containing the red channel three times.


```csharp
public Vector3 XXX(Color c)

```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

<a name="XYZ"></a>

### `XYZ(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 1.0.0 -->
Gets a [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) containing the red, green, and blue channels.


```csharp
public Vector3 XYZ(Color c)

```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

<a name="YYY"></a>

### `YYY(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 1.0.0 -->
Gets a [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) containing the green channel three times.


```csharp
public Vector3 YYY(Color c)

```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

<a name="ZZZ"></a>

### `ZZZ(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 1.0.0 -->
Gets a [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) containing the blue channel three times.


```csharp
public Vector3 ZZZ(Color c)

```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

<a name="ToVector4"></a>

### `ToVector4(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector4 https://docs.unity3d.com/ScriptReference/Vector4.html -->
<!-- tc:version 1.0.0 -->
Converts a [Vector4](https://docs.unity3d.com/ScriptReference/Vector4.html).


```csharp
public Vector4 ToVector4(Color color)

```

**Parameters** <br>
`color` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>

<a name="XXXX"></a>

### `XXXX(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector4 https://docs.unity3d.com/ScriptReference/Vector4.html -->
<!-- tc:version 1.0.0 -->
Gets a [Vector4](https://docs.unity3d.com/ScriptReference/Vector4.html) containing the red channel four times.


```csharp
public Vector4 XXXX(Color c)

```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

<a name="YYYY"></a>

### `YYYY(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector4 https://docs.unity3d.com/ScriptReference/Vector4.html -->
<!-- tc:version 1.0.0 -->
Gets a [Vector4](https://docs.unity3d.com/ScriptReference/Vector4.html) containing the green channel four times.


```csharp
public Vector4 YYYY(Color c)

```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

<a name="ZZZZ"></a>

### `ZZZZ(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector4 https://docs.unity3d.com/ScriptReference/Vector4.html -->
<!-- tc:version 1.0.0 -->
Gets a [Vector4](https://docs.unity3d.com/ScriptReference/Vector4.html) containing the blue channel four times.


```csharp
public Vector4 ZZZZ(Color c)

```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

## More information

* [UnityEngine.Color](https://docs.unity3d.com/ScriptReference/Color.html)
