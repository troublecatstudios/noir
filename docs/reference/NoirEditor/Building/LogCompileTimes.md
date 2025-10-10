# LogCompileTimes

<!-- tc:namespace NoirEditor.Building -->

<!-- tc:assembly NoirEditor.dll -->

Logs the time taken to perform script compilations and domain reloads.


```csharp
public sealed class LogCompileTimes : EditorSingleton<T>
```

**Implements:** _[EditorSingleton\<T\>](/noir/reference//noir/reference/NoirEditor/EditorSingleton-1/)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public LogCompileTimes()

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

<a name="name"></a>

### `name`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public string name { get; public set; }

```

## Methods

<a name="Awake"></a>

### `Awake()`
<!-- tc:scope private -->
<!-- tc:version 0.0.0 -->

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

