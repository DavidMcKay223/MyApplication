# AddressDto

**Namespace:** `MyApp.Application.DTOs.Medical`

**File Path:** `MyApp.Application/DTOs/Medical/AddressDto.cs`

## Properties

- `string? Street`
- `string? City`
- `string? State`
- `string? ZipCode`
- `string? Phone`

# ClaimDto

**Namespace:** `MyApp.Application.DTOs.Medical`

**File Path:** `MyApp.Application/DTOs/Medical/ClaimDto.cs`

## Properties

- `int FormId`
- `InsuranceProgram InsuranceProgram`
- `string? InsuredIdNumber`
- `PatientInfoDto Patient`
- `InsuredInfoDto Insured`
- `OtherInsuranceInfoDto OtherInsurance`
- `ConditionRelatedDto ConditionRelated`
- `List<DiagnosisCodeDto> DiagnosisCodes`
- `List<ServiceLineDto> ServiceLines`
- `ProviderInfoDto BillingProvider`
- `ProviderInfoDto ServiceFacility`
- `decimal TotalCharge`
- `decimal AmountPaid`
- `DateTime? PatientSignatureDate`
- `DateTime? PhysicianSignatureDate`
- `DateTime CreatedDate`
- `DateTime? UpdatedDate`

# ConditionRelatedDto

**Namespace:** `MyApp.Application.DTOs.Medical`

**File Path:** `MyApp.Application/DTOs/Medical/ConditionRelatedDto.cs`

## Properties

- `bool Employment`
- `bool AutoAccident`
- `bool OtherAccident`
- `string? AccidentState`

# DiagnosisCodeDto

**Namespace:** `MyApp.Application.DTOs.Medical`

**File Path:** `MyApp.Application/DTOs/Medical/DiagnosisCodeDto.cs`

## Properties

- `int DiagnosisId`
- `string? Code`
- `int Priority`

# InsuredInfoDto

**Namespace:** `MyApp.Application.DTOs.Medical`

**File Path:** `MyApp.Application/DTOs/Medical/InsuredInfoDto.cs`

## Properties

- `string? LastName`
- `string? FirstName`
- `AddressDto Address`
- `string? GroupNumber`

# OtherInsuranceInfoDto

**Namespace:** `MyApp.Application.DTOs.Medical`

**File Path:** `MyApp.Application/DTOs/Medical/OtherInsuranceInfoDto.cs`

## Properties

- `string? PolicyHolderName`
- `string? PolicyNumber`
- `string? PlanName`

# PatientInfoDto

**Namespace:** `MyApp.Application.DTOs.Medical`

**File Path:** `MyApp.Application/DTOs/Medical/PatientInfoDto.cs`

## Properties

- `string? LastName`
- `string? FirstName`
- `DateTime? BirthDate`
- `Sex Sex`
- `AddressDto Address`
- `Relationship RelationshipToInsured`

# ProviderInfoDto

**Namespace:** `MyApp.Application.DTOs.Medical`

**File Path:** `MyApp.Application/DTOs/Medical/ProviderInfoDto.cs`

## Properties

- `string? Name`
- `string? FederalTaxId`
- `AddressDto Address`
- `string? NpiNumber`
- `string? Phone`

# SearchClaimDto

**Namespace:** `MyApp.Application.DTOs.Medical`

**File Path:** `MyApp.Application/DTOs/Medical/SearchClaimDto.cs`

## Inherits From

- `AbstractSearchDto<ClaimSortBy, ClaimSortOrder>`

## Properties

- `string? InsuredIdNumber`
- `string? PatientLastName`
- `string? PatientFirstName`
- `InsuranceProgram? InsuranceProgram`

# ServiceLineDto

**Namespace:** `MyApp.Application.DTOs.Medical`

**File Path:** `MyApp.Application/DTOs/Medical/ServiceLineDto.cs`

## Properties

- `int ServiceLineId`
- `DateTime? ServiceStartDate`
- `DateTime? ServiceEndDate`
- `string? ProcedureCode`
- `string? Modifier`
- `string? DiagnosisPointer`
- `decimal Charge`
- `string? RenderingProviderId`

