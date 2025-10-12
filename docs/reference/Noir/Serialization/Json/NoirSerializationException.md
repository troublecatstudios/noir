# NoirSerializationException

<!-- tc:namespace Noir.Serialization.Json -->

<!-- tc:assembly Noir.dll -->


```csharp
public class NoirSerializationException : JsonSerializationException, ISerializable
```

**Implements:** _[JsonSerializationException](/noir/reference/), [ISerializable](https://learn.microsoft.com/en-us/dotnet/api/System.Runtime.Serialization.ISerializable?view=net-7.0)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public NoirSerializationException()

```

## Methods

<a name="CreateSerializationException"></a>

### `CreateSerializationException(JsonReader, string, Exception)`
<!-- tc:scope public -->
<!-- tc:return_type NoirSerializationException /noir/reference/Noir/Serialization/Json/NoirSerializationException/ -->
<!-- tc:version 1.0.0 -->

```csharp
public NoirSerializationException CreateSerializationException(JsonReader reader,
                                                                string message,
                                                                Exception innerException)


```

**Parameters** <br>
`reader` [JsonReader](/noir/reference/) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`innerException` [Exception](https://learn.microsoft.com/en-us/dotnet/api/System.Exception?view=net-7.0) <br>

