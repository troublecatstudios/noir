# TrafficLightGUI

**Namespace:** NoirEditor.Editors <br>
**Assembly:** NoirEditor.dll

```csharp
public static class TrafficLightGUI
```

### 📦 Properties
#### DoubleLightSize
```csharp
public static Vector2 DoubleLightSize { get; }
```

**Returns** <br>
[Vector2](../../) <br>
#### QuadLightSize
```csharp
public static Vector2 QuadLightSize { get; }
```

**Returns** <br>
[Vector2](../../) <br>
#### SingleLightSize
```csharp
public static Vector2 SingleLightSize { get; }
```

**Returns** <br>
[Vector2](../../) <br>
#### TripleLightSize
```csharp
public static Vector2 TripleLightSize { get; }
```

**Returns** <br>
[Vector2](../../) <br>
### ⛹️‍♀️ Methods
#### GetTrafficLightSize(TrafficLightSize)
```csharp
public Vector2 GetTrafficLightSize(TrafficLightSize size)
```

**Parameters** <br>
`size` [TrafficLightSize](../../NoirEditor/Editors/TrafficLightSize.html) <br>

**Returns** <br>
[Vector2](../../) <br>

#### DrawTrafficLightDouble(Rect, TrafficLightColor, TrafficLightColor)
```csharp
public void DrawTrafficLightDouble(Rect position, TrafficLightColor typeA, TrafficLightColor typeB)
```

**Parameters** <br>
`position` [Rect](../../) <br>
`typeA` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>
`typeB` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>

#### DrawTrafficLightQuad(Rect, TrafficLightColor, TrafficLightColor, TrafficLightColor, TrafficLightColor)
```csharp
public void DrawTrafficLightQuad(Rect position, TrafficLightColor typeA, TrafficLightColor typeB, TrafficLightColor typeC, TrafficLightColor typeD)
```

**Parameters** <br>
`position` [Rect](../../) <br>
`typeA` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>
`typeB` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>
`typeC` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>
`typeD` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>

#### DrawTrafficLightSingle(Rect, TrafficLightColor)
```csharp
public void DrawTrafficLightSingle(Rect position, TrafficLightColor type)
```

**Parameters** <br>
`position` [Rect](../../) <br>
`type` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>

#### DrawTrafficLightTriple(Rect, TrafficLightColor, TrafficLightColor, TrafficLightColor)
```csharp
public void DrawTrafficLightTriple(Rect position, TrafficLightColor typeA, TrafficLightColor typeB, TrafficLightColor typeC)
```

**Parameters** <br>
`position` [Rect](../../) <br>
`typeA` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>
`typeB` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>
`typeC` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>

