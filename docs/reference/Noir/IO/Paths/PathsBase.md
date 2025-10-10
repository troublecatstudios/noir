# PathsBase

<!-- tc:namespace Noir.IO.Paths -->

<!-- tc:assembly Noir.dll -->


```csharp
public abstract class PathsBase
```

## Constructors

<a name=".ctor"></a>

### `.ctor()`
<!-- tc:scope private -->
<!-- tc:version 1.0.0 -->

```csharp
protected PathsBase()

```

## Methods

<a name="AppendDirectory"></a>

### `AppendDirectory(string, string)`
<!-- tc:scope private -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
protected string AppendDirectory(string path, string dir)

```

**Parameters** <br>
`path` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`dir` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

<a name="AppendProductPath"></a>

### `AppendProductPath(string, bool)`
<!-- tc:scope private -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
protected string AppendProductPath(string path, bool includeCompanyName)

```

**Parameters** <br>
`path` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>
`includeCompanyName` [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

<a name="CleanForPath"></a>

### `CleanForPath(string)`
<!-- tc:scope private -->
<!-- tc:return_type string https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0 -->
<!-- tc:version 1.0.0 -->

```csharp
protected string CleanForPath(string str)

```

**Parameters** <br>
`str` [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=net-7.0) <br>

