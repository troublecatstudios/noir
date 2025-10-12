# TrafficLightGUI

<!-- tc:namespace NoirEditor.Editors -->

<!-- tc:assembly NoirEditor.dll -->


```csharp
public static class TrafficLightGUI
```

## Properties

<a name="DoubleLightSize"></a>

### `DoubleLightSize`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 0.0.0 -->

```csharp
public static Vector2 DoubleLightSize { get; }

```

<a name="QuadLightSize"></a>

### `QuadLightSize`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 0.0.0 -->

```csharp
public static Vector2 QuadLightSize { get; }

```

<a name="SingleLightSize"></a>

### `SingleLightSize`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 0.0.0 -->

```csharp
public static Vector2 SingleLightSize { get; }

```

<a name="TripleLightSize"></a>

### `TripleLightSize`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 0.0.0 -->

```csharp
public static Vector2 TripleLightSize { get; }

```

## Methods

<a name="GetTrafficLightSize"></a>

### `GetTrafficLightSize(TrafficLightSize)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 0.0.0 -->

```csharp
public Vector2 GetTrafficLightSize(TrafficLightSize size)

```

**Parameters** <br>
`size` [TrafficLightSize](/noir/reference/NoirEditor/Editors/TrafficLightSize/) <br>

<a name="DrawTrafficLightDouble"></a>

### `DrawTrafficLightDouble(Rect, TrafficLightColor, TrafficLightColor)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void DrawTrafficLightDouble(Rect position, TrafficLightColor typeA,
                                    TrafficLightColor typeB)


```

**Parameters** <br>
`position` [Rect](https://docs.unity3d.com/ScriptReference/Rect.html) <br>
`typeA` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
`typeB` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>

<a name="DrawTrafficLightQuad"></a>

### `DrawTrafficLightQuad(Rect, TrafficLightColor, TrafficLightColor, TrafficLightColor, TrafficLightColor)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void DrawTrafficLightQuad(Rect position, TrafficLightColor typeA,
                                  TrafficLightColor typeB,
                                  TrafficLightColor typeC,
                                  TrafficLightColor typeD)


```

**Parameters** <br>
`position` [Rect](https://docs.unity3d.com/ScriptReference/Rect.html) <br>
`typeA` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
`typeB` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
`typeC` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
`typeD` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>

<a name="DrawTrafficLightSingle"></a>

### `DrawTrafficLightSingle(Rect, TrafficLightColor)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void DrawTrafficLightSingle(Rect position, TrafficLightColor type)

```

**Parameters** <br>
`position` [Rect](https://docs.unity3d.com/ScriptReference/Rect.html) <br>
`type` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>

<a name="DrawTrafficLightTriple"></a>

### `DrawTrafficLightTriple(Rect, TrafficLightColor, TrafficLightColor, TrafficLightColor)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void DrawTrafficLightTriple(Rect position, TrafficLightColor typeA,
                                    TrafficLightColor typeB,
                                    TrafficLightColor typeC)


```

**Parameters** <br>
`position` [Rect](https://docs.unity3d.com/ScriptReference/Rect.html) <br>
`typeA` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
`typeB` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
`typeC` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>

