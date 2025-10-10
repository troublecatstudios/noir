# UnityTypeContractResolver

<!-- tc:namespace Noir.Serialization.Json -->

<!-- tc:assembly Noir.dll -->


```csharp
public class UnityTypeContractResolver : DefaultContractResolver, IContractResolver
```

**Implements:** _[DefaultContractResolver](/noir/reference//noir/reference//noir/reference/), [IContractResolver](/noir/reference//noir/reference//noir/reference/)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public UnityTypeContractResolver()

```

## Properties

<a name="DefaultMembersSearchFlags"></a>

### `DefaultMembersSearchFlags`
<!-- tc:scope public -->
<!-- tc:return_type BindingFlags https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public BindingFlags DefaultMembersSearchFlags { get; public set; }

```

<a name="DynamicCodeGeneration"></a>

### `DynamicCodeGeneration`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool DynamicCodeGeneration { get; }

```

<a name="IgnoreIsSpecifiedMembers"></a>

### `IgnoreIsSpecifiedMembers`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool IgnoreIsSpecifiedMembers { get; public set; }

```

<a name="IgnoreSerializableAttribute"></a>

### `IgnoreSerializableAttribute`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool IgnoreSerializableAttribute { get; public set; }

```

<a name="IgnoreSerializableInterface"></a>

### `IgnoreSerializableInterface`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool IgnoreSerializableInterface { get; public set; }

```

<a name="IgnoreShouldSerializeMembers"></a>

### `IgnoreShouldSerializeMembers`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool IgnoreShouldSerializeMembers { get; public set; }

```

<a name="NamingStrategy"></a>

### `NamingStrategy`
<!-- tc:scope public -->
<!-- tc:return_type NamingStrategy -->
<!-- tc:version 1.0.0 -->

```csharp
public NamingStrategy NamingStrategy { get; public set; }

```

<a name="SerializeCompilerGeneratedMembers"></a>

### `SerializeCompilerGeneratedMembers`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool SerializeCompilerGeneratedMembers { get; public set; }

```

## Methods

<a name="CreateConstructorParameters"></a>

### `CreateConstructorParameters(ConstructorInfo, JsonPropertyCollection)`
<!-- tc:scope private -->
<!-- tc:return_type IList\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual IList<T> CreateConstructorParameters(ConstructorInfo constructor,
                                                        JsonPropertyCollection memberProperties)


```

**Parameters** <br>
`constructor` [ConstructorInfo](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.ConstructorInfo?view=net-7.0) <br>
`memberProperties` [JsonPropertyCollection](/noir/reference//noir/reference//noir/reference/) <br>

<a name="CreateProperties"></a>

### `CreateProperties(Type, MemberSerialization)`
<!-- tc:scope private -->
<!-- tc:return_type IList\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual IList<T> CreateProperties(Type type,
                                             MemberSerialization memberSerialization)


```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`memberSerialization` [MemberSerialization](/noir/reference//noir/reference//noir/reference/) <br>

<a name="CreateMemberValueProvider"></a>

### `CreateMemberValueProvider(MemberInfo)`
<!-- tc:scope private -->
<!-- tc:return_type IValueProvider -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member)

```

**Parameters** <br>
`member` [MemberInfo](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.MemberInfo?view=net-7.0) <br>

<a name="CreateArrayContract"></a>

### `CreateArrayContract(Type)`
<!-- tc:scope private -->
<!-- tc:return_type JsonArrayContract -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual JsonArrayContract CreateArrayContract(Type objectType)

```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

<a name="CreateContract"></a>

### `CreateContract(Type)`
<!-- tc:scope private -->
<!-- tc:return_type JsonContract -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual JsonContract CreateContract(Type objectType)

```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

<a name="ResolveContractConverter"></a>

### `ResolveContractConverter(Type)`
<!-- tc:scope private -->
<!-- tc:return_type JsonConverter -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual JsonConverter ResolveContractConverter(Type objectType)

```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

<a name="CreateDictionaryContract"></a>

### `CreateDictionaryContract(Type)`
<!-- tc:scope private -->
<!-- tc:return_type JsonDictionaryContract -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType)


