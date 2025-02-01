# Namespace: `MyApp.Application.UseCases.NPI`

## Class: `ProviderUseCases`

- **File Path:** `MyApp.Application/UseCases/NPI/ProviderUseCases.cs`
- **Inherits From:** `IProviderUseCases`

### Class Code

```csharp
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

```

### Methods

| Name | Signature |
|------|-----------|
| `GetProvidersAsync` | `public Task<List<ProviderDto>?> GetProvidersAsync(SearchProviderCriteria dto)` |

#### Method: `GetProvidersAsync`

```csharp

public async Task<List<ProviderDto>?> GetProvidersAsync(SearchProviderCriteria dto)
{
    return _mapper.Map<List<ProviderDto>?>(await _npiRegistryClient.GetProvidersAsync(dto));
}

```

