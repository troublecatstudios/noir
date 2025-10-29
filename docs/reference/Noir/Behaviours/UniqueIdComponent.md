# UniqueIdComponent

<!-- tc:namespace Noir.Behaviours -->

<!-- tc:assembly Noir.dll -->

Provides a persistent, unique identifier for a GameObject or entity in the game world.
This component assigns a globally unique identifier (GUID) to each object it is attached to.
            The identifier remains consistent across play sessions unless regenerated manually.


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
Gets the unique identifier as a [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=net-7.0) structure.


```csharp
public Guid Guid { get; }

```

<a name="Separated"></a>

### `Separated`
<!-- tc:scope public -->
<!-- tc:return_type SeparatedGuid /noir/reference/Noir/SeparatedGuid/ -->
<!-- tc:version 1.0.0 -->
Gets the unique identifier represented as a [SeparatedGuid](/noir/reference/Noir/SeparatedGuid/).
This format is used for systems that store GUIDs as separated or segmented components
            for serialization or data comparison purposes.


```csharp
public SeparatedGuid Separated { get; }

```

<a name="ShortId"></a>

### `ShortId`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets a shortened representation of the identifier for debugging or display purposes.
The format is the first four and last four characters of the GUID, concatenated.


```csharp
public string ShortId { get; }

```

<a name="UID"></a>

### `UID`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the raw string form of the unique identifier assigned to this object.
This string is a standard GUID, e.g., <c>550e8400-e29b-41d4-a716-446655440000</c>.


```csharp
public string UID { get; }

```

## Methods

<a name="GenerateUUID"></a>

### `GenerateUUID()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Generates a new globally unique identifier (GUID) for this object, replacing the existing one.
This method should generally only be used in the editor or during setup.
            Changing IDs at runtime can cause inconsistencies in systems relying on stable identifiers.


```csharp
public void GenerateUUID()

```

