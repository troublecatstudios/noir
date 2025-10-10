# SerializedPropertyExtensions

<!-- tc:namespace NoirEditor -->

<!-- tc:assembly NoirEditor.dll -->


```csharp
public static class SerializedPropertyExtensions
```

## Methods

<a name="GetValue"></a>

### `GetValue(SerializedProperty)`
<!-- tc:scope public -->
<!-- tc:return_type Object https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0 -->
<!-- tc:version 0.0.0 -->
Retrieves the value of the specified SerializedProperty.
This method navigates through the property path of the SerializedProperty to retrieve the final value.


```csharp
public Object GetValue(SerializedProperty property)

```

**Parameters** <br>
`property` [SerializedProperty](https://docs.unity3d.com/ScriptReference/SerializedProperty.html) <br>
 <br>

<a name="SetValue"></a>

### `SetValue(SerializedProperty, Object)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Sets the value of the specified SerializedProperty.
This method records an undo operation, sets the value of the SerializedProperty, marks the object as dirty, and applies the modified properties.


```csharp
public void SetValue(SerializedProperty property, Object value)

```

**Parameters** <br>
`property` [SerializedProperty](https://docs.unity3d.com/ScriptReference/SerializedProperty.html) <br>
 <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>

<a name="SetValueNoRecord"></a>

### `SetValueNoRecord(SerializedProperty, Object)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Sets the value of the specified SerializedProperty.
This method sets the value of the SerializedProperty, however the change will not be persisted unless you call SetDirty and ApplyModifiedProperties. Also, no undo operation is recorded.


```csharp
public void SetValueNoRecord(SerializedProperty property, Object value)

```

**Parameters** <br>
`property` [SerializedProperty](https://docs.unity3d.com/ScriptReference/SerializedProperty.html) <br>
 <br>
`value` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>

