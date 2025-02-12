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
    public class ConditionRelated
    {
        public bool Employment { get; set; }
        public bool AutoAccident { get; set; }
        public bool OtherAccident { get; set; }
        [MaxLength(2)]
        public string? AccidentState { get; set; }
    }
}
