# Vector3Converter

**Namespace:** Noir.Serialization.Json.Converters <br>
**Assembly:** Noir.dll

```csharp
public class Vector3Converter : PartialConverter<T>
```

**Implements:** _[PartialConverter\<T\>](../../../../Noir/Serialization/Json/Converters/PartialConverter-1.html)_

### 🛠 Constructors
```csharp
public Vector3Converter()
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
#### ReadValue(Vector3&, string, JsonReader, JsonSerializer)
```csharp
protected virtual void ReadValue(Vector3& value, string name, JsonReader reader, JsonSerializer serializer)
```

**Parameters** <br>
`value` [Vector3&](../../../../) <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`reader` [JsonReader](../../../../) <br>
`serializer` [JsonSerializer](../../../../) <br>

#### WriteJsonProperties(JsonWriter, Vector3, JsonSerializer)
```csharp
protected virtual void WriteJsonProperties(JsonWriter writer, Vector3 value, JsonSerializer serializer)
```

**Parameters** <br>
`writer` [JsonWriter](../../../../) <br>
`value` [Vector3](../../../../) <br>
`serializer` [JsonSerializer](../../../../) <br>

#### CanConvert(Type)
```csharp
public virtual bool CanConvert(Type objectType)
```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### ReadJson(JsonReader, Type, Object, JsonSerializer)
```csharp
public virtual Object ReadJson(JsonReader reader, Type objectType, Object existingValue, JsonSerializer serializer)
```

**Parameters** <br>
`reader` [JsonReader](../../../../) <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`existingValue` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`serializer` [JsonSerializer](../../../../) <br>

**Returns** <br>
[Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

#### WriteJson(JsonWriter, Object, JsonSerializer)
```csharp
public virtual void WriteJson(JsonWriter writer, Object value, JsonSerializer serializer)
```

**Parameters** <br>
`writer` [JsonWriter](../../../../) <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`serializer` [JsonSerializer](../../../../) <br>

