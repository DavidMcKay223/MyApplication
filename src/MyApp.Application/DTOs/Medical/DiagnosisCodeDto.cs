using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Medical
{
    public class DiagnosisCodeDto
    {
        public int DiagnosisId { get; set; }
        public string? Code { get; set; }
        public int Priority { get; set; }
    }
}
