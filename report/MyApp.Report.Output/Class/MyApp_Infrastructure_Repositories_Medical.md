# Namespace: `MyApp.Infrastructure.Repositories.Medical`

## Class: `ClaimRepository`

- **File Path:** `MyApp.Infrastructure/Repositories/Medical/ClaimRepository.cs`
- **Inherits From:** `IClaimRepository`

### Class Code

```csharp
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
```

### Methods

| Name | Signature | Definition |
|------|-----------|-------------|
| `AddAsync` | `public Task AddAsync(Claim claim)` | `public async Task AddAsync(Claim claim)<br>        {<br>            await _context.Claims.AddAsync(claim);<br>            await _context.SaveChangesAsync();<br>        }` |
| `DeleteAsync` | `public Task DeleteAsync(int id)` | `public async Task DeleteAsync(int id)<br>        {<br>            var claim = await _context.Claims.FindAsync(id);<br>            if (claim != null)<br>            {<br>                _context.Claims.Remove(claim);<br>                await _context.SaveChangesAsync();<br>            }<br>        }` |
| `GetAllAsync` | `public IQueryable<Claim> GetAllAsync()` | `public IQueryable<Claim> GetAllAsync()<br>        {<br>            return _context.Claims<br>                .Include(c => c.Patient)<br>                .Include(c => c.Insured)<br>                .Include(c => c.BillingProvider)<br>                .Include(c => c.ServiceFacility)<br>                .Include(c => c.DiagnosisCodes)<br>                .Include(c => c.ServiceLines)<br>                .AsQueryable();<br>        }` |
| `GetByIdAsync` | `public Task<Claim?> GetByIdAsync(int id)` | `public async Task<Claim?> GetByIdAsync(int id)<br>        {<br>            return await _context.Claims<br>                .Include(c => c.Patient)<br>                .Include(c => c.Insured)<br>                .Include(c => c.BillingProvider)<br>                .Include(c => c.ServiceFacility)<br>                .Include(c => c.DiagnosisCodes)<br>                .Include(c => c.ServiceLines)<br>                .FirstOrDefaultAsync(c => c.FormId == id);<br>        }` |
| `UpdateAsync` | `public Task UpdateAsync(Claim claim)` | `public async Task UpdateAsync(Claim claim)<br>        {<br>            _context.Claims.Update(claim);<br>            await _context.SaveChangesAsync();<br>        }` |

