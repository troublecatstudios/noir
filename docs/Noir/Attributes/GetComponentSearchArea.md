# GetComponentSearchArea

<!-- tc:namespace Noir.Attributes -->

<!-- tc:assembly Noir.dll -->


```csharp
public sealed enum GetComponentSearchArea : Enum, IComparable, ISpanFormattable, IFormattable, IConvertible
```

**Implements:** _[Enum](https://learn.microsoft.com/en-us/dotnet/api/System.Enum?view=net-7.0), [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=net-7.0), [ISpanFormattable](https://learn.microsoft.com/en-us/dotnet/api/System.ISpanFormattable?view=net-7.0), [IFormattable](https://learn.microsoft.com/en-us/dotnet/api/System.IFormattable?view=net-7.0), [IConvertible](https://learn.microsoft.com/en-us/dotnet/api/System.IConvertible?view=net-7.0)_

## 📦 Properties

### `ChildrenFirst`
<!-- tc:scope private -->
<!-- tc:return_type GetComponentSearchArea /noir/reference//noir/reference/Noir/Attributes/GetComponentSearchArea/ -->
<!-- tc:version 1.0.0 -->
Search for the component type within the children of the current GameObject before searching on the current GameObject.


```csharp
public static const GetComponentSearchArea ChildrenFirst;
```

### `ParentFirst`
<!-- tc:scope private -->
<!-- tc:return_type GetComponentSearchArea /noir/reference//noir/reference/Noir/Attributes/GetComponentSearchArea/ -->
<!-- tc:version 1.0.0 -->
Search for the component type within the parents of the current GameObject before searching on the current GameObject.


```csharp
public static const GetComponentSearchArea ParentFirst;
```

### `SelfOnly`
<!-- tc:scope private -->
<!-- tc:return_type GetComponentSearchArea /noir/reference//noir/reference/Noir/Attributes/GetComponentSearchArea/ -->
<!-- tc:version 1.0.0 -->
Search for the component type only on the current GameObject.


```csharp
public static const GetComponentSearchArea SelfOnly;
```

