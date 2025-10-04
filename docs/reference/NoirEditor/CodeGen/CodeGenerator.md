# CodeGenerator

<!-- tc:namespace NoirEditor.CodeGen -->

<!-- tc:assembly NoirEditor.dll -->


```csharp
public class CodeGenerator
```

## Constructors

### `.ctor(string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public CodeGenerator(string outputFolder)

```

**Parameters** <br>
`outputFolder` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

## Methods

### `Generate(bool, bool)`
<!-- tc:scope public -->
<!-- tc:return_type [CodeGenReport](/noir/reference//noir/reference/NoirEditor/CodeGen/CodeGenReport.html) -->
<!-- tc:version 0.0.0 -->

```csharp
public CodeGenReport Generate(bool force, bool dryRun)

```

**Parameters** <br>
`force` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`dryRun` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

### `AddTask(CodeGenTask)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void AddTask(CodeGenTask task)

```

**Parameters** <br>
`task` [CodeGenTask](/noir/reference//noir/reference/NoirEditor/CodeGen/CodeGenTask.html) <br>

### `AddTasks(IEnumerable<T>)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void AddTasks(IEnumerable<T> tasks)

```

**Parameters** <br>
`tasks` [IEnumerable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0) <br>

