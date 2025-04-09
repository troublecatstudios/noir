# INoirEventRegistry

**Namespace:** Noir.Events <br>
**Assembly:** Noir.dll

```csharp
public abstract INoirEventRegistry
```

### ⛹️‍♀️ Methods
#### Register(GameObject, Type)
```csharp
public abstract void Register(GameObject handler, Type eventDataType)
```

**Parameters** <br>
`handler` [GameObject](../../) <br>
`eventDataType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

#### Register(GameObject)
```csharp
public abstract void Register(GameObject handler)
```

**Parameters** <br>
`handler` [GameObject](../../) <br>

#### Unregister(GameObject, Type)
```csharp
public abstract void Unregister(GameObject handler, Type eventDataType)
```

**Parameters** <br>
`handler` [GameObject](../../) <br>
`eventDataType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

#### Unregister(GameObject)
```csharp
public abstract void Unregister(GameObject handler)
```

**Parameters** <br>
`handler` [GameObject](../../) <br>

