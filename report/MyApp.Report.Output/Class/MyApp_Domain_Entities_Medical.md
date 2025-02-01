# Namespace: `MyApp.Domain.Entities.Medical`

## Class: `Address`

- **File Path:** `MyApp.Domain/Entities/Medical/Address.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `AddressId` | `int` |
| `Street` | `string?` |
| `City` | `string?` |
| `State` | `string?` |
| `ZipCode` | `string?` |
| `Phone` | `string?` |

## Class: `Claim`

- **File Path:** `MyApp.Domain/Entities/Medical/Claim.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `FormId` | `int` |
| `InsuranceProgram` | `InsuranceProgram` |
| `InsuredIdNumber` | `string?` |
| `Patient` | `PatientInfo` |
| `Insured` | `InsuredInfo` |
| `OtherInsurance` | `OtherInsuranceInfo?` |
| `ConditionRelated` | `ConditionRelated` |
| `DiagnosisCodes` | `List<DiagnosisCode>` |
| `ServiceLines` | `List<ServiceLine>` |
| `BillingProvider` | `ProviderInfo` |
| `ServiceFacility` | `ProviderInfo` |
| `TotalCharge` | `decimal` |
| `AmountPaid` | `decimal` |
| `PatientSignatureDate` | `DateTime` |
| `PhysicianSignatureDate` | `DateTime` |
| `CreatedDate` | `DateTime` |
| `UpdatedDate` | `DateTime?` |

## Class: `ConditionRelated`

- **File Path:** `MyApp.Domain/Entities/Medical/ConditionRelated.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `Employment` | `bool` |
| `AutoAccident` | `bool` |
| `OtherAccident` | `bool` |
| `AccidentState` | `string?` |

## Class: `DiagnosisCode`

- **File Path:** `MyApp.Domain/Entities/Medical/DiagnosisCode.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `DiagnosisId` | `int` |
| `Code` | `string` |
| `Priority` | `int` |
| `Claim` | `Claim` |
| `ClaimId` | `int` |

## Class: `InsuredInfo`

- **File Path:** `MyApp.Domain/Entities/Medical/InsuredInfo.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `LastName` | `string` |
| `FirstName` | `string` |
| `Address` | `Address` |
| `GroupNumber` | `string?` |

## Class: `OtherInsuranceInfo`

- **File Path:** `MyApp.Domain/Entities/Medical/OtherInsuranceInfo.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `PolicyHolderName` | `string?` |
| `PolicyNumber` | `string?` |
| `PlanName` | `string?` |
| `CreatedDate` | `DateTime` |

## Class: `PatientInfo`

- **File Path:** `MyApp.Domain/Entities/Medical/PatientInfo.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `LastName` | `string` |
| `FirstName` | `string` |
| `BirthDate` | `DateTime` |
| `Sex` | `Sex` |
| `Address` | `Address` |
| `RelationshipToInsured` | `Relationship` |

## Class: `ProviderInfo`

- **File Path:** `MyApp.Domain/Entities/Medical/ProviderInfo.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `Name` | `string` |
| `FederalTaxId` | `string` |
| `Address` | `Address` |
| `NpiNumber` | `string?` |
| `Phone` | `string?` |

## Class: `ServiceLine`

- **File Path:** `MyApp.Domain/Entities/Medical/ServiceLine.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `ServiceLineId` | `int` |
| `ServiceStartDate` | `DateTime` |
| `ServiceEndDate` | `DateTime` |
| `ProcedureCode` | `string` |
| `Modifier` | `string?` |
| `DiagnosisPointer` | `string?` |
| `Charge` | `decimal` |
| `RenderingProviderId` | `string` |
| `Claim` | `Claim` |
| `ClaimId` | `int` |

