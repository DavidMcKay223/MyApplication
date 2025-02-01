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

| Name | Signature |
|------|-----------|
| `CreateClaimAsync` | `public Task CreateClaimAsync(ClaimDto claimDto)` |
| `DeleteClaimAsync` | `public Task DeleteClaimAsync(int claimId)` |
| `GetClaimAsync` | `public Task<ClaimDto?> GetClaimAsync(int claimId)` |
| `GetClaimsAsync` | `public Task<List<ClaimDto>?> GetClaimsAsync()` |
| `UpdateClaimAsync` | `public Task UpdateClaimAsync(int claimId, ClaimDto claimDto)` |

#### Method: `CreateClaimAsync`

```csharp
public async Task CreateClaimAsync(ClaimDto claimDto)
        {
            var claim = _mapper.Map<Claim>(claimDto);
            await _claimRepo.AddAsync(claim);
            _logger.LogInformation("Claim created with ID: {ClaimId}", claim.FormId);
        }
```

#### Method: `DeleteClaimAsync`

```csharp
public async Task DeleteClaimAsync(int claimId)
        {
            await _claimRepo.DeleteAsync(claimId);
            _logger.LogInformation("Claim deleted with ID: {ClaimId}", claimId);
        }
```

#### Method: `GetClaimAsync`

```csharp
public async Task<ClaimDto?> GetClaimAsync(int claimId)
        {
            var claim = await _claimRepo.GetByIdAsync(claimId);
            return _mapper.Map<ClaimDto>(claim);
        }
```

#### Method: `GetClaimsAsync`

```csharp
public async Task<List<ClaimDto>?> GetClaimsAsync()
        {
            var claims = await _claimRepo.GetAllAsync().ToListAsync();
            return _mapper.Map<List<ClaimDto>>(claims);
        }
```

#### Method: `UpdateClaimAsync`

```csharp
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
```

