# ActiveBuildTargetChangedHandler

**Namespace:** NoirEditor.Callbacks <br>
**Assembly:** NoirEditor.dll

```csharp
public class ActiveBuildTargetChangedHandler : IActiveBuildTargetChanged, IOrderedCallback
```

**Implements:** _[IActiveBuildTargetChanged](../../), [IOrderedCallback](../../)_

### 🛠 Constructors
```csharp
public ActiveBuildTargetChangedHandler()
```

### 📦 Properties
#### callbackOrder
```csharp
public virtual int callbackOrder { get; }
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>
### ⛹️‍♀️ Methods
#### OnActiveBuildTargetChanged(BuildTarget, BuildTarget)
```csharp
public virtual void OnActiveBuildTargetChanged(BuildTarget previousTarget, BuildTarget newTarget)
```

**Parameters** <br>
`previousTarget` [BuildTarget](../../) <br>
`newTarget` [BuildTarget](../../) <br>

