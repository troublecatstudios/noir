# GameObjectAssertions

<!-- tc:namespace Noir.Testing.Assertions -->

<!-- tc:assembly NoirEditor.dll -->

Provides assertion extensions for verifying the state and components of [Behaviour](https://docs.unity3d.com/ScriptReference/Behaviour.html) instances in Unity.


```csharp
public static class GameObjectAssertions
```

## Methods

<a name="HasComponent"></a>

### `HasComponent(IAssertionContext<T>, string)`
<!-- tc:scope public -->
<!-- tc:return_type IAssertionContext\<T\> /noir/reference/Noir/Testing/IAssertionContext-1/ -->
<!-- tc:version 0.0.0 -->
Asserts that the target [UnityEngine.GameObject" /> has the specified component of type <typeparamref name="T]().


```csharp
public IAssertionContext<T> HasComponent(IAssertionContext<T> context,
                                          string message)


```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
 <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

**Exceptions** <br>
[AssertionException](/noir/reference/) <br>
 <br>
<a name="IsActive"></a>

### `IsActive(IAssertionContext<T>, string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Asserts that the target [GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html) is active in the scene hierarchy.


```csharp
public void IsActive(IAssertionContext<T> context, string message)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
 <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="IsEnabled"></a>

### `IsEnabled(IAssertionContext<T>, string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void IsEnabled(IAssertionContext<T> context, string message)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="IsNotActive"></a>

### `IsNotActive(IAssertionContext<T>, string)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Asserts that the target [GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html) is not active in the scene hierarchy.


```csharp
public void IsNotActive(IAssertionContext<T> context, string message)

```

**Parameters** <br>
`context` [IAssertionContext\<T\>](/noir/reference/Noir/Testing/IAssertionContext-1/) <br>
 <br>
`message` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

## More information

* [UnityEngine.GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html)
* [UnityEngine.Behaviour](https://docs.unity3d.com/ScriptReference/Behaviour.html)
