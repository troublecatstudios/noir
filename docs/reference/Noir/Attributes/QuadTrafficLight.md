# QuadTrafficLight

<!-- tc:namespace Noir.Attributes -->

<!-- tc:assembly Noir.dll -->

Displays a quad traffic light indicator in the Unity Inspector.


```csharp
public class QuadTrafficLight : TrafficLightAttribute
```

**Implements:** _[TrafficLightAttribute](/noir/reference/Noir/Attributes/TrafficLightAttribute/)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Creates a four-light indicator with blue, green, yellow, and pink lights.


```csharp
public QuadTrafficLight()

```

<a name=".ctor"></a>

### `.ctor(TrafficLightColor, TrafficLightColor, TrafficLightColor, TrafficLightColor)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Creates a four-light indicator with specified colors.


```csharp
public QuadTrafficLight(TrafficLightColor a, TrafficLightColor b,
                         TrafficLightColor c, TrafficLightColor d)


```

**Parameters** <br>
`a` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
`b` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
`c` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
`d` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>

