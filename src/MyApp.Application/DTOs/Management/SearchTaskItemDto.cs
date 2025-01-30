using MyApp.Application.Common;
using MyApp.Domain.Enums.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Management
{
    public class SearchTaskItemDto : AbstractSearchDto<TaskSortBy, TaskSortOrder>
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public TaskType? TaskType { get; set; }
        public bool? IsCompleted { get; set; }
    }
}
