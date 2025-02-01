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

| Name | Signature |
|------|-----------|
| `AddAsync` | `public Task AddAsync(Claim claim)` |
| `DeleteAsync` | `public Task DeleteAsync(int id)` |
| `GetAllAsync` | `public IQueryable<Claim> GetAllAsync()` |
| `GetByIdAsync` | `public Task<Claim?> GetByIdAsync(int id)` |
| `UpdateAsync` | `public Task UpdateAsync(Claim claim)` |

#### Method: `AddAsync`

```csharp

public async Task AddAsync(Claim claim)
{
    await _context.Claims.AddAsync(claim);
    await _context.SaveChangesAsync();
}

```

#### Method: `DeleteAsync`

```csharp

public async Task DeleteAsync(int id)
{
    var claim = await _context.Claims.FindAsync(id);
    if (claim != null)
    {
        _context.Claims.Remove(claim);
        await _context.SaveChangesAsync();
    }
}

```

#### Method: `GetAllAsync`

```csharp

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

```

#### Method: `GetByIdAsync`

```csharp

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

```

#### Method: `UpdateAsync`

```csharp

public async Task UpdateAsync(Claim claim)
{
    _context.Claims.Update(claim);
    await _context.SaveChangesAsync();
}

```

