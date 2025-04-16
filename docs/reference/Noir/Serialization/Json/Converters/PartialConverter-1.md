# PartialConverter\<T\>

**Namespace:** Noir.Serialization.Json.Converters <br>
**Assembly:** Noir.dll

```csharp
public abstract class PartialConverter<T> : JsonConverter
```

**Implements:** _[JsonConverter](../../../../)_

### 🛠 Constructors
```csharp
protected PartialConverter<T>()
```

### 📦 Properties
#### CanRead
```csharp
public virtual bool CanRead { get; }
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### CanWrite
```csharp
public virtual bool CanWrite { get; }
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
### ⛹️‍♀️ Methods
#### ReadValue(T&, string, JsonReader, JsonSerializer)
```csharp
protected abstract void ReadValue(T& value, string name, JsonReader reader, JsonSerializer serializer)
```

**Parameters** <br>
`value` [T&](../../../../) <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`reader` [JsonReader](../../../../) <br>
`serializer` [JsonSerializer](../../../../) <br>

#### WriteJsonProperties(JsonWriter, T, JsonSerializer)
```csharp
protected abstract void WriteJsonProperties(JsonWriter writer, T value, JsonSerializer serializer)
```

**Parameters** <br>
`writer` [JsonWriter](../../../../) <br>
`value` [T](../../../../) <br>
`serializer` [JsonSerializer](../../../../) <br>

#### CanConvert(Type)
```csharp
public virtual bool CanConvert(Type objectType)
```

Determine if the object type is <typeparamref name="T" />

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
 <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

#### ReadJson(JsonReader, Type, Object, JsonSerializer)
```csharp
public virtual Object ReadJson(JsonReader reader, Type objectType, Object existingValue, JsonSerializer serializer)
```

Read the specified properties to the object.

**Parameters** <br>
`reader` [JsonReader](../../../../) <br>
 <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
 <br>
`existingValue` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>
`serializer` [JsonSerializer](../../../../) <br>
 <br>

**Returns** <br>
[Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>

#### WriteJson(JsonWriter, Object, JsonSerializer)
```csharp
public virtual void WriteJson(JsonWriter writer, Object value, JsonSerializer serializer)
```

Write the specified properties of the object.

**Parameters** <br>
`writer` [JsonWriter](../../../../) <br>
 <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>
`serializer` [JsonSerializer](../../../../) <br>
 <br>

