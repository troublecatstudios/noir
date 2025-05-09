# AssetDB

<!-- tc:namespace NoirEditor -->
<!-- tc:assembly NoirEditor.dll -->

Useful utility methods for interacting with the Unity AssetDatabase.


```csharp
public static class AssetDB
```

## Methods

### `Mkdirp(string)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 0.0.0 -->
Walks a directory path ensuring each directory exists.


```csharp
public bool Mkdirp(string path)
```

**Parameters** <br>
`path` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

### `TryGetReferencesToObject(Object, out IEnumerable`1&)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public bool TryGetReferencesToObject(Object asset, IEnumerable`1& assetPaths)
```

**Parameters** <br>
`asset` [Object](https://docs.unity3d.com/ScriptReference/Object.html) <br>
`assetPaths` [IEnumerable\<T\>&](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>

### `Load(Func<T, TResult>, String[])`
<!-- tc:scope public -->
<!-- tc:return_type List\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public List<T> Load(Func<T, TResult> filter, String[] searchPaths)
```

**Parameters** <br>
`filter` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>
`searchPaths` [string[]](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `Load(string, Func<T, TResult>, String[])`
<!-- tc:scope public -->
<!-- tc:return_type List\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0 -->
<!-- tc:version 0.0.0 -->
Loads all assets from the [AssetDatabase](https://docs.unity3d.com/ScriptReference/AssetDatabase.html) that match the given type paramter.


```csharp
public List<T> Load(string query, Func<T, TResult> filter, String[] searchPaths)
```

**Parameters** <br>
`query` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`filter` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>
`searchPaths` [string[]](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

### `Load(Type, Func<T, TResult>, String[])`
<!-- tc:scope public -->
<!-- tc:return_type List\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0 -->
<!-- tc:version 0.0.0 -->
Loads all assets from the [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0).


```csharp
public List<T> Load(Type type, Func<T, TResult> criteria, String[] searchPaths)
```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
 <br>
`criteria` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>
 <br>
`searchPaths` [string[]](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

### `LoadSingle(Type, Func<T, TResult>, String[])`
<!-- tc:scope public -->
<!-- tc:return_type Object https://docs.unity3d.com/ScriptReference/Object.html -->
<!-- tc:version 0.0.0 -->

```csharp
public Object LoadSingle(Type objectType, Func<T, TResult> filter, String[] searchPaths)
```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`filter` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>
`searchPaths` [string[]](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `LoadSingle(string, Func<T, TResult>, String[])`
<!-- tc:scope public -->
<!-- tc:return_type T _na_ -->
<!-- tc:version 0.0.0 -->

```csharp
public T LoadSingle(string query, Func<T, TResult> criteria, String[] searchPaths)
```

**Parameters** <br>
`query` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`criteria` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>
`searchPaths` [string[]](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

