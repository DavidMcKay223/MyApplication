# Namespace: `MyApp.Domain.Entities.Medical`

## Class: `Address`

- **File Path:** `MyApp.Domain/Entities/Medical/Address.cs`
- **Inherits From:** N/A

### Class Code

```csharp
[Table("Medical_Claim_Address")]
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        [MaxLength(100)]
        public string? Street { get; set; }
        [MaxLength(50)]
        public string? City { get; set; }
        [MaxLength(2)]
        public string? State { get; set; }
        [MaxLength(10)]
        public string? ZipCode { get; set; }
        [MaxLength(20)]
        public string? Phone { get; set; }
    }
```

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

### Class Code

```csharp
[Table("Medical_Claim")]
    public class Claim
    {
        [Key]
        public int FormId { get; set; }

        // Program Information (Item 1) 
        [Required]
        public InsuranceProgram InsuranceProgram { get; set; }
        [MaxLength(20)]
        public string? InsuredIdNumber { get; set; }

        // Patient Information (Items 2-6) 
        public required PatientInfo Patient { get; set; }

        // Insured Information (Items 4,7,14) 
        public required InsuredInfo Insured { get; set; }

        // Other Insurance (Item 9) 
        public OtherInsuranceInfo? OtherInsurance { get; set; }

        // Condition Related To (Item 10) 
        public ConditionRelated ConditionRelated { get; set; } = new();

        // Service Details (Items 21,24) 
        public List<DiagnosisCode> DiagnosisCodes { get; set; } = new();
        public List<ServiceLine> ServiceLines { get; set; } = new();

        // Provider Information (Items 25,32,33) 
        public required ProviderInfo BillingProvider { get; set; }
        public required ProviderInfo ServiceFacility { get; set; }

        // Financials (Items 28-29) 
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalCharge { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal AmountPaid { get; set; }

        // Signatures (Items 12,31) 
        public DateTime PatientSignatureDate { get; set; }
        public DateTime PhysicianSignatureDate { get; set; }

        // Metadata 
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

### Class Code

```csharp
[Owned]
    public class ConditionRelated
    {
        public bool Employment { get; set; }
        public bool AutoAccident { get; set; }
        public bool OtherAccident { get; set; }
        [MaxLength(2)]
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

## Class: `DiagnosisCode`

- **File Path:** `MyApp.Domain/Entities/Medical/DiagnosisCode.cs`
- **Inherits From:** N/A

### Class Code

```csharp
[Table("Medical_Claim_Diagnosis")]
    public class DiagnosisCode
    {
        [Key]
        public int DiagnosisId { get; set; }
        [MaxLength(10)]
        public required string Code { get; set; } // ICD-10 code 
        public int Priority { get; set; } // A-L indicators (1-12) 
        public required Claim Claim { get; set; }
        public int ClaimId { get; set; }
    }
```

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

### Class Code

```csharp
[Owned]
    public class InsuredInfo
    {
        [MaxLength(50)]
        public required string LastName { get; set; }
        [MaxLength(50)]
        public required string FirstName { get; set; }
        public required Address Address { get; set; }
        [MaxLength(20)]
        public string? GroupNumber { get; set; }
    }
```

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

### Class Code

```csharp
[Owned]
    public class OtherInsuranceInfo
    {
        [MaxLength(50)]
        public string? PolicyHolderName { get; set; }
        [MaxLength(20)]
        public string? PolicyNumber { get; set; }
        [MaxLength(50)]
        public string? PlanName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
```

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

### Class Code

```csharp
[Owned]
    public class PatientInfo
    {
        [MaxLength(50)]
        public required string LastName { get; set; }
        [MaxLength(50)]
        public required string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public Sex Sex { get; set; }
        public required Address Address { get; set; }
        public Relationship RelationshipToInsured { get; set; }
    }
```

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

### Class Code

```csharp
[Owned]
    public class ProviderInfo
    {
        [MaxLength(100)]
        public required string Name { get; set; }
        [MaxLength(20)]
        public required string FederalTaxId { get; set; }
        public required Address Address { get; set; }
        [MaxLength(20)]
        public string? NpiNumber { get; set; }
        [MaxLength(20)]
        public string? Phone { get; set; }
    }
```

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

### Class Code

```csharp
[Table("Medical_Claim_ServiceLine")]
    public class ServiceLine
    {
        [Key]
        public int ServiceLineId { get; set; }
        public DateTime ServiceStartDate { get; set; }
        public DateTime ServiceEndDate { get; set; }
        [MaxLength(10)]
        public required string ProcedureCode { get; set; } // CPT/HCPCS 
        [MaxLength(2)]
        public string? Modifier { get; set; }
        [MaxLength(10)]
        public string? DiagnosisPointer { get; set; } // Links to DiagnosisCode.Priority 
        [Column(TypeName = "decimal(18,2)")]
        public decimal Charge { get; set; }
        [MaxLength(20)]
        public required string RenderingProviderId { get; set; }
        public required Claim Claim { get; set; }
        public int ClaimId { get; set; }
    }
```

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

