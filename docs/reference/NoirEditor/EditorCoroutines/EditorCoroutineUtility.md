# EditorCoroutineUtility

<!-- tc:namespace NoirEditor.EditorCoroutines -->

<!-- tc:assembly NoirEditor.dll -->


```csharp
public static class EditorCoroutineUtility
```

## Methods

<a name="StartCoroutine"></a>

### `StartCoroutine(IEnumerator, Object)`
<!-- tc:scope public -->
<!-- tc:return_type EditorCoroutine /noir/reference//noir/reference/NoirEditor/EditorCoroutines/EditorCoroutine/ -->
<!-- tc:version 0.0.0 -->
Starts an <see cref="T:NoirEditor.EditorCoroutines.EditorCoroutine">EditorCoroutine</see> with the specified owner object.
             If the garbage collector collects the owner object, while the resulting coroutine is still executing, the coroutine will stop running.
             <code>
             using System.Collections;
             using Unity.EditorCoroutines.Editor;
             using UnityEditor;
            
             public class ExampleWindow : EditorWindow
             {
                 int m_Updates = 0;
                 void OnEnable()
                 {
                     EditorCoroutineUtility.StartCoroutine(CountEditorUpdates(), this);
                 }
            
                 IEnumerator CountEditorUpdates()
                 {
                     while (true)
                     {
                         ++m_Updates;
                         yield return null;
                     }
                 }
             }
             </code>
Only types that don't inherit from <see cref="T:UnityEngine.Object">UnityEngine.Object</see> will get collected the next time the GC runs instead of getting null-ed immediately.


```csharp
public EditorCoroutine StartCoroutine(IEnumerator routine, Object owner)

```

**Parameters** <br>
`routine` [IEnumerator](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator?view=net-7.0) <br>
 <br>
`owner` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>
 <br>

<a name="StartCoroutineOwnerless"></a>

### `StartCoroutineOwnerless(IEnumerator)`
<!-- tc:scope public -->
<!-- tc:return_type EditorCoroutine /noir/reference//noir/reference/NoirEditor/EditorCoroutines/EditorCoroutine/ -->
<!-- tc:version 0.0.0 -->
This method starts an <see cref="T:NoirEditor.EditorCoroutines.EditorCoroutine">EditorCoroutine</see> without an owning object. The <see cref="T:NoirEditor.EditorCoroutines.EditorCoroutine">EditorCoroutine</see> runs until it completes or is canceled using <see cref="M:NoirEditor.EditorCoroutines.EditorCoroutineUtility.StopCoroutine(NoirEditor.EditorCoroutines.EditorCoroutine)">StopCoroutine</see>.
             <code>
             using System.Collections;
             using Unity.EditorCoroutines.Editor;
             using UnityEditor;
             using UnityEngine;
            
             public class ExampleWindow : EditorWindow
             {
                 void OnEnable()
                 {
                     EditorCoroutineUtility.StartCoroutineOwnerless(LogTimeSinceStartup());
                 }
            
                 IEnumerator LogTimeSinceStartup()
                 {
                     while (true)
                     {
                         Debug.LogFormat("Time since startup: {0} s", Time.realtimeSinceStartup);
                         yield return null;
                     }
                 }
             }
             </code>


```csharp
public EditorCoroutine StartCoroutineOwnerless(IEnumerator routine)

```

**Parameters** <br>
`routine` [IEnumerator](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator?view=net-7.0) <br>
 <br>

<a name="StopCoroutine"></a>

### `StopCoroutine(EditorCoroutine)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Immediately stop an <see cref="T:NoirEditor.EditorCoroutines.EditorCoroutine">EditorCoroutine</see>. This method is safe to call on an already completed <see cref="T:NoirEditor.EditorCoroutines.EditorCoroutine">EditorCoroutine</see>.
             <code>
             using System.Collections;
             using Unity.EditorCoroutines.Editor;
             using UnityEditor;
             using UnityEngine;
            
             public class ExampleWindow : EditorWindow
             {
                 EditorCoroutine m_LoggerCoroutine;
                 void OnEnable()
                 {
                     m_LoggerCoroutine = EditorCoroutineUtility.StartCoroutineOwnerless(LogRunning());
                 }
            
                 void OnDisable()
                 {
                     EditorCoroutineUtility.StopCoroutine(m_LoggerCoroutine);
                 }
            
                 IEnumerator LogRunning()
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
public void StopCoroutine(EditorCoroutine coroutine)

```

**Parameters** <br>
`coroutine` [EditorCoroutine](/noir/reference//noir/reference/NoirEditor/EditorCoroutines/EditorCoroutine/) <br>
 <br>

