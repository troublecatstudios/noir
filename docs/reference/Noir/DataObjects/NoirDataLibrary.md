# NoirDataLibrary

<!-- tc:namespace Noir.DataObjects -->

<!-- tc:assembly Noir.dll -->

Central data registry for Noir game assets and runtime-accessible variables.
The [NoirDataLibrary](/noir/reference/Noir/DataObjects/NoirDataLibrary/) acts as a globally accessible repository for
            [DataVariable](/noir/reference/Noir/Variables/DataVariable/) assets.
            It automatically loads itself from the Unity <c>Resources</c> folder and provides
            cached lookups to improve performance during repeated access.


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

## Fields

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

## Properties

<a name="Instance"></a>

### `Instance`
<!-- tc:scope public -->
<!-- tc:return_type NoirDataLibrary /noir/reference/Noir/DataObjects/NoirDataLibrary/ -->
<!-- tc:version 1.0.0 -->
Gets the globally accessible instance of the [NoirDataLibrary](/noir/reference/Noir/DataObjects/NoirDataLibrary/).
The instance is automatically loaded from the <c>Resources</c> folder at runtime.
            This ensures that systems referencing shared data—such as audio managers or
            gameplay logic—can access it without explicit references in the scene.


```csharp
public static NoirDataLibrary Instance { get; }

```

## Methods

<a name="GetSoundEffectByName"></a>

### `GetSoundEffectByName(string)`
<!-- tc:scope public -->
<!-- tc:return_type SoundEffect /noir/reference/Noir/Audio/SoundEffect/ -->
<!-- tc:version 1.0.0 -->
Retrieves a [SoundEffect](/noir/reference/Noir/Audio/SoundEffect/) by name, using cached lookup when possible.


```csharp
public SoundEffect GetSoundEffectByName(string name)

```

**Parameters** <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

<a name="GetVariableByName"></a>

### `GetVariableByName(string)`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 1.0.0 -->
Retrieves a [DataVariable](/noir/reference/Noir/Variables/DataVariable/) of the specified type by name.
If the variable is not found, a warning is logged and <c>null</c> is returned.


```csharp
public T GetVariableByName(string name)

```

**Parameters** <br>
`name` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

## More information

* [Noir.DataObjects.NoirDataLibrary](/noir/reference/Noir/DataObjects/NoirDataLibrary/)
* [Noir.Audio.SoundEffect](/noir/reference/Noir/Audio/SoundEffect/)
* [Noir.Variables.DataVariable](/noir/reference/Noir/Variables/DataVariable/)
