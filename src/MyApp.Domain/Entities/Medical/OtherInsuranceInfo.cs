﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Domain.Entities.Medical
{
    [Owned]
    public class OtherInsuranceInfo
    {
        [MaxLength(50)]
        public string? PolicyHolderName { get; set; }
        [MaxLength(20)]
        public string? PolicyNumber { get; set; }
        [MaxLength(50)]
        public string? PlanName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
