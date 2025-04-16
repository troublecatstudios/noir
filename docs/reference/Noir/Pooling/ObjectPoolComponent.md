# ObjectPoolComponent

**Namespace:** Noir.Pooling <br>
**Assembly:** Noir.dll

```csharp
public class ObjectPoolComponent : NoirBehaviour
```

Configures an object for use with a [ObjectPoolSystem](../../Noir/Pooling/ObjectPoolSystem.html).

**Implements:** _[NoirBehaviour](../../Noir/NoirBehaviour.html)_

### 🛠 Constructors
```csharp
public ObjectPoolComponent()
```

### 📦 Properties
#### animation
```csharp
public Component animation { get; }
```

**Returns** <br>
[Component](../../) <br>
#### audio
```csharp
public Component audio { get; }
```

**Returns** <br>
[Component](../../) <br>
#### camera
```csharp
public Component camera { get; }
```

**Returns** <br>
[Component](../../) <br>
#### Capacity
```csharp
public uint Capacity { get; }
```

The max size of the pool

**Returns** <br>
[uint](https://learn.microsoft.com/en-us/dotnet/api/System.UInt32?view=net-7.0) <br>
#### collider
```csharp
public Component collider { get; }
```

**Returns** <br>
[Component](../../) <br>
#### collider2D
```csharp
public Component collider2D { get; }
```

**Returns** <br>
[Component](../../) <br>
#### constantForce
```csharp
public Component constantForce { get; }
```

**Returns** <br>
[Component](../../) <br>
#### enabled
```csharp
public bool enabled { get; public set; }
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### gameObject
```csharp
public GameObject gameObject { get; }
```

**Returns** <br>
[GameObject](../../) <br>
#### GameTime
```csharp
protected GameTime GameTime { get; }
```

**Returns** <br>
[GameTime](../../Noir/GameTime.html) <br>
#### hideFlags
```csharp
public HideFlags hideFlags { get; public set; }
```

**Returns** <br>
[HideFlags](../../) <br>
#### hingeJoint
```csharp
public Component hingeJoint { get; }
```

**Returns** <br>
[Component](../../) <br>
#### isActiveAndEnabled
```csharp
public bool isActiveAndEnabled { get; }
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### IsParentForSpawnedObjects
```csharp
public bool IsParentForSpawnedObjects { get; }
```

Should the [ObjectPoolSystem](../../Noir/Pooling/ObjectPoolSystem.html) gameobject be the parent for spawned objects?

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### IsPreWarmEnabled
```csharp
public bool IsPreWarmEnabled { get; }
```

Should the object pool pre-generate all the items at startup?

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### light
```csharp
public Component light { get; }
```

**Returns** <br>
[Component](../../) <br>
#### Logger
```csharp
protected BehaviourLogger Logger { get; }
```

**Returns** <br>
[BehaviourLogger](../../Noir/Logging/BehaviourLogger.html) <br>
#### name
```csharp
public string name { get; public set; }
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### networkView
```csharp
public Component networkView { get; }
```

**Returns** <br>
[Component](../../) <br>
#### particleSystem
```csharp
public Component particleSystem { get; }
```

**Returns** <br>
[Component](../../) <br>
#### Prefab
```csharp
public ObjectPoolItemSystem Prefab { get; }
```

The gameobject to spawn using the object pool

**Returns** <br>
[ObjectPoolItemSystem](../../Noir/Pooling/ObjectPoolItemSystem.html) <br>
#### renderer
```csharp
public Component renderer { get; }
```

**Returns** <br>
[Component](../../) <br>
#### rigidbody
```csharp
public Component rigidbody { get; }
```

**Returns** <br>
[Component](../../) <br>
#### rigidbody2D
```csharp
public Component rigidbody2D { get; }
```

**Returns** <br>
[Component](../../) <br>
#### runInEditMode
```csharp
public bool runInEditMode { get; public set; }
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
#### Services
```csharp
protected ComponentServiceLocator Services { get; }
```

**Returns** <br>
[ComponentServiceLocator](../../Noir/DependencyInjection/ComponentServiceLocator.html) <br>
#### tag
```csharp
public string tag { get; public set; }
```

**Returns** <br>
[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
#### transform
```csharp
public Transform transform { get; }
```

**Returns** <br>
[Transform](../../) <br>
#### useGUILayout
```csharp
public bool useGUILayout { get; public set; }
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
### ⛹️‍♀️ Methods
#### DispatchEvent(T)
```csharp
protected void DispatchEvent(T eventInfo)
```

**Parameters** <br>
`eventInfo` [T](../../) <br>

#### RegisterListener()
```csharp
protected void RegisterListener()
```

#### UnregisterListener()
```csharp
protected void UnregisterListener()
```

#### CompareTag(string)
```csharp
public bool CompareTag(string tag)
```

**Parameters** <br>
`tag` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### IsInvoking()
```csharp
public bool IsInvoking()
```

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### IsInvoking(string)
```csharp
public bool IsInvoking(string methodName)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### TryGetComponent(Type, out Component&)
```csharp
public bool TryGetComponent(Type type, Component& component)
```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`component` [Component&](../../) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### TryGetComponent(out T&)
```csharp
public bool TryGetComponent(T& component)
```

**Parameters** <br>
`component` [T&](../../) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### GetComponent(string)
```csharp
public Component GetComponent(string type)
```

**Parameters** <br>
`type` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[Component](../../) <br>

#### GetComponent(Type)
```csharp
public Component GetComponent(Type type)
```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[Component](../../) <br>

#### GetComponentInChildren(Type, bool)
```csharp
public Component GetComponentInChildren(Type t, bool includeInactive)
```

**Parameters** <br>
`t` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

**Returns** <br>
[Component](../../) <br>

#### GetComponentInChildren(Type)
```csharp
public Component GetComponentInChildren(Type t)
```

**Parameters** <br>
`t` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[Component](../../) <br>

#### GetComponentInParent(Type, bool)
```csharp
public Component GetComponentInParent(Type t, bool includeInactive)
```

**Parameters** <br>
`t` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

**Returns** <br>
[Component](../../) <br>

#### GetComponentInParent(Type)
```csharp
public Component GetComponentInParent(Type t)
```

**Parameters** <br>
`t` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[Component](../../) <br>

#### GetComponents(Type)
```csharp
public Component[] GetComponents(Type type)
```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[Component[]](../../) <br>

#### GetComponentsInChildren(Type, bool)
```csharp
public Component[] GetComponentsInChildren(Type t, bool includeInactive)
```

**Parameters** <br>
`t` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

**Returns** <br>
[Component[]](../../) <br>

#### GetComponentsInChildren(Type)
```csharp
public Component[] GetComponentsInChildren(Type t)
```

**Parameters** <br>
`t` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[Component[]](../../) <br>

#### GetComponentsInParent(Type, bool)
```csharp
public Component[] GetComponentsInParent(Type t, bool includeInactive)
```

**Parameters** <br>
`t` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

**Returns** <br>
[Component[]](../../) <br>

#### GetComponentsInParent(Type)
```csharp
public Component[] GetComponentsInParent(Type t)
```

**Parameters** <br>
`t` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

**Returns** <br>
[Component[]](../../) <br>

#### StartCoroutine_Auto(IEnumerator)
```csharp
public Coroutine StartCoroutine_Auto(IEnumerator routine)
```

**Parameters** <br>
`routine` [IEnumerator](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator?view=net-7.0) <br>

**Returns** <br>
[Coroutine](../../) <br>

#### StartCoroutine(IEnumerator)
```csharp
public Coroutine StartCoroutine(IEnumerator routine)
```

**Parameters** <br>
`routine` [IEnumerator](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator?view=net-7.0) <br>

**Returns** <br>
[Coroutine](../../) <br>

#### StartCoroutine(string, Object)
```csharp
public Coroutine StartCoroutine(string methodName, Object value)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

**Returns** <br>
[Coroutine](../../) <br>

#### StartCoroutine(string)
```csharp
public Coroutine StartCoroutine(string methodName)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

**Returns** <br>
[Coroutine](../../) <br>

#### GetInstanceID()
```csharp
public int GetInstanceID()
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

#### GetComponent()
```csharp
public T GetComponent()
```

**Returns** <br>
[T](../../) <br>

#### GetComponentInChildren()
```csharp
public T GetComponentInChildren()
```

**Returns** <br>
[T](../../) <br>

#### GetComponentInChildren(bool)
```csharp
public T GetComponentInChildren(bool includeInactive)
```

**Parameters** <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

**Returns** <br>
[T](../../) <br>

#### GetComponentInParent()
```csharp
public T GetComponentInParent()
```

**Returns** <br>
[T](../../) <br>

#### GetComponentInParent(bool)
```csharp
public T GetComponentInParent(bool includeInactive)
```

**Parameters** <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

**Returns** <br>
[T](../../) <br>

#### GetComponents()
```csharp
public T[] GetComponents()
```

**Returns** <br>
[T[]](../../) <br>

#### GetComponentsInChildren()
```csharp
public T[] GetComponentsInChildren()
```

**Returns** <br>
[T[]](../../) <br>

#### GetComponentsInChildren(bool)
```csharp
public T[] GetComponentsInChildren(bool includeInactive)
```

**Parameters** <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

**Returns** <br>
[T[]](../../) <br>

#### GetComponentsInParent()
```csharp
public T[] GetComponentsInParent()
```

**Returns** <br>
[T[]](../../) <br>

#### GetComponentsInParent(bool)
```csharp
public T[] GetComponentsInParent(bool includeInactive)
```

**Parameters** <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

**Returns** <br>
[T[]](../../) <br>

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

#### BroadcastMessage(string, Object, SendMessageOptions)
```csharp
public void BroadcastMessage(string methodName, Object parameter, SendMessageOptions options)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`parameter` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`options` [SendMessageOptions](../../) <br>

#### BroadcastMessage(string, Object)
```csharp
public void BroadcastMessage(string methodName, Object parameter)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`parameter` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

#### BroadcastMessage(string, SendMessageOptions)
```csharp
public void BroadcastMessage(string methodName, SendMessageOptions options)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`options` [SendMessageOptions](../../) <br>

#### BroadcastMessage(string)
```csharp
public void BroadcastMessage(string methodName)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### CancelInvoke()
```csharp
public void CancelInvoke()
```

#### CancelInvoke(string)
```csharp
public void CancelInvoke(string methodName)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### GetComponents(List<T>)
```csharp
public void GetComponents(List<T> results)
```

**Parameters** <br>
`results` [List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>

#### GetComponents(Type, List<T>)
```csharp
public void GetComponents(Type type, List<T> results)
```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`results` [List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>

#### GetComponentsInChildren(bool, List<T>)
```csharp
public void GetComponentsInChildren(bool includeInactive, List<T> result)
```

**Parameters** <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`result` [List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>

#### GetComponentsInChildren(List<T>)
```csharp
public void GetComponentsInChildren(List<T> results)
```

**Parameters** <br>
`results` [List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>

#### GetComponentsInParent(bool, List<T>)
```csharp
public void GetComponentsInParent(bool includeInactive, List<T> results)
```

**Parameters** <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`results` [List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>

#### Invoke(string, float)
```csharp
public void Invoke(string methodName, float time)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`time` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

#### InvokeRepeating(string, float, float)
```csharp
public void InvokeRepeating(string methodName, float time, float repeatRate)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`time` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`repeatRate` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

#### SendMessage(string, Object, SendMessageOptions)
```csharp
public void SendMessage(string methodName, Object value, SendMessageOptions options)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`options` [SendMessageOptions](../../) <br>

#### SendMessage(string, Object)
```csharp
public void SendMessage(string methodName, Object value)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

#### SendMessage(string, SendMessageOptions)
```csharp
public void SendMessage(string methodName, SendMessageOptions options)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`options` [SendMessageOptions](../../) <br>

#### SendMessage(string)
```csharp
public void SendMessage(string methodName)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### SendMessageUpwards(string, Object, SendMessageOptions)
```csharp
public void SendMessageUpwards(string methodName, Object value, SendMessageOptions options)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`options` [SendMessageOptions](../../) <br>

#### SendMessageUpwards(string, Object)
```csharp
public void SendMessageUpwards(string methodName, Object value)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

#### SendMessageUpwards(string, SendMessageOptions)
```csharp
public void SendMessageUpwards(string methodName, SendMessageOptions options)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`options` [SendMessageOptions](../../) <br>

#### SendMessageUpwards(string)
```csharp
public void SendMessageUpwards(string methodName)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### StopAllCoroutines()
```csharp
public void StopAllCoroutines()
```

#### StopCoroutine(IEnumerator)
```csharp
public void StopCoroutine(IEnumerator routine)
```

**Parameters** <br>
`routine` [IEnumerator](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator?view=net-7.0) <br>

#### StopCoroutine(string)
```csharp
public void StopCoroutine(string methodName)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

#### StopCoroutine(Coroutine)
```csharp
public void StopCoroutine(Coroutine routine)
```

**Parameters** <br>
`routine` [Coroutine](../../) <br>

