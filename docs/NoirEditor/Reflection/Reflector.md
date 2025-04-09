# Reflector

**Namespace:** NoirEditor.Reflection <br>
**Assembly:** NoirEditor.dll

```csharp
public static class Reflector
```

### 📦 Properties
#### DefaultFlags
```csharp
public static const BindingFlags DefaultFlags;
```

**Returns** <br>
[BindingFlags](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags?view=net-7.0) <br>
### ⛹️‍♀️ Methods
#### IsDecoratedWithAttribute(Type)
```csharp
public bool IsDecoratedWithAttribute(Type type)
```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### IsListType(Type, bool, out Type&)
```csharp
public bool IsListType(Type tp, bool ignoreAsInterface, Type& innerType)
```

**Parameters** <br>
`tp` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`ignoreAsInterface` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`innerType` [Type&](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### IsListType(Type, bool)
```csharp
public bool IsListType(Type tp, bool ignoreAsInterface)
```

**Parameters** <br>
`tp` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`ignoreAsInterface` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### IsListType(Type, out Type&)
```csharp
public bool IsListType(Type tp, Type& innerType)
```

**Parameters** <br>
`tp` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`innerType` [Type&](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### IsListType(Type)
```csharp
public bool IsListType(Type tp)
```

**Parameters** <br>
`tp` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### IsType(Type, Type)
```csharp
public bool IsType(Type tp, Type assignableType)
```

**Parameters** <br>
`tp` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`assignableType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### IsType(Type, Type[])
```csharp
public bool IsType(Type tp, Type[] assignableTypes)
```

**Parameters** <br>
`tp` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`assignableTypes` [Type[]](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### SetValue(SerializedProperty, T)
```csharp
public bool SetValue(SerializedProperty property, T value)
```

**Parameters** <br>
`property` [SerializedProperty](../../) <br>
`value` [T](../../) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### GetField(Object, string)
```csharp
public FieldInfo GetField(Object target, string fieldName)
```

**Parameters** <br>
`target` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`fieldName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[FieldInfo](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo?view=net-7.0) <br>

#### GetField(Type, string)
```csharp
public FieldInfo GetField(Type type, string fieldName)
```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`fieldName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[FieldInfo](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo?view=net-7.0) <br>

#### GetAllFields(Object, Func<T, TResult>)
```csharp
public IEnumerable<T> GetAllFields(Object target, Func<T, TResult> predicate)
```

**Parameters** <br>
`target` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`predicate` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>

**Returns** <br>
[IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>

#### GetAllFields(Object)
```csharp
public IEnumerable<T> GetAllFields(Object target)
```

**Parameters** <br>
`target` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

**Returns** <br>
[IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>

#### GetAllFields(Type, Func<T, TResult>)
```csharp
public IEnumerable<T> GetAllFields(Type type, Func<T, TResult> predicate)
```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`predicate` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>

**Returns** <br>
[IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>

#### GetAllFields(Type)
```csharp
public IEnumerable<T> GetAllFields(Type type)
```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>

#### GetAllMethods(Object, Func<T, TResult>)
```csharp
public IEnumerable<T> GetAllMethods(Object target, Func<T, TResult> predicate)
```

**Parameters** <br>
`target` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`predicate` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>

**Returns** <br>
[IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>

#### GetAllProperties(Object, Func<T, TResult>, BindingFlags)
```csharp
public IEnumerable<T> GetAllProperties(Object target, Func<T, TResult> predicate, BindingFlags flags)
```

**Parameters** <br>
`target` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`predicate` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>
`flags` [BindingFlags](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags?view=net-7.0) <br>

**Returns** <br>
[IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>

#### GetTypes(Func<T, TResult>)
```csharp
public IEnumerable<T> GetTypes(Func<T, TResult> predicate)
```

**Parameters** <br>
`predicate` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>

**Returns** <br>
[IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>

#### GetTypesAssignableFrom(Assembly, Type)
```csharp
public IEnumerable<T> GetTypesAssignableFrom(Assembly assemb, Type rootType)
```

**Parameters** <br>
`assemb` [Assembly](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly?view=net-7.0) <br>
`rootType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>

#### GetTypesAssignableFrom(Type)
```csharp
public IEnumerable<T> GetTypesAssignableFrom(Type rootType)
```

**Parameters** <br>
`rootType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>

#### GetTypesInAppDomain()
```csharp
public IEnumerable<T> GetTypesInAppDomain()
```

**Returns** <br>
[IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>

#### GetMethod(Object, string)
```csharp
public MethodInfo GetMethod(Object target, string methodName)
```

**Parameters** <br>
`target` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[MethodInfo](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo?view=net-7.0) <br>

#### GetPropertyValue(Object, string, BindingFlags)
```csharp
public Object GetPropertyValue(Object obj, string name, BindingFlags flags)
```

**Parameters** <br>
`obj` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`flags` [BindingFlags](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags?view=net-7.0) <br>

**Returns** <br>
[Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

#### GetTargetObject(SerializedProperty)
```csharp
public Object GetTargetObject(SerializedProperty property)
```

**Parameters** <br>
`property` [SerializedProperty](../../) <br>

**Returns** <br>
[Object](../../) <br>

#### GetTargetObjectOfProperty(SerializedProperty)
```csharp
public Object GetTargetObjectOfProperty(SerializedProperty property)
```

Gets the object the property represents.

**Parameters** <br>
`property` [SerializedProperty](../../) <br>
 <br>

**Returns** <br>
[Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>

#### GetProperty(Object, string, BindingFlags)
```csharp
public PropertyInfo GetProperty(Object target, string propertyName, BindingFlags flags)
```

**Parameters** <br>
`target` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`propertyName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`flags` [BindingFlags](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags?view=net-7.0) <br>

**Returns** <br>
[PropertyInfo](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo?view=net-7.0) <br>

#### ToLogString(Type)
```csharp
public string ToLogString(Type type)
```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### GetAttribute(SerializedProperty)
```csharp
public T GetAttribute(SerializedProperty property)
```

**Parameters** <br>
`property` [SerializedProperty](../../) <br>

**Returns** <br>
[T](../../) <br>

#### GetPropertyValue(Object, string, BindingFlags)
```csharp
public T GetPropertyValue(Object obj, string name, BindingFlags flags)
```

**Parameters** <br>
`obj` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`flags` [BindingFlags](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags?view=net-7.0) <br>

**Returns** <br>
[T](../../) <br>

#### GetValue(SerializedProperty)
```csharp
public T GetValue(SerializedProperty property)
```

**Parameters** <br>
`property` [SerializedProperty](../../) <br>

**Returns** <br>
[T](../../) <br>

#### GetAttributes(SerializedProperty)
```csharp
public T[] GetAttributes(SerializedProperty property)
```

**Parameters** <br>
`property` [SerializedProperty](../../) <br>

**Returns** <br>
[T[]](../../) <br>

#### FindType(string, bool, bool)
```csharp
public Type FindType(string typeName, bool useFullName, bool ignoreCase)
```

**Parameters** <br>
`typeName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`useFullName` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`ignoreCase` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

**Returns** <br>
[Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

#### FindType(string, Type, bool, bool)
```csharp
public Type FindType(string typeName, Type baseType, bool useFullName, bool ignoreCase)
```

**Parameters** <br>
`typeName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`baseType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`useFullName` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`ignoreCase` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

**Returns** <br>
[Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

#### GetElementTypeOfListType(Type)
```csharp
public Type GetElementTypeOfListType(Type tp)
```

**Parameters** <br>
`tp` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

#### ParseType(string, string)
```csharp
public Type ParseType(string assembName, string typeName)
```

**Parameters** <br>
`assembName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`typeName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

#### GetTypesWithAttribute()
```csharp
public ValueTuple`2[] GetTypesWithAttribute()
```

**Returns** <br>
[ValueTuple\<T1, T2\>[]](https://learn.microsoft.com/en-us/dotnet/api/System.ValueTuple-2?view=net-7.0) <br>

#### GetVectorValue(SerializedProperty)
```csharp
public Vector3 GetVectorValue(SerializedProperty property)
```

**Parameters** <br>
`property` [SerializedProperty](../../) <br>

**Returns** <br>
[Vector3](../../) <br>

#### SetVectorValue(SerializedProperty, float, float, float)
```csharp
public void SetVectorValue(SerializedProperty property, float x, float y, float z)
```

**Parameters** <br>
`property` [SerializedProperty](../../) <br>
`x` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`y` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`z` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

