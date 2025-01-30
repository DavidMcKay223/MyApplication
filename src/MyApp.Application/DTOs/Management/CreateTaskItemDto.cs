﻿using MyApp.Domain.Enums.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Management
{
    public class CreateTaskItemDto
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public TaskType TaskType { get; set; }
        public TaskSubType TaskSubType { get; set; }
        public TaskObjectType TaskObjectType { get; set; }
        public int? TaskObjectId { get; set; }
    }
}
