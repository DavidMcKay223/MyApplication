# Namespace: `MyApp.Application.UseCases.Medical`

## Class: `ClaimUseCases`

- **File Path:** `MyApp.Application/UseCases/Medical/ClaimUseCases.cs`
- **Inherits From:** `IClaimUseCases`

### Class Code

```csharp
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
```

### Methods

| Name | Signature | Definition |
|------|-----------|-------------|
| `CreateClaimAsync` | `public Task CreateClaimAsync(ClaimDto claimDto)` | `public async Task CreateClaimAsync(ClaimDto claimDto)<br>        {<br>            var claim = _mapper.Map<Claim>(claimDto);<br>            await _claimRepo.AddAsync(claim);<br>            _logger.LogInformation("Claim created with ID: {ClaimId}", claim.FormId);<br>        }` |
| `DeleteClaimAsync` | `public Task DeleteClaimAsync(int claimId)` | `public async Task DeleteClaimAsync(int claimId)<br>        {<br>            await _claimRepo.DeleteAsync(claimId);<br>            _logger.LogInformation("Claim deleted with ID: {ClaimId}", claimId);<br>        }` |
| `GetClaimAsync` | `public Task<ClaimDto?> GetClaimAsync(int claimId)` | `public async Task<ClaimDto?> GetClaimAsync(int claimId)<br>        {<br>            var claim = await _claimRepo.GetByIdAsync(claimId);<br>            return _mapper.Map<ClaimDto>(claim);<br>        }` |
| `GetClaimsAsync` | `public Task<List<ClaimDto>?> GetClaimsAsync()` | `public async Task<List<ClaimDto>?> GetClaimsAsync()<br>        {<br>            var claims = await _claimRepo.GetAllAsync().ToListAsync();<br>            return _mapper.Map<List<ClaimDto>>(claims);<br>        }` |
| `UpdateClaimAsync` | `public Task UpdateClaimAsync(int claimId, ClaimDto claimDto)` | `public async Task UpdateClaimAsync(int claimId, ClaimDto claimDto)<br>        {<br>            var existingClaim = await _claimRepo.GetByIdAsync(claimId);<br>            if (existingClaim == null)<br>            {<br>                _logger.LogWarning("Claim not found with ID: {ClaimId}", claimId);<br>                return;<br>            }<br><br>            _mapper.Map(claimDto, existingClaim);<br>            await _claimRepo.UpdateAsync(existingClaim);<br>            _logger.LogInformation("Claim updated with ID: {ClaimId}", claimId);<br>        }` |

