using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Domain.Enums.Management;

namespace MyApp.Domain.Entities.Management
{
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
}
