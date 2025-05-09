# DoubleTrafficLight

<!-- tc:namespace Noir.Attributes -->
<!-- tc:assembly Noir.dll -->


```csharp
public class DoubleTrafficLight : TrafficLightAttribute
```

**Implements:** _[TrafficLightAttribute](../../Noir/Attributes/TrafficLightAttribute.html)_

## Constructors

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public DoubleTrafficLight()
```

### `.ctor(TrafficLightColor, TrafficLightColor)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public DoubleTrafficLight(TrafficLightColor a, TrafficLightColor b)
```

**Parameters** <br>
`a` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>
`b` [TrafficLightColor](../../Noir/Attributes/TrafficLightColor.html) <br>

## Properties

### `AlsoDrawDefault`
<!-- tc:scope private -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool AlsoDrawDefault;
```

### `Colors`
<!-- tc:scope private -->
<!-- tc:return_type TrafficLightColor[] ../../Noir/Attributes/TrafficLightColor.html -->
<!-- tc:version 1.0.0 -->

```csharp
public TrafficLightColor[] Colors;
```

### `CustomLabel`
<!-- tc:scope private -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string CustomLabel;
```

### `DrawLabel`
<!-- tc:scope private -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool DrawLabel;
```

### `FillLights`
<!-- tc:scope private -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool FillLights;
```

### `LightCount`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int LightCount;
```

### `order`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int order { get; public set; }
```

### `TypeId`
<!-- tc:scope public -->
<!-- tc:return_type Object https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual Object TypeId { get; }
```

