# TypeExtensions

<!-- tc:namespace NoirEditor.Reflection -->

<!-- tc:assembly NoirEditor.dll -->


```csharp
public static class TypeExtensions
```

## ⛹️‍♀️ Methods

### `GetAllMembers(Type, string, BindingFlags)`
<!-- tc:scope public -->
<!-- tc:return_type List\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0 -->
<!-- tc:version 0.0.0 -->
Retrieves all members (fields and properties) of a specified type that match a given name and binding flags.


```csharp
public List<T> GetAllMembers(Type type, string name, BindingFlags bindingFlags)
```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
 <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`bindingFlags` [BindingFlags](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags?view=net-7.0) <br>
 <br>

