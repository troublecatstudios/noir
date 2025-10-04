# EditorSingleton\<T\>

<!-- tc:namespace NoirEditor -->

<!-- tc:assembly NoirEditor.dll -->

ScriptableObject-based singleton for GUI-less editor plug-ins.


```csharp
public abstract class EditorSingleton<T> : ScriptableObject
```

**Implements:** _[ScriptableObject](https://docs.unity3d.com/ScriptReference/ScriptableObject.html)_

## Constructors

### `.ctor()`
<!-- tc:scope private -->
<!-- tc:version 0.0.0 -->

```csharp
protected EditorSingleton<T>()

```

## Properties

### `hideFlags`
<!-- tc:scope public -->
<!-- tc:return_type HideFlags https://docs.unity3d.com/ScriptReference/HideFlags.html -->
<!-- tc:version 0.0.0 -->

```csharp
public HideFlags hideFlags { get; public set; }

```

### `instance`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 0.0.0 -->

```csharp
public static T instance { get; }

```

### `name`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public string name { get; public set; }

```

## Methods

### `Initialize()`
<!-- tc:scope private -->
<!-- tc:return_type T -->
<!-- tc:version 0.0.0 -->
Finds or creates the singleton instance and stores it in _instance.


```csharp
protected T Initialize()

```

### `Awake()`
<!-- tc:scope private -->
<!-- tc:version 0.0.0 -->
Called once during creation of this instance


```csharp
protected virtual void Awake()

```

### `GetInstanceID()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public int GetInstanceID()

```

### `Equals(Object)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public virtual bool Equals(Object other)

```

**Parameters** <br>
`other` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

### `GetHashCode()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public virtual int GetHashCode()

```

### `ToString()`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public virtual string ToString()

```

### `SetDirty()`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public void SetDirty()

```

