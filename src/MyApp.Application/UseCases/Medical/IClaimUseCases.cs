using MyApp.Application.DTOs.Medical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.UseCases.Medical
{
    public interface IClaimUseCases
    {
        Task<ClaimDto?> GetClaimAsync(int claimId);
        Task<List<ClaimDto>?> GetClaimsAsync();
        Task CreateClaimAsync(ClaimDto claim);
        Task UpdateClaimAsync(int claimId, ClaimDto claim);
        Task DeleteClaimAsync(int claimId);
    }
}
