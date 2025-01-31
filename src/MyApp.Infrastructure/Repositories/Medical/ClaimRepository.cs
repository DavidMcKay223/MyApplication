using MyApp.Domain.Entities.Medical;
using MyApp.Domain.Repositories.Medical;
using MyApp.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.Repositories.Medical
{
    public class ClaimRepository : IClaimRepository
    {
        private readonly AppDbContext _context;
        public ClaimRepository(AppDbContext context) => _context = context;

        public Task AddAsync(Claim claim)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Claim> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Claim?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Claim claim)
        {
            throw new NotImplementedException();
        }
    }
}
