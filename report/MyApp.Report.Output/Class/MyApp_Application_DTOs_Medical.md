# Namespace: `MyApp.Application.DTOs.Medical`

## Class: `AddressDto`

- **File Path:** `MyApp.Application/DTOs/Medical/AddressDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `Street` | `string?` |
| `City` | `string?` |
| `State` | `string?` |
| `ZipCode` | `string?` |
| `Phone` | `string?` |

## Class: `ClaimDto`

- **File Path:** `MyApp.Application/DTOs/Medical/ClaimDto.cs`
- **Inherits From:** N/A

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

## Class: `ConditionRelatedDto`

- **File Path:** `MyApp.Application/DTOs/Medical/ConditionRelatedDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `Employment` | `bool` |
| `AutoAccident` | `bool` |
| `OtherAccident` | `bool` |
| `AccidentState` | `string?` |

## Class: `DiagnosisCodeDto`

- **File Path:** `MyApp.Application/DTOs/Medical/DiagnosisCodeDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `DiagnosisId` | `int` |
| `Code` | `string?` |
| `Priority` | `int` |

## Class: `InsuredInfoDto`

- **File Path:** `MyApp.Application/DTOs/Medical/InsuredInfoDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `LastName` | `string?` |
| `FirstName` | `string?` |
| `Address` | `AddressDto` |
| `GroupNumber` | `string?` |

## Class: `OtherInsuranceInfoDto`

- **File Path:** `MyApp.Application/DTOs/Medical/OtherInsuranceInfoDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `PolicyHolderName` | `string?` |
| `PolicyNumber` | `string?` |
| `PlanName` | `string?` |

## Class: `PatientInfoDto`

- **File Path:** `MyApp.Application/DTOs/Medical/PatientInfoDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `LastName` | `string?` |
| `FirstName` | `string?` |
| `BirthDate` | `DateTime?` |
| `Sex` | `Sex` |
| `Address` | `AddressDto` |
| `RelationshipToInsured` | `Relationship` |

## Class: `ProviderInfoDto`

- **File Path:** `MyApp.Application/DTOs/Medical/ProviderInfoDto.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `Name` | `string?` |
| `FederalTaxId` | `string?` |
| `Address` | `AddressDto` |
| `NpiNumber` | `string?` |
| `Phone` | `string?` |

## Class: `SearchClaimDto`

- **File Path:** `MyApp.Application/DTOs/Medical/SearchClaimDto.cs`
- **Inherits From:** `AbstractSearchDto<ClaimSortBy, ClaimSortOrder>`

### Properties

| Name | Type |
|------|------|
| `InsuredIdNumber` | `string?` |
| `PatientLastName` | `string?` |
| `PatientFirstName` | `string?` |
| `InsuranceProgram` | `InsuranceProgram?` |

## Class: `ServiceLineDto`

- **File Path:** `MyApp.Application/DTOs/Medical/ServiceLineDto.cs`
- **Inherits From:** N/A

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

