# EditorWindowCoroutineExtension

**Namespace:** NoirEditor.EditorCoroutines <br>
**Assembly:** NoirEditor.dll

```csharp
public static class EditorWindowCoroutineExtension
```

### ⛹️‍♀️ Methods
#### StartCoroutine(EditorWindow, IEnumerator)
```csharp
public EditorCoroutine StartCoroutine(EditorWindow window, IEnumerator routine)
```

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

**Parameters** <br>
`window` [EditorWindow](../../) <br>
`routine` [IEnumerator](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator?view=net-7.0) <br>
 <br>

**Returns** <br>
[EditorCoroutine](../../NoirEditor/EditorCoroutines/EditorCoroutine.html) <br>
 <br>

#### StopCoroutine(EditorWindow, EditorCoroutine)
```csharp
public void StopCoroutine(EditorWindow window, EditorCoroutine coroutine)
```

Immediately stop an [EditorWindow](../../) instance. This method is safe to call on an already completed <see cref="T:NoirEditor.EditorCoroutines.EditorCoroutine">EditorCoroutine</see>.
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

**Parameters** <br>
`window` [EditorWindow](../../) <br>
`coroutine` [EditorCoroutine](../../NoirEditor/EditorCoroutines/EditorCoroutine.html) <br>
 <br>

