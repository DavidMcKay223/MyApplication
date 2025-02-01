# Namespace: `MyApp.Application.Common`

## Class: `AbstractSearchDto`

- **File Path:** `MyApp.Application/Common/AbstractSearchDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public abstract class AbstractSearchDto<TSortBy, TSortOrder>
    where TSortBy : Enum
    where TSortOrder : Enum
{
    public int PageNumber { get; set; } = 0;
    public int PageSize { get; set; } = 10;
    public Boolean UsePagination { get; set; } = true;
    public TSortBy? SortBy { get; set; }
    public TSortOrder? SortOrder { get; set; }
    public int TotalItems { get; set; }
}

```

### Properties

| Name | Type |
|------|------|
| `PageNumber` | `int` |
| `PageSize` | `int` |
| `UsePagination` | `Boolean` |
| `SortBy` | `TSortBy?` |
| `SortOrder` | `TSortOrder?` |
| `TotalItems` | `int` |

#### Property: `PageNumber`

```csharp
public int PageNumber { get; set; } = 0;

```

#### Property: `PageSize`

```csharp
public int PageSize { get; set; } = 10;

```

#### Property: `UsePagination`

```csharp
public Boolean UsePagination { get; set; } = true;

```

#### Property: `SortBy`

```csharp
public TSortBy? SortBy { get; set; }

```

#### Property: `SortOrder`

```csharp
public TSortOrder? SortOrder { get; set; }

```

#### Property: `TotalItems`

```csharp
public int TotalItems { get; set; }

```

