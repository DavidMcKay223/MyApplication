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
[Key]
public int ID { get; set; }

```

#### Property: `Title`

```csharp

[MaxLength(500)]
public required string Title { get; set; }

```

#### Property: `Description`

```csharp

[MaxLength(5000)]
public required string Description { get; set; }

```

#### Property: `IsCompleted`

```csharp

public bool IsCompleted { get; set; } = false;

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

public TaskObjectType TaskObjectType { get; set; } = TaskObjectType.None;

```

#### Property: `TaskObjectId`

```csharp

public int? TaskObjectId { get; set; }

```

#### Property: `CreatedDate`

```csharp

public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

```

#### Property: `UpdatedDate`

```csharp

public DateTime? UpdatedDate { get; set; }

```

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

| Name | Signature |
|------|-----------|
| `GetValidSubTypes` | `public static List<TaskSubType> GetValidSubTypes(TaskType taskType)` |
| `IsValidSubType` | `public static bool IsValidSubType(TaskType taskType, TaskSubType taskSubType)` |

#### Method: `GetValidSubTypes`

```csharp

// Get valid TaskSubTypes for a given TaskType
public static List<TaskSubType> GetValidSubTypes(TaskType taskType)
{
    return TaskTypeSubTypes.TryGetValue(taskType, out var subTypes) ? subTypes : new List<TaskSubType>();
}

```

#### Method: `IsValidSubType`

```csharp

// Validate if a TaskSubType is valid for a given TaskType
public static bool IsValidSubType(TaskType taskType, TaskSubType taskSubType)
{
    return TaskTypeSubTypes.TryGetValue(taskType, out var subTypes) && subTypes.Contains(taskSubType);
}

```

