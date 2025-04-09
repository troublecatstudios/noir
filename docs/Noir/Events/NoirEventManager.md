# NoirEventManager

**Namespace:** Noir.Events <br>
**Assembly:** Noir.dll

```csharp
public class NoirEventManager : INoirEventDispatcher, INoirEventRegistry
```

**Implements:** _[INoirEventDispatcher](../../Noir/Events/INoirEventDispatcher.html), [INoirEventRegistry](../../Noir/Events/INoirEventRegistry.html)_

### 🛠 Constructors
```csharp
public NoirEventManager()
```

### ⛹️‍♀️ Methods
#### DispatchEvent(T)
```csharp
public virtual bool DispatchEvent(T eventData)
```

**Parameters** <br>
`eventData` [T](../../) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### Register(GameObject, Type)
```csharp
public virtual void Register(GameObject handler, Type eventDataType)
```

**Parameters** <br>
`handler` [GameObject](../../) <br>
`eventDataType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

#### Register(GameObject)
```csharp
public virtual void Register(GameObject handler)
```

**Parameters** <br>
`handler` [GameObject](../../) <br>

#### Unregister(GameObject, Type)
```csharp
public virtual void Unregister(GameObject handler, Type eventDataType)
```

**Parameters** <br>
`handler` [GameObject](../../) <br>
`eventDataType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

#### Unregister(GameObject)
```csharp
public virtual void Unregister(GameObject handler)
```

**Parameters** <br>
`handler` [GameObject](../../) <br>

