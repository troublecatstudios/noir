# GetComponentSearchArea

**Namespace:** Noir.Attributes <br>
**Assembly:** Noir.dll

```csharp
public sealed enum GetComponentSearchArea : Enum, IComparable, ISpanFormattable, IFormattable, IConvertible
```

**Implements:** _[Enum](https://learn.microsoft.com/en-us/dotnet/api/System.Enum?view=net-7.0), [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=net-7.0), [ISpanFormattable](https://learn.microsoft.com/en-us/dotnet/api/System.ISpanFormattable?view=net-7.0), [IFormattable](https://learn.microsoft.com/en-us/dotnet/api/System.IFormattable?view=net-7.0), [IConvertible](https://learn.microsoft.com/en-us/dotnet/api/System.IConvertible?view=net-7.0)_

### 📦 Properties
#### ChildrenFirst
```csharp
public static const GetComponentSearchArea ChildrenFirst;
```

Search for the component type within the children of the current GameObject before searching on the current GameObject.

**Returns** <br>
[GetComponentSearchArea](../../Noir/Attributes/GetComponentSearchArea.html) <br>
#### ParentFirst
```csharp
public static const GetComponentSearchArea ParentFirst;
```

Search for the component type within the parents of the current GameObject before searching on the current GameObject.

**Returns** <br>
[GetComponentSearchArea](../../Noir/Attributes/GetComponentSearchArea.html) <br>
#### SelfOnly
```csharp
public static const GetComponentSearchArea SelfOnly;
```

Search for the component type only on the current GameObject.

**Returns** <br>
[GetComponentSearchArea](../../Noir/Attributes/GetComponentSearchArea.html) <br>
