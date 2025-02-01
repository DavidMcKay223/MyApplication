# Address

**Namespace:** `MyApp.Domain.Entities.Medical`

**File Path:** `MyApp.Domain/Entities/Medical/Address.cs`

## Properties

- `int AddressId`
- `string? Street`
- `string? City`
- `string? State`
- `string? ZipCode`
- `string? Phone`

# Claim

**Namespace:** `MyApp.Domain.Entities.Medical`

**File Path:** `MyApp.Domain/Entities/Medical/Claim.cs`

## Properties

- `int FormId`
- `InsuranceProgram InsuranceProgram`
- `string? InsuredIdNumber`
- `PatientInfo Patient`
- `InsuredInfo Insured`
- `OtherInsuranceInfo? OtherInsurance`
- `ConditionRelated ConditionRelated`
- `List<DiagnosisCode> DiagnosisCodes`
- `List<ServiceLine> ServiceLines`
- `ProviderInfo BillingProvider`
- `ProviderInfo ServiceFacility`
- `decimal TotalCharge`
- `decimal AmountPaid`
- `DateTime PatientSignatureDate`
- `DateTime PhysicianSignatureDate`
- `DateTime CreatedDate`
- `DateTime? UpdatedDate`

# ConditionRelated

**Namespace:** `MyApp.Domain.Entities.Medical`

**File Path:** `MyApp.Domain/Entities/Medical/ConditionRelated.cs`

## Properties

- `bool Employment`
- `bool AutoAccident`
- `bool OtherAccident`
- `string? AccidentState`

# DiagnosisCode

**Namespace:** `MyApp.Domain.Entities.Medical`

**File Path:** `MyApp.Domain/Entities/Medical/DiagnosisCode.cs`

## Properties

- `int DiagnosisId`
- `string Code`
- `int Priority`
- `Claim Claim`
- `int ClaimId`

# InsuredInfo

**Namespace:** `MyApp.Domain.Entities.Medical`

**File Path:** `MyApp.Domain/Entities/Medical/InsuredInfo.cs`

## Properties

- `string LastName`
- `string FirstName`
- `Address Address`
- `string? GroupNumber`

# OtherInsuranceInfo

**Namespace:** `MyApp.Domain.Entities.Medical`

**File Path:** `MyApp.Domain/Entities/Medical/OtherInsuranceInfo.cs`

## Properties

- `string? PolicyHolderName`
- `string? PolicyNumber`
- `string? PlanName`
- `DateTime CreatedDate`

# PatientInfo

**Namespace:** `MyApp.Domain.Entities.Medical`

**File Path:** `MyApp.Domain/Entities/Medical/PatientInfo.cs`

## Properties

- `string LastName`
- `string FirstName`
- `DateTime BirthDate`
- `Sex Sex`
- `Address Address`
- `Relationship RelationshipToInsured`

# ProviderInfo

**Namespace:** `MyApp.Domain.Entities.Medical`

**File Path:** `MyApp.Domain/Entities/Medical/ProviderInfo.cs`

## Properties

- `string Name`
- `string FederalTaxId`
- `Address Address`
- `string? NpiNumber`
- `string? Phone`

# ServiceLine

**Namespace:** `MyApp.Domain.Entities.Medical`

**File Path:** `MyApp.Domain/Entities/Medical/ServiceLine.cs`

## Properties

- `int ServiceLineId`
- `DateTime ServiceStartDate`
- `DateTime ServiceEndDate`
- `string ProcedureCode`
- `string? Modifier`
- `string? DiagnosisPointer`
- `decimal Charge`
- `string RenderingProviderId`
- `Claim Claim`
- `int ClaimId`

