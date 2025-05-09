# ColorExtensions

<!-- tc:namespace Noir -->
<!-- tc:assembly Noir.dll -->


```csharp
public static class ColorExtensions
```

## Methods

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
`mode` [ColorBlendMode](../Noir/ColorBlendMode.html) <br>

### `Darken(Color, Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Color Darken(Color a, Color b)
```

**Parameters** <br>
`a` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
`b` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `Darken(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Color Darken(Color a)
```

**Parameters** <br>
`a` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `Difference(Color, Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Color Difference(Color a, Color b)
```

**Parameters** <br>
`a` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
`b` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `Exclusion(Color, Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Color Exclusion(Color a, Color b)
```

**Parameters** <br>
`a` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
`b` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `HardLight(Color, Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Color HardLight(Color a, Color b)
```

**Parameters** <br>
`a` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
`b` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `Lighten(Color, Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Color Lighten(Color a, Color b)
```

**Parameters** <br>
`a` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
`b` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `Lighten(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Color Lighten(Color a)
```

**Parameters** <br>
`a` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `MaxWith(Color, Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Color MaxWith(Color c1, Color c2)
```

**Parameters** <br>
`c1` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
`c2` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `MinWith(Color, Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Color MinWith(Color c1, Color c2)
```

**Parameters** <br>
`c1` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
`c2` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `Overlay(Color, Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Color Overlay(Color a, Color b)
```

**Parameters** <br>
`a` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
`b` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `SoftLight(Color, Color)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Color SoftLight(Color a, Color b)
```

**Parameters** <br>
`a` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
`b` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `ToColor(Vector4)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Color ToColor(Vector4 vector)
```

**Parameters** <br>
`vector` [Vector4](https://docs.unity3d.com/ScriptReference/Vector4.html) <br>

### `WithAlpha(Color, float)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Color WithAlpha(Color color, float alpha)
```

**Parameters** <br>
`color` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
`alpha` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

### `FadeTo(Color, Color, float)`
<!-- tc:scope public -->
<!-- tc:return_type IEnumerator https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public IEnumerator FadeTo(Color color, Color colorb, float duration)
```

**Parameters** <br>
`color` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
`colorb` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
`duration` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

### `XW(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector2 XW(Color c)
```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `XX(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector2 XX(Color c)
```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `XY(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector2 XY(Color c)
```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `XZ(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector2 XZ(Color c)
```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `YW(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector2 YW(Color c)
```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `YX(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector2 YX(Color c)
```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `YY(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector2 YY(Color c)
```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `YZ(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector2 YZ(Color c)
```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `ZW(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector2 ZW(Color c)
```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `ZX(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector2 ZX(Color c)
```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `ZY(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector2 ZY(Color c)
```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `ZZ(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector2 ZZ(Color c)
```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `ToVector3(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector3 ToVector3(Color c)
```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `XXX(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector3 XXX(Color c)
```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `XYZ(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector3 XYZ(Color c)
```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `YYY(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector3 YYY(Color c)
```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `ZZZ(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector3 ZZZ(Color c)
```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `ToVector4(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector4 https://docs.unity3d.com/ScriptReference/Vector4.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector4 ToVector4(Color color)
```

**Parameters** <br>
`color` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `XXXX(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector4 https://docs.unity3d.com/ScriptReference/Vector4.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector4 XXXX(Color c)
```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `YYYY(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector4 https://docs.unity3d.com/ScriptReference/Vector4.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector4 YYYY(Color c)
```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

### `ZZZZ(Color)`
<!-- tc:scope public -->
<!-- tc:return_type Vector4 https://docs.unity3d.com/ScriptReference/Vector4.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector4 ZZZZ(Color c)
```

**Parameters** <br>
`c` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>

