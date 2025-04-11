# IServiceLocator

**Namespace:** Noir <br>
**Assembly:** Noir.dll

```csharp
public abstract IServiceLocator
```

### ⛹️‍♀️ Methods
#### IsServiceRegistered()
```csharp
public abstract bool IsServiceRegistered()
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### TryGetService(out T&)
```csharp
public abstract bool TryGetService(T& instance)
```

**Parameters** <br>
`instance` [T&](../) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### GetService()
```csharp
public abstract T GetService()
```

**Returns** <br>
[T](../) <br>

#### RegisterService(Func<TResult>)
```csharp
public abstract void RegisterService(Func<TResult> factory)
```

**Parameters** <br>
`factory` [Func\<TResult\>](https://learn.microsoft.com/en-us/dotnet/api/System.Func-1?view=net-7.0) <br>

#### RegisterService(T)
```csharp
public abstract void RegisterService(T instance)
```

**Parameters** <br>
`instance` [T](../) <br>

#### UnregisterService()
```csharp
public abstract void UnregisterService()
```

