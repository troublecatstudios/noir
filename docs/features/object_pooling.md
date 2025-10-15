# Object pooling

Object pooling is a design pattern that improves performance by pre-instantiating a set of objects and reusing them instead of constantly creating and destroying them during runtime.

When an object is needed, one is taken from the pool; when it's no longer needed, it's returned to the pool and disabled, not destroyed.

This is especially beneficial in scenarios with many objects, like games with projectiles or particles, to reduce CPU load from garbage collection and instantiation.

```mermaid
flowchart LR
    init[Initialization]
    acquisition[Acquisition]
    reuse[Re-use]
    return[Return]
    init --> acquisition
    acquisition --> reuse
    reuse --> return
    return --> reuse
```


## Creating a new object pool

Here's an example of how to create and utilize a new object pool.

Before starting, you'll need to create two new game objects. The first will be your "pool manager", the object responsible
for holding the pooled objects and enabling/disabling objects as needed by your game. Then there is the "pool item", the
object that will be spawned by your pool.


=== "ProjectileManagerBehavior.cs"

```csharp
using Noir;
using Noir.Attributes;
using Noir.Spawning;

public class ProjectileManagerBehaviour : NoirSingletonBehaviour<ProjectileManagerBehaviour> {
    [GetComponent]
    [SerializeField] private ObjectPoolSystem _objectPool;

    public ObjectPoolItemSystem SpawnProjectile(Vector3 position, Sprite projectileSprite, Vector3 direction, float force) {
        if (_objectPool.TryGet(out var poolObject)) {
            go.transform.SetPositionAndRotation(position, Quaternion.identity);

            var projectile = go.GetComponent<ProjectileBehaviour>();
            projectile.SetSprite(projectileSprite);
            projectile.SetStartPosition(position);
            projectile.SetDirection(direction);
            projectile.SetForce(force);

            projectile.Initialize();

            return go;
        }
        return null;
    }

}
```


=== "ProjectileBehaviour.cs"

This is a basic script that would be attached to the object pool prefab. It handles setting the projectile sprite and moving the projectile across the screen.
The script also handles returning the object back to the pool after 10 seconds.

```csharp
using Noir;
using Noir.Spawning;

public class ProjectileBehaviour : NoirBehaviour {
    [SerializeField] private Sprite _projectileSprite;
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _force;
    [SerializeField] private float _maxLifetime = 10f;

    [GetComponent]
    [SerializeField] private ObjectPoolItemSystem _objectPoolSystem;
    [GetComponent]
    [SerializeField] private SpriteRenderer _projectileRenderer;

    private float _startTime;
    private bool _isRunning = false;

    public void SetSprite(Sprite projectileSprite) => _projectileSprite = projectileSprite;
    public void SetStartPosition(Vector3 startPosition) => _startPosition = startPosition;
    public void SetDirection(Vector3 direction) => _direction = direction;
    public void SetForce(float force) => _force = force;
    public void SetMaxLifetime(float lifetime) => _maxLifetime = lifetime;

    public void Initialize() {
        _startTime = GameTime.time;
        transform.position = _startPosition;
        _projectileRenderer.sprite = _projectileSprite;
        _projectileRenderer.transform.localPosition = new Vector3(0, 0, 0);
    }

    private void Update() {
        transform.position += (_direction * _force) * GameTime.deltaTime;
    }

    private void LateUpdate() {
        if (GameTime.time - _startTime > _maxLifetime && _objectPoolSystem && !_objectPoolSystem.IsReturned) {
            _objectPoolSystem.ReturnToPool();
        }
    }
}
```
