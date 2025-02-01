# TaskItem

**Namespace:** `MyApp.Domain.Entities.Management`

**File Path:** `MyApp.Domain/Entities/Management/TaskItem.cs`

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

# TaskTypeHelper

**Namespace:** `MyApp.Domain.Entities.Management`

**File Path:** `MyApp.Domain/Entities/Management/TaskTypeHelper.cs`

## Methods

- `public` static `List<TaskSubType> GetValidSubTypes(TaskType taskType)`
- `public` static `bool IsValidSubType(TaskType taskType, TaskSubType taskSubType)`

