# Namespace: `MyApp.Application.Mappings.NPI`

## Class: `ProviderProfile`

- **File Path:** `MyApp.Application/Mappings/NPI/ProviderProfile.cs`
- **Inherits From:** `Profile`

### Class Code

```csharp
public class ProviderProfile : Profile
    {
        public ProviderProfile()
        {
            // Provider DTO ↔ Entity
            CreateMap<ProviderDto, Provider>()
                .ReverseMap(); // Add ReverseMap() if you need bidirectional mapping

            // Identifier DTO ↔ Entity
            CreateMap<IdentifierDto, Identifier>()
                .ReverseMap();

            // Endpoint DTO ↔ Entity (assuming you have an Endpoint entity)
            CreateMap<EndpointDto, Endpoint>()
                .ReverseMap();
        }
    }
```

