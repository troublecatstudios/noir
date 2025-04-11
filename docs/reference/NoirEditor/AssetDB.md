# AssetDB

**Namespace:** NoirEditor <br>
**Assembly:** NoirEditor.dll

```csharp
public static class AssetDB
```

Useful utility methods for interacting with the Unity AssetDatabase.

### ⛹️‍♀️ Methods
#### Mkdirp(string)
```csharp
public bool Mkdirp(string path)
```

Walks a directory path ensuring each directory exists.

**Parameters** <br>
`path` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
 <br>

#### TryGetReferencesToObject(Object, out IEnumerable`1&)
```csharp
public bool TryGetReferencesToObject(Object asset, IEnumerable`1& assetPaths)
```

**Parameters** <br>
`asset` [Object](../) <br>
`assetPaths` [IEnumerable\<T\>&](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### Load(Func<T, TResult>, String[])
```csharp
public List<T> Load(Func<T, TResult> filter, String[] searchPaths)
```

**Parameters** <br>
`filter` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>
`searchPaths` [string[]](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>

#### Load(string, Func<T, TResult>, String[])
```csharp
public List<T> Load(string query, Func<T, TResult> filter, String[] searchPaths)
```

Loads all assets from the [AssetDatabase](../) that match the given type paramter.

**Parameters** <br>
`query` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`filter` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>
`searchPaths` [string[]](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

**Returns** <br>
[List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>
 <br>

#### Load(Type, Func<T, TResult>, String[])
```csharp
public List<T> Load(Type type, Func<T, TResult> criteria, String[] searchPaths)
```

Loads all assets from the [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0).

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
 <br>
`criteria` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>
 <br>
`searchPaths` [string[]](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

**Returns** <br>
[List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>
 <br>

#### LoadSingle(Type, Func<T, TResult>, String[])
```csharp
public Object LoadSingle(Type objectType, Func<T, TResult> filter, String[] searchPaths)
```

**Parameters** <br>
`objectType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`filter` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>
`searchPaths` [string[]](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[Object](../) <br>

#### LoadSingle(string, Func<T, TResult>, String[])
```csharp
public T LoadSingle(string query, Func<T, TResult> criteria, String[] searchPaths)
```

**Parameters** <br>
`query` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`criteria` [Func\<T, TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-2?view=net-7.0) <br>
`searchPaths` [string[]](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[T](../) <br>

