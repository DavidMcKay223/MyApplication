using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities.Medical
{
    [Table("Medical_Claim_ServiceLine")]
    public class ServiceLine
    {
        [Key]
        public int ServiceLineId { get; set; }
        public DateTime ServiceStartDate { get; set; }
        public DateTime ServiceEndDate { get; set; }
        [MaxLength(10)]
        public required string ProcedureCode { get; set; } // CPT/HCPCS 
        [MaxLength(2)]
        public string? Modifier { get; set; }
        [MaxLength(10)]
        public string? DiagnosisPointer { get; set; } // Links to DiagnosisCode.Priority 
        [Column(TypeName = "decimal(18,2)")]
        public decimal Charge { get; set; }
        [MaxLength(20)]
        public required string RenderingProviderId { get; set; }
        public required Claim Claim { get; set; }
        public int ClaimId { get; set; }
    }
}
