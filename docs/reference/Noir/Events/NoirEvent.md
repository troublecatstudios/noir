# NoirEvent

**Namespace:** Noir.Events <br>
**Assembly:** Noir.dll

```csharp
public class NoirEvent : ScriptableObject
```

**Implements:** _[ScriptableObject](../../)_

### 🛠 Constructors
```csharp
public NoirEvent()
```

### 📦 Properties
#### hideFlags
```csharp
public HideFlags hideFlags { get; public set; }
```

**Returns** <br>
[HideFlags](../../) <br>
#### IsSubscribed
```csharp
public bool IsSubscribed { get; }
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### name
```csharp
public string name { get; public set; }
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### Name
```csharp
public string Name { get; }
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### SubscriberCount
```csharp
public int SubscriberCount { get; }
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
### ⛹️‍♀️ Methods
#### GetInstanceID()
```csharp
public int GetInstanceID()
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

#### Equals(Object)
```csharp
public virtual bool Equals(Object other)
```

**Parameters** <br>
`other` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### GetHashCode()
```csharp
public virtual int GetHashCode()
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

#### ToString()
```csharp
public virtual string ToString()
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### Invoke()
```csharp
public void Invoke()
```

#### Invoke(Object)
```csharp
public void Invoke(Object context)
```

**Parameters** <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

#### Register(MonoBehaviour, Action)
```csharp
public void Register(MonoBehaviour behaviour, Action callback)
```

**Parameters** <br>
`behaviour` [MonoBehaviour](../../) <br>
`callback` [Action](https://learn.microsoft.com/en-us/dotnet/api/System.Action?view=net-7.0) <br>

#### Register(MonoBehaviour, Action<T>)
```csharp
public void Register(MonoBehaviour behaviour, Action<T> callback)
```

**Parameters** <br>
`behaviour` [MonoBehaviour](../../) <br>
`callback` [Action\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Action-1?view=net-7.0) <br>

#### SetDirty()
```csharp
public void SetDirty()
```

#### Unregister(MonoBehaviour, Action)
```csharp
public void Unregister(MonoBehaviour behaviour, Action callback)
```

**Parameters** <br>
`behaviour` [MonoBehaviour](../../) <br>
`callback` [Action](https://learn.microsoft.com/en-us/dotnet/api/System.Action?view=net-7.0) <br>

#### Unregister(MonoBehaviour, Action<T>)
```csharp
public void Unregister(MonoBehaviour behaviour, Action<T> callback)
```

**Parameters** <br>
`behaviour` [MonoBehaviour](../../) <br>
`callback` [Action\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Action-1?view=net-7.0) <br>

