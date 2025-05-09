# NoirEvent

<!-- tc:namespace Noir.Events -->
<!-- tc:assembly Noir.dll -->


```csharp
public class NoirEvent : ScriptableObject
```

**Implements:** _[ScriptableObject](https://docs.unity3d.com/ScriptReference/ScriptableObject.html)_

## Constructors

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public NoirEvent()
```

## Properties

### `hideFlags`
<!-- tc:scope public -->
<!-- tc:return_type HideFlags https://docs.unity3d.com/ScriptReference/HideFlags.html -->
<!-- tc:version 1.0.0 -->

```csharp
public HideFlags hideFlags { get; public set; }
```

### `IsSubscribed`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool IsSubscribed { get; }
```

### `name`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string name { get; public set; }
```

### `Name`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string Name { get; }
```

### `SubscriberCount`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int SubscriberCount { get; }
```

## Methods

### `GetInstanceID()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int GetInstanceID()
```

### `Equals(Object)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Equals(Object other)
```

**Parameters** <br>
`other` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

### `GetHashCode()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual int GetHashCode()
```

### `ToString()`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual string ToString()
```

### `Invoke()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Invoke()
```

### `Invoke(Object)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Invoke(Object context)
```

**Parameters** <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

### `Register(MonoBehaviour, Action)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Register(MonoBehaviour behaviour, Action callback)
```

**Parameters** <br>
`behaviour` [MonoBehaviour](https://docs.unity3d.com/ScriptReference/MonoBehaviour.html) <br>
`callback` [Action](https://learn.microsoft.com/en-us/dotnet/api/System.Action?view=net-7.0) <br>

### `Register(MonoBehaviour, Action<T>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Register(MonoBehaviour behaviour, Action<T> callback)
```

**Parameters** <br>
`behaviour` [MonoBehaviour](https://docs.unity3d.com/ScriptReference/MonoBehaviour.html) <br>
`callback` [Action\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Action-1?view=net-7.0) <br>

### `SetDirty()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SetDirty()
```

### `Unregister(MonoBehaviour, Action)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Unregister(MonoBehaviour behaviour, Action callback)
```

**Parameters** <br>
`behaviour` [MonoBehaviour](https://docs.unity3d.com/ScriptReference/MonoBehaviour.html) <br>
`callback` [Action](https://learn.microsoft.com/en-us/dotnet/api/System.Action?view=net-7.0) <br>

### `Unregister(MonoBehaviour, Action<T>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Unregister(MonoBehaviour behaviour, Action<T> callback)
```

**Parameters** <br>
`behaviour` [MonoBehaviour](https://docs.unity3d.com/ScriptReference/MonoBehaviour.html) <br>
`callback` [Action\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Action-1?view=net-7.0) <br>

