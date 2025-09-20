# NoirSerializationException

<!-- tc:namespace Noir.Serialization.Json -->

<!-- tc:assembly Noir.dll -->


```csharp
public class NoirSerializationException : JsonSerializationException, ISerializable
```

**Implements:** _[JsonSerializationException](/noir/reference/), [ISerializable](https://learn.microsoft.com/en-us/dotnet/api/System.Runtime.Serialization.ISerializable?view=net-7.0)_

## 🛠 Constructors

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public NoirSerializationException()
```

## 📦 Properties

### `Data`
<!-- tc:scope public -->
<!-- tc:return_type IDictionary https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IDictionary?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual IDictionary Data { get; }
```

### `HelpLink`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual string HelpLink { get; public set; }
```

### `HResult`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int HResult { get; public set; }
```

### `InnerException`
<!-- tc:scope public -->
<!-- tc:return_type Exception https://learn.microsoft.com/en-us/dotnet/api/System.Exception?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public Exception InnerException { get; }
```

### `LineNumber`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int LineNumber { get; }
```

### `LinePosition`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int LinePosition { get; }
```

### `Message`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual string Message { get; }
```

### `Path`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string Path { get; }
```

### `Source`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual string Source { get; public set; }
```

### `StackTrace`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual string StackTrace { get; }
```

### `TargetSite`
<!-- tc:scope public -->
<!-- tc:return_type MethodBase https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.MethodBase?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public MethodBase TargetSite { get; }
```

## ⛹️‍♀️ Methods

### `CreateSerializationException(JsonReader, string, Exception)`
<!-- tc:scope public -->
<!-- tc:return_type NoirSerializationException /noir/reference/Noir/Serialization/Json/NoirSerializationException/ -->
<!-- tc:version 1.0.0 -->

```csharp
public NoirSerializationException CreateSerializationException(JsonReader reader, string message, Exception innerException)
```

**Parameters** <br>
`reader` [JsonReader](/noir/reference/) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`innerException` [Exception](https://learn.microsoft.com/en-us/dotnet/api/System.Exception?view=net-7.0) <br>

### `GetType()`
<!-- tc:scope public -->
<!-- tc:return_type Type https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public Type GetType()
```

### `GetBaseException()`
<!-- tc:scope public -->
<!-- tc:return_type Exception https://learn.microsoft.com/en-us/dotnet/api/System.Exception?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual Exception GetBaseException()
```

### `ToString()`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual string ToString()
```

### `GetObjectData(SerializationInfo, StreamingContext)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
```

**Parameters** <br>
`info` [SerializationInfo](https://learn.microsoft.com/en-us/dotnet/api/System.Runtime.Serialization.SerializationInfo?view=net-7.0) <br>
`context` [StreamingContext](https://learn.microsoft.com/en-us/dotnet/api/System.Runtime.Serialization.StreamingContext?view=net-7.0) <br>

