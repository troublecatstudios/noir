# ObjectPoolSystem

<!-- tc:namespace Noir.Pooling -->

<!-- tc:assembly Noir.dll -->

Provides the ability to create, and manage the lifetime of a [ObjectPool](/noir/reference//noir/reference/Noir/Pooling/ObjectPool/).


```csharp
public class ObjectPoolSystem : NoirBehaviour
```

**Implements:** _[NoirBehaviour](/noir/reference//noir/reference/Noir/NoirBehaviour/)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public ObjectPoolSystem()

```

## Properties

<a name="ActiveItems"></a>

### `ActiveItems`
<!-- tc:scope public -->
<!-- tc:return_type uint https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the number of active items in the pool.


```csharp
public uint ActiveItems { get; }

```

<a name="animation"></a>

### `animation`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component animation { get; }

```

<a name="audio"></a>

### `audio`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component audio { get; }

```

<a name="camera"></a>

### `camera`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component camera { get; }

```

<a name="collider"></a>

### `collider`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component collider { get; }

```

<a name="collider2D"></a>

### `collider2D`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component collider2D { get; }

```

<a name="constantForce"></a>

### `constantForce`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component constantForce { get; }

```

<a name="enabled"></a>

### `enabled`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool enabled { get; public set; }

```

<a name="gameObject"></a>

### `gameObject`
<!-- tc:scope public -->
<!-- tc:return_type GameObject https://docs.unity3d.com/ScriptReference/GameObject.html -->
<!-- tc:version 1.0.0 -->

```csharp
public GameObject gameObject { get; }

```

<a name="GameTime"></a>

### `GameTime`
<!-- tc:scope protected -->
<!-- tc:return_type GameTime /noir/reference//noir/reference/Noir/GameTime/ -->
<!-- tc:version 1.0.0 -->

```csharp
protected GameTime GameTime { get; }

```

<a name="hideFlags"></a>

### `hideFlags`
<!-- tc:scope public -->
<!-- tc:return_type HideFlags https://docs.unity3d.com/ScriptReference/HideFlags.html -->
<!-- tc:version 1.0.0 -->

```csharp
public HideFlags hideFlags { get; public set; }

```

<a name="hingeJoint"></a>

### `hingeJoint`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component hingeJoint { get; }

```

<a name="InactiveItems"></a>

### `InactiveItems`
<!-- tc:scope public -->
<!-- tc:return_type uint https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the number of inactive items in the pool.


```csharp
public uint InactiveItems { get; }

```

<a name="isActiveAndEnabled"></a>

### `isActiveAndEnabled`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool isActiveAndEnabled { get; }

```

<a name="light"></a>

### `light`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component light { get; }

```

<a name="Logger"></a>

### `Logger`
<!-- tc:scope protected -->
<!-- tc:return_type BehaviourLogger /noir/reference//noir/reference/Noir/Logging/BehaviourLogger/ -->
<!-- tc:version 1.0.0 -->

```csharp
protected BehaviourLogger Logger { get; }

```

<a name="name"></a>

### `name`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string name { get; public set; }

```

<a name="networkView"></a>

### `networkView`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component networkView { get; }

```

<a name="particleSystem"></a>

### `particleSystem`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component particleSystem { get; }

```

<a name="renderer"></a>

### `renderer`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component renderer { get; }

```

<a name="rigidbody"></a>

### `rigidbody`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component rigidbody { get; }

```

<a name="rigidbody2D"></a>

### `rigidbody2D`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component rigidbody2D { get; }

```

<a name="runInEditMode"></a>

### `runInEditMode`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool runInEditMode { get; public set; }

```

<a name="Services"></a>

### `Services`
<!-- tc:scope protected -->
<!-- tc:return_type ComponentServiceLocator /noir/reference//noir/reference/Noir/DependencyInjection/ComponentServiceLocator/ -->
<!-- tc:version 1.0.0 -->

```csharp
protected ComponentServiceLocator Services { get; }

```

<a name="tag"></a>

### `tag`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string tag { get; public set; }

```

<a name="TotalItems"></a>

### `TotalItems`
<!-- tc:scope public -->
<!-- tc:return_type uint https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the total items.


```csharp
public uint TotalItems { get; }

```

<a name="transform"></a>

### `transform`
<!-- tc:scope public -->
<!-- tc:return_type Transform https://docs.unity3d.com/ScriptReference/Transform.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Transform transform { get; }

```

<a name="useGUILayout"></a>

### `useGUILayout`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool useGUILayout { get; public set; }

```

<a name="Utilization"></a>

### `Utilization`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 1.0.0 -->
Gets the pool utilization.


```csharp
public float Utilization { get; }

```

## Events

<a name="OnPoolItemCreated"></a>

### `OnPoolItemCreated`
<!-- tc:scope private -->
<!-- tc:return_type OnPoolItemCreatedEvent /noir/reference//noir/reference/Noir/Pooling/OnPoolItemCreatedEvent/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnPoolItemCreatedEvent OnPoolItemCreated;

```

<a name="OnPoolItemRerieved"></a>

### `OnPoolItemRerieved`
<!-- tc:scope private -->
<!-- tc:return_type OnPoolItemRetrievedEvent /noir/reference//noir/reference/Noir/Pooling/OnPoolItemRetrievedEvent/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnPoolItemRetrievedEvent OnPoolItemRerieved;

```

<a name="OnPoolItemResetToDefaults"></a>

### `OnPoolItemResetToDefaults`
<!-- tc:scope private -->
<!-- tc:return_type OnPoolItemResetToDefaultsEvent /noir/reference//noir/reference/Noir/Pooling/OnPoolItemResetToDefaultsEvent/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnPoolItemResetToDefaultsEvent OnPoolItemResetToDefaults;

```

<a name="OnPoolItemReturned"></a>

### `OnPoolItemReturned`
<!-- tc:scope private -->
<!-- tc:return_type OnPoolItemReturnedEvent /noir/reference//noir/reference/Noir/Pooling/OnPoolItemReturnedEvent/ -->
<!-- tc:version 1.0.0 -->

```csharp
public event OnPoolItemReturnedEvent OnPoolItemReturned;

```

## Methods

<a name="CreateObjectPool"></a>

### `CreateObjectPool(ObjectPoolItemSystem, uint)`
<!-- tc:scope private -->
<!-- tc:return_type ObjectPool /noir/reference//noir/reference/Noir/Pooling/ObjectPool/ -->
<!-- tc:version 1.0.0 -->
A [ObjectPool](/noir/reference//noir/reference/Noir/Pooling/ObjectPool/).
The [Noir.Pooling.ObjectPool]() instance, if needed. This is the preferred technique for customizing object pool behavior within Noir.


```csharp
protected virtual ObjectPool CreateObjectPool(ObjectPoolItemSystem prefab,
                                               uint capacity)


```

**Parameters** <br>
`prefab` [ObjectPoolItemSystem](/noir/reference//noir/reference/Noir/Pooling/ObjectPoolItemSystem/) <br>
 <br>
`capacity` [uint](https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0) <br>
 <br>

<a name="DispatchEvent"></a>

### `DispatchEvent(T)`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected void DispatchEvent(T eventInfo)

```

**Parameters** <br>
`eventInfo` [T](/noir/reference//noir/reference/) <br>

<a name="RegisterListener"></a>

### `RegisterListener()`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected void RegisterListener()

```

<a name="UnregisterListener"></a>

### `UnregisterListener()`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected void UnregisterListener()

```

<a name="CompareTag"></a>

### `CompareTag(string)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool CompareTag(string tag)

```

**Parameters** <br>
`tag` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="IsInvoking"></a>

### `IsInvoking()`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool IsInvoking()

```

<a name="IsInvoking"></a>

### `IsInvoking(string)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool IsInvoking(string methodName)

```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="TryGetComponent"></a>

### `TryGetComponent(Type, out Component&)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool TryGetComponent(Type type, Component& component)

```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`component` [Component&](https://docs.unity3d.com/ScriptReference/Component.html) <br>

<a name="TryGetComponent"></a>

### `TryGetComponent(out T&)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool TryGetComponent(T& component)

```

**Parameters** <br>
`component` [T&](/noir/reference//noir/reference/) <br>

<a name="GetComponent"></a>

### `GetComponent(string)`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component GetComponent(string type)

```

**Parameters** <br>
`type` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="GetComponent"></a>

### `GetComponent(Type)`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component GetComponent(Type type)

```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

<a name="GetComponentInChildren"></a>

### `GetComponentInChildren(Type, bool)`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component GetComponentInChildren(Type t, bool includeInactive)

```

**Parameters** <br>
`t` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

<a name="GetComponentInChildren"></a>

### `GetComponentInChildren(Type)`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component GetComponentInChildren(Type t)

```

**Parameters** <br>
`t` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

<a name="GetComponentInParent"></a>

### `GetComponentInParent(Type, bool)`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component GetComponentInParent(Type t, bool includeInactive)

```

**Parameters** <br>
`t` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

<a name="GetComponentInParent"></a>

### `GetComponentInParent(Type)`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component GetComponentInParent(Type t)

```

**Parameters** <br>
`t` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

<a name="GetComponents"></a>

### `GetComponents(Type)`
<!-- tc:scope public -->
<!-- tc:return_type Component[] https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component[] GetComponents(Type type)

```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

<a name="GetComponentsInChildren"></a>

### `GetComponentsInChildren(Type, bool)`
<!-- tc:scope public -->
<!-- tc:return_type Component[] https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component[] GetComponentsInChildren(Type t, bool includeInactive)

```

**Parameters** <br>
`t` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

<a name="GetComponentsInChildren"></a>

### `GetComponentsInChildren(Type)`
<!-- tc:scope public -->
<!-- tc:return_type Component[] https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component[] GetComponentsInChildren(Type t)

```

**Parameters** <br>
`t` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

<a name="GetComponentsInParent"></a>

### `GetComponentsInParent(Type, bool)`
<!-- tc:scope public -->
<!-- tc:return_type Component[] https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component[] GetComponentsInParent(Type t, bool includeInactive)

```

**Parameters** <br>
`t` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

<a name="GetComponentsInParent"></a>

### `GetComponentsInParent(Type)`
<!-- tc:scope public -->
<!-- tc:return_type Component[] https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component[] GetComponentsInParent(Type t)

```

**Parameters** <br>
`t` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

<a name="StartCoroutine_Auto"></a>

### `StartCoroutine_Auto(IEnumerator)`
<!-- tc:scope public -->
<!-- tc:return_type Coroutine https://docs.unity3d.com/ScriptReference/Coroutine.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Coroutine StartCoroutine_Auto(IEnumerator routine)

```

**Parameters** <br>
`routine` [IEnumerator](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator?view=net-7.0) <br>

<a name="StartCoroutine"></a>

### `StartCoroutine(IEnumerator)`
<!-- tc:scope public -->
<!-- tc:return_type Coroutine https://docs.unity3d.com/ScriptReference/Coroutine.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Coroutine StartCoroutine(IEnumerator routine)

```

**Parameters** <br>
`routine` [IEnumerator](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator?view=net-7.0) <br>

<a name="StartCoroutine"></a>

### `StartCoroutine(string, Object)`
<!-- tc:scope public -->
<!-- tc:return_type Coroutine https://docs.unity3d.com/ScriptReference/Coroutine.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Coroutine StartCoroutine(string methodName, Object value)

```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

<a name="StartCoroutine"></a>

### `StartCoroutine(string)`
<!-- tc:scope public -->
<!-- tc:return_type Coroutine https://docs.unity3d.com/ScriptReference/Coroutine.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Coroutine StartCoroutine(string methodName)

```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="GetActiveItems"></a>

### `GetActiveItems()`
<!-- tc:scope public -->
<!-- tc:return_type IEnumerable\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public IEnumerable<T> GetActiveItems()

```

<a name="GetInstanceID"></a>

### `GetInstanceID()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int GetInstanceID()

```

<a name="GetComponent"></a>

### `GetComponent()`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 1.0.0 -->

```csharp
public T GetComponent()

```

<a name="GetComponentInChildren"></a>

### `GetComponentInChildren()`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 1.0.0 -->

```csharp
public T GetComponentInChildren()

```

<a name="GetComponentInChildren"></a>

### `GetComponentInChildren(bool)`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 1.0.0 -->

```csharp
public T GetComponentInChildren(bool includeInactive)

```

**Parameters** <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

<a name="GetComponentInParent"></a>

### `GetComponentInParent()`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 1.0.0 -->

```csharp
public T GetComponentInParent()

```

<a name="GetComponentInParent"></a>

### `GetComponentInParent(bool)`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 1.0.0 -->

```csharp
public T GetComponentInParent(bool includeInactive)

```

**Parameters** <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

<a name="GetComponents"></a>

### `GetComponents()`
<!-- tc:scope public -->
<!-- tc:return_type T[] -->
<!-- tc:version 1.0.0 -->

```csharp
public T[] GetComponents()

```

<a name="GetComponentsInChildren"></a>

### `GetComponentsInChildren()`
<!-- tc:scope public -->
<!-- tc:return_type T[] -->
<!-- tc:version 1.0.0 -->

```csharp
public T[] GetComponentsInChildren()

```

<a name="GetComponentsInChildren"></a>

### `GetComponentsInChildren(bool)`
<!-- tc:scope public -->
<!-- tc:return_type T[] -->
<!-- tc:version 1.0.0 -->

```csharp
public T[] GetComponentsInChildren(bool includeInactive)

```

**Parameters** <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

<a name="GetComponentsInParent"></a>

### `GetComponentsInParent()`
<!-- tc:scope public -->
<!-- tc:return_type T[] -->
<!-- tc:version 1.0.0 -->

```csharp
public T[] GetComponentsInParent()

```

<a name="GetComponentsInParent"></a>

### `GetComponentsInParent(bool)`
<!-- tc:scope public -->
<!-- tc:return_type T[] -->
<!-- tc:version 1.0.0 -->

```csharp
public T[] GetComponentsInParent(bool includeInactive)

```

**Parameters** <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

<a name="Equals"></a>

### `Equals(Object)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Equals(Object other)

```

**Parameters** <br>
`other` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

<a name="TryGet"></a>

### `TryGet(out ObjectPoolItemSystem&)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool TryGet(ObjectPoolItemSystem& item)

```

**Parameters** <br>
`item` [ObjectPoolItemSystem&](/noir/reference//noir/reference/Noir/Pooling/ObjectPoolItemSystem/) <br>

<a name="GetHashCode"></a>

### `GetHashCode()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual int GetHashCode()

```

<a name="ToString"></a>

### `ToString()`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual string ToString()

```

<a name="Return"></a>

### `Return(ObjectPoolItemSystem)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void Return(ObjectPoolItemSystem item)

```

**Parameters** <br>
`item` [ObjectPoolItemSystem](/noir/reference//noir/reference/Noir/Pooling/ObjectPoolItemSystem/) <br>

<a name="ReturnAll"></a>

### `ReturnAll()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void ReturnAll()

```

<a name="BroadcastMessage"></a>

### `BroadcastMessage(string, Object, SendMessageOptions)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void BroadcastMessage(string methodName, Object parameter,
                              SendMessageOptions options)


```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`parameter` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`options` [SendMessageOptions](https://docs.unity3d.com/ScriptReference/SendMessageOptions.html) <br>

<a name="BroadcastMessage"></a>

### `BroadcastMessage(string, Object)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void BroadcastMessage(string methodName, Object parameter)

```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`parameter` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

<a name="BroadcastMessage"></a>

### `BroadcastMessage(string, SendMessageOptions)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void BroadcastMessage(string methodName, SendMessageOptions options)

```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`options` [SendMessageOptions](https://docs.unity3d.com/ScriptReference/SendMessageOptions.html) <br>

<a name="BroadcastMessage"></a>

### `BroadcastMessage(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void BroadcastMessage(string methodName)

```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="CancelInvoke"></a>

### `CancelInvoke()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void CancelInvoke()

```

<a name="CancelInvoke"></a>

### `CancelInvoke(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void CancelInvoke(string methodName)

```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="GetComponents"></a>

### `GetComponents(List<T>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void GetComponents(List<T> results)

```

**Parameters** <br>
`results` [List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>

<a name="GetComponents"></a>

### `GetComponents(Type, List<T>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void GetComponents(Type type, List<T> results)

```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`results` [List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>

<a name="GetComponentsInChildren"></a>

### `GetComponentsInChildren(bool, List<T>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void GetComponentsInChildren(bool includeInactive, List<T> result)

```

**Parameters** <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`result` [List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>

<a name="GetComponentsInChildren"></a>

### `GetComponentsInChildren(List<T>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void GetComponentsInChildren(List<T> results)

```

**Parameters** <br>
`results` [List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>

<a name="GetComponentsInParent"></a>

### `GetComponentsInParent(bool, List<T>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void GetComponentsInParent(bool includeInactive, List<T> results)

```

**Parameters** <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`results` [List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>

<a name="Invoke"></a>

### `Invoke(string, float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Invoke(string methodName, float time)

```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`time` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="InvokeRepeating"></a>

### `InvokeRepeating(string, float, float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void InvokeRepeating(string methodName, float time, float repeatRate)

```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`time` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`repeatRate` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

<a name="SendMessage"></a>

### `SendMessage(string, Object, SendMessageOptions)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SendMessage(string methodName, Object value,
                         SendMessageOptions options)


```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`options` [SendMessageOptions](https://docs.unity3d.com/ScriptReference/SendMessageOptions.html) <br>

<a name="SendMessage"></a>

### `SendMessage(string, Object)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SendMessage(string methodName, Object value)

```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

<a name="SendMessage"></a>

### `SendMessage(string, SendMessageOptions)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SendMessage(string methodName, SendMessageOptions options)

```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`options` [SendMessageOptions](https://docs.unity3d.com/ScriptReference/SendMessageOptions.html) <br>

<a name="SendMessage"></a>

### `SendMessage(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SendMessage(string methodName)

```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="SendMessageUpwards"></a>

### `SendMessageUpwards(string, Object, SendMessageOptions)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SendMessageUpwards(string methodName, Object value,
                                SendMessageOptions options)


```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`options` [SendMessageOptions](https://docs.unity3d.com/ScriptReference/SendMessageOptions.html) <br>

<a name="SendMessageUpwards"></a>

### `SendMessageUpwards(string, Object)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SendMessageUpwards(string methodName, Object value)

```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

<a name="SendMessageUpwards"></a>

### `SendMessageUpwards(string, SendMessageOptions)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SendMessageUpwards(string methodName, SendMessageOptions options)

```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`options` [SendMessageOptions](https://docs.unity3d.com/ScriptReference/SendMessageOptions.html) <br>

<a name="SendMessageUpwards"></a>

### `SendMessageUpwards(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SendMessageUpwards(string methodName)

```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="StopAllCoroutines"></a>

### `StopAllCoroutines()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void StopAllCoroutines()

```

<a name="StopCoroutine"></a>

### `StopCoroutine(IEnumerator)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void StopCoroutine(IEnumerator routine)

```

**Parameters** <br>
`routine` [IEnumerator](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator?view=net-7.0) <br>

<a name="StopCoroutine"></a>

### `StopCoroutine(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void StopCoroutine(string methodName)

```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="StopCoroutine"></a>

### `StopCoroutine(Coroutine)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void StopCoroutine(Coroutine routine)

```

**Parameters** <br>
`routine` [Coroutine](https://docs.unity3d.com/ScriptReference/Coroutine.html) <br>

## More information

* [Noir.Pooling.ObjectPool](/noir/reference//noir/reference/Noir/Pooling/ObjectPool/)
