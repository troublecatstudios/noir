# Data variables

Data variables are useful for sharing data between objects within Unity. Variables can store primitive struct values, like integers, booleans, strings or vectors. Each variable is a ScriptableObject that exists within your Unity project. This means variables can be referenced by Behaviours at design time, making it incredibly easy to share values between components/prefabs.

This also means that the changes to variable data are instantly available to any component or behaviour that references them.

You can view the complete code reference documentation for the [DataVariable][data_variable_ref] class in our source code reference docs.

### Adding a variable to a component

```csharp
public DataVariable<int> numberOfEnemiesToSpawn;
public DataVariable<int> enemyMaxHp;
public DataVariable<int> spawnRadius;
```

### Reading and writing variables

Each variable includes an [implicit cast][implicit_cast] to the data type it contains, this allows you to use variables directly in other function calls or assignment operations within your code.

```csharp
private void Update() {
    // snip: some logic to determine if we should spawn an enemy
    var hp = Random.Range(1, enemyMaxHp);
    var pos = transform.position + (Random.insideUnitCircle * spawnRadius);
    EnemySpawner.Instance.SpawnEnemy(hp, pos);
}
```

When setting a value within a variable, you must use the `Value` property.

```csharp
private void Awake() {
    numberOfEnemiesToSpawn.Value = 10;
}
```

### Events

Variables emit events whenever their data is altered. This is useful if you want to respond to changes in your variables without having to poll for changes. The code below uses the `numerOfEnemiesToSpawn` variable declared in the code sample above, but the examples should be able to be applied easily to your own use cases.

```csharp
private void Awake() {
    numberOfEnemiesToSpawn.Value = 10;
}

private void Start() {
    // normally, you would want to bind these to private methods within your component
    // so you could properly clean them up when your component is disabled/destroyed
    numberOfEnemiesToSpawn.OnBeforeVariableChanged += () => {
        Debug.Log($"numberOfEnemiesToSpawn = {numberOfEnemiesToSpawn}");
    };

    numberOfEnemiesToSpawn.OnAfterVariableChanged += () => {
        Debug.Log($"numberOfEnemiesToSpawn = {numberOfEnemiesToSpawn}");
    };

    numberOfEnemiesToSpawn.OnDataVariableChanged<int> += (int oldValue, int newValue) => {
        Debug.Log($"numberOfEnemiesToSpawn is changing rom {oldValue} to {newValue}");
    };
}

public void SpawnEnemy() {
    // snip: repeatable logic to spawn enemies...
    numberOfEnemies--;
}
```

In the example code above when `SpawnEnemy()` is called three logs will be written to the Unity console:

```
numberOfEnemiesToSpawn = 10
numberOfEnemiesToSpawn is changing from 10 to 9
numberOfEnemiesToSpawn = 9
```

For most use cases, the `OnBeforeVariableChanged` and `OnAfterVariableChanged` events should be sufficient. If you need to compare the old and new values, then the `OnDataVariableChanged` event should be used.

???+ info
    When setting a value into a variable, you can avoid triggering the events by calling `TrySetValue(object value, bool silently = false)` and passing `true` for the `silently` parameter.


[data_variable_ref]: ./../reference/Noir/Variables/DataVariable.md
[implicit_cast]: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/user-defined-conversion-operators
