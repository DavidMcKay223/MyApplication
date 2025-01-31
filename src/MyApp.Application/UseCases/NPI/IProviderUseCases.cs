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
    public interface IProviderUseCases
    {
        Task<List<ProviderDto>?> GetProvidersAsync(SearchProviderCriteria dto);
    }
}
