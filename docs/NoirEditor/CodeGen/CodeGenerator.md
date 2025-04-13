# CodeGenerator

**Namespace:** NoirEditor.CodeGen <br>
**Assembly:** NoirEditor.dll

```csharp
public class CodeGenerator
```

### 🛠 Constructors
```csharp
public CodeGenerator(string outputFolder)
```

**Parameters** <br>
`outputFolder` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### ⛹️‍♀️ Methods
#### Generate(bool, bool)
```csharp
public CodeGenReport Generate(bool force, bool dryRun)
```

**Parameters** <br>
`force` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`dryRun` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

**Returns** <br>
[CodeGenReport](../../NoirEditor/CodeGen/CodeGenReport.html) <br>

#### AddTask(CodeGenTask)
```csharp
public void AddTask(CodeGenTask task)
```

**Parameters** <br>
`task` [CodeGenTask](../../NoirEditor/CodeGen/CodeGenTask.html) <br>

#### AddTasks(IEnumerable<T>)
```csharp
public void AddTasks(IEnumerable<T> tasks)
```

**Parameters** <br>
`tasks` [IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>

