# NoirDataLibrary

<!-- tc:namespace Noir.DataObjects -->

<!-- tc:assembly Noir.dll -->


```csharp
public class NoirDataLibrary : ScriptableObject
```

**Implements:** _[ScriptableObject](https://docs.unity3d.com/ScriptReference/ScriptableObject.html)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public NoirDataLibrary()

```

## Properties

<a name="hideFlags"></a>

### `hideFlags`
<!-- tc:scope public -->
<!-- tc:return_type HideFlags https://docs.unity3d.com/ScriptReference/HideFlags.html -->
<!-- tc:version 1.0.0 -->

```csharp
public HideFlags hideFlags { get; public set; }

```

<a name="Instance"></a>

### `Instance`
<!-- tc:scope public -->
<!-- tc:return_type NoirDataLibrary /noir/reference//noir/reference/Noir/DataObjects/NoirDataLibrary/ -->
<!-- tc:version 1.0.0 -->

```csharp
public static NoirDataLibrary Instance { get; }

```

<a name="name"></a>

### `name`
<!-- tc:scope public -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public string name { get; public set; }

```

<a name="SoundEffects"></a>

### `SoundEffects`
<!-- tc:scope private -->
<!-- tc:return_type List\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public List<T> SoundEffects;

```

<a name="Variables"></a>

### `Variables`
<!-- tc:scope private -->
<!-- tc:return_type List\<T\> https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public List<T> Variables;

```

## Methods

<a name="GetInstanceID"></a>

### `GetInstanceID()`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
public int GetInstanceID()

```

<a name="GetSoundEffectByName"></a>

### `GetSoundEffectByName(string)`
<!-- tc:scope public -->
<!-- tc:return_type SoundEffect /noir/reference//noir/reference/Noir/Audio/SoundEffect/ -->
<!-- tc:version 1.0.0 -->

```csharp
public SoundEffect GetSoundEffectByName(string name)

```

**Parameters** <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="GetVariableByName"></a>

### `GetVariableByName(string)`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 1.0.0 -->
Gets a variable by name.


```csharp
public T GetVariableByName(string name)

```

**Parameters** <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

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

<a name="SetDirty"></a>

### `SetDirty()`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->

```csharp
public void SetDirty()

```

