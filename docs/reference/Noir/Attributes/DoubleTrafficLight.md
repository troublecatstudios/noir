# DoubleTrafficLight

<!-- tc:namespace Noir.Attributes -->

<!-- tc:assembly Noir.dll -->

Displays a double traffic light indicator in the Unity Inspector.


```csharp
public class DoubleTrafficLight : TrafficLightAttribute
```

**Implements:** _[TrafficLightAttribute](/noir/reference/Noir/Attributes/TrafficLightAttribute/)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Creates a red and green traffic light indicator.


```csharp
public DoubleTrafficLight()

```

<a name=".ctor"></a>

### `.ctor(TrafficLightColor, TrafficLightColor)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Creates a two-light indicator with specified colors.


```csharp
public DoubleTrafficLight(TrafficLightColor a, TrafficLightColor b)

```

**Parameters** <br>
`a` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>
`b` [TrafficLightColor](/noir/reference/Noir/Attributes/TrafficLightColor/) <br>

