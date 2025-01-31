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
        public PatientInfoDto Patient { get; set; }
        public InsuredInfoDto Insured { get; set; }
        public OtherInsuranceInfoDto? OtherInsurance { get; set; }
        public ConditionRelatedDto ConditionRelated { get; set; }
        public List<DiagnosisCodeDto> DiagnosisCodes { get; set; } = new();
        public List<ServiceLineDto> ServiceLines { get; set; } = new();
        public ProviderInfoDto BillingProvider { get; set; }
        public ProviderInfoDto ServiceFacility { get; set; }
        public decimal TotalCharge { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime PatientSignatureDate { get; set; }
        public DateTime PhysicianSignatureDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
