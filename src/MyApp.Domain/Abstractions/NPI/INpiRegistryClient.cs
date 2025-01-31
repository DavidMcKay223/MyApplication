using MyApp.Domain.Entities.NPI;
using MyApp.Domain.Specifications.NPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Abstractions.NPI
{
    public interface INpiRegistryClient
    {
        Task<List<Provider?>> GetProviderAsync(SearchProviderCriteria searchProviderCriteria);
        Task<Provider?> GetProviderByNpiAsync(string npiNumber);
    }
}
