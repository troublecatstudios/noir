# Maths

<!-- tc:namespace Noir -->

<!-- tc:assembly Noir.dll -->

Provides mathematical utility methods and constants for working with vectors and numeric operations.


```csharp
public static class Maths
```

## Fields

<a name="MaxVector2"></a>

### `MaxVector2`
<!-- tc:scope private -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->

```csharp
public static Vector2 MaxVector2;

```

<a name="MinVector2"></a>

### `MinVector2`
<!-- tc:scope private -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 1.0.0 -->

```csharp
public static Vector2 MinVector2;

```

## Methods

<a name="Scale"></a>

### `Scale(float, float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Scales the given value <paramref name="x" /> to the nearest multiple of <paramref name="y" />,
            rounding up to the next multiple if necessary.


```csharp
public float Scale(float x, float y)

```

**Parameters** <br>
`x` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>
`y` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

