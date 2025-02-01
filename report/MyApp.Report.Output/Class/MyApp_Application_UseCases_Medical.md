# Namespace: `MyApp.Application.UseCases.Medical`

## Class: `ClaimUseCases`

- **File Path:** `MyApp.Application/UseCases/Medical/ClaimUseCases.cs`
- **Inherits From:** `IClaimUseCases`

### Methods

| Name | Return Type | Access Modifier | Static | Parameters |
|------|-------------|-----------------|--------|------------|
| `CreateClaimAsync` | `Task` | `public` | `No` | `ClaimDto claimDto` |
| `DeleteClaimAsync` | `Task` | `public` | `No` | `int claimId` |
| `GetClaimAsync` | `Task<ClaimDto?>` | `public` | `No` | `int claimId` |
| `GetClaimsAsync` | `Task<List<ClaimDto>?>` | `public` | `No` | None |
| `UpdateClaimAsync` | `Task` | `public` | `No` | `int claimId`, `ClaimDto claimDto` |

