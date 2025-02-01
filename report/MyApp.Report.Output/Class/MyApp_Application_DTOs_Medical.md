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

| Name | Type |
|------|------|
| `Street` | `string?` |
| `City` | `string?` |
| `State` | `string?` |
| `ZipCode` | `string?` |
| `Phone` | `string?` |

#### Property: `Street`

```csharp
public string? Street { get; set; }

```

#### Property: `City`

```csharp
public string? City { get; set; }

```

#### Property: `State`

```csharp
public string? State { get; set; }

```

#### Property: `ZipCode`

```csharp
public string? ZipCode { get; set; }

```

#### Property: `Phone`

```csharp
public string? Phone { get; set; }

```

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

| Name | Type |
|------|------|
| `FormId` | `int` |
| `InsuranceProgram` | `InsuranceProgram` |
| `InsuredIdNumber` | `string?` |
| `Patient` | `PatientInfoDto` |
| `Insured` | `InsuredInfoDto` |
| `OtherInsurance` | `OtherInsuranceInfoDto` |
| `ConditionRelated` | `ConditionRelatedDto` |
| `DiagnosisCodes` | `List<DiagnosisCodeDto>` |
| `ServiceLines` | `List<ServiceLineDto>` |
| `BillingProvider` | `ProviderInfoDto` |
| `ServiceFacility` | `ProviderInfoDto` |
| `TotalCharge` | `decimal` |
| `AmountPaid` | `decimal` |
| `PatientSignatureDate` | `DateTime?` |
| `PhysicianSignatureDate` | `DateTime?` |
| `CreatedDate` | `DateTime` |
| `UpdatedDate` | `DateTime?` |

#### Property: `FormId`

```csharp
public int FormId { get; set; }

```

#### Property: `InsuranceProgram`

```csharp
public InsuranceProgram InsuranceProgram { get; set; }

```

#### Property: `InsuredIdNumber`

```csharp
public string? InsuredIdNumber { get; set; }

```

#### Property: `Patient`

```csharp
public required PatientInfoDto Patient { get; set; }

```

#### Property: `Insured`

```csharp
public required InsuredInfoDto Insured { get; set; }

```

#### Property: `OtherInsurance`

```csharp
public required OtherInsuranceInfoDto OtherInsurance { get; set; }

```

#### Property: `ConditionRelated`

```csharp
public required ConditionRelatedDto ConditionRelated { get; set; }

```

#### Property: `DiagnosisCodes`

```csharp
public required List<DiagnosisCodeDto> DiagnosisCodes { get; set; } = [];

```

#### Property: `ServiceLines`

```csharp
public required List<ServiceLineDto> ServiceLines { get; set; } = [];

```

#### Property: `BillingProvider`

```csharp
public required ProviderInfoDto BillingProvider { get; set; }

```

#### Property: `ServiceFacility`

```csharp
public required ProviderInfoDto ServiceFacility { get; set; }

```

#### Property: `TotalCharge`

```csharp
public decimal TotalCharge { get; set; }

```

#### Property: `AmountPaid`

```csharp
public decimal AmountPaid { get; set; }

```

#### Property: `PatientSignatureDate`

```csharp
public DateTime? PatientSignatureDate { get; set; }

```

#### Property: `PhysicianSignatureDate`

```csharp
public DateTime? PhysicianSignatureDate { get; set; }

```

#### Property: `CreatedDate`

```csharp
public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

```

#### Property: `UpdatedDate`

```csharp
public DateTime? UpdatedDate { get; set; }

```

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

| Name | Type |
|------|------|
| `Employment` | `bool` |
| `AutoAccident` | `bool` |
| `OtherAccident` | `bool` |
| `AccidentState` | `string?` |

#### Property: `Employment`

```csharp
public bool Employment { get; set; }

```

#### Property: `AutoAccident`

```csharp
public bool AutoAccident { get; set; }

```

#### Property: `OtherAccident`

```csharp
public bool OtherAccident { get; set; }

```

#### Property: `AccidentState`

```csharp
public string? AccidentState { get; set; }

```

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

| Name | Type |
|------|------|
| `DiagnosisId` | `int` |
| `Code` | `string?` |
| `Priority` | `int` |

#### Property: `DiagnosisId`

```csharp
public int DiagnosisId { get; set; }

```

#### Property: `Code`

```csharp
public string? Code { get; set; }

```

