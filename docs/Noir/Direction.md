# Direction

**Namespace:** Noir <br>
**Assembly:** Noir.dll

```csharp
public sealed struct Direction : IEquatable<T>
```

Represents a direction in two-dimensional or three-dimensional space. The horizontal and vertical axis are
            separated out into easier to read properties [Direction.Vertical](../Noir/Direction.html#vertical) respectively.

**Implements:** _[IEquatable\<T\>](https://learn.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=net-7.0)_

### 🛠 Constructors
```csharp
public Direction(Vector2 vector)
```

Initializes a new instance of the [Direction](../Noir/Direction.html) struct.

**Parameters** <br>
`vector` [Vector2](../) <br>
 <br>

```csharp
public Direction(Vector3 vector)
```

Initializes a new instance of the [Direction](../Noir/Direction.html) struct.

**Parameters** <br>
`vector` [Vector3](../) <br>
 <br>

### 📦 Properties
#### Horizontal
```csharp
public HorizontalDirections Horizontal { get; private set; }
```

Gets the horizontal axis.

**Returns** <br>
[HorizontalDirections](../Noir/HorizontalDirections.html) <br>
#### None
```csharp
public readonly static Direction None;
```

**Returns** <br>
[Direction](../Noir/Direction.html) <br>
#### Perpendicular
```csharp
public PerpendicularDirections Perpendicular { get; private set; }
```

Gets the perpendicular axis.

**Returns** <br>
[PerpendicularDirections](../Noir/PerpendicularDirections.html) <br>
#### Vertical
```csharp
public VerticalDirections Vertical { get; private set; }
```

Gets the vertical axis.

**Returns** <br>
[VerticalDirections](../Noir/VerticalDirections.html) <br>
### ⛹️‍♀️ Methods
#### Equals(Direction)
```csharp
public virtual bool Equals(Direction other)
```

**Parameters** <br>
`other` [Direction](../Noir/Direction.html) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### Equals(Object)
```csharp
public virtual bool Equals(Object obj)
```

**Parameters** <br>
`obj` [Object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=net-7.0) <br>

**Returns** <br>
[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=net-7.0) <br>

#### GetHashCode()
```csharp
public virtual int GetHashCode()
```

**Returns** <br>
[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=net-7.0) <br>

