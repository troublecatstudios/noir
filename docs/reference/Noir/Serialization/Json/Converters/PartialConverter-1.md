# PartialConverter\<T\>

<!-- tc:namespace Noir.Serialization.Json.Converters -->

<!-- tc:assembly Noir.dll -->


```csharp
public abstract class PartialConverter<T> : JsonConverter
```

**Implements:** _[JsonConverter](/noir/reference/)_

## Methods

<a name="CanConvert"></a>

### `CanConvert(Type)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Determine if the object type is <typeparamref name="T" />


```csharp
public virtual bool CanConvert(Type objectType)

```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
 <br>

<a name="ReadJson"></a>

### `ReadJson(JsonReader, Type, Object, JsonSerializer)`
<!-- tc:scope public -->
<!-- tc:return_type Object https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Read the specified properties to the object.


```csharp
public virtual Object ReadJson(JsonReader reader, Type objectType,
                                Object existingValue, JsonSerializer serializer)


```

**Parameters** <br>
`reader` [JsonReader](/noir/reference/) <br>
 <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
 <br>
`existingValue` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>
`serializer` [JsonSerializer](/noir/reference/) <br>
 <br>

<a name="WriteJson"></a>

### `WriteJson(JsonWriter, Object, JsonSerializer)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Write the specified properties of the object.


```csharp
public virtual void WriteJson(JsonWriter writer, Object value,
                               JsonSerializer serializer)


```

**Parameters** <br>
`writer` [JsonWriter](/noir/reference/) <br>
 <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>
`serializer` [JsonSerializer](/noir/reference/) <br>
 <br>

