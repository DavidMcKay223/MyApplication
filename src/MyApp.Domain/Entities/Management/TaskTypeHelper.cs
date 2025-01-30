using MyApp.Domain.Enums.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities.Management
{
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
}
