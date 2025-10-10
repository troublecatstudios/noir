# EditorWaitForSeconds

<!-- tc:namespace NoirEditor.EditorCoroutines -->

<!-- tc:assembly NoirEditor.dll -->

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


```csharp
public class EditorWaitForSeconds
```

## Constructors

<a name=".ctor"></a>

### `.ctor(float)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->
Creates a instruction object for yielding inside a generator function.


```csharp
public EditorWaitForSeconds(float time)

```

**Parameters** <br>
`time` [float](https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0) <br>
 <br>

## Properties

<a name="WaitTime"></a>

### `WaitTime`
<!-- tc:scope public -->
<!-- tc:return_type float https://learn.microsoft.com/en-us/dotnet/api/System.Single?view=net-7.0 -->
<!-- tc:version 0.0.0 -->
The time to wait in seconds.


```csharp
public float WaitTime { get; }

```

## More information

* [EditorCoroutine](T:NoirEditor.EditorCoroutines.EditorCoroutine)
