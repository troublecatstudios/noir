# Reflector

<!-- tc:namespace NoirEditor.Reflection -->

<!-- tc:assembly NoirEditor.dll -->


```csharp
public static class Reflector
```

## Properties

### `DefaultFlags`
<!-- tc:scope private -->
<!-- tc:return_type BindingFlags https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public static const BindingFlags DefaultFlags;

```

## Methods

### `IsDecoratedWithAttribute(Type)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public bool IsDecoratedWithAttribute(Type type)

```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

### `IsListType(Type, bool, out Type&)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public bool IsListType(Type tp, bool ignoreAsInterface, Type& innerType)

```

**Parameters** <br>
`tp` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`ignoreAsInterface` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`innerType` [Type&](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

### `IsListType(Type, bool)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public bool IsListType(Type tp, bool ignoreAsInterface)

```

**Parameters** <br>
`tp` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`ignoreAsInterface` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

### `IsListType(Type, out Type&)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public bool IsListType(Type tp, Type& innerType)

```

**Parameters** <br>
`tp` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`innerType` [Type&](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

### `IsListType(Type)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public bool IsListType(Type tp)

```

**Parameters** <br>
`tp` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

### `IsType(Type, Type)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public bool IsType(Type tp, Type assignableType)

```

**Parameters** <br>
`tp` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`assignableType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

### `IsType(Type, Type[])`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public bool IsType(Type tp, Type[] assignableTypes)

```

**Parameters** <br>
`tp` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`assignableTypes` [Type[]](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

### `SetValue(SerializedProperty, T)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public bool SetValue(SerializedProperty property, T value)

```

**Parameters** <br>
`property` [SerializedProperty](https://docs.unity3d.com/ScriptReference/SerializedProperty.html) <br>
`value` [T](/noir/reference//noir/reference/) <br>

### `GetField(Object, string)`
<!-- tc:scope public -->
<!-- tc:return_type FieldInfo https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public FieldInfo GetField(Object target, string fieldName)

```

**Parameters** <br>
`target` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`fieldName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `GetField(Type, string)`
<!-- tc:scope public -->
<!-- tc:return_type FieldInfo https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public FieldInfo GetField(Type type, string fieldName)

```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`fieldName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `GetAllFields(Object, Func<T, TResult>)`
<!-- tc:scope public -->
<!-- tc:return_type IEnumerable\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public IEnumerable<T> GetAllFields(Object target, Func<T, TResult> predicate)

```

**Parameters** <br>
`target` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`predicate` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>

### `GetAllFields(Object)`
<!-- tc:scope public -->
<!-- tc:return_type IEnumerable\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public IEnumerable<T> GetAllFields(Object target)

```

**Parameters** <br>
`target` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

### `GetAllFields(Type, Func<T, TResult>)`
<!-- tc:scope public -->
<!-- tc:return_type IEnumerable\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public IEnumerable<T> GetAllFields(Type type, Func<T, TResult> predicate)

```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`predicate` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>

### `GetAllFields(Type)`
<!-- tc:scope public -->
<!-- tc:return_type IEnumerable\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public IEnumerable<T> GetAllFields(Type type)

```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

### `GetAllMethods(Object, Func<T, TResult>)`
<!-- tc:scope public -->
<!-- tc:return_type IEnumerable\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public IEnumerable<T> GetAllMethods(Object target, Func<T, TResult> predicate)

```

**Parameters** <br>
`target` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`predicate` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>

### `GetAllProperties(Object, Func<T, TResult>, BindingFlags)`
<!-- tc:scope public -->
<!-- tc:return_type IEnumerable\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public IEnumerable<T> GetAllProperties(Object target, Func<T, TResult> predicate,
                                        BindingFlags flags)


```

**Parameters** <br>
`target` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`predicate` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>
`flags` [BindingFlags](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags?view=net-7.0) <br>

### `GetTypes(Func<T, TResult>)`
<!-- tc:scope public -->
<!-- tc:return_type IEnumerable\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public IEnumerable<T> GetTypes(Func<T, TResult> predicate)

```

**Parameters** <br>
`predicate` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>

### `GetTypesAssignableFrom(Assembly, Type)`
<!-- tc:scope public -->
<!-- tc:return_type IEnumerable\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public IEnumerable<T> GetTypesAssignableFrom(Assembly assemb, Type rootType)

```

**Parameters** <br>
`assemb` [Assembly](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly?view=net-7.0) <br>
`rootType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

### `GetTypesAssignableFrom(Type)`
<!-- tc:scope public -->
<!-- tc:return_type IEnumerable\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public IEnumerable<T> GetTypesAssignableFrom(Type rootType)

```

**Parameters** <br>
`rootType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

### `GetTypesInAppDomain()`
<!-- tc:scope public -->
<!-- tc:return_type IEnumerable\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public IEnumerable<T> GetTypesInAppDomain()

```

### `GetMethod(Object, string)`
<!-- tc:scope public -->
<!-- tc:return_type MethodInfo https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public MethodInfo GetMethod(Object target, string methodName)

```

