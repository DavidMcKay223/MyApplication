using MyApp.Domain.Enums.Medical;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities.Medical
{
    [Table("Medical_Claim")]
    public class Claim
    {
        [Key]
        public int FormId { get; set; }

        // Program Information (Item 1) 
        [Required]
        public InsuranceProgram InsuranceProgram { get; set; }
        [MaxLength(20)]
        public string? InsuredIdNumber { get; set; }

        // Patient Information (Items 2-6) 
        public required PatientInfo Patient { get; set; }

        // Insured Information (Items 4,7,14) 
        public required InsuredInfo Insured { get; set; }

        // Other Insurance (Item 9) 
        public OtherInsuranceInfo? OtherInsurance { get; set; }

        // Condition Related To (Item 10) 
        public ConditionRelated ConditionRelated { get; set; } = new();

        // Service Details (Items 21,24) 
        public List<DiagnosisCode> DiagnosisCodes { get; set; } = new();
        public List<ServiceLine> ServiceLines { get; set; } = new();

        // Provider Information (Items 25,32,33) 
        public required ProviderInfo BillingProvider { get; set; }
        public required ProviderInfo ServiceFacility { get; set; }

        // Financials (Items 28-29) 
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalCharge { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal AmountPaid { get; set; }

        // Signatures (Items 12,31) 
        public DateTime PatientSignatureDate { get; set; }
        public DateTime PhysicianSignatureDate { get; set; }

        // Metadata 
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
    }
}
