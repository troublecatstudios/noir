# Vector2Converter

<!-- tc:namespace Noir.Serialization.Json.Converters -->

<!-- tc:assembly Noir.dll -->


```csharp
public class Vector2Converter : PartialConverter<T>
```

**Implements:** _[PartialConverter\<T\>](/noir/reference//noir/reference//noir/reference//noir/reference/Noir/Serialization/Json/Converters/PartialConverter-1/)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public Vector2Converter()

```

## Properties

<a name="CanRead"></a>

### `CanRead`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool CanRead { get; }

```

<a name="CanWrite"></a>

### `CanWrite`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool CanWrite { get; }

```

## Methods

<a name="ReadValue"></a>

### `ReadValue(Vector2&, string, JsonReader, JsonSerializer)`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual void ReadValue(Vector2& value, string name, JsonReader reader,
                                  JsonSerializer serializer)


```

**Parameters** <br>
`value` [Vector2&](https://docs.unity3d.com/ScriptReference/Vector2.html) <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`reader` [JsonReader](/noir/reference//noir/reference//noir/reference//noir/reference/) <br>
`serializer` [JsonSerializer](/noir/reference//noir/reference//noir/reference//noir/reference/) <br>

<a name="WriteJsonProperties"></a>

### `WriteJsonProperties(JsonWriter, Vector2, JsonSerializer)`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual void WriteJsonProperties(JsonWriter writer, Vector2 value,
                                            JsonSerializer serializer)


```

**Parameters** <br>
`writer` [JsonWriter](/noir/reference//noir/reference//noir/reference//noir/reference/) <br>
`value` [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) <br>
`serializer` [JsonSerializer](/noir/reference//noir/reference//noir/reference//noir/reference/) <br>

<a name="CanConvert"></a>

### `CanConvert(Type)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool CanConvert(Type objectType)

```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

<a name="ReadJson"></a>

### `ReadJson(JsonReader, Type, Object, JsonSerializer)`
<!-- tc:scope public -->
<!-- tc:return_type Object https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual Object ReadJson(JsonReader reader, Type objectType,
                                Object existingValue, JsonSerializer serializer)


```

**Parameters** <br>
`reader` [JsonReader](/noir/reference//noir/reference//noir/reference//noir/reference/) <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`existingValue` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`serializer` [JsonSerializer](/noir/reference//noir/reference//noir/reference//noir/reference/) <br>

<a name="WriteJson"></a>

### `WriteJson(JsonWriter, Object, JsonSerializer)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void WriteJson(JsonWriter writer, Object value,
                               JsonSerializer serializer)


```

**Parameters** <br>
`writer` [JsonWriter](/noir/reference//noir/reference//noir/reference//noir/reference/) <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`serializer` [JsonSerializer](/noir/reference//noir/reference//noir/reference//noir/reference/) <br>

