using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities.Medical
{
    [Table("Medical_Claim_Diagnosis")]
    public class DiagnosisCode
    {
        [Key]
        public int DiagnosisId { get; set; }
        [MaxLength(10)]
        public required string Code { get; set; } // ICD-10 code 
        public int Priority { get; set; } // A-L indicators (1-12) 
        public Claim Claim { get; set; }
        public int ClaimId { get; set; }
    }
}