```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

<a name="CreateDynamicContract"></a>

### `CreateDynamicContract(Type)`
<!-- tc:scope private -->
<!-- tc:return_type JsonDynamicContract -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual JsonDynamicContract CreateDynamicContract(Type objectType)

```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

<a name="CreateISerializableContract"></a>

### `CreateISerializableContract(Type)`
<!-- tc:scope private -->
<!-- tc:return_type JsonISerializableContract -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual JsonISerializableContract CreateISerializableContract(Type objectType)


```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

<a name="CreateLinqContract"></a>

### `CreateLinqContract(Type)`
<!-- tc:scope private -->
<!-- tc:return_type JsonLinqContract -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual JsonLinqContract CreateLinqContract(Type objectType)

```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

<a name="CreateObjectContract"></a>

### `CreateObjectContract(Type)`
<!-- tc:scope private -->
<!-- tc:return_type JsonObjectContract -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual JsonObjectContract CreateObjectContract(Type objectType)

```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

<a name="CreatePrimitiveContract"></a>

### `CreatePrimitiveContract(Type)`
<!-- tc:scope private -->
<!-- tc:return_type JsonPrimitiveContract -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType)

```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

<a name="CreateProperty"></a>

### `CreateProperty(MemberInfo, MemberSerialization)`
<!-- tc:scope private -->
<!-- tc:return_type JsonProperty -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual JsonProperty CreateProperty(MemberInfo member,
                                               MemberSerialization memberSerialization)


```

**Parameters** <br>
`member` [MemberInfo](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.MemberInfo?view=net-7.0) <br>
`memberSerialization` [MemberSerialization](/noir/reference//noir/reference//noir/reference/) <br>

<a name="CreatePropertyFromConstructorParameter"></a>

### `CreatePropertyFromConstructorParameter(JsonProperty, ParameterInfo)`
<!-- tc:scope private -->
<!-- tc:return_type JsonProperty -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty,
                                                                       ParameterInfo parameterInfo)


```

**Parameters** <br>
`matchingMemberProperty` [JsonProperty](/noir/reference//noir/reference//noir/reference/) <br>
`parameterInfo` [ParameterInfo](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.ParameterInfo?view=net-7.0) <br>

<a name="CreateStringContract"></a>

### `CreateStringContract(Type)`
<!-- tc:scope private -->
<!-- tc:return_type JsonStringContract -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual JsonStringContract CreateStringContract(Type objectType)

```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

<a name="GetSerializableMembers"></a>

### `GetSerializableMembers(Type)`
<!-- tc:scope private -->
<!-- tc:return_type List\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual List<T> GetSerializableMembers(Type objectType)

```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

<a name="ResolveDictionaryKey"></a>

### `ResolveDictionaryKey(string)`
<!-- tc:scope private -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual string ResolveDictionaryKey(string dictionaryKey)

```

**Parameters** <br>
`dictionaryKey` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="ResolveExtensionDataName"></a>

### `ResolveExtensionDataName(string)`
<!-- tc:scope private -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual string ResolveExtensionDataName(string extensionDataName)

```

**Parameters** <br>
`extensionDataName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="ResolvePropertyName"></a>

### `ResolvePropertyName(string)`
<!-- tc:scope private -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual string ResolvePropertyName(string propertyName)

```

**Parameters** <br>
`propertyName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="GetResolvedPropertyName"></a>

### `GetResolvedPropertyName(string)`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string GetResolvedPropertyName(string propertyName)

```

**Parameters** <br>
`propertyName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="ResolveContract"></a>

### `ResolveContract(Type)`
<!-- tc:scope public -->
<!-- tc:return_type JsonContract -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual JsonContract ResolveContract(Type type)

```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

