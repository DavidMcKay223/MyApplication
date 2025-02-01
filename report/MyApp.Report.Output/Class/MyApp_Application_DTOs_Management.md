# Namespace: `MyApp.Application.DTOs.Management`

## Class: `CreateTaskItemDto`

- **File Path:** `MyApp.Application/DTOs/Management/CreateTaskItemDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class CreateTaskItemDto
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public TaskType TaskType { get; set; }
    public TaskSubType TaskSubType { get; set; }
    public TaskObjectType TaskObjectType { get; set; }
    public int? TaskObjectId { get; set; }
}

```

### Properties

| Name | Type |
|------|------|
| `Title` | `string` |
| `Description` | `string` |
| `TaskType` | `TaskType` |
| `TaskSubType` | `TaskSubType` |
| `TaskObjectType` | `TaskObjectType` |
| `TaskObjectId` | `int?` |

#### Property: `Title`

```csharp
public required string Title { get; set; }

```

#### Property: `Description`

```csharp
public required string Description { get; set; }

```

#### Property: `TaskType`

```csharp
public TaskType TaskType { get; set; }

```

#### Property: `TaskSubType`

```csharp
public TaskSubType TaskSubType { get; set; }

```

#### Property: `TaskObjectType`

```csharp
public TaskObjectType TaskObjectType { get; set; }

```

#### Property: `TaskObjectId`

```csharp
public int? TaskObjectId { get; set; }

```

## Class: `DeleteTaskItemDto`

- **File Path:** `MyApp.Application/DTOs/Management/DeleteTaskItemDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class DeleteTaskItemDto
{
    public int ID { get; set; }
}

```

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |

#### Property: `ID`

```csharp
public int ID { get; set; }

```

## Class: `SearchTaskItemDto`

- **File Path:** `MyApp.Application/DTOs/Management/SearchTaskItemDto.cs`
- **Inherits From:** `AbstractSearchDto<TaskSortBy, TaskSortOrder>`

### Class Code

```csharp
public class SearchTaskItemDto : AbstractSearchDto<TaskSortBy, TaskSortOrder>
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public TaskType? TaskType { get; set; }
    public bool? IsCompleted { get; set; }
}

```

### Properties

| Name | Type |
|------|------|
| `Title` | `string?` |
| `Description` | `string?` |
| `TaskType` | `TaskType?` |
| `IsCompleted` | `bool?` |

#### Property: `Title`

```csharp
public string? Title { get; set; }

```

#### Property: `Description`

```csharp
public string? Description { get; set; }

```

#### Property: `TaskType`

```csharp
public TaskType? TaskType { get; set; }

```

#### Property: `IsCompleted`

```csharp
public bool? IsCompleted { get; set; }

```

## Class: `TaskItemDto`

- **File Path:** `MyApp.Application/DTOs/Management/TaskItemDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class TaskItemDto
{
    public int ID { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public bool IsCompleted { get; set; }
    public TaskType TaskType { get; set; }
    public TaskSubType TaskSubType { get; set; }
    public TaskObjectType TaskObjectType { get; set; }
    public int? TaskObjectId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
}

```

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |
| `Title` | `string` |
| `Description` | `string` |
| `IsCompleted` | `bool` |
| `TaskType` | `TaskType` |
| `TaskSubType` | `TaskSubType` |
| `TaskObjectType` | `TaskObjectType` |
| `TaskObjectId` | `int?` |
| `CreatedDate` | `DateTime` |
| `UpdatedDate` | `DateTime?` |

#### Property: `ID`

```csharp
public int ID { get; set; }

```

#### Property: `Title`

```csharp
public required string Title { get; set; }

```

#### Property: `Description`

```csharp
public required string Description { get; set; }

```

#### Property: `IsCompleted`

```csharp
public bool IsCompleted { get; set; }

```

#### Property: `TaskType`

```csharp
public TaskType TaskType { get; set; }

```

#### Property: `TaskSubType`

```csharp
public TaskSubType TaskSubType { get; set; }

```

#### Property: `TaskObjectType`

```csharp
public TaskObjectType TaskObjectType { get; set; }

```

#### Property: `TaskObjectId`

```csharp
public int? TaskObjectId { get; set; }

```

#### Property: `CreatedDate`

```csharp
public DateTime CreatedDate { get; set; }

```

#### Property: `UpdatedDate`

```csharp
public DateTime? UpdatedDate { get; set; }

```

## Class: `UpdateTaskItemDto`

- **File Path:** `MyApp.Application/DTOs/Management/UpdateTaskItemDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class UpdateTaskItemDto
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public bool IsCompleted { get; set; }
}

```

### Properties

| Name | Type |
|------|------|
| `Title` | `string` |
| `Description` | `string` |
| `IsCompleted` | `bool` |

#### Property: `Title`

```csharp
public required string Title { get; set; }

```

#### Property: `Description`

```csharp
public required string Description { get; set; }

```

#### Property: `IsCompleted`

```csharp
public bool IsCompleted { get; set; }

```

