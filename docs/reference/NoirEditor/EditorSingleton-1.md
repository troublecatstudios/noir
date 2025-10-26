# EditorSingleton\<T\>

<!-- tc:namespace NoirEditor -->

<!-- tc:assembly NoirEditor.dll -->

ScriptableObject-based singleton for GUI-less editor plug-ins.
OnEnable() / OnDisable() should be used to register with any global events to properly support domain reloads.


```csharp
public abstract class EditorSingleton<T> : ScriptableObject
```

**Implements:** _[ScriptableObject](https://docs.unity3d.com/ScriptReference/ScriptableObject.html)_

## Properties

<a name="instance"></a>

### `instance`
<!-- tc:scope public -->
<!-- tc:return_type T -->
<!-- tc:version 0.0.0 -->
The singleton instance of type <typeparamref name="T" />.
This is not thread safe, but should be fine for use within ScriptableObjects within the Unity Editor.


```csharp
public static T instance { get; }

```

