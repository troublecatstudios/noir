---
title: Automatically Creating ScriptableObjects
tags:
    - features
    - basic
    - ScriptableObjects
    - data-management
    - data
---

How often does this happen: you add a new `ScriptableObject` class to your game, intending for it to be loaded from the `Resources` folder, or an AssetBundle only to hit play and have your game throw an error stating that the asset can't be found and you realize that you never instantiated the ScriptableObject where it needed to be? Now you have to add a `[CreateAssetMenu]` attribute, cluttering up your menu for an asset that only needs to be created once.

Or maybe you're building a package and need a way to ensure that a ScriptableObject is created once the package is imported, but don't want to add the potential frustration of developers forgetting to select a menu option?

Noir provides the `[AutomaticallyCreate]` attribute to decorate `ScriptableObject` classes and mark them to be created when the next code compilation completes.

The example below defines a new `SceneCollection` scriptable object. Once the code compilation is completed a new instance will be created at `./Assets/SceneCollection.asset`. All automatically created scriptable objects are created within the `./Assets` folder and use the class name as the asset file name by default.

```csharp
using Noir.Attributes;
using UnityEngine;

[AutomaticallyCreate]
public class SceneCollection : ScriptableObject {
    [Scene] public string MainScene;
}

```


## Changing the asset location

Assets can be automatically created within any folder path underneath the `./Assets` folder. Changing the path is done via the `customPathPrefix` argument. The example below will create the `SceneCollection` from before at `./Assets/Resources/SceneCollection.asset`.

```csharp
using Noir.Attributes;
using UnityEngine;

[AutomaticallyCreate(customPathPrefix: "Resources/")]
public class SceneCollection : ScriptableObject {
    [Scene] public string MainScene;
}

```

## Useful patterns

Below are some useful patterns that can be easily implemented using the `AutomaticallyCreate` attribute.

### ScriptableObject Singleton

Building off the previous examples, we can ensure that our `SceneCollection` asset is created before we run our game and make it available as a [singleton](https://gameprogrammingpatterns.com/singleton.html).

```csharp
using Noir.Attributes;
using UnityEngine;

[AutomaticallyCreate(customPathPrefix: "Resources/")]
public class SceneCollection : ScriptableObject {
    private static SceneCollection _instance;

    public static SceneCollection Instance {
        get {
            if (!_instance) {
                _instance = Resources.Load<SceneCollection>($"{nameof(SceneCollection)}");
            }
            return _instance;
        }
    }

    [Scene] public string MainScene;
}
```

#### Use Cases

* Sharing common data between separate components, without requiring fields to be assigned in-editor.
* Allowing access to data without requiring a dependency on asset bundles or addressables.
* Providing configuration for a custom Unity package
