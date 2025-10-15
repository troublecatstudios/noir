# Features

## Categories

### Gameplay

The following features make creating game mechanics or adding polish easier.

<div class="grid cards" markdown>

-   :material-dice-6-outline: &nbsp; __[Procedural Generation][procgen]__

    ---

    Procedural generation is a method of creating data algorithmically instead of manually, combining human-generated
    content with computer-generated randomness and processing power.

    ---

    __Use math to create vast and diverse worlds, enemy behaviors and interactable objects for your games__

-   :material-flash-outline: &nbsp; __[Events][events]__

    ---

    Events allow you to publish and subscribe to messages within your game, creating dynamic and reactive experiences
    while allowing you to more easily refactor and extend your code.

    ---

    __Easily connect multiple bahaviours together without tight coupling__

-   :material-circle-multiple-outline: &nbsp; __Object pooling__

    ---

    **Coming soon.** Object pooling enables efficient spawning and management of hundreds or thousands
    of objects using prefabs and a simple MonoBehaviour.

    ---

    __Create hectic and exciting gameplay without over taxing your players machines__

-   :material-cast-audio: &nbsp; __Sound Effects__

    ---

    **Documentation coming soon.** Sound effects are data objects that reference mulitple [AudioClip][unity_audioclip] and decouple
    asset references from code, allowing game code and animations to play sounds easily.

    ---

    __Adding and managing sound effects within your game is easy__

</div>

  [procgen]: procedural_generation.md
  [events]: events.md
  [pool]: object_pooling.md
  [sfx]: sound_effects.md
  [unity_audioclip]: https://docs.unity3d.com/ScriptReference/AudioClip.html

### Editor

The following features greatly improve the authoring experience when working on your game.

<div class="grid cards" markdown>

-   :material-code-brackets: &nbsp; __Attributes__

    ---

    **Documentation coming soon.** Save time and keystrokes by using built-in decorators to automatically create ScriptableObjects,
    bind input actions, automatically populate component references and more.

    ---

    __Attributes reduce the amount of code you have to write to take advantage of powerful editor shortcuts__

-   :material-code-block-braces: &nbsp; __Code Generation__

    ---

    **Documentation coming soon.** Noir generates and automatically updates C# code that allows you to access your scenes, sorting layers,
    collision layers, tags and more directly from your scripts.

    ---

    __Easily access Unity constructs and receive build errors if they are removed/renamed__

-   :material-variable-box: &nbsp; __[Data Variables][variables]__

    ---

    Data variables make it easy to store data and reference it from different
    parts of your game code.

    ---

    __Simpler organization, management and sharing of data across your game objects__

-   :material-robot-happy-outline: &nbsp; __NoirBehaviour__

    ---

    **Documentation coming soon.** Noir inlcudes a base behaviour class that provides easy access to the Noir event system, service location,
    and logging.

    ---

    __No need to roll your own bootstrap class or copy and paste blocks of code to each behaviour__

</div>

  [attributes]: attributes.md
  [codegen]: codegen.md
  [variables]: data_variables.md
  [noirbehaviour]: noirbehaviour.md
