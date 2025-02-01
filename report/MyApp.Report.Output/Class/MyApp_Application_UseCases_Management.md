# Namespace: `MyApp.Application.UseCases.Management`

## Class: `TaskItemUseCases`

- **File Path:** `MyApp.Application/UseCases/Management/TaskItemUseCases.cs`
- **Inherits From:** `ITaskItemUseCases`

### Methods

| Name | Return Type | Access Modifier | Static | Parameters |
|------|-------------|-----------------|--------|------------|
| `CreateTaskItemAsync` | `Task` | `public` | `No` | `CreateTaskItemDto dto` |
| `DeleteTaskItemAsync` | `Task` | `public` | `No` | `DeleteTaskItemDto dto` |
| `GetAllTaskItemsAsync` | `Task<List<TaskItemDto>?>` | `public` | `No` | `SearchTaskItemDto dto` |
| `GetTaskItemByIdAsync` | `Task<TaskItemDto?>` | `public` | `No` | `int id` |
| `UpdateTaskItemAsync` | `Task` | `public` | `No` | `int id`, `UpdateTaskItemDto dto` |

