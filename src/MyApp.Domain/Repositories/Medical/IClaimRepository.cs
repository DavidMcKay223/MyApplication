using MyApp.Domain.Entities.Medical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Repositories.Medical
{
    public interface IClaimRepository
    {
        Task<Claim?> GetByIdAsync(int id);
        IQueryable<Claim> GetAllAsync();
        Task AddAsync(Claim claim);
        Task UpdateAsync(Claim claim);
        Task DeleteAsync(int id);
    }
}
