using MyApp.Domain.Enums.Medical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Medical
{
    public class ClaimDto
    {
        public int FormId { get; set; }
        public InsuranceProgram InsuranceProgram { get; set; }
        public string? InsuredIdNumber { get; set; }
        public required PatientInfoDto Patient { get; set; }
        public required InsuredInfoDto Insured { get; set; }
        public required OtherInsuranceInfoDto OtherInsurance { get; set; }
        public required ConditionRelatedDto ConditionRelated { get; set; }
        public required List<DiagnosisCodeDto> DiagnosisCodes { get; set; } = [];
        public required List<ServiceLineDto> ServiceLines { get; set; } = [];
        public required ProviderInfoDto BillingProvider { get; set; }
        public required ProviderInfoDto ServiceFacility { get; set; }
        public decimal TotalCharge { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime? PatientSignatureDate { get; set; }
        public DateTime? PhysicianSignatureDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
    }
}
