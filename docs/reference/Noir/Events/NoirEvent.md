# NoirEvent

<!-- tc:namespace Noir.Events -->

<!-- tc:assembly Noir.dll -->


```csharp
public class NoirEvent : ScriptableObject
```

**Implements:** _[ScriptableObject](https://docs.unity3d.com/ScriptReference/ScriptableObject.html)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public NoirEvent()

```

## Properties

<a name="IsSubscribed"></a>

### `IsSubscribed`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool IsSubscribed { get; }

```

<a name="Name"></a>

### `Name`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string Name { get; }

```

<a name="SubscriberCount"></a>

### `SubscriberCount`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int SubscriberCount { get; }

```

## Methods

<a name="Invoke"></a>

### `Invoke()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Invoke()

```

<a name="Invoke"></a>

### `Invoke(Object)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Invoke(Object context)

```

**Parameters** <br>
`context` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

<a name="Register"></a>

### `Register(MonoBehaviour, Action)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Register(MonoBehaviour behaviour, Action callback)

```

**Parameters** <br>
`behaviour` [MonoBehaviour](https://docs.unity3d.com/ScriptReference/MonoBehaviour.html) <br>
`callback` [Action](https://learn.microsoft.com/en-us/dotnet/api/System.Action?view=net-7.0) <br>

<a name="Register"></a>

### `Register(MonoBehaviour, Action<T>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Register(MonoBehaviour behaviour, Action<T> callback)

```

**Parameters** <br>
`behaviour` [MonoBehaviour](https://docs.unity3d.com/ScriptReference/MonoBehaviour.html) <br>
`callback` [Action\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Action-1?view=net-7.0) <br>

<a name="Unregister"></a>

### `Unregister(MonoBehaviour, Action)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Unregister(MonoBehaviour behaviour, Action callback)

```

**Parameters** <br>
`behaviour` [MonoBehaviour](https://docs.unity3d.com/ScriptReference/MonoBehaviour.html) <br>
`callback` [Action](https://learn.microsoft.com/en-us/dotnet/api/System.Action?view=net-7.0) <br>

<a name="Unregister"></a>

### `Unregister(MonoBehaviour, Action<T>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Unregister(MonoBehaviour behaviour, Action<T> callback)

```

**Parameters** <br>
`behaviour` [MonoBehaviour](https://docs.unity3d.com/ScriptReference/MonoBehaviour.html) <br>
`callback` [Action\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Action-1?view=net-7.0) <br>

