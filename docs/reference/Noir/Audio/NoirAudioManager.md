# NoirAudioManager

<!-- tc:namespace Noir.Audio -->

<!-- tc:assembly Noir.dll -->


```csharp
public class NoirAudioManager : NoirSingletonBehaviour<T>, INoirAudioManager, INoirEventListener<T>, IEventSystemHandler, INoirEventListener<T>
```

**Implements:** _[NoirSingletonBehaviour\<T\>](/noir/reference/Noir/NoirSingletonBehaviour-1/), [INoirAudioManager](/noir/reference/Noir/Audio/INoirAudioManager/), [INoirEventListener\<T\>](/noir/reference/Noir/Events/INoirEventListener-1/), [IEventSystemHandler](https://docs.unity3d.com/ScriptReference/EventSystems.IEventSystemHandler.html), [INoirEventListener\<T\>](/noir/reference/Noir/Events/INoirEventListener-1/)_

## 🛠 Constructors

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public NoirAudioManager()
```

## 📦 Properties

### `animation`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component animation { get; }
```

### `audio`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component audio { get; }
```

### `camera`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component camera { get; }
```

### `collider`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component collider { get; }
```

### `collider2D`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component collider2D { get; }
```

### `constantForce`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component constantForce { get; }
```

### `destroyCancellationToken`
<!-- tc:scope public -->
<!-- tc:return_type CancellationToken https://learn.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public CancellationToken destroyCancellationToken { get; }
```

### `didAwake`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool didAwake { get; }
```

### `didStart`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool didStart { get; }
```

### `enabled`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool enabled { get; public set; }
```

### `gameObject`
<!-- tc:scope public -->
<!-- tc:return_type GameObject https://docs.unity3d.com/ScriptReference/GameObject.html -->
<!-- tc:version 1.0.0 -->

```csharp
public GameObject gameObject { get; }
```

### `GameTime`
<!-- tc:scope protected -->
<!-- tc:return_type GameTime /noir/reference/Noir/GameTime/ -->
<!-- tc:version 1.0.0 -->

```csharp
protected GameTime GameTime { get; }
```

### `hideFlags`
<!-- tc:scope public -->
<!-- tc:return_type HideFlags https://docs.unity3d.com/ScriptReference/HideFlags.html -->
<!-- tc:version 1.0.0 -->

```csharp
public HideFlags hideFlags { get; public set; }
```

### `hingeJoint`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component hingeJoint { get; }
```

### `isActiveAndEnabled`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool isActiveAndEnabled { get; }
```

### `light`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component light { get; }
```

### `Logger`
<!-- tc:scope protected -->
<!-- tc:return_type BehaviourLogger /noir/reference/Noir/Logging/BehaviourLogger/ -->
<!-- tc:version 1.0.0 -->

```csharp
protected BehaviourLogger Logger { get; }
```

### `name`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string name { get; public set; }
```

### `networkView`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component networkView { get; }
```

### `particleSystem`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component particleSystem { get; }
```

### `renderer`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component renderer { get; }
```

### `rigidbody`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component rigidbody { get; }
```

### `rigidbody2D`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component rigidbody2D { get; }
```

### `runInEditMode`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool runInEditMode { get; public set; }
```

### `Services`
<!-- tc:scope protected -->
<!-- tc:return_type ComponentServiceLocator /noir/reference/Noir/DependencyInjection/ComponentServiceLocator/ -->
<!-- tc:version 1.0.0 -->

```csharp
protected ComponentServiceLocator Services { get; }
```

### `tag`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string tag { get; public set; }
```

### `transform`
<!-- tc:scope public -->
<!-- tc:return_type Transform https://docs.unity3d.com/ScriptReference/Transform.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Transform transform { get; }
```

### `useGUILayout`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool useGUILayout { get; public set; }
```

## ⛹️‍♀️ Methods

### `OnDisabled(bool)`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual void OnDisabled(bool isDestroyed)
```

**Parameters** <br>
`isDestroyed` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

### `OnEnabled()`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual void OnEnabled()
```

### `SingletonAwake()`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual void SingletonAwake()
```

### `SingletonStart()`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected virtual void SingletonStart()
```

### `DispatchEvent(T)`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected void DispatchEvent(T eventInfo)
```

**Parameters** <br>
`eventInfo` [T](/noir/reference/) <br>

### `RegisterListener()`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected void RegisterListener()
```

### `UnregisterListener()`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected void UnregisterListener()
```

### `CompareTag(string)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool CompareTag(string tag)
```

**Parameters** <br>
`tag` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `CompareTag(TagHandle)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool CompareTag(TagHandle tag)
```

**Parameters** <br>
`tag` [TagHandle](https://docs.unity3d.com/ScriptReference/TagHandle.html) <br>

### `IsInvoking()`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool IsInvoking()
```

### `IsInvoking(string)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool IsInvoking(string methodName)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

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

### `TryGetComponent(out T&)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool TryGetComponent(T& component)
```

**Parameters** <br>
`component` [T&](/noir/reference/) <br>

### `TryPlaySoundEffect(SoundEffect, Transform, float, float, float, bool, AudioMixerGroup)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool TryPlaySoundEffect(SoundEffect effect, Transform sourceObject, float delay, float volume, float pitch, bool loop, AudioMixerGroup mixerGroup)
```

**Parameters** <br>
`effect` [SoundEffect](/noir/reference/Noir/Audio/SoundEffect/) <br>
`sourceObject` [Transform](https://docs.unity3d.com/ScriptReference/Transform.html) <br>
`delay` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`volume` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`pitch` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`loop` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`mixerGroup` [AudioMixerGroup](https://docs.unity3d.com/ScriptReference/Audio.AudioMixerGroup.html) <br>

### `TryPlaySoundEffect(string, T?, float, float, float, bool, AudioMixerGroup)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public bool TryPlaySoundEffect(string effectName, T? origin, float delay, float volume, float pitch, bool loop, AudioMixerGroup mixerGroup)
```

**Parameters** <br>
`effectName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`origin` [T?](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0) <br>
`delay` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`volume` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`pitch` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`loop` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`mixerGroup` [AudioMixerGroup](https://docs.unity3d.com/ScriptReference/Audio.AudioMixerGroup.html) <br>

### `GetComponent(string)`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component GetComponent(string type)
```

**Parameters** <br>
`type` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `GetComponent(Type)`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component GetComponent(Type type)
```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

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

### `GetComponentInChildren(Type)`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component GetComponentInChildren(Type t)
```

**Parameters** <br>
`t` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

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

### `GetComponentInParent(Type)`
<!-- tc:scope public -->
<!-- tc:return_type Component https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component GetComponentInParent(Type t)
```

**Parameters** <br>
`t` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

### `GetComponents(Type)`
<!-- tc:scope public -->
<!-- tc:return_type Component[] https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component[] GetComponents(Type type)
```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

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

### `GetComponentsInChildren(Type)`
<!-- tc:scope public -->
<!-- tc:return_type Component[] https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component[] GetComponentsInChildren(Type t)
```

**Parameters** <br>
`t` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

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

### `GetComponentsInParent(Type)`
<!-- tc:scope public -->
<!-- tc:return_type Component[] https://docs.unity3d.com/ScriptReference/Component.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Component[] GetComponentsInParent(Type t)
```

**Parameters** <br>
`t` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>

### `StartCoroutine_Auto(IEnumerator)`
<!-- tc:scope public -->
<!-- tc:return_type Coroutine https://docs.unity3d.com/ScriptReference/Coroutine.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Coroutine StartCoroutine_Auto(IEnumerator routine)
```

**Parameters** <br>
`routine` [IEnumerator](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator?view=net-7.0) <br>

### `StartCoroutine(IEnumerator)`
<!-- tc:scope public -->
<!-- tc:return_type Coroutine https://docs.unity3d.com/ScriptReference/Coroutine.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Coroutine StartCoroutine(IEnumerator routine)
```

**Parameters** <br>
`routine` [IEnumerator](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator?view=net-7.0) <br>

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

### `StartCoroutine(string)`
<!-- tc:scope public -->
<!-- tc:return_type Coroutine https://docs.unity3d.com/ScriptReference/Coroutine.html -->
<!-- tc:version 1.0.0 -->

```csharp
public Coroutine StartCoroutine(string methodName)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `GetComponentIndex()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int GetComponentIndex()
```

### `GetInstanceID()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int GetInstanceID()
```

### `GetComponent()`
<!-- tc:scope public -->
<!-- tc:return_type T /noir/reference/ -->
<!-- tc:version 1.0.0 -->

```csharp
public T GetComponent()
```

### `GetComponentInChildren()`
<!-- tc:scope public -->
<!-- tc:return_type T /noir/reference/ -->
<!-- tc:version 1.0.0 -->

```csharp
public T GetComponentInChildren()
```

### `GetComponentInChildren(bool)`
<!-- tc:scope public -->
<!-- tc:return_type T /noir/reference/ -->
<!-- tc:version 1.0.0 -->

```csharp
public T GetComponentInChildren(bool includeInactive)
```

**Parameters** <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

### `GetComponentInParent()`
<!-- tc:scope public -->
<!-- tc:return_type T /noir/reference/ -->
<!-- tc:version 1.0.0 -->

```csharp
public T GetComponentInParent()
```

### `GetComponentInParent(bool)`
<!-- tc:scope public -->
<!-- tc:return_type T /noir/reference/ -->
<!-- tc:version 1.0.0 -->

```csharp
public T GetComponentInParent(bool includeInactive)
```

**Parameters** <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

### `GetComponents()`
<!-- tc:scope public -->
<!-- tc:return_type T[] /noir/reference/ -->
<!-- tc:version 1.0.0 -->

```csharp
public T[] GetComponents()
```

### `GetComponentsInChildren()`
<!-- tc:scope public -->
<!-- tc:return_type T[] /noir/reference/ -->
<!-- tc:version 1.0.0 -->

```csharp
public T[] GetComponentsInChildren()
```

### `GetComponentsInChildren(bool)`
<!-- tc:scope public -->
<!-- tc:return_type T[] /noir/reference/ -->
<!-- tc:version 1.0.0 -->

```csharp
public T[] GetComponentsInChildren(bool includeInactive)
```

**Parameters** <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

### `GetComponentsInParent()`
<!-- tc:scope public -->
<!-- tc:return_type T[] /noir/reference/ -->
<!-- tc:version 1.0.0 -->

```csharp
public T[] GetComponentsInParent()
```

### `GetComponentsInParent(bool)`
<!-- tc:scope public -->
<!-- tc:return_type T[] /noir/reference/ -->
<!-- tc:version 1.0.0 -->

```csharp
public T[] GetComponentsInParent(bool includeInactive)
```

**Parameters** <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

### `Equals(Object)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool Equals(Object other)
```

**Parameters** <br>
`other` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

### `TryPlayClip(AudioClip, T?, float, float, float, bool, AudioMixerGroup, float)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool TryPlayClip(AudioClip clip, T? origin, float delay, float volume, float pitch, bool loop, AudioMixerGroup mixerGroup, float spatialBlend)
```

**Parameters** <br>
`clip` [AudioClip](https://docs.unity3d.com/ScriptReference/AudioClip.html) <br>
`origin` [T?](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0) <br>
`delay` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`volume` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`pitch` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`loop` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`mixerGroup` [AudioMixerGroup](https://docs.unity3d.com/ScriptReference/Audio.AudioMixerGroup.html) <br>
`spatialBlend` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

### `TryPlaySoundEffect(SoundEffect, T?, float, float, float, bool, AudioMixerGroup)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool TryPlaySoundEffect(SoundEffect effect, T? origin, float delay, float volume, float pitch, bool loop, AudioMixerGroup mixerGroup)
```

**Parameters** <br>
`effect` [SoundEffect](/noir/reference/Noir/Audio/SoundEffect/) <br>
`origin` [T?](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=net-7.0) <br>
`delay` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`volume` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`pitch` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`loop` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`mixerGroup` [AudioMixerGroup](https://docs.unity3d.com/ScriptReference/Audio.AudioMixerGroup.html) <br>

### `TryPlaySoundEffect(string, Transform, float, float, float, bool, AudioMixerGroup)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual bool TryPlaySoundEffect(string effectName, Transform sourceObject, float delay, float volume, float pitch, bool loop, AudioMixerGroup mixerGroup)
```

**Parameters** <br>
`effectName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`sourceObject` [Transform](https://docs.unity3d.com/ScriptReference/Transform.html) <br>
`delay` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`volume` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`pitch` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
`loop` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`mixerGroup` [AudioMixerGroup](https://docs.unity3d.com/ScriptReference/Audio.AudioMixerGroup.html) <br>

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

### `StopAllEffects()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void StopAllEffects()
```

### `StopEffect(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual void StopEffect(string name)
```

**Parameters** <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `BroadcastMessage(string, Object, SendMessageOptions)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void BroadcastMessage(string methodName, Object parameter, SendMessageOptions options)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`parameter` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`options` [SendMessageOptions](https://docs.unity3d.com/ScriptReference/SendMessageOptions.html) <br>

### `BroadcastMessage(string, Object)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void BroadcastMessage(string methodName, Object parameter)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`parameter` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

### `BroadcastMessage(string, SendMessageOptions)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void BroadcastMessage(string methodName, SendMessageOptions options)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`options` [SendMessageOptions](https://docs.unity3d.com/ScriptReference/SendMessageOptions.html) <br>

### `BroadcastMessage(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void BroadcastMessage(string methodName)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `CancelInvoke()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void CancelInvoke()
```

### `CancelInvoke(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void CancelInvoke(string methodName)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `GetComponents(List<T>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void GetComponents(List<T> results)
```

**Parameters** <br>
`results` [List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>

### `GetComponents(Type, List<T>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void GetComponents(Type type, List<T> results)
```

**Parameters** <br>
`type` [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=net-7.0) <br>
`results` [List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>

### `GetComponentsInChildren(bool, List<T>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void GetComponentsInChildren(bool includeInactive, List<T> result)
```

**Parameters** <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`result` [List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>

### `GetComponentsInChildren(List<T>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void GetComponentsInChildren(List<T> results)
```

**Parameters** <br>
`results` [List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>

### `GetComponentsInParent(bool, List<T>)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void GetComponentsInParent(bool includeInactive, List<T> results)
```

**Parameters** <br>
`includeInactive` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>
`results` [List\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0) <br>

### `Invoke(string, float)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void Invoke(string methodName, float time)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`time` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

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

### `SendMessage(string, Object, SendMessageOptions)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SendMessage(string methodName, Object value, SendMessageOptions options)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`options` [SendMessageOptions](https://docs.unity3d.com/ScriptReference/SendMessageOptions.html) <br>

### `SendMessage(string, Object)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SendMessage(string methodName, Object value)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

### `SendMessage(string, SendMessageOptions)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SendMessage(string methodName, SendMessageOptions options)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`options` [SendMessageOptions](https://docs.unity3d.com/ScriptReference/SendMessageOptions.html) <br>

### `SendMessage(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SendMessage(string methodName)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `SendMessageUpwards(string, Object, SendMessageOptions)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SendMessageUpwards(string methodName, Object value, SendMessageOptions options)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
`options` [SendMessageOptions](https://docs.unity3d.com/ScriptReference/SendMessageOptions.html) <br>

### `SendMessageUpwards(string, Object)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SendMessageUpwards(string methodName, Object value)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

### `SendMessageUpwards(string, SendMessageOptions)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SendMessageUpwards(string methodName, SendMessageOptions options)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`options` [SendMessageOptions](https://docs.unity3d.com/ScriptReference/SendMessageOptions.html) <br>

### `SendMessageUpwards(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SendMessageUpwards(string methodName)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `StopAllCoroutines()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void StopAllCoroutines()
```

### `StopCoroutine(IEnumerator)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void StopCoroutine(IEnumerator routine)
```

**Parameters** <br>
`routine` [IEnumerator](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator?view=net-7.0) <br>

### `StopCoroutine(string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void StopCoroutine(string methodName)
```

**Parameters** <br>
`methodName` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

### `StopCoroutine(Coroutine)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void StopCoroutine(Coroutine routine)
```

**Parameters** <br>
`routine` [Coroutine](https://docs.unity3d.com/ScriptReference/Coroutine.html) <br>