#### Property: `Priority`

```csharp
public int Priority { get; set; }

```

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

| Name | Type |
|------|------|
| `LastName` | `string?` |
| `FirstName` | `string?` |
| `Address` | `AddressDto` |
| `GroupNumber` | `string?` |

#### Property: `LastName`

```csharp
public string? LastName { get; set; }

```

#### Property: `FirstName`

```csharp
public string? FirstName { get; set; }

```

#### Property: `Address`

```csharp
public required AddressDto Address { get; set; }

```

#### Property: `GroupNumber`

```csharp
public string? GroupNumber { get; set; }

```

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

| Name | Type |
|------|------|
| `PolicyHolderName` | `string?` |
| `PolicyNumber` | `string?` |
| `PlanName` | `string?` |

#### Property: `PolicyHolderName`

```csharp
public string? PolicyHolderName { get; set; }

```

#### Property: `PolicyNumber`

```csharp
public string? PolicyNumber { get; set; }

```

#### Property: `PlanName`

```csharp
public string? PlanName { get; set; }

```

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

| Name | Type |
|------|------|
| `LastName` | `string?` |
| `FirstName` | `string?` |
| `BirthDate` | `DateTime?` |
| `Sex` | `Sex` |
| `Address` | `AddressDto` |
| `RelationshipToInsured` | `Relationship` |

#### Property: `LastName`

```csharp
public string? LastName { get; set; }

```

#### Property: `FirstName`

```csharp
public string? FirstName { get; set; }

```

#### Property: `BirthDate`

```csharp
public DateTime? BirthDate { get; set; }

```

#### Property: `Sex`

```csharp
public Sex Sex { get; set; }

```

#### Property: `Address`

```csharp
public required AddressDto Address { get; set; }

```

#### Property: `RelationshipToInsured`

```csharp
public Relationship RelationshipToInsured { get; set; }

```

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

| Name | Type |
|------|------|
| `Name` | `string?` |
| `FederalTaxId` | `string?` |
| `Address` | `AddressDto` |
| `NpiNumber` | `string?` |
| `Phone` | `string?` |

#### Property: `Name`

```csharp
public string? Name { get; set; }

```

#### Property: `FederalTaxId`

```csharp
public string? FederalTaxId { get; set; }

```

#### Property: `Address`

```csharp
public required AddressDto Address { get; set; }

```

#### Property: `NpiNumber`

```csharp
public string? NpiNumber { get; set; }

```

#### Property: `Phone`

```csharp
public string? Phone { get; set; }

```

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

| Name | Type |
|------|------|
| `InsuredIdNumber` | `string?` |
| `PatientLastName` | `string?` |
| `PatientFirstName` | `string?` |
| `InsuranceProgram` | `InsuranceProgram?` |

#### Property: `InsuredIdNumber`

```csharp
public string? InsuredIdNumber { get; set; }

```

#### Property: `PatientLastName`

```csharp
public string? PatientLastName { get; set; }

```

#### Property: `PatientFirstName`

```csharp
public string? PatientFirstName { get; set; }

```

#### Property: `InsuranceProgram`

```csharp
public InsuranceProgram? InsuranceProgram { get; set; }

```

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

| Name | Type |
|------|------|
| `ServiceLineId` | `int` |
| `ServiceStartDate` | `DateTime?` |
| `ServiceEndDate` | `DateTime?` |
| `ProcedureCode` | `string?` |
| `Modifier` | `string?` |
| `DiagnosisPointer` | `string?` |
| `Charge` | `decimal` |
| `RenderingProviderId` | `string?` |

#### Property: `ServiceLineId`

```csharp
public int ServiceLineId { get; set; }

```

#### Property: `ServiceStartDate`

```csharp
public DateTime? ServiceStartDate { get; set; }

```

#### Property: `ServiceEndDate`

```csharp
public DateTime? ServiceEndDate { get; set; }

```

#### Property: `ProcedureCode`

```csharp
public string? ProcedureCode { get; set; }

```

#### Property: `Modifier`

```csharp
public string? Modifier { get; set; }

```

#### Property: `DiagnosisPointer`

```csharp
public string? DiagnosisPointer { get; set; }

```

#### Property: `Charge`

```csharp
public decimal Charge { get; set; }

```

#### Property: `RenderingProviderId`

```csharp
public string? RenderingProviderId { get; set; }

```

