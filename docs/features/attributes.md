# Editor attributes

### GetComponent

The `GetComponent` attribute is a fork of [`AutohookAttribute`][autohook], originally
created by the extremely talented [Lotte][lotte]. Please consider [donating][donate1] to them if
you've found this attribute useful.

  [autohook]: https://gist.github.com/LotteMakesStuff/d6a9a4944fc667e557083108606b7d22
  [lotte]: https://github.com/LotteMakesStuff
  [donate1]: https://ko-fi.com/lotte

```csharp
[GetComponent(GetComponentSearchArea searchArea = GetComponentSearchArea.SelfOnly)]
public AudioSource ExampleAudio;
```

#### [`searchArea`](#searchArea)

Allows more control over the logic used when searching for matching component types.

* `SelfOnly` - Search for the component type only on the current GameObject.
* `ParentFirst` - Search for the component type within the parents of the current GameObject before searching on the current GameObject.
* `ChildrenFirst` - Search for the component type within the children of the current GameObject before searching on the current GameObject.

[View the full reference documentation](/noir/reference/Noir/Attributes/GetComponentAttribute/){ .md-button }
