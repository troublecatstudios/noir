# TrafficLightDrawer

<!-- tc:namespace NoirEditor.Editors.PropertyDrawers -->

<!-- tc:assembly NoirEditor.dll -->


```csharp
public class TrafficLightDrawer : PropertyDrawer
```

**Implements:** _[PropertyDrawer](https://docs.unity3d.com/ScriptReference/PropertyDrawer.html)_

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public TrafficLightDrawer()

```

## Methods

<a name="GetPropertyHeight"></a>

### `GetPropertyHeight(SerializedProperty, GUIContent)`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public virtual float GetPropertyHeight(SerializedProperty property,
                                        GUIContent label)


```

**Parameters** <br>
`property` [SerializedProperty](https://docs.unity3d.com/ScriptReference/SerializedProperty.html) <br>
`label` [GUIContent](https://docs.unity3d.com/ScriptReference/GUIContent.html) <br>

<a name="OnGUI"></a>

### `OnGUI(Rect, SerializedProperty, GUIContent)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public virtual void OnGUI(Rect position, SerializedProperty property,
                           GUIContent label)


```

**Parameters** <br>
`position` [Rect](https://docs.unity3d.com/ScriptReference/Rect.html) <br>
`property` [SerializedProperty](https://docs.unity3d.com/ScriptReference/SerializedProperty.html) <br>
`label` [GUIContent](https://docs.unity3d.com/ScriptReference/GUIContent.html) <br>

