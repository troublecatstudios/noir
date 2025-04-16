# CodeGenFile

**Namespace:** NoirEditor.CodeGen <br>
**Assembly:** NoirEditor.dll

```csharp
public static class CodeGenFile
```

### ⛹️‍♀️ Methods
#### BuildConstIntegerVariable(string, int, string)
```csharp
public string BuildConstIntegerVariable(string varName, int varValue, string indent)
```

**Parameters** <br>
`varName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`varValue` [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
`indent` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### BuildConstStringVariable(string, string, string)
```csharp
public string BuildConstStringVariable(string varName, string varValue, string indent)
```

**Parameters** <br>
`varName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`varValue` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`indent` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### GetClassContent(IEnumerable<T>)
```csharp
public string GetClassContent(IEnumerable<T> items)
```

**Parameters** <br>
`items` [IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### GetClassContent(String[])
```csharp
public string GetClassContent(String[] labelsArray)
```

**Parameters** <br>
`labelsArray` [string[]](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### GetClassWrapper(string, string, string, String[], string, string)
```csharp
public string GetClassWrapper(string namespace, string className, string contents, String[] usings, string header, string footer)
```

**Parameters** <br>
`namespace` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`className` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`contents` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`usings` [string[]](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`header` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`footer` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### GetHashFromSourceFile(string)
```csharp
public string GetHashFromSourceFile(string sourceFilePath)
```

**Parameters** <br>
`sourceFilePath` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### UppercaseVariableName(string)
```csharp
public string UppercaseVariableName(string input)
```

**Parameters** <br>
`input` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

