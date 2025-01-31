using AutoMapper;
using Microsoft.Extensions.Logging;
using MyApp.Application.DTOs.Medical;
using MyApp.Domain.Repositories.Medical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public Task CreateClaimAsync(ClaimDto claim)
        {
            throw new NotImplementedException();
        }

        public Task DeleteClaimAsync(int claimId)
        {
            throw new NotImplementedException();
        }

        public Task<ClaimDto?> GetClaimAsync(int claimId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClaimDto>?> GetClaimsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateClaimAsync(int claimId, ClaimDto claim)
        {
            throw new NotImplementedException();
        }
    }
}
