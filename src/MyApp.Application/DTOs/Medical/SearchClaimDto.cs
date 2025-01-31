using MyApp.Application.Common;
using MyApp.Domain.Enums.Medical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Medical
{
    public class SearchClaimDto : AbstractSearchDto<ClaimSortBy, ClaimSortOrder>
    {
        public string? InsuredIdNumber { get; set; }
        public string? PatientLastName { get; set; }
        public string? PatientFirstName { get; set; }
        public InsuranceProgram? InsuranceProgram { get; set; }
    }
}
