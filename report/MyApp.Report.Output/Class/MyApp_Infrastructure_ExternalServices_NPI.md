# Namespace: `MyApp.Infrastructure.ExternalServices.NPI`

## Class: `NpiRegistryService`

- **File Path:** `MyApp.Infrastructure/ExternalServices/NPI/NpiRegistryService.cs`
- **Inherits From:** `INpiRegistryClient`

### Methods

| Name | Return Type | Access Modifier | Static | Parameters |
|------|-------------|-----------------|--------|------------|
| `GetProvidersAsync` | `Task<List<Provider?>>` | `public` | `No` | `SearchProviderCriteria searchProviderCriteria` |
| `GetProviderByNpiAsync` | `Task<Provider?>` | `public` | `No` | `string npiNumber` |
| `ParseProvider` | `Provider?` | `private` | `Yes` | `Result provider` |

