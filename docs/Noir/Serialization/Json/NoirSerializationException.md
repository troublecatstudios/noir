# NoirSerializationException

**Namespace:** Noir.Serialization.Json <br>
**Assembly:** Noir.dll

```csharp
public class NoirSerializationException : JsonSerializationException, ISerializable
```

**Implements:** _[JsonSerializationException](../../../), [ISerializable](https://learn.microsoft.com/en-us/dotnet/api/System.Runtime.Serialization.ISerializable?view=net-7.0)_

### 🛠 Constructors
```csharp
public NoirSerializationException()
```

### 📦 Properties
#### Data
```csharp
public virtual IDictionary Data { get; }
```

**Returns** <br>
[IDictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IDictionary?view=net-7.0) <br>
#### HelpLink
```csharp
public virtual string HelpLink { get; public set; }
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### HResult
```csharp
public int HResult { get; public set; }
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
#### InnerException
```csharp
public Exception InnerException { get; }
```

**Returns** <br>
[Exception](https://learn.microsoft.com/en-us/dotnet/api/System.Exception?view=net-7.0) <br>
#### LineNumber
```csharp
public int LineNumber { get; }
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
#### LinePosition
```csharp
public int LinePosition { get; }
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
#### Message
```csharp
public virtual string Message { get; }
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### Path
```csharp
public string Path { get; }
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### Source
```csharp
public virtual string Source { get; public set; }
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### StackTrace
```csharp
public virtual string StackTrace { get; }
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### TargetSite
```csharp
public MethodBase TargetSite { get; }
```

**Returns** <br>
[MethodBase](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.MethodBase?view=net-7.0) <br>
### ⛹️‍♀️ Methods
#### CreateSerializationException(JsonReader, string, Exception)
```csharp
public NoirSerializationException CreateSerializationException(JsonReader reader, string message, Exception innerException)
```

**Parameters** <br>
`reader` [JsonReader](../../../) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`innerException` [Exception](https://learn.microsoft.com/en-us/dotnet/api/System.Exception?view=net-7.0) <br>

**Returns** <br>
[NoirSerializationException](../../../Noir/Serialization/Json/NoirSerializationException.html) <br>

#### GetType()
```csharp
public Type GetType()
```

**Returns** <br>
[Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

#### GetBaseException()
```csharp
public virtual Exception GetBaseException()
```

**Returns** <br>
[Exception](https://learn.microsoft.com/en-us/dotnet/api/System.Exception?view=net-7.0) <br>

#### ToString()
```csharp
public virtual string ToString()
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### GetObjectData(SerializationInfo, StreamingContext)
```csharp
public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
```

**Parameters** <br>
`info` [SerializationInfo](https://learn.microsoft.com/en-us/dotnet/api/System.Runtime.Serialization.SerializationInfo?view=net-7.0) <br>
`context` [StreamingContext](https://learn.microsoft.com/en-us/dotnet/api/System.Runtime.Serialization.StreamingContext?view=net-7.0) <br>

