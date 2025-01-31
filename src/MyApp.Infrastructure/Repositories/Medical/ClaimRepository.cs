using MyApp.Domain.Entities.Medical;
using MyApp.Domain.Repositories.Medical;
using MyApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.Repositories.Medical
{
    public class ClaimRepository : IClaimRepository
    {
        private readonly AppDbContext _context;

        public ClaimRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Claim claim)
        {
            await _context.Claims.AddAsync(claim);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var claim = await _context.Claims.FindAsync(id);
            if (claim != null)
            {
                _context.Claims.Remove(claim);
                await _context.SaveChangesAsync();
            }
        }

        public IQueryable<Claim> GetAllAsync()
        {
            return _context.Claims
                .Include(c => c.Patient)
                .Include(c => c.Insured)
                .Include(c => c.BillingProvider)
                .Include(c => c.ServiceFacility)
                .Include(c => c.DiagnosisCodes)
                .Include(c => c.ServiceLines)
                .AsQueryable();
        }

        public async Task<Claim?> GetByIdAsync(int id)
        {
            return await _context.Claims
                .Include(c => c.Patient)
                .Include(c => c.Insured)
                .Include(c => c.BillingProvider)
                .Include(c => c.ServiceFacility)
                .Include(c => c.DiagnosisCodes)
                .Include(c => c.ServiceLines)
                .FirstOrDefaultAsync(c => c.FormId == id);
        }

        public async Task UpdateAsync(Claim claim)
        {
            _context.Claims.Update(claim);
            await _context.SaveChangesAsync();
        }
    }
}
