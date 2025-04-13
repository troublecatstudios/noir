# AssertionContext\<T\>

**Namespace:** Noir.Testing <br>
**Assembly:** NoirEditor.dll

```csharp
public class AssertionContext<T> : IAssertionContext<T>
```

**Implements:** _[IAssertionContext\<T\>](../../Noir/Testing/IAssertionContext-1.html)_

### 🛠 Constructors
```csharp
public AssertionContext<T>()
```

```csharp
public AssertionContext<T>(T target, Object[] additionalContexts)
```

**Parameters** <br>
`target` [T](../../) <br>
`additionalContexts` [Object[]](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

### 📦 Properties
#### AdditionalContexts
```csharp
public virtual Object[] AdditionalContexts { get; internal set; }
```

**Returns** <br>
[Object[]](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
#### Target
```csharp
public virtual T Target { get; internal set; }
```

**Returns** <br>
[T](../../) <br>
