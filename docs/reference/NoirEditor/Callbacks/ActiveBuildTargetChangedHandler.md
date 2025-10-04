# ActiveBuildTargetChangedHandler

<!-- tc:namespace NoirEditor.Callbacks -->

<!-- tc:assembly NoirEditor.dll -->


```csharp
public class ActiveBuildTargetChangedHandler : IActiveBuildTargetChanged, IOrderedCallback
```

**Implements:** _[IActiveBuildTargetChanged](https://docs.unity3d.com/ScriptReference/Build.IActiveBuildTargetChanged.html), [IOrderedCallback](https://docs.unity3d.com/ScriptReference/Build.IOrderedCallback.html)_

## Constructors

### `.ctor()`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public ActiveBuildTargetChangedHandler()

```

## Properties

### `callbackOrder`
<!-- tc:scope public -->
<!-- tc:return_type int https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0 -->
<!-- tc:version 0.0.0 -->

```csharp
public virtual int callbackOrder { get; }

```

## Methods

### `OnActiveBuildTargetChanged(BuildTarget, BuildTarget)`
<!-- tc:scope public -->
<!-- tc:version 0.0.0 -->

```csharp
public virtual void OnActiveBuildTargetChanged(BuildTarget previousTarget,
                                                BuildTarget newTarget)


```

**Parameters** <br>
`previousTarget` [BuildTarget](https://docs.unity3d.com/ScriptReference/BuildTarget.html) <br>
`newTarget` [BuildTarget](https://docs.unity3d.com/ScriptReference/BuildTarget.html) <br>

