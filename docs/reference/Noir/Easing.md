# Easing

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Provides easing functions for interpolation of various types.


```csharp
public static class Easing
```

## Methods

<a name="Ease"></a>

### `Ease(EaseType, Color, Color, float)`
<!-- tc:scope public -->
<!-- tc:return_type Color https://docs.unity3d.com/ScriptReference/Color.html -->
<!-- tc:version 1.0.0 -->
Interpolates between two [Color](https://docs.unity3d.com/ScriptReference/Color.html) values using the specified easing type.


```csharp
public Color Ease(EaseType type, Color from, Color to, float t)

```

**Parameters** <br>
`type` [EaseType](/noir/reference/Noir/EaseType/) <br>
 <br>
`from` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>
`to` [Color](https://docs.unity3d.com/ScriptReference/Color.html) <br>
 <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

<a name="BackIn"></a>

### `BackIn(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Back in easing.


```csharp
public float BackIn(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="BackInOut"></a>

### `BackInOut(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Back in-out easing.


```csharp
public float BackInOut(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="BackOut"></a>

### `BackOut(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Back out easing.


```csharp
public float BackOut(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="BounceIn"></a>

### `BounceIn(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Bounce in easing.


```csharp
public float BounceIn(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="BounceInOut"></a>

### `BounceInOut(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Bounce in-out easing.


```csharp
public float BounceInOut(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="BounceOut"></a>

### `BounceOut(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Bounce out easing.


```csharp
public float BounceOut(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="CircularIn"></a>

### `CircularIn(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Circular in easing.


```csharp
public float CircularIn(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="CircularInOut"></a>

### `CircularInOut(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Circular in-out easing.


```csharp
public float CircularInOut(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="CircularOut"></a>

### `CircularOut(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Circular out easing.


```csharp
public float CircularOut(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="CubicIn"></a>

### `CubicIn(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Cubic in easing (accelerating from zero velocity).


```csharp
public float CubicIn(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="CubicInOut"></a>

### `CubicInOut(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Cubic in-out easing (acceleration until halfway, then deceleration).


```csharp
public float CubicInOut(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="CubicOut"></a>

### `CubicOut(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Cubic out easing (decelerating to zero velocity).


```csharp
public float CubicOut(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="Ease"></a>

### `Ease(EaseType, float, float, float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Interpolates between two float values using the specified easing type.


```csharp
public float Ease(EaseType type, float from, float to, float t)

```

**Parameters** <br>
`type` [EaseType](/noir/reference/Noir/EaseType/) <br>
 <br>
`from` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`to` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

<a name="ElasticIn"></a>

### `ElasticIn(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Elastic in easing.


```csharp
public float ElasticIn(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="ElasticInOut"></a>

### `ElasticInOut(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Elastic in-out easing.


```csharp
public float ElasticInOut(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="ElasticOut"></a>

### `ElasticOut(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Elastic out easing.


```csharp
public float ElasticOut(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="ExponentialIn"></a>

### `ExponentialIn(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Exponential in easing.


```csharp
public float ExponentialIn(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="ExponentialInOut"></a>

### `ExponentialInOut(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Exponential in-out easing.


```csharp
public float ExponentialInOut(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="ExponentialOut"></a>

### `ExponentialOut(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Exponential out easing.


```csharp
public float ExponentialOut(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="Linear"></a>

### `Linear(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Linear easing (no acceleration).


```csharp
public float Linear(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="QuadraticIn"></a>

### `QuadraticIn(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Quadratic in easing (accelerating from zero velocity).


```csharp
public float QuadraticIn(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="QuadraticInOut"></a>

### `QuadraticInOut(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Quadratic in-out easing (acceleration until halfway, then deceleration).


```csharp
public float QuadraticInOut(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="QuadraticOut"></a>

### `QuadraticOut(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Quadratic out easing (decelerating to zero velocity).


```csharp
public float QuadraticOut(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="QuarticIn"></a>

### `QuarticIn(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Quartic in easing (accelerating from zero velocity).


```csharp
public float QuarticIn(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="QuarticInOut"></a>

### `QuarticInOut(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Quartic in-out easing (acceleration until halfway, then deceleration).


```csharp
public float QuarticInOut(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="QuarticOut"></a>

### `QuarticOut(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Quartic out easing (decelerating to zero velocity).


```csharp
public float QuarticOut(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="QuinticIn"></a>

### `QuinticIn(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Quintic in easing (accelerating from zero velocity).


```csharp
public float QuinticIn(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="QuinticInOut"></a>

### `QuinticInOut(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Quintic in-out easing (acceleration until halfway, then deceleration).


```csharp
public float QuinticInOut(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="QuinticOut"></a>

### `QuinticOut(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Quintic out easing (decelerating to zero velocity).


```csharp
public float QuinticOut(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="SinusoidalIn"></a>

### `SinusoidalIn(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Sinusoidal in easing.


```csharp
public float SinusoidalIn(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="SinusoidalInOut"></a>

### `SinusoidalInOut(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Sinusoidal in-out easing.


```csharp
public float SinusoidalInOut(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="SinusoidalOut"></a>

### `SinusoidalOut(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Sinusoidal out easing.


```csharp
public float SinusoidalOut(float t)

```

**Parameters** <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="Function"></a>

### `Function(EaseType)`
<!-- tc:scope public -->
<!-- tc:return_type Func\<T, TResult\> https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the easing function delegate for the specified [EaseType](/noir/reference/Noir/EaseType/).


```csharp
public Func<T, TResult> Function(EaseType type)

```

**Parameters** <br>
`type` [EaseType](/noir/reference/Noir/EaseType/) <br>
 <br>

<a name="Ease"></a>

### `Ease(EaseType, Quaternion, Quaternion, float)`
<!-- tc:scope public -->
<!-- tc:return_type Quaternion https://docs.unity3d.com/ScriptReference/Quaternion.html -->
<!-- tc:version 1.0.0 -->
Interpolates between two [Quaternion](https://docs.unity3d.com/ScriptReference/Quaternion.html) values using the specified easing type.


```csharp
public Quaternion Ease(EaseType type, Quaternion from, Quaternion to, float t)

```

**Parameters** <br>
`type` [EaseType](/noir/reference/Noir/EaseType/) <br>
 <br>
`from` [Quaternion](https://docs.unity3d.com/ScriptReference/Quaternion.html) <br>
 <br>
`to` [Quaternion](https://docs.unity3d.com/ScriptReference/Quaternion.html) <br>
 <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

<a name="Ease"></a>

### `Ease(EaseType, Vector3, Vector3, float)`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 1.0.0 -->
Interpolates between two [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) values using the specified easing type.


```csharp
public Vector3 Ease(EaseType type, Vector3 from, Vector3 to, float t)

```

**Parameters** <br>
`type` [EaseType](/noir/reference/Noir/EaseType/) <br>
 <br>
`from` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>
`to` [Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) <br>
 <br>
`t` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

