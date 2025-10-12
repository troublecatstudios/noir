# UniqueIdComponent

<!-- tc:namespace Noir.Behaviours -->

<!-- tc:assembly Noir.dll -->


```csharp
public class UniqueIdComponent : NoirBehaviour
```

**Implements:** _[NoirBehaviour](/noir/reference/Noir/NoirBehaviour/)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public UniqueIdComponent()

```

## Properties

<a name="Guid"></a>

### `Guid`
<!-- tc:scope public -->
<!-- tc:return_type Guid https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public Guid Guid { get; }

```

<a name="Separated"></a>

### `Separated`
<!-- tc:scope public -->
<!-- tc:return_type SeparatedGuid /noir/reference/Noir/SeparatedGuid/ -->
<!-- tc:version 1.0.0 -->

```csharp
public SeparatedGuid Separated { get; }

```

<a name="ShortId"></a>

### `ShortId`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string ShortId { get; }

```

<a name="UID"></a>

### `UID`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
A generated GUID that uniquely identifies this entity in the game.


```csharp
public string UID { get; }

```

## Methods

<a name="GenerateUUID"></a>

### `GenerateUUID()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void GenerateUUID()

```

