# TrafficLightGUILayout

<!-- tc:namespace NoirEditor.Editors -->

<!-- tc:assembly NoirEditor.dll -->

Provides utility methods for rendering traffic light indicators in Unity's IMGUI system using [GUILayout](https://docs.unity3d.com/ScriptReference/GUILayout.html).


```csharp
public static class TrafficLightGUILayout
```

## Methods

<a name="BoolLight"></a>

### `BoolLight(bool, TrafficLightColor)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Draws a single light that turns on or off based on a boolean value.


```csharp
public void BoolLight(bool val, TrafficLightColor color)

```

**Parameters** <br>
`val` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>
`color` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
 <br>

<a name="BoolLightLarge"></a>

### `BoolLightLarge(bool, TrafficLightColor, TrafficLightColor)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Draws a large two-light indicator for a boolean value, showing red for false and green for true by default.


```csharp
public void BoolLightLarge(bool val, TrafficLightColor colorA,
                            TrafficLightColor colorB)


```

**Parameters** <br>
`val` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>
`colorA` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
 <br>
`colorB` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
 <br>

<a name="DrawTrafficLightDouble"></a>

### `DrawTrafficLightDouble(TrafficLightColor, TrafficLightColor)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Draws a double traffic light indicator using GUILayout positioning.


```csharp
public void DrawTrafficLightDouble(TrafficLightColor colorA,
                                    TrafficLightColor ccolorB)


```

**Parameters** <br>
`colorA` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
 <br>
`ccolorB` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
 <br>

<a name="DrawTrafficLightQuad"></a>

### `DrawTrafficLightQuad(TrafficLightColor, TrafficLightColor, TrafficLightColor, TrafficLightColor)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Draws a quadruple traffic light indicator using GUILayout positioning.


```csharp
public void DrawTrafficLightQuad(TrafficLightColor colorA,
                                  TrafficLightColor colorB,
                                  TrafficLightColor colorC,
                                  TrafficLightColor colorD)


```

**Parameters** <br>
`colorA` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
 <br>
`colorB` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
 <br>
`colorC` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
 <br>
`colorD` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
 <br>

<a name="DrawTrafficLightSingle"></a>

### `DrawTrafficLightSingle(TrafficLightColor)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Draws a single traffic light indicator using GUILayout positioning.


```csharp
public void DrawTrafficLightSingle(TrafficLightColor colorA)

```

**Parameters** <br>
`colorA` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
 <br>

<a name="DrawTrafficLightTriple"></a>

### `DrawTrafficLightTriple(TrafficLightColor, TrafficLightColor, TrafficLightColor)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Draws a triple traffic light indicator using GUILayout positioning.


```csharp
public void DrawTrafficLightTriple(TrafficLightColor colorA,
                                    TrafficLightColor colorB,
                                    TrafficLightColor colorC)


```

**Parameters** <br>
`colorA` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
 <br>
`colorB` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
 <br>
`colorC` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
 <br>

## More information

* [UnityEngine.GUILayout](https://docs.unity3d.com/ScriptReference/GUILayout.html)
