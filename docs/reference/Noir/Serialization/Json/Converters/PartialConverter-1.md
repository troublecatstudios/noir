# PartialConverter\<T\>

<!-- tc:namespace Noir.Serialization.Json.Converters -->

<!-- tc:assembly Noir.dll -->


```csharp
public abstract class PartialConverter<T> : JsonConverter
```

**Implements:** _[JsonConverter](/noir/reference//noir/reference//noir/reference//noir/reference/)_

## Constructors

### `.ctor()`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected PartialConverter<T>()

```

## Properties

### `CanRead`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool CanRead { get; }

```

### `CanWrite`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool CanWrite { get; }

```

## Methods

### `ReadValue(T&, string, JsonReader, JsonSerializer)`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected abstract void ReadValue(T& value, string name, JsonReader reader,
                                   JsonSerializer serializer)


```

**Parameters** <br>
`value` [T&](/noir/reference//noir/reference//noir/reference//noir/reference/) <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`reader` [JsonReader](/noir/reference//noir/reference//noir/reference//noir/reference/) <br>
`serializer` [JsonSerializer](/noir/reference//noir/reference//noir/reference//noir/reference/) <br>

### `WriteJsonProperties(JsonWriter, T, JsonSerializer)`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected abstract void WriteJsonProperties(JsonWriter writer, T value,
                                             JsonSerializer serializer)


```

**Parameters** <br>
`writer` [JsonWriter](/noir/reference//noir/reference//noir/reference//noir/reference/) <br>
`value` [T](/noir/reference//noir/reference//noir/reference//noir/reference/) <br>
`serializer` [JsonSerializer](/noir/reference//noir/reference//noir/reference//noir/reference/) <br>

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
`reader` [JsonReader](/noir/reference//noir/reference//noir/reference//noir/reference/) <br>
 <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
 <br>
`existingValue` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>
`serializer` [JsonSerializer](/noir/reference//noir/reference//noir/reference//noir/reference/) <br>
 <br>

### `WriteJson(JsonWriter, Object, JsonSerializer)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Write the specified properties of the object.


```csharp
public virtual void WriteJson(JsonWriter writer, Object value,
                               JsonSerializer serializer)


```

**Parameters** <br>
`writer` [JsonWriter](/noir/reference//noir/reference//noir/reference//noir/reference/) <br>
 <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>
`serializer` [JsonSerializer](/noir/reference//noir/reference//noir/reference//noir/reference/) <br>
 <br>

