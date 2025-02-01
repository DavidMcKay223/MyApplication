# CreateTaskItemDto

**Namespace:** `MyApp.Application.DTOs.Management`

**File Path:** `MyApp.Application/DTOs/Management/CreateTaskItemDto.cs`

## Properties

- `string Title`
- `string Description`
- `TaskType TaskType`
- `TaskSubType TaskSubType`
- `TaskObjectType TaskObjectType`
- `int? TaskObjectId`

# DeleteTaskItemDto

**Namespace:** `MyApp.Application.DTOs.Management`

**File Path:** `MyApp.Application/DTOs/Management/DeleteTaskItemDto.cs`

## Properties

- `int ID`

# SearchTaskItemDto

**Namespace:** `MyApp.Application.DTOs.Management`

**File Path:** `MyApp.Application/DTOs/Management/SearchTaskItemDto.cs`

## Inherits From

- `AbstractSearchDto<TaskSortBy, TaskSortOrder>`

## Properties

- `string? Title`
- `string? Description`
- `TaskType? TaskType`
- `bool? IsCompleted`

# TaskItemDto

**Namespace:** `MyApp.Application.DTOs.Management`

**File Path:** `MyApp.Application/DTOs/Management/TaskItemDto.cs`

## Properties

- `int ID`
- `string Title`
- `string Description`
- `bool IsCompleted`
- `TaskType TaskType`
- `TaskSubType TaskSubType`
- `TaskObjectType TaskObjectType`
- `int? TaskObjectId`
- `DateTime CreatedDate`
- `DateTime? UpdatedDate`

# UpdateTaskItemDto

**Namespace:** `MyApp.Application.DTOs.Management`

**File Path:** `MyApp.Application/DTOs/Management/UpdateTaskItemDto.cs`

## Properties

- `string Title`
- `string Description`
- `bool IsCompleted`

