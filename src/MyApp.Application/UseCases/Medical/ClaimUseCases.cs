using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyApp.Application.DTOs.Medical;
using MyApp.Domain.Entities.Medical;
using MyApp.Domain.Repositories.Medical;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyApp.Application.UseCases.Medical
{
    public class ClaimUseCases : IClaimUseCases
    {
        private readonly IClaimRepository _claimRepo;
        private readonly IMapper _mapper;
        private readonly ILogger<ClaimUseCases> _logger;

        public ClaimUseCases(IClaimRepository claimRepo, IMapper mapper, ILogger<ClaimUseCases> logger)
        {
            _claimRepo = claimRepo;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task CreateClaimAsync(ClaimDto claimDto)
        {
            var claim = _mapper.Map<Claim>(claimDto);
            await _claimRepo.AddAsync(claim);
            _logger.LogInformation("Claim created with ID: {ClaimId}", claim.FormId);
        }

        public async Task DeleteClaimAsync(int claimId)
        {
            await _claimRepo.DeleteAsync(claimId);
            _logger.LogInformation("Claim deleted with ID: {ClaimId}", claimId);
        }

        public async Task<ClaimDto?> GetClaimAsync(int claimId)
        {
            var claim = await _claimRepo.GetByIdAsync(claimId);
            return _mapper.Map<ClaimDto>(claim);
        }

        public async Task<List<ClaimDto>?> GetClaimsAsync()
        {
            var claims = await _claimRepo.GetAllAsync().ToListAsync();
            return _mapper.Map<List<ClaimDto>>(claims);
        }

        public async Task UpdateClaimAsync(int claimId, ClaimDto claimDto)
        {
            var existingClaim = await _claimRepo.GetByIdAsync(claimId);
            if (existingClaim == null)
            {
                _logger.LogWarning("Claim not found with ID: {ClaimId}", claimId);
                return;
            }

            _mapper.Map(claimDto, existingClaim);
            await _claimRepo.UpdateAsync(existingClaim);
            _logger.LogInformation("Claim updated with ID: {ClaimId}", claimId);
        }
    }
}
