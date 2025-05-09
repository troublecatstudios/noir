# EditorWindowCoroutineExtension

<!-- tc:namespace NoirEditor.EditorCoroutines -->
<!-- tc:assembly NoirEditor.dll -->


```csharp
public static class EditorWindowCoroutineExtension
```

## Methods

### `StartCoroutine(EditorWindow, IEnumerator)`
<!-- tc:scope public -->
<!-- tc:return_type EditorCoroutine ../../NoirEditor/EditorCoroutines/EditorCoroutine.html -->
<!-- tc:version 0.0.0 -->
Start an <see cref="T:NoirEditor.EditorCoroutines.EditorCoroutine">EditorCoroutine</see>, owned by the calling <see cref="T:UnityEditor.EditorWindow">EditorWindow</see> instance.
             <code>
             using System.Collections;
             using Unity.EditorCoroutines.Editor;
             using UnityEditor;
            
             public class ExampleWindow : EditorWindow
             {
                 void OnEnable()
                 {
                     this.StartCoroutine(CloseWindowDelayed());
                 }
            
                 IEnumerator CloseWindowDelayed() //close the window after 1000 frames have elapsed
                 {
                     int count = 1000;
                     while (count &gt; 0)
                     {
                         yield return null;
                     }
                     Close();
                 }
             }
             </code>


```csharp
public EditorCoroutine StartCoroutine(EditorWindow window, IEnumerator routine)
```

**Parameters** <br>
`window` [EditorWindow](https://docs.unity3d.com/ScriptReference/EditorWindow.html) <br>
`routine` [IEnumerator](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator?view=net-7.0) <br>
 <br>

### `StopCoroutine(EditorWindow, EditorCoroutine)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Immediately stop an [EditorWindow](https://docs.unity3d.com/ScriptReference/EditorWindow.html) instance. This method is safe to call on an already completed <see cref="T:NoirEditor.EditorCoroutines.EditorCoroutine">EditorCoroutine</see>.
             <code>
             using System.Collections;
             using Unity.EditorCoroutines.Editor;
             using UnityEditor;
             using UnityEngine;
            
             public class ExampleWindow : EditorWindow
             {
                 EditorCoroutine coroutine;
                 void OnEnable()
                 {
                     coroutine = this.StartCoroutine(CloseWindowDelayed());
                 }
            
                 private void OnDisable()
                 {
                     this.StopCoroutine(coroutine);
                 }
            
                 IEnumerator CloseWindowDelayed()
                 {
                     while (true)
                     {
                         Debug.Log("Running");
                         yield return null;
                     }
                 }
             }
             </code>


```csharp
public void StopCoroutine(EditorWindow window, EditorCoroutine coroutine)
```

**Parameters** <br>
`window` [EditorWindow](https://docs.unity3d.com/ScriptReference/EditorWindow.html) <br>
`coroutine` [EditorCoroutine](../../NoirEditor/EditorCoroutines/EditorCoroutine.html) <br>
 <br>

