# Namespace: `MyApp.Application.DTOs.Medical`

## Class: `AddressDto`

- **File Path:** `MyApp.Application/DTOs/Medical/AddressDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class AddressDto
    {
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Phone { get; set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `Street` | `string?` | `public string? Street { get; set; }` |
| `City` | `string?` | `public string? City { get; set; }` |
| `State` | `string?` | `public string? State { get; set; }` |
| `ZipCode` | `string?` | `public string? ZipCode { get; set; }` |
| `Phone` | `string?` | `public string? Phone { get; set; }` |

## Class: `ClaimDto`

- **File Path:** `MyApp.Application/DTOs/Medical/ClaimDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class ClaimDto
    {
        public int FormId { get; set; }
        public InsuranceProgram InsuranceProgram { get; set; }
        public string? InsuredIdNumber { get; set; }
        public required PatientInfoDto Patient { get; set; }
        public required InsuredInfoDto Insured { get; set; }
        public required OtherInsuranceInfoDto OtherInsurance { get; set; }
        public required ConditionRelatedDto ConditionRelated { get; set; }
        public required List<DiagnosisCodeDto> DiagnosisCodes { get; set; } = [];
        public required List<ServiceLineDto> ServiceLines { get; set; } = [];
        public required ProviderInfoDto BillingProvider { get; set; }
        public required ProviderInfoDto ServiceFacility { get; set; }
        public decimal TotalCharge { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime? PatientSignatureDate { get; set; }
        public DateTime? PhysicianSignatureDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `FormId` | `int` | `public int FormId { get; set; }` |
| `InsuranceProgram` | `InsuranceProgram` | `public InsuranceProgram InsuranceProgram { get; set; }` |
| `InsuredIdNumber` | `string?` | `public string? InsuredIdNumber { get; set; }` |
| `Patient` | `PatientInfoDto` | `public required PatientInfoDto Patient { get; set; }` |
| `Insured` | `InsuredInfoDto` | `public required InsuredInfoDto Insured { get; set; }` |
| `OtherInsurance` | `OtherInsuranceInfoDto` | `public required OtherInsuranceInfoDto OtherInsurance { get; set; }` |
| `ConditionRelated` | `ConditionRelatedDto` | `public required ConditionRelatedDto ConditionRelated { get; set; }` |
| `DiagnosisCodes` | `List<DiagnosisCodeDto>` | `public required List<DiagnosisCodeDto> DiagnosisCodes { get; set; } = [];` |
| `ServiceLines` | `List<ServiceLineDto>` | `public required List<ServiceLineDto> ServiceLines { get; set; } = [];` |
| `BillingProvider` | `ProviderInfoDto` | `public required ProviderInfoDto BillingProvider { get; set; }` |
| `ServiceFacility` | `ProviderInfoDto` | `public required ProviderInfoDto ServiceFacility { get; set; }` |
| `TotalCharge` | `decimal` | `public decimal TotalCharge { get; set; }` |
| `AmountPaid` | `decimal` | `public decimal AmountPaid { get; set; }` |
| `PatientSignatureDate` | `DateTime?` | `public DateTime? PatientSignatureDate { get; set; }` |
| `PhysicianSignatureDate` | `DateTime?` | `public DateTime? PhysicianSignatureDate { get; set; }` |
| `CreatedDate` | `DateTime` | `public DateTime CreatedDate { get; set; } = DateTime.UtcNow;` |
| `UpdatedDate` | `DateTime?` | `public DateTime? UpdatedDate { get; set; }` |

## Class: `ConditionRelatedDto`

- **File Path:** `MyApp.Application/DTOs/Medical/ConditionRelatedDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class ConditionRelatedDto
    {
        public bool Employment { get; set; }
        public bool AutoAccident { get; set; }
        public bool OtherAccident { get; set; }
        public string? AccidentState { get; set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `Employment` | `bool` | `public bool Employment { get; set; }` |
| `AutoAccident` | `bool` | `public bool AutoAccident { get; set; }` |
| `OtherAccident` | `bool` | `public bool OtherAccident { get; set; }` |
| `AccidentState` | `string?` | `public string? AccidentState { get; set; }` |

## Class: `DiagnosisCodeDto`

- **File Path:** `MyApp.Application/DTOs/Medical/DiagnosisCodeDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class DiagnosisCodeDto
    {
        public int DiagnosisId { get; set; }
        public string? Code { get; set; }
        public int Priority { get; set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `DiagnosisId` | `int` | `public int DiagnosisId { get; set; }` |
| `Code` | `string?` | `public string? Code { get; set; }` |
| `Priority` | `int` | `public int Priority { get; set; }` |

## Class: `InsuredInfoDto`

- **File Path:** `MyApp.Application/DTOs/Medical/InsuredInfoDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class InsuredInfoDto
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public required AddressDto Address { get; set; }
        public string? GroupNumber { get; set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `LastName` | `string?` | `public string? LastName { get; set; }` |
| `FirstName` | `string?` | `public string? FirstName { get; set; }` |
| `Address` | `AddressDto` | `public required AddressDto Address { get; set; }` |
| `GroupNumber` | `string?` | `public string? GroupNumber { get; set; }` |

## Class: `OtherInsuranceInfoDto`

- **File Path:** `MyApp.Application/DTOs/Medical/OtherInsuranceInfoDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class OtherInsuranceInfoDto
    {
        public string? PolicyHolderName { get; set; }
        public string? PolicyNumber { get; set; }
        public string? PlanName { get; set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `PolicyHolderName` | `string?` | `public string? PolicyHolderName { get; set; }` |
| `PolicyNumber` | `string?` | `public string? PolicyNumber { get; set; }` |
| `PlanName` | `string?` | `public string? PlanName { get; set; }` |

## Class: `PatientInfoDto`

- **File Path:** `MyApp.Application/DTOs/Medical/PatientInfoDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class PatientInfoDto
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public DateTime? BirthDate { get; set; }
        public Sex Sex { get; set; }
        public required AddressDto Address { get; set; }
        public Relationship RelationshipToInsured { get; set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `LastName` | `string?` | `public string? LastName { get; set; }` |
| `FirstName` | `string?` | `public string? FirstName { get; set; }` |
| `BirthDate` | `DateTime?` | `public DateTime? BirthDate { get; set; }` |
| `Sex` | `Sex` | `public Sex Sex { get; set; }` |
| `Address` | `AddressDto` | `public required AddressDto Address { get; set; }` |
| `RelationshipToInsured` | `Relationship` | `public Relationship RelationshipToInsured { get; set; }` |

## Class: `ProviderInfoDto`

- **File Path:** `MyApp.Application/DTOs/Medical/ProviderInfoDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class ProviderInfoDto
    {
        public string? Name { get; set; }
        public string? FederalTaxId { get; set; }
        public required AddressDto Address { get; set; }
        public string? NpiNumber { get; set; }
        public string? Phone { get; set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `Name` | `string?` | `public string? Name { get; set; }` |
| `FederalTaxId` | `string?` | `public string? FederalTaxId { get; set; }` |
| `Address` | `AddressDto` | `public required AddressDto Address { get; set; }` |
| `NpiNumber` | `string?` | `public string? NpiNumber { get; set; }` |
| `Phone` | `string?` | `public string? Phone { get; set; }` |

## Class: `SearchClaimDto`

- **File Path:** `MyApp.Application/DTOs/Medical/SearchClaimDto.cs`
- **Inherits From:** `AbstractSearchDto<ClaimSortBy, ClaimSortOrder>`

### Class Code

```csharp
public class SearchClaimDto : AbstractSearchDto<ClaimSortBy, ClaimSortOrder>
    {
        public string? InsuredIdNumber { get; set; }
        public string? PatientLastName { get; set; }
        public string? PatientFirstName { get; set; }
        public InsuranceProgram? InsuranceProgram { get; set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `InsuredIdNumber` | `string?` | `public string? InsuredIdNumber { get; set; }` |
| `PatientLastName` | `string?` | `public string? PatientLastName { get; set; }` |
| `PatientFirstName` | `string?` | `public string? PatientFirstName { get; set; }` |
| `InsuranceProgram` | `InsuranceProgram?` | `public InsuranceProgram? InsuranceProgram { get; set; }` |

## Class: `ServiceLineDto`

- **File Path:** `MyApp.Application/DTOs/Medical/ServiceLineDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class ServiceLineDto
    {
        public int ServiceLineId { get; set; }
        public DateTime? ServiceStartDate { get; set; }
        public DateTime? ServiceEndDate { get; set; }
        public string? ProcedureCode { get; set; }
        public string? Modifier { get; set; }
        public string? DiagnosisPointer { get; set; }
        public decimal Charge { get; set; }
        public string? RenderingProviderId { get; set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `ServiceLineId` | `int` | `public int ServiceLineId { get; set; }` |
| `ServiceStartDate` | `DateTime?` | `public DateTime? ServiceStartDate { get; set; }` |
| `ServiceEndDate` | `DateTime?` | `public DateTime? ServiceEndDate { get; set; }` |
| `ProcedureCode` | `string?` | `public string? ProcedureCode { get; set; }` |
| `Modifier` | `string?` | `public string? Modifier { get; set; }` |
| `DiagnosisPointer` | `string?` | `public string? DiagnosisPointer { get; set; }` |
| `Charge` | `decimal` | `public decimal Charge { get; set; }` |
| `RenderingProviderId` | `string?` | `public string? RenderingProviderId { get; set; }` |

