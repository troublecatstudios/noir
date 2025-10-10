# INoirEventRegistry

<!-- tc:namespace Noir.Events -->

<!-- tc:assembly Noir.dll -->


```csharp
public abstract INoirEventRegistry
```

## Methods

<a name="Register"></a>

### `Register(GameObject, Type)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void Register(GameObject handler, Type eventDataType)

```

**Parameters** <br>
`handler` [GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html) <br>
`eventDataType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

<a name="Register"></a>

### `Register(GameObject)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void Register(GameObject handler)

```

**Parameters** <br>
`handler` [GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html) <br>

<a name="Unregister"></a>

### `Unregister(GameObject, Type)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void Unregister(GameObject handler, Type eventDataType)

```

**Parameters** <br>
`handler` [GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html) <br>
`eventDataType` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

<a name="Unregister"></a>

### `Unregister(GameObject)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public abstract void Unregister(GameObject handler)

```

**Parameters** <br>
`handler` [GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html) <br>

