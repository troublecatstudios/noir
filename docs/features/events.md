# Events

Using events allows you to connect multiple code objects without any of them needing to be aware of any of the others.

This enables the development of more modular game features by decoupling the code that performs an action from the code
that checks the game state to determine if the action should run.

## Event types

The Noir library has two different kinds of events: Code Events and Data Events.

`Code Events`

:   Code events are strongly typed C# data structures that can be emitted at any layer within your game. Subscribers
    register and unregister based on the lifecycle of their game object.

`Data Events`

:   Data events are scriptable objects that can be referenced by many game objects within your game. Each game object
    can subscribe to any data event it contains. Data events can be triggered by any game object that references
    them.


## Creating a code event - spawning projectiles

Creating a code event starts with defining the event data structure. For this example, we'll create an event that we
intend to use to spawn a projectile when the player presses the space bar on their keyboard.

=== "SpawnProjectileEvent.cs"

    Code events in Noir are just *P*lain *O*ld *C#* *O*bjects (POCOs).

    ```csharp
    using UnityEngine;
    using System;

    public class SpawnProjectileEvent {
        public Vector3 Position;
        public Vector3 Direction;
        public float Speed;
        public GameObject ProjectileObject;
    }
    ```

=== "PlayerInputBehaviour.cs"

    Create a game object in your scene named "PlayerInput" and add the script below. It polls the input system each
    frame to see if the player has pressed the spacebar on the keyboard. Each time the spacebar is pressed down a
    new `SpawnProjectileEvent` will be dispatched.

    ```csharp
    using Noir;
    using UnityEngine;

    public class PlayerInputBehaviour : NoirBehaviour {
        [SerializeField] private GameObject _projectileObject;
        [SerializeField] private float _speed = 10;
        [SerializeField] private Vector3 _shootDirection = new Vector3(1, 0, 0);

        private void Update() {
            if (Input.GetKeyDown(KeyCode.Space)) {
                DispatchEvent<SpawnProjectileEvent>(new() {
                    ProjectileObject = _projectileObject,
                    Position = Vector3.zero,
                    Direction = _shootDirection,
                    Speed = _speed,
                });
            }
        }
    }
    ```


=== "ProjectileManager.cs"

    Create a new game object at the root of your scene named "ProjectileManager" and add the following script. The script
    listens for all dispatched events with the type `SpawnProjectileEvent` and will log a debug message to the Unity console
    upon receiving one.

    ```csharp
    public class ProjectileManager : NoirSingletonBehaviour<ProjectileManager>,
                                     INoirEventListener<SpawnProjectileEvent> {
        protected override void SingletonStart() {
            base.SingletonStart();
            ServiceLocator.GetService<INoirEventRegistry>()
                .Register<SpawnProjectileEvent>(gameObject);
        }

        void INoirEventListener<SpawnProjectileEvent>.EventReceived(SpawnProjectileEvent eventInfo) {
            Logger.Debug($"SpawnProjectileEvent position={eventInfo.Position.ToLogString()}, "+
                         $"direction={eventInfo.Direction.ToLogString()}" +
                         $"speed={eventInfo.Speed}, projectileObject={eventInfo.ProjectileObject.name}");
        }
    }
    ```

    This script utilizes the [singleton][singleton_pattern] programming pattern - modified slightly to fit within the
    Unity engine. This object will exist for the full lifetime of the game so it never needs to unregister with the
    event registry.


### Obeying the object lifecycle

Event listeners are somewhat expensive and can cause memory leaks if not disposed of correctly. Noir makes this easy
by providing simple register and unregister methods that should be called within your behaviour lifecycle to ensure
any event listeners are cleared and re-established as needed.

```csharp
private void OnEnable() {
    ServiceLocator.GetService<INoirEventRegistry>()
        .Register<SpawnProjectileEvent>(gameObject);
}

private void OnDisable() {
    ServiceLocator.GetService<INoirEventRegistry>()
        .Unregister<SpawnProjectileEvent>(gameObject);
}
```

This is even simpler if your object extends from the [NoirBehaviour][noirbehaviour] base class.

```csharp
public class ProjectileManager : NoirBehaviour,
                                 INoirEventListener<SpawnProjectileEvent> {
    private void OnEnable() {
        RegisterListener<SpawnProjectileEvent>();
    }

    private void OnDisable() {
        UnregisterListener<SpawnProjectileEvent>();
    }
}
```


[singleton_pattern]: https://gameprogrammingpatterns.com/singleton.html
[un_mb_enable]: https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnEnable.html
[un_mb_disable]: https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnDisable.html
[noirbehaviour]: ../reference/Noir/NoirBehaviour.md
