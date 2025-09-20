# NoirEventManager

<!-- tc:namespace Noir.Events -->

<!-- tc:assembly Noir.dll -->


```csharp
public class NoirEventManager : INoirEventDispatcher, INoirEventRegistry
```

**Implements:** _[INoirEventDispatcher](/noir/reference//noir/reference/Noir/Events/INoirEventDispatcher/), [INoirEventRegistry](/noir/reference//noir/reference/Noir/Events/INoirEventRegistry/)_

## 🛠 Constructors

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public NoirEventManager()
```

## ⛹️‍♀️ Methods

### `DispatchEvent(T)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool DispatchEvent(T eventData)
```

**Parameters** <br>
`eventData` [T](/noir/reference//noir/reference/) <br>

### `Register(GameObject, Type)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Register(GameObject handler, Type eventDataType)
```

**Parameters** <br>
`handler` [GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html) <br>
`eventDataType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

### `Register(GameObject)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Register(GameObject handler)
```

**Parameters** <br>
`handler` [GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html) <br>

### `Unregister(GameObject, Type)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Unregister(GameObject handler, Type eventDataType)
```

**Parameters** <br>
`handler` [GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html) <br>
`eventDataType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

### `Unregister(GameObject)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Unregister(GameObject handler)
```

**Parameters** <br>
`handler` [GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html) <br>

