# Namespace: `MyApp.Shared.DTOs`

## Class: `NavBarItemDto`

- **File Path:** `MyApp.Shared/DTOs/NavBarItemDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class NavBarItemDto
{
    public List<NavBarItemDto>? ChildList { get; set; }
    public required string Description { get; set; }
    public required string Class { get; set; }
    public required string Href { get; set; }
}

```

### Properties

| Name | Type |
|------|------|
| `ChildList` | `List<NavBarItemDto>?` |
| `Description` | `string` |
| `Class` | `string` |
| `Href` | `string` |

#### Property: `ChildList`

```csharp
public List<NavBarItemDto>? ChildList { get; set; }

```

#### Property: `Description`

```csharp
public required string Description { get; set; }

```

#### Property: `Class`

```csharp
public required string Class { get; set; }

```

#### Property: `Href`

```csharp
public required string Href { get; set; }

```

## Class: `StateDto`

- **File Path:** `MyApp.Shared/DTOs/StateDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class StateDto
{
    public required string Value { get; set; }
    public required string Description { get; set; }
}

```

### Properties

| Name | Type |
|------|------|
| `Value` | `string` |
| `Description` | `string` |

#### Property: `Value`

```csharp
public required string Value { get; set; }

```

#### Property: `Description`

```csharp
public required string Description { get; set; }

```