**Parameters** <br>
`target` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `GetPropertyValue(Object, string, BindingFlags)`
<!-- tc:scope public -->
<!-- tc:return_type Object https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public Object GetPropertyValue(Object obj, string name, BindingFlags flags)

```

**Parameters** <br>
`obj` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`flags` [BindingFlags](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags?view=net-7.0) <br>

### `GetTargetObject(SerializedProperty)`
<!-- tc:scope public -->
<!-- tc:return_type Object https://docs.unity3d.com/ScriptReference/Object.html -->
<!-- tc:version 0.0.0 -->

```csharp
public Object GetTargetObject(SerializedProperty property)

```

**Parameters** <br>
`property` [SerializedProperty](https://docs.unity3d.com/ScriptReference/SerializedProperty.html) <br>

### `GetTargetObjectOfProperty(SerializedProperty)`
<!-- tc:scope public -->
<!-- tc:return_type Object https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0 -->
<!-- tc:version 0.0.0 -->
Gets the object the property represents.


```csharp
public Object GetTargetObjectOfProperty(SerializedProperty property)

```

**Parameters** <br>
`property` [SerializedProperty](https://docs.unity3d.com/ScriptReference/SerializedProperty.html) <br>
 <br>

### `GetProperty(Object, string, BindingFlags)`
<!-- tc:scope public -->
<!-- tc:return_type PropertyInfo https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public PropertyInfo GetProperty(Object target, string propertyName,
                                 BindingFlags flags)


```

**Parameters** <br>
`target` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`propertyName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`flags` [BindingFlags](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags?view=net-7.0) <br>

### `ToLogString(Type)`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public string ToLogString(Type type)

```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

### `GetAttribute(SerializedProperty)`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 0.0.0 -->

```csharp
public T GetAttribute(SerializedProperty property)

```

**Parameters** <br>
`property` [SerializedProperty](https://docs.unity3d.com/ScriptReference/SerializedProperty.html) <br>

### `GetPropertyValue(Object, string, BindingFlags)`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 0.0.0 -->

```csharp
public T GetPropertyValue(Object obj, string name, BindingFlags flags)

```

**Parameters** <br>
`obj` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`flags` [BindingFlags](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags?view=net-7.0) <br>

### `GetValue(SerializedProperty)`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 0.0.0 -->

```csharp
public T GetValue(SerializedProperty property)

```

**Parameters** <br>
`property` [SerializedProperty](https://docs.unity3d.com/ScriptReference/SerializedProperty.html) <br>

### `GetAttributes(SerializedProperty)`
<!-- tc:scope public -->
<!-- tc:return_type T[] -->
<!-- tc:version 0.0.0 -->

```csharp
public T[] GetAttributes(SerializedProperty property)

```

**Parameters** <br>
`property` [SerializedProperty](https://docs.unity3d.com/ScriptReference/SerializedProperty.html) <br>

### `FindType(string, bool, bool)`
<!-- tc:scope public -->
<!-- tc:return_type Type https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public Type FindType(string typeName, bool useFullName, bool ignoreCase)

```

**Parameters** <br>
`typeName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`useFullName` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`ignoreCase` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

### `FindType(string, Type, bool, bool)`
<!-- tc:scope public -->
<!-- tc:return_type Type https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public Type FindType(string typeName, Type baseType, bool useFullName,
                      bool ignoreCase)


```

**Parameters** <br>
`typeName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`baseType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`useFullName` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`ignoreCase` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

### `GetElementTypeOfListType(Type)`
<!-- tc:scope public -->
<!-- tc:return_type Type https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public Type GetElementTypeOfListType(Type tp)

```

**Parameters** <br>
`tp` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

### `ParseType(string, string)`
<!-- tc:scope public -->
<!-- tc:return_type Type https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public Type ParseType(string assembName, string typeName)

```

**Parameters** <br>
`assembName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`typeName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `GetTypesWithAttribute()`
<!-- tc:scope public -->
<!-- tc:return_type ValueTuple\<T1, T2\>[] https://learn.microsoft.com/en-us/dotnet/api/System.ValueTuple-2?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public ValueTuple`2[] GetTypesWithAttribute()

```

### `GetVectorValue(SerializedProperty)`
<!-- tc:scope public -->
<!-- tc:return_type Vector3 https://docs.unity3d.com/ScriptReference/Vector3.html -->
<!-- tc:version 0.0.0 -->

```csharp
public Vector3 GetVectorValue(SerializedProperty property)

```

**Parameters** <br>
`property` [SerializedProperty](https://docs.unity3d.com/ScriptReference/SerializedProperty.html) <br>

### `SetVectorValue(SerializedProperty, float, float, float)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void SetVectorValue(SerializedProperty property, float x, float y,
                            float z)


```

**Parameters** <br>
`property` [SerializedProperty](https://docs.unity3d.com/ScriptReference/SerializedProperty.html) <br>
`x` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`y` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`z` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

