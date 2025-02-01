# Namespace: `MyApp.Application.Mappings.Medical`

## Class: `ClaimProfile`

- **File Path:** `MyApp.Application/Mappings/Medical/ClaimProfile.cs`
- **Inherits From:** `Profile`

### Class Code

```csharp
public class ClaimProfile : Profile
    {
        public ClaimProfile()
        {
            // Address Mapping
            CreateMap<Address, AddressDto>().ReverseMap();

            // PatientInfo Mapping
            CreateMap<PatientInfo, PatientInfoDto>()
                .ReverseMap();

            // InsuredInfo Mapping
            CreateMap<InsuredInfo, InsuredInfoDto>()
                .ReverseMap();

            // ProviderInfo Mapping
            CreateMap<ProviderInfo, ProviderInfoDto>()
                .ReverseMap();

            // ServiceLine Mapping
            CreateMap<ServiceLine, ServiceLineDto>()
                .ReverseMap();

            // DiagnosisCode Mapping
            CreateMap<DiagnosisCode, DiagnosisCodeDto>()
                .ReverseMap();

            // ConditionRelated Mapping
            CreateMap<ConditionRelated, ConditionRelatedDto>()
                .ReverseMap();

            // OtherInsuranceInfo Mapping
            CreateMap<OtherInsuranceInfo, OtherInsuranceInfoDto>()
                .ReverseMap();

            // Claim Mapping
            CreateMap<Claim, ClaimDto>()
                .ForMember(dest => dest.Patient, opt => opt.MapFrom(src => src.Patient))
                .ForMember(dest => dest.Insured, opt => opt.MapFrom(src => src.Insured))
                .ForMember(dest => dest.OtherInsurance, opt => opt.MapFrom(src => src.OtherInsurance))
                .ForMember(dest => dest.ConditionRelated, opt => opt.MapFrom(src => src.ConditionRelated))
                .ForMember(dest => dest.DiagnosisCodes, opt => opt.MapFrom(src => src.DiagnosisCodes))
                .ForMember(dest => dest.ServiceLines, opt => opt.MapFrom(src => src.ServiceLines))
                .ForMember(dest => dest.BillingProvider, opt => opt.MapFrom(src => src.BillingProvider))
                .ForMember(dest => dest.ServiceFacility, opt => opt.MapFrom(src => src.ServiceFacility))
                .ReverseMap();
        }
    }
```

