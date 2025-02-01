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

