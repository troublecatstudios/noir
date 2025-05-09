# TrafficLightGUI

<!-- tc:namespace NoirEditor.Editors -->
<!-- tc:assembly NoirEditor.dll -->


```csharp
public static class TrafficLightGUI
```

## Properties

### `DoubleLightSize`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 0.0.0 -->

```csharp
public static Vector2 DoubleLightSize { get; }
```

### `QuadLightSize`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 0.0.0 -->

```csharp
public static Vector2 QuadLightSize { get; }
```

### `SingleLightSize`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 0.0.0 -->

```csharp
public static Vector2 SingleLightSize { get; }
```

### `TripleLightSize`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 0.0.0 -->

```csharp
public static Vector2 TripleLightSize { get; }
```

## Methods

### `GetTrafficLightSize(TrafficLightSize)`
<!-- tc:scope public -->
<!-- tc:return_type Vector2 https://docs.unity3d.com/ScriptReference/Vector2.html -->
<!-- tc:version 0.0.0 -->

```csharp
public Vector2 GetTrafficLightSize(TrafficLightSize size)
```

**Parameters** <br>
`size` [TrafficLightSize](../../NoirEditor/Editors/TrafficLightSize.html) <br>

### `DrawTrafficLightDouble(Rect, TrafficLightColor, TrafficLightColor)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void DrawTrafficLightDouble(Rect position, TrafficLightColor typeA, TrafficLightColor typeB)
```

**Parameters** <br>
`position` [Rect](https://docs.unity3d.com/ScriptReference/Rect.html) <br>
`typeA` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>
`typeB` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>

### `DrawTrafficLightQuad(Rect, TrafficLightColor, TrafficLightColor, TrafficLightColor, TrafficLightColor)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void DrawTrafficLightQuad(Rect position, TrafficLightColor typeA, TrafficLightColor typeB, TrafficLightColor typeC, TrafficLightColor typeD)
```

**Parameters** <br>
`position` [Rect](https://docs.unity3d.com/ScriptReference/Rect.html) <br>
`typeA` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>
`typeB` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>
`typeC` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>
`typeD` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>

### `DrawTrafficLightSingle(Rect, TrafficLightColor)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void DrawTrafficLightSingle(Rect position, TrafficLightColor type)
```

**Parameters** <br>
`position` [Rect](https://docs.unity3d.com/ScriptReference/Rect.html) <br>
`type` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>

### `DrawTrafficLightTriple(Rect, TrafficLightColor, TrafficLightColor, TrafficLightColor)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void DrawTrafficLightTriple(Rect position, TrafficLightColor typeA, TrafficLightColor typeB, TrafficLightColor typeC)
```

**Parameters** <br>
`position` [Rect](https://docs.unity3d.com/ScriptReference/Rect.html) <br>
`typeA` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>
`typeB` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>
`typeC` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>

