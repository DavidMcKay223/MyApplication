using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Management
{
    public class UpdateTaskItemDto
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
