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

| Name | Type | Definition |
|------|------|-------------|
| `Title` | `string` | `public required string Title { get; set; }` |
| `Description` | `string` | `public required string Description { get; set; }` |
| `TaskType` | `TaskType` | `public TaskType TaskType { get; set; }` |
| `TaskSubType` | `TaskSubType` | `public TaskSubType TaskSubType { get; set; }` |
| `TaskObjectType` | `TaskObjectType` | `public TaskObjectType TaskObjectType { get; set; }` |
| `TaskObjectId` | `int?` | `public int? TaskObjectId { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `ID` | `int` | `public int ID { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `Title` | `string?` | `public string? Title { get; set; }` |
| `Description` | `string?` | `public string? Description { get; set; }` |
| `TaskType` | `TaskType?` | `public TaskType? TaskType { get; set; }` |
| `IsCompleted` | `bool?` | `public bool? IsCompleted { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `ID` | `int` | `public int ID { get; set; }` |
| `Title` | `string` | `public required string Title { get; set; }` |
| `Description` | `string` | `public required string Description { get; set; }` |
| `IsCompleted` | `bool` | `public bool IsCompleted { get; set; }` |
| `TaskType` | `TaskType` | `public TaskType TaskType { get; set; }` |
| `TaskSubType` | `TaskSubType` | `public TaskSubType TaskSubType { get; set; }` |
| `TaskObjectType` | `TaskObjectType` | `public TaskObjectType TaskObjectType { get; set; }` |
| `TaskObjectId` | `int?` | `public int? TaskObjectId { get; set; }` |
| `CreatedDate` | `DateTime` | `public DateTime CreatedDate { get; set; }` |
| `UpdatedDate` | `DateTime?` | `public DateTime? UpdatedDate { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `Title` | `string` | `public required string Title { get; set; }` |
| `Description` | `string` | `public required string Description { get; set; }` |
| `IsCompleted` | `bool` | `public bool IsCompleted { get; set; }` |

