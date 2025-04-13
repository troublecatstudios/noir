# ComponentServiceLocator

**Namespace:** Noir.DependencyInjection <br>
**Assembly:** Noir.dll

```csharp
public class ComponentServiceLocator
```

### 🛠 Constructors
```csharp
public ComponentServiceLocator(GameObject container)
```

**Parameters** <br>
`container` [GameObject](../../) <br>

### ⛹️‍♀️ Methods
#### TryGetService(out T&)
```csharp
public bool TryGetService(T& instance)
```

**Parameters** <br>
`instance` [T&](../../) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### GetService()
```csharp
public T GetService()
```

**Returns** <br>
[T](../../) <br>

