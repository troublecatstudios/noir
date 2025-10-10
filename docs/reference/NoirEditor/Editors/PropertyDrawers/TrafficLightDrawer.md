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

## Properties

<a name="attribute"></a>

### `attribute`
<!-- tc:scope public -->
<!-- tc:return_type PropertyAttribute https://docs.unity3d.com/ScriptReference/PropertyAttribute.html -->
<!-- tc:version 0.0.0 -->

```csharp
public PropertyAttribute attribute { get; }

```

<a name="fieldInfo"></a>

### `fieldInfo`
<!-- tc:scope public -->
<!-- tc:return_type FieldInfo https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public FieldInfo fieldInfo { get; }

```

## Methods

<a name="CanCacheInspectorGUI"></a>

### `CanCacheInspectorGUI(SerializedProperty)`
<!-- tc:scope public -->
<!-- tc:return_type bool https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public virtual bool CanCacheInspectorGUI(SerializedProperty property)

```

**Parameters** <br>
`property` [SerializedProperty](https://docs.unity3d.com/ScriptReference/SerializedProperty.html) <br>

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

<a name="CreatePropertyGUI"></a>

### `CreatePropertyGUI(SerializedProperty)`
<!-- tc:scope public -->
<!-- tc:return_type VisualElement https://docs.unity3d.com/ScriptReference/UIElements.VisualElement.html -->
<!-- tc:version 0.0.0 -->

```csharp
public virtual VisualElement CreatePropertyGUI(SerializedProperty property)

```

**Parameters** <br>
`property` [SerializedProperty](https://docs.unity3d.com/ScriptReference/SerializedProperty.html) <br>

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

