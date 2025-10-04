# AutomaticallyCreateAttribute

<!-- tc:namespace Noir.Attributes -->

<!-- tc:assembly Noir.dll -->


```csharp
public class AutomaticallyCreateAttribute : Attribute
```

**Implements:** _[Attribute](https://learn.microsoft.com/en-us/dotnet/api/System.Attribute?view=net-7.0)_

## Constructors

### `.ctor(string, string)`
<!-- tc:scope public -->
<!-- tc:version 1.0.0 -->
Declare that this ScriptableObject should be automatically created at build time.


```csharp
public AutomaticallyCreateAttribute(string customPathPrefix,
                                     string assetNameOverride)


```

**Parameters** <br>
`customPathPrefix` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>
`assetNameOverride` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
 <br>

## Properties

### `AssetNameOverride`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public string AssetNameOverride { get; private set; }

```

### `CreatePathPrefix`
<!-- tc:scope public -->
<!-- tc:return_type [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) -->
<!-- tc:version 1.0.0 -->
Gets the custom folder path to store the created asset. Is automatically prefixed with "Assets/".


```csharp
public string CreatePathPrefix { get; private set; }

```

### `TypeId`
<!-- tc:scope public -->
<!-- tc:return_type [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) -->
<!-- tc:version 1.0.0 -->

```csharp
public virtual Object TypeId { get; }

```

