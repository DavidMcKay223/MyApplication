# Namespace: `MyApp.Domain.Entities.Management`

## Class: `TaskItem`

- **File Path:** `MyApp.Domain/Entities/Management/TaskItem.cs`
- **Inherits From:** N/A

### Class Code

```csharp
[Table("Management_TaskItem")]
    public class TaskItem
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(500)]
        public required string Title { get; set; }

        [MaxLength(5000)]
        public required string Description { get; set; }

        public bool IsCompleted { get; set; } = false;

        public TaskType TaskType { get; set; }

        public TaskSubType TaskSubType { get; set; }

        public TaskObjectType TaskObjectType { get; set; } = TaskObjectType.None;

        public int? TaskObjectId { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedDate { get; set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `ID` | `int` | `[Key]<br>        public int ID { get; set; }` |
| `Title` | `string` | `[MaxLength(500)]<br>        public required string Title { get; set; }` |
| `Description` | `string` | `[MaxLength(5000)]<br>        public required string Description { get; set; }` |
| `IsCompleted` | `bool` | `public bool IsCompleted { get; set; } = false;` |
| `TaskType` | `TaskType` | `public TaskType TaskType { get; set; }` |
| `TaskSubType` | `TaskSubType` | `public TaskSubType TaskSubType { get; set; }` |
| `TaskObjectType` | `TaskObjectType` | `public TaskObjectType TaskObjectType { get; set; } = TaskObjectType.None;` |
| `TaskObjectId` | `int?` | `public int? TaskObjectId { get; set; }` |
| `CreatedDate` | `DateTime` | `public DateTime CreatedDate { get; set; } = DateTime.UtcNow;` |
| `UpdatedDate` | `DateTime?` | `public DateTime? UpdatedDate { get; set; }` |

## Class: `TaskTypeHelper`

- **File Path:** `MyApp.Domain/Entities/Management/TaskTypeHelper.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public static class TaskTypeHelper
    {
        private static readonly Dictionary<TaskType, List<TaskSubType>> TaskTypeSubTypes = new()
        {
            { TaskType.Development, new List<TaskSubType> { TaskSubType.Backend, TaskSubType.Frontend, TaskSubType.Database } },
            { TaskType.Testing, new List<TaskSubType> { TaskSubType.UnitTesting, TaskSubType.IntegrationTesting, TaskSubType.SystemTesting } },
            { TaskType.Documentation, new List<TaskSubType> { TaskSubType.UserManual, TaskSubType.TechnicalSpecification, TaskSubType.APIReference } },
            { TaskType.Maintenance, new List<TaskSubType> { TaskSubType.BugFix, TaskSubType.PerformanceOptimization } },
            { TaskType.Support, new List<TaskSubType> { TaskSubType.CustomerSupport, TaskSubType.TechnicalSupport } }
        };

        // Get valid TaskSubTypes for a given TaskType
        public static List<TaskSubType> GetValidSubTypes(TaskType taskType)
        {
            return TaskTypeSubTypes.TryGetValue(taskType, out var subTypes) ? subTypes : new List<TaskSubType>();
        }

        // Validate if a TaskSubType is valid for a given TaskType
        public static bool IsValidSubType(TaskType taskType, TaskSubType taskSubType)
        {
            return TaskTypeSubTypes.TryGetValue(taskType, out var subTypes) && subTypes.Contains(taskSubType);
        }
    }
```

### Methods

| Name | Signature | Definition |
|------|-----------|-------------|
| `GetValidSubTypes` | `public static List<TaskSubType> GetValidSubTypes(TaskType taskType)` | `// Get valid TaskSubTypes for a given TaskType<br>        public static List<TaskSubType> GetValidSubTypes(TaskType taskType)<br>        {<br>            return TaskTypeSubTypes.TryGetValue(taskType, out var subTypes) ? subTypes : new List<TaskSubType>();<br>        }` |
| `IsValidSubType` | `public static bool IsValidSubType(TaskType taskType, TaskSubType taskSubType)` | `// Validate if a TaskSubType is valid for a given TaskType<br>        public static bool IsValidSubType(TaskType taskType, TaskSubType taskSubType)<br>        {<br>            return TaskTypeSubTypes.TryGetValue(taskType, out var subTypes) && subTypes.Contains(taskSubType);<br>        }` |

