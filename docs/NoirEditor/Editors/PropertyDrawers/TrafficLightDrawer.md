# TrafficLightDrawer

**Namespace:** NoirEditor.Editors.PropertyDrawers <br>
**Assembly:** NoirEditor.dll

```csharp
public class TrafficLightDrawer : PropertyDrawer
```

**Implements:** _[PropertyDrawer](../../../)_

### 🛠 Constructors
```csharp
public TrafficLightDrawer()
```

### 📦 Properties
#### attribute
```csharp
public PropertyAttribute attribute { get; }
```

**Returns** <br>
[PropertyAttribute](../../../) <br>
#### fieldInfo
```csharp
public FieldInfo fieldInfo { get; }
```

**Returns** <br>
[FieldInfo](https://learn.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo?view=net-7.0) <br>
### ⛹️‍♀️ Methods
#### CanCacheInspectorGUI(SerializedProperty)
```csharp
public virtual bool CanCacheInspectorGUI(SerializedProperty property)
```

**Parameters** <br>
`property` [SerializedProperty](../../../) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### GetPropertyHeight(SerializedProperty, GUIContent)
```csharp
public virtual float GetPropertyHeight(SerializedProperty property, GUIContent label)
```

**Parameters** <br>
`property` [SerializedProperty](../../../) <br>
`label` [GUIContent](../../../) <br>

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>

#### CreatePropertyGUI(SerializedProperty)
```csharp
public virtual VisualElement CreatePropertyGUI(SerializedProperty property)
```

**Parameters** <br>
`property` [SerializedProperty](../../../) <br>

**Returns** <br>
[VisualElement](../../../) <br>

#### OnGUI(Rect, SerializedProperty, GUIContent)
```csharp
public virtual void OnGUI(Rect position, SerializedProperty property, GUIContent label)
```

**Parameters** <br>
`position` [Rect](../../../) <br>
`property` [SerializedProperty](../../../) <br>
`label` [GUIContent](../../../) <br>

