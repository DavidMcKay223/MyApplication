# Namespace: `MyApp.Application.DTOs.Management`

## Class: `CreateTaskItemDto`

- **File Path:** `MyApp.Application/DTOs/Management/CreateTaskItemDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `Title` | `string` |
| `Description` | `string` |
| `TaskType` | `TaskType` |
| `TaskSubType` | `TaskSubType` |
| `TaskObjectType` | `TaskObjectType` |
| `TaskObjectId` | `int?` |

## Class: `DeleteTaskItemDto`

- **File Path:** `MyApp.Application/DTOs/Management/DeleteTaskItemDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `ID` | `int` |

## Class: `SearchTaskItemDto`

- **File Path:** `MyApp.Application/DTOs/Management/SearchTaskItemDto.cs`
- **Inherits From:** `AbstractSearchDto<TaskSortBy, TaskSortOrder>`

### Properties

| Name | Type |
|------|------|
| `Title` | `string?` |
| `Description` | `string?` |
| `TaskType` | `TaskType?` |
| `IsCompleted` | `bool?` |

## Class: `TaskItemDto`

- **File Path:** `MyApp.Application/DTOs/Management/TaskItemDto.cs`
- **Inherits From:** N/A

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

## Class: `UpdateTaskItemDto`

- **File Path:** `MyApp.Application/DTOs/Management/UpdateTaskItemDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `Title` | `string` |
| `Description` | `string` |
| `IsCompleted` | `bool` |

