# CustomAssertionContext\<T\>

**Namespace:** Noir.Testing <br>
**Assembly:** NoirEditor.dll

```csharp
public class CustomAssertionContext<T> : ICustomAssertionContext<T>
```

**Implements:** _[ICustomAssertionContext\<T\>](../../Noir/Testing/ICustomAssertionContext-1.html)_

### 🛠 Constructors
```csharp
public CustomAssertionContext<T>()
```

```csharp
public CustomAssertionContext<T>(T target, Object[] additionalContexts)
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
