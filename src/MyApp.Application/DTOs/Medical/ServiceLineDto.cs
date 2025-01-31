using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Medical
{
    public class ServiceLineDto
    {
        public int ServiceLineId { get; set; }
        public DateTime? ServiceStartDate { get; set; }
        public DateTime? ServiceEndDate { get; set; }
        public string? ProcedureCode { get; set; }
        public string? Modifier { get; set; }
        public string? DiagnosisPointer { get; set; }
        public decimal Charge { get; set; }
        public string? RenderingProviderId { get; set; }
    }
}
