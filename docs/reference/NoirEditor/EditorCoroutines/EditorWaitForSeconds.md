# EditorWaitForSeconds

**Namespace:** NoirEditor.EditorCoroutines <br>
**Assembly:** NoirEditor.dll

```csharp
public class EditorWaitForSeconds
```

Suspends the <see cref="T:NoirEditor.EditorCoroutines.EditorCoroutine">EditorCoroutine</see> execution for the given amount of seconds, using unscaled time.
             The coroutine execution continues after the specified time has elapsed.
             <code>
             using System.Collections;
             using UnityEngine;
             using Unity.EditorCoroutines.Editor;
             using UnityEditor;
            
             public class MyEditorWindow : EditorWindow
             {
                 IEnumerator PrintEachSecond()
                 {
                     var waitForOneSecond = new EditorWaitForSeconds(1.0f);
            
                     while (true)
                     {
                         yield return waitForOneSecond;
                         Debug.Log("Printing each second");
                     }
                 }
             }
             </code>

### 🛠 Constructors
```csharp
public EditorWaitForSeconds(float time)
```

Creates a instruction object for yielding inside a generator function.

**Parameters** <br>
`time` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

### 📦 Properties
#### WaitTime
```csharp
public float WaitTime { get; }
```

The time to wait in seconds.

**Returns** <br>
[float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
