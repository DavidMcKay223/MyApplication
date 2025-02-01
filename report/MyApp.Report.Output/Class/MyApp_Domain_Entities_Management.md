# Namespace: `MyApp.Domain.Entities.Management`

## Class: `TaskItem`

- **File Path:** `MyApp.Domain/Entities/Management/TaskItem.cs`
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

## Class: `TaskTypeHelper`

- **File Path:** `MyApp.Domain/Entities/Management/TaskTypeHelper.cs`
- **Inherits From:** N/A

### Methods

| Name | Return Type | Access Modifier | Static | Parameters |
|------|-------------|-----------------|--------|------------|
| `GetValidSubTypes` | `List<TaskSubType>` | `public` | `Yes` | `TaskType taskType` |
| `IsValidSubType` | `bool` | `public` | `Yes` | `TaskType taskType`, `TaskSubType taskSubType` |

