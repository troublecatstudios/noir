# DecibelConstants

<!-- tc:namespace Noir.Audio -->

<!-- tc:assembly Noir.dll -->


```csharp
public static class DecibelConstants
```

## Properties

### `Concert`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Also: jet aircraft engine during takeoff from 200ft


```csharp
public static const int Concert;

```

### `Conversation`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Conversation at 3ft distance


```csharp
public static const int Conversation;

```

### `Discomfort`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public static const int Discomfort;

```

### `LoudRadio`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Also: A jackhammer at 50ft


```csharp
public static const int LoudRadio;

```

### `Pain`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public static const int Pain;

```

### `Rain`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Ambient noise of a perfectly quiet night, in a suburban neighborhood


```csharp
public static const int Rain;

```

### `SubwayTrain`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Also: construction site


```csharp
public static const int SubwayTrain;

```

### `Whisper`
<!-- tc:scope private -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Ambient noise of a perfectly quiet night in the countryside


```csharp
public static const int Whisper;

```

## Methods

### `DecibelToDistance(float)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Estimates the distance based on the principle that sound intensity decreases by 6 decibels each time the distance from the source doubles


```csharp
public float DecibelToDistance(float db)

```

**Parameters** <br>
`db` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

