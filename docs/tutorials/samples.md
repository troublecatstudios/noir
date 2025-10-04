# Noir Library Samples

## Basics

### Service Location (dependency injection, sort of)

Noir includes a static singleton `ServiceLocator` that can be accessed directly and also via the `Services` property in both the `NoirBehaviour` and `NoirSingletonBehaviour` component classes.

Noir isn't built on a "proper" dependency injection solution, mostly because they impart too many opinions into the code structure of a game.

=== "Registering a service"

    The ImplementationType must be able to instantiated
    via an empty constructor, e.g. new ImplementationType()

    ```csharp
    ServiceLocator.RegisterService<InterfaceType, ImplmentationType>();
    ```


=== "Using a factory function"

    The passed factory function will be invoked when
    the service is first requested

    ```csharp
    ServiceLocator.RegisterService<InterfaceType>(() =>
        new ImplementationType(any, constructor, arguments));
    ```


=== "Using an instance"

    This should be avoided unless absolutely necessary
    as it can force the parent scope to avoid garbage
    collection until the implementation is removed from
    the service registry

    ```csharp
    var implementation = new ImplementationType(any, constructor, arguments);
    ServiceLocator.RegisterService<InterfaceType>(implementation);
    ```

##### Tips for using ServiceLocator

- It's best to limit calls to ServiceLocator methods the startup of your components: `Awake()`, `Start()`, `OnEnable()` are all good points to register and get services.
- Avoid calling the service locator within loops or `Update()` and `LateUpdate()`.
- When registering with the service locator, it's best to register an interface or abstract class as the lookup type.

#### More Info

- [Dependency Injections Demystified](https://www.jamesshore.com/v2/blog/2006/dependency-injection-demystified) by James Shore
- [ServiceLocator Pattern](https://gameprogrammingpatterns.com/service-locator.html) on gameprogrammingpatterns.com

### Engine

Noir includes a root-level manager object called the `Engine`. The engine handles startup logic for the Noir library, including:

- Creating the internal `ServiceLocator`
- Creating the internal `EventManager`
