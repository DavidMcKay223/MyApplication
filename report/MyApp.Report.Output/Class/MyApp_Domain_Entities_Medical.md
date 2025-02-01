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

| Name | Type | Definition |
|------|------|-------------|
| `AddressId` | `int` | `[Key]<br>        public int AddressId { get; set; }` |
| `Street` | `string?` | `[MaxLength(100)]<br>        public string? Street { get; set; }` |
| `City` | `string?` | `[MaxLength(50)]<br>        public string? City { get; set; }` |
| `State` | `string?` | `[MaxLength(2)]<br>        public string? State { get; set; }` |
| `ZipCode` | `string?` | `[MaxLength(10)]<br>        public string? ZipCode { get; set; }` |
| `Phone` | `string?` | `[MaxLength(20)]<br>        public string? Phone { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `FormId` | `int` | `[Key]<br>        public int FormId { get; set; }` |
| `InsuranceProgram` | `InsuranceProgram` | `// Program Information (Item 1) <br>        [Required]<br>        public InsuranceProgram InsuranceProgram { get; set; }` |
| `InsuredIdNumber` | `string?` | `[MaxLength(20)]<br>        public string? InsuredIdNumber { get; set; }` |
| `Patient` | `PatientInfo` | `// Patient Information (Items 2-6) <br>        public required PatientInfo Patient { get; set; }` |
| `Insured` | `InsuredInfo` | `// Insured Information (Items 4,7,14) <br>        public required InsuredInfo Insured { get; set; }` |
| `OtherInsurance` | `OtherInsuranceInfo?` | `// Other Insurance (Item 9) <br>        public OtherInsuranceInfo? OtherInsurance { get; set; }` |
| `ConditionRelated` | `ConditionRelated` | `// Condition Related To (Item 10) <br>        public ConditionRelated ConditionRelated { get; set; } = new();` |
| `DiagnosisCodes` | `List<DiagnosisCode>` | `// Service Details (Items 21,24) <br>        public List<DiagnosisCode> DiagnosisCodes { get; set; } = new();` |
| `ServiceLines` | `List<ServiceLine>` | `public List<ServiceLine> ServiceLines { get; set; } = new();` |
| `BillingProvider` | `ProviderInfo` | `// Provider Information (Items 25,32,33) <br>        public required ProviderInfo BillingProvider { get; set; }` |
| `ServiceFacility` | `ProviderInfo` | `public required ProviderInfo ServiceFacility { get; set; }` |
| `TotalCharge` | `decimal` | `// Financials (Items 28-29) <br>        [Column(TypeName = "decimal(18,2)")]<br>        public decimal TotalCharge { get; set; }` |
| `AmountPaid` | `decimal` | `[Column(TypeName = "decimal(18,2)")]<br>        public decimal AmountPaid { get; set; }` |
| `PatientSignatureDate` | `DateTime` | `// Signatures (Items 12,31) <br>        public DateTime PatientSignatureDate { get; set; }` |
| `PhysicianSignatureDate` | `DateTime` | `public DateTime PhysicianSignatureDate { get; set; }` |
| `CreatedDate` | `DateTime` | `// Metadata <br>        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;` |
| `UpdatedDate` | `DateTime?` | `public DateTime? UpdatedDate { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `Employment` | `bool` | `public bool Employment { get; set; }` |
| `AutoAccident` | `bool` | `public bool AutoAccident { get; set; }` |
| `OtherAccident` | `bool` | `public bool OtherAccident { get; set; }` |
| `AccidentState` | `string?` | `[MaxLength(2)]<br>        public string? AccidentState { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `DiagnosisId` | `int` | `[Key]<br>        public int DiagnosisId { get; set; }` |
| `Code` | `string` | `[MaxLength(10)]<br>        public required string Code { get; set; } // ICD-10 code` |
| `Priority` | `int` | `public int Priority { get; set; } // A-L indicators (1-12)` |
| `Claim` | `Claim` | `public required Claim Claim { get; set; }` |
| `ClaimId` | `int` | `public int ClaimId { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `LastName` | `string` | `[MaxLength(50)]<br>        public required string LastName { get; set; }` |
| `FirstName` | `string` | `[MaxLength(50)]<br>        public required string FirstName { get; set; }` |
| `Address` | `Address` | `public required Address Address { get; set; }` |
| `GroupNumber` | `string?` | `[MaxLength(20)]<br>        public string? GroupNumber { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `PolicyHolderName` | `string?` | `[MaxLength(50)]<br>        public string? PolicyHolderName { get; set; }` |
| `PolicyNumber` | `string?` | `[MaxLength(20)]<br>        public string? PolicyNumber { get; set; }` |
| `PlanName` | `string?` | `[MaxLength(50)]<br>        public string? PlanName { get; set; }` |
| `CreatedDate` | `DateTime` | `public DateTime CreatedDate { get; set; } = DateTime.UtcNow;` |

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

| Name | Type | Definition |
|------|------|-------------|
| `LastName` | `string` | `[MaxLength(50)]<br>        public required string LastName { get; set; }` |
| `FirstName` | `string` | `[MaxLength(50)]<br>        public required string FirstName { get; set; }` |
| `BirthDate` | `DateTime` | `public DateTime BirthDate { get; set; }` |
| `Sex` | `Sex` | `public Sex Sex { get; set; }` |
| `Address` | `Address` | `public required Address Address { get; set; }` |
| `RelationshipToInsured` | `Relationship` | `public Relationship RelationshipToInsured { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `Name` | `string` | `[MaxLength(100)]<br>        public required string Name { get; set; }` |
| `FederalTaxId` | `string` | `[MaxLength(20)]<br>        public required string FederalTaxId { get; set; }` |
| `Address` | `Address` | `public required Address Address { get; set; }` |
| `NpiNumber` | `string?` | `[MaxLength(20)]<br>        public string? NpiNumber { get; set; }` |
| `Phone` | `string?` | `[MaxLength(20)]<br>        public string? Phone { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `ServiceLineId` | `int` | `[Key]<br>        public int ServiceLineId { get; set; }` |
| `ServiceStartDate` | `DateTime` | `public DateTime ServiceStartDate { get; set; }` |
| `ServiceEndDate` | `DateTime` | `public DateTime ServiceEndDate { get; set; }` |
| `ProcedureCode` | `string` | `[MaxLength(10)]<br>        public required string ProcedureCode { get; set; } // CPT/HCPCS` |
| `Modifier` | `string?` | `[MaxLength(2)]<br>        public string? Modifier { get; set; }` |
| `DiagnosisPointer` | `string?` | `[MaxLength(10)]<br>        public string? DiagnosisPointer { get; set; } // Links to DiagnosisCode.Priority` |
| `Charge` | `decimal` | `[Column(TypeName = "decimal(18,2)")]<br>        public decimal Charge { get; set; }` |
| `RenderingProviderId` | `string` | `[MaxLength(20)]<br>        public required string RenderingProviderId { get; set; }` |
| `Claim` | `Claim` | `public required Claim Claim { get; set; }` |
| `ClaimId` | `int` | `public int ClaimId { get; set; }` |

