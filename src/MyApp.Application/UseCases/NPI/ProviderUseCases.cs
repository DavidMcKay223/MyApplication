using AutoMapper;
using Microsoft.Extensions.Logging;
using MyApp.Application.DTOs.NPI;
using MyApp.Domain.Abstractions.NPI;
using MyApp.Domain.Specifications.NPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.UseCases.NPI
{
    public class ProviderUseCases : IProviderUseCases
    {
        private readonly INpiRegistryClient _npiRegistryClient;
        private readonly IMapper _mapper;
        private readonly ILogger<ProviderUseCases> _logger;

        public ProviderUseCases(INpiRegistryClient npiRegistryClient, IMapper mapper, ILogger<ProviderUseCases> logger)
        {
            _npiRegistryClient = npiRegistryClient;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<List<ProviderDto>?> GetProvidersAsync(SearchProviderCriteria dto)
        {
            return _mapper.Map<List<ProviderDto>?>(await _npiRegistryClient.GetProvidersAsync(dto));
        }
    }
}
