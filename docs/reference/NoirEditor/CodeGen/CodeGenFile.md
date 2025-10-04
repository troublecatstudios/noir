# CodeGenFile

<!-- tc:namespace NoirEditor.CodeGen -->

<!-- tc:assembly NoirEditor.dll -->


```csharp
public static class CodeGenFile
```

## Methods

### `BuildConstIntegerVariable(string, int, string)`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
<!-- tc:version 0.0.0 -->

```csharp
public string BuildConstIntegerVariable(string varName, int varValue,
                                         string indent)


```

**Parameters** <br>
`varName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`varValue` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
`indent` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `BuildConstStringVariable(string, string, string)`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
<!-- tc:version 0.0.0 -->

```csharp
public string BuildConstStringVariable(string varName, string varValue,
                                        string indent)


```

**Parameters** <br>
`varName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`varValue` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`indent` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `GetClassContent(IEnumerable<T>)`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
<!-- tc:version 0.0.0 -->

```csharp
public string GetClassContent(IEnumerable<T> items)

```

**Parameters** <br>
`items` [IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>

### `GetClassContent(String[])`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
<!-- tc:version 0.0.0 -->

```csharp
public string GetClassContent(String[] labelsArray)

```

**Parameters** <br>
`labelsArray` [string[]](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `GetClassWrapper(string, string, string, String[], string, string)`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
<!-- tc:version 0.0.0 -->

```csharp
public string GetClassWrapper(string namespace, string className,
                               string contents, String[] usings, string header,
                               string footer)


```

**Parameters** <br>
`namespace` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`className` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`contents` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`usings` [string[]](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`header` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`footer` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `GetHashFromSourceFile(string)`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
<!-- tc:version 0.0.0 -->

```csharp
public string GetHashFromSourceFile(string sourceFilePath)

```

**Parameters** <br>
`sourceFilePath` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `UppercaseVariableName(string)`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
<!-- tc:version 0.0.0 -->

```csharp
public string UppercaseVariableName(string input)

```

**Parameters** <br>
`input` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

