# EditorSingleton\<T\>

<!-- tc:namespace NoirEditor -->

<!-- tc:assembly NoirEditor.dll -->

ScriptableObject-based singleton for GUI-less editor plug-ins.
OnEnable() / OnDisable() should be used to register with any global events to properly support domain reloads.


```csharp
public abstract class EditorSingleton<T> : ScriptableObject
```

**Implements:** _[ScriptableObject](https://docs.unity3d.com/ScriptReference/ScriptableObject.html)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope private -->
<!-- tc:version 0.0.0 -->

```csharp
protected EditorSingleton<T>()

```

## Properties

<a name="hideFlags"></a>

### `hideFlags`
<!-- tc:scope public -->
<!-- tc:return_type HideFlags https://docs.unity3d.com/ScriptReference/HideFlags.html -->
<!-- tc:version 0.0.0 -->

```csharp
public HideFlags hideFlags { get; public set; }

```

<a name="instance"></a>

### `instance`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 0.0.0 -->

```csharp
public static T instance { get; }

```

<a name="name"></a>

### `name`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public string name { get; public set; }

```

## Methods

<a name="Initialize"></a>

### `Initialize()`
<!-- tc:scope private -->
<!-- tc:return_type T -->
<!-- tc:version 0.0.0 -->
Finds or creates the singleton instance and stores it in _instance.
Can be called from a derived type to ensure creation of the singleton using the [InitializeOnLoadMethod] attribute on a static method.


```csharp
protected T Initialize()

```

<a name="Awake"></a>

### `Awake()`
<!-- tc:scope private -->
<!-- tc:version 0.0.0 -->
Called once during creation of this instance
Derived classes should call this base method first if overridden.


```csharp
protected virtual void Awake()

```

<a name="GetInstanceID"></a>

### `GetInstanceID()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public int GetInstanceID()

```

<a name="Equals"></a>

### `Equals(Object)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public virtual bool Equals(Object other)

```

**Parameters** <br>
`other` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

<a name="GetHashCode"></a>

### `GetHashCode()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public virtual int GetHashCode()

```

<a name="ToString"></a>

### `ToString()`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public virtual string ToString()

```

<a name="SetDirty"></a>

### `SetDirty()`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void SetDirty()

```

