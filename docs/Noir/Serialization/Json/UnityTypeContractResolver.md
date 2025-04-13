# UnityTypeContractResolver

**Namespace:** Noir.Serialization.Json <br>
**Assembly:** Noir.dll

```csharp
public class UnityTypeContractResolver : DefaultContractResolver, IContractResolver
```

**Implements:** _[DefaultContractResolver](../../../), [IContractResolver](../../../)_

### 🛠 Constructors
```csharp
public UnityTypeContractResolver()
```

### 📦 Properties
#### DefaultMembersSearchFlags
```csharp
public BindingFlags DefaultMembersSearchFlags { get; public set; }
```

**Returns** <br>
[BindingFlags](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags?view=net-7.0) <br>
#### DynamicCodeGeneration
```csharp
public bool DynamicCodeGeneration { get; }
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### IgnoreIsSpecifiedMembers
```csharp
public bool IgnoreIsSpecifiedMembers { get; public set; }
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### IgnoreSerializableAttribute
```csharp
public bool IgnoreSerializableAttribute { get; public set; }
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### IgnoreSerializableInterface
```csharp
public bool IgnoreSerializableInterface { get; public set; }
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### IgnoreShouldSerializeMembers
```csharp
public bool IgnoreShouldSerializeMembers { get; public set; }
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### NamingStrategy
```csharp
public NamingStrategy NamingStrategy { get; public set; }
```

**Returns** <br>
[NamingStrategy](../../../) <br>
#### SerializeCompilerGeneratedMembers
```csharp
public bool SerializeCompilerGeneratedMembers { get; public set; }
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
### ⛹️‍♀️ Methods
#### CreateConstructorParameters(ConstructorInfo, JsonPropertyCollection)
```csharp
protected virtual IList<T> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties)
```

**Parameters** <br>
`constructor` [ConstructorInfo](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.ConstructorInfo?view=net-7.0) <br>
`memberProperties` [JsonPropertyCollection](../../../) <br>

**Returns** <br>
[IList\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=net-7.0) <br>

#### CreateProperties(Type, MemberSerialization)
```csharp
protected virtual IList<T> CreateProperties(Type type, MemberSerialization memberSerialization)
```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`memberSerialization` [MemberSerialization](../../../) <br>

**Returns** <br>
[IList\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=net-7.0) <br>

#### CreateMemberValueProvider(MemberInfo)
```csharp
protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member)
```

**Parameters** <br>
`member` [MemberInfo](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.MemberInfo?view=net-7.0) <br>

**Returns** <br>
[IValueProvider](../../../) <br>

#### CreateArrayContract(Type)
```csharp
protected virtual JsonArrayContract CreateArrayContract(Type objectType)
```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[JsonArrayContract](../../../) <br>

#### CreateContract(Type)
```csharp
protected virtual JsonContract CreateContract(Type objectType)
```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[JsonContract](../../../) <br>

#### ResolveContractConverter(Type)
```csharp
protected virtual JsonConverter ResolveContractConverter(Type objectType)
```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[JsonConverter](../../../) <br>

#### CreateDictionaryContract(Type)
```csharp
protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType)
```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[JsonDictionaryContract](../../../) <br>

#### CreateDynamicContract(Type)
```csharp
protected virtual JsonDynamicContract CreateDynamicContract(Type objectType)
```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[JsonDynamicContract](../../../) <br>

#### CreateISerializableContract(Type)
```csharp
protected virtual JsonISerializableContract CreateISerializableContract(Type objectType)
```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[JsonISerializableContract](../../../) <br>

#### CreateLinqContract(Type)
```csharp
protected virtual JsonLinqContract CreateLinqContract(Type objectType)
```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[JsonLinqContract](../../../) <br>

#### CreateObjectContract(Type)
```csharp
protected virtual JsonObjectContract CreateObjectContract(Type objectType)
```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[JsonObjectContract](../../../) <br>

#### CreatePrimitiveContract(Type)
```csharp
protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType)
```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[JsonPrimitiveContract](../../../) <br>

#### CreateProperty(MemberInfo, MemberSerialization)
```csharp
protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
```

**Parameters** <br>
`member` [MemberInfo](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.MemberInfo?view=net-7.0) <br>
`memberSerialization` [MemberSerialization](../../../) <br>

**Returns** <br>
[JsonProperty](../../../) <br>

#### CreatePropertyFromConstructorParameter(JsonProperty, ParameterInfo)
```csharp
protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo)
```

**Parameters** <br>
`matchingMemberProperty` [JsonProperty](../../../) <br>
`parameterInfo` [ParameterInfo](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.ParameterInfo?view=net-7.0) <br>

**Returns** <br>
[JsonProperty](../../../) <br>

#### CreateStringContract(Type)
```csharp
protected virtual JsonStringContract CreateStringContract(Type objectType)
```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[JsonStringContract](../../../) <br>

#### GetSerializableMembers(Type)
```csharp
protected virtual List<T> GetSerializableMembers(Type objectType)
```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>

#### ResolveDictionaryKey(string)
```csharp
protected virtual string ResolveDictionaryKey(string dictionaryKey)
```

**Parameters** <br>
`dictionaryKey` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### ResolveExtensionDataName(string)
```csharp
protected virtual string ResolveExtensionDataName(string extensionDataName)
```

**Parameters** <br>
`extensionDataName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### ResolvePropertyName(string)
```csharp
protected virtual string ResolvePropertyName(string propertyName)
```

**Parameters** <br>
`propertyName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### GetResolvedPropertyName(string)
```csharp
public string GetResolvedPropertyName(string propertyName)
```

**Parameters** <br>
`propertyName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### ResolveContract(Type)
```csharp
public virtual JsonContract ResolveContract(Type type)
```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[JsonContract](../../../) <br>

