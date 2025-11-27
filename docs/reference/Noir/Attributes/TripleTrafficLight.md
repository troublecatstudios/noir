# TripleTrafficLight

<!-- tc:namespace Noir.Attributes -->

<!-- tc:assembly Noir.dll -->

Displays a triple traffic light indicator in the Unity Inspector.


```csharp
public class TripleTrafficLight : TrafficLightAttribute
```

**Implements:** _[TrafficLightAttribute](/noir/reference/Noir/Attributes/TrafficLightAttribute/)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Creates a red, amber, and green traffic light indicator.


```csharp
public TripleTrafficLight()

```

<a name=".ctor"></a>

### `.ctor(TrafficLightColor, TrafficLightColor, TrafficLightColor)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Creates a three-light indicator with specified colors.


```csharp
public TripleTrafficLight(TrafficLightColor a, TrafficLightColor b,
                           TrafficLightColor c)


```

**Parameters** <br>
`a` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
`b` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
`c` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>

