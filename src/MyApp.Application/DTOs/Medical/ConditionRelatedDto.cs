using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Medical
{
    public class ConditionRelatedDto
    {
        public bool Employment { get; set; }
        public bool AutoAccident { get; set; }
        public bool OtherAccident { get; set; }
        public string? AccidentState { get; set; }
    }
}
