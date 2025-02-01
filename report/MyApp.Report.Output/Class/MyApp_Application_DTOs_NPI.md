# Namespace: `MyApp.Application.DTOs.NPI`

## Class: `EndpointDto`

- **File Path:** `MyApp.Application/DTOs/NPI/EndpointDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
[Serializable]
public class EndpointDto
{
    public string? EndpointType { get; set; }
    public string? EndpointTypeDescription { get; set; }
    public string? EndpointValue { get; set; }
    public string? Affiliation { get; set; }
    public string? UseDescription { get; set; }
    public string? ContentTypeDescription { get; set; }
    public string? CountryCode { get; set; }
    public string? CountryName { get; set; }
    public string? AddressType { get; set; }
    public string? Address1 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? PostalCode { get; set; }
}

```

### Properties

| Name | Type |
|------|------|
| `EndpointType` | `string?` |
| `EndpointTypeDescription` | `string?` |
| `EndpointValue` | `string?` |
| `Affiliation` | `string?` |
| `UseDescription` | `string?` |
| `ContentTypeDescription` | `string?` |
| `CountryCode` | `string?` |
| `CountryName` | `string?` |
| `AddressType` | `string?` |
| `Address1` | `string?` |
| `City` | `string?` |
| `State` | `string?` |
| `PostalCode` | `string?` |

#### Property: `EndpointType`

```csharp
public string? EndpointType { get; set; }

```

#### Property: `EndpointTypeDescription`

```csharp
public string? EndpointTypeDescription { get; set; }

```

#### Property: `EndpointValue`

```csharp
public string? EndpointValue { get; set; }

```

#### Property: `Affiliation`

```csharp
public string? Affiliation { get; set; }

```

#### Property: `UseDescription`

```csharp
public string? UseDescription { get; set; }

```

#### Property: `ContentTypeDescription`

```csharp
public string? ContentTypeDescription { get; set; }

```

#### Property: `CountryCode`

```csharp
public string? CountryCode { get; set; }

```

#### Property: `CountryName`

```csharp
public string? CountryName { get; set; }

```

#### Property: `AddressType`

```csharp
public string? AddressType { get; set; }

```

#### Property: `Address1`

```csharp
public string? Address1 { get; set; }

```

#### Property: `City`

```csharp
public string? City { get; set; }

```

#### Property: `State`

```csharp
public string? State { get; set; }

```

#### Property: `PostalCode`

```csharp
public string? PostalCode { get; set; }

```

## Class: `IdentifierDto`

- **File Path:** `MyApp.Application/DTOs/NPI/IdentifierDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
[Serializable]
public class IdentifierDto
{
    public string? Code { get; set; }
    public string? Description { get; set; }
    public string? Issuer { get; set; }
    public string? IdentifierValue { get; set; }
    public string? State { get; set; }
}

```

### Properties

| Name | Type |
|------|------|
| `Code` | `string?` |
| `Description` | `string?` |
| `Issuer` | `string?` |
| `IdentifierValue` | `string?` |
| `State` | `string?` |

#### Property: `Code`

```csharp
public string? Code { get; set; }

```

#### Property: `Description`

```csharp
public string? Description { get; set; }

```

#### Property: `Issuer`

```csharp
public string? Issuer { get; set; }

```

#### Property: `IdentifierValue`

```csharp
public string? IdentifierValue { get; set; }

```

#### Property: `State`

```csharp
public string? State { get; set; }

```

## Class: `ProviderDto`

- **File Path:** `MyApp.Application/DTOs/NPI/ProviderDto.cs`
- **Inherits From:** N/A

### Class Code

```csharp
[Serializable]
public class ProviderDto
{
    #region -- NPI Number --
    public required string NPI { get; set; }
    #endregion

    #region -- Address Info --
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Zip { get; set; }
    public string? Phone { get; set; }
    public string? Fax { get; set; }
    #endregion

    #region -- Mailing Address Info --
    public string? MailingAddress1 { get; set; }
    public string? MailingAddress2 { get; set; }
    public string? MailingCity { get; set; }
    public string? MailingState { get; set; }
    public string? MailingZip { get; set; }
    public string? MailingPhone { get; set; }
    public string? MailingFax { get; set; }
    #endregion

    #region -- Basic Info --
    public string? Name { get; set; }
    public string? ProviderName { get; set; }
    public string? ProviderFirstName { get; set; }
    public string? ProviderLastName { get; set; }
    public string? OrganizationName { get; set; }
    public string? ParentOrganizationLegalBusinessName { get; set; }
    public string? Gender { get; set; }
    public string? SoleProprietor { get; set; }
    public string? EnumerationDate { get; set; }
    public string? LastUpdated { get; set; }
    public string? Status { get; set; }
    #endregion

    #region -- Other Names --
    public string? OtherOrganizationName { get; set; }
    #endregion

    #region -- Taxonomy --
    public string? PrimaryTaxonomyCode { get; set; }
    public string? PrimaryTaxonomyStateLicense { get; set; }
    public string? PrimaryTaxonomyDescription { get; set; }
    public string? PrimaryTaxonomyGroup { get; set; }
    #endregion

    #region -- Identifiers --
    public List<IdentifierDto>? Identifiers { get; set; }
    #endregion

    #region -- Endpoints --
    public List<EndpointDto>? Endpoints { get; set; }
    #endregion

    #region -- Dynamic --
    public string? DynamicName => string.IsNullOrWhiteSpace(OtherOrganizationName) ? Name : OtherOrganizationName;

    public string? DynamicLegalName => string.IsNullOrWhiteSpace(ParentOrganizationLegalBusinessName) ? Name : ParentOrganizationLegalBusinessName;
    #endregion
}

```

### Properties

| Name | Type |
|------|------|
| `NPI` | `string` |
| `Address1` | `string?` |
| `Address2` | `string?` |
| `City` | `string?` |
| `State` | `string?` |
| `Zip` | `string?` |
| `Phone` | `string?` |
| `Fax` | `string?` |
| `MailingAddress1` | `string?` |
| `MailingAddress2` | `string?` |
| `MailingCity` | `string?` |
| `MailingState` | `string?` |
| `MailingZip` | `string?` |
| `MailingPhone` | `string?` |
| `MailingFax` | `string?` |
| `Name` | `string?` |
| `ProviderName` | `string?` |
| `ProviderFirstName` | `string?` |
| `ProviderLastName` | `string?` |
| `OrganizationName` | `string?` |
| `ParentOrganizationLegalBusinessName` | `string?` |
| `Gender` | `string?` |
| `SoleProprietor` | `string?` |
| `EnumerationDate` | `string?` |
| `LastUpdated` | `string?` |
| `Status` | `string?` |
| `OtherOrganizationName` | `string?` |
| `PrimaryTaxonomyCode` | `string?` |
| `PrimaryTaxonomyStateLicense` | `string?` |
| `PrimaryTaxonomyDescription` | `string?` |
| `PrimaryTaxonomyGroup` | `string?` |
| `Identifiers` | `List<IdentifierDto>?` |
| `Endpoints` | `List<EndpointDto>?` |
| `DynamicName` | `string?` |
| `DynamicLegalName` | `string?` |

#### Property: `NPI`

```csharp
#region -- NPI Number --
public required string NPI { get; set; }

```

#### Property: `Address1`

```csharp
#endregion

#region -- Address Info --
public string? Address1 { get; set; }

```

#### Property: `Address2`

```csharp
public string? Address2 { get; set; }

```

#### Property: `City`

```csharp
public string? City { get; set; }

```

#### Property: `State`

```csharp
public string? State { get; set; }

```

#### Property: `Zip`

```csharp
public string? Zip { get; set; }

```

#### Property: `Phone`

```csharp
public string? Phone { get; set; }

```

#### Property: `Fax`

```csharp
public string? Fax { get; set; }

```

#### Property: `MailingAddress1`

```csharp
#endregion

#region -- Mailing Address Info --
public string? MailingAddress1 { get; set; }

```

#### Property: `MailingAddress2`

```csharp
public string? MailingAddress2 { get; set; }

```

#### Property: `MailingCity`

```csharp
public string? MailingCity { get; set; }

```

#### Property: `MailingState`

```csharp
public string? MailingState { get; set; }

```

#### Property: `MailingZip`

```csharp
public string? MailingZip { get; set; }

```

#### Property: `MailingPhone`

```csharp
public string? MailingPhone { get; set; }

```

#### Property: `MailingFax`

```csharp
public string? MailingFax { get; set; }

```

#### Property: `Name`

```csharp
#endregion

#region -- Basic Info --
public string? Name { get; set; }

```

#### Property: `ProviderName`

```csharp
public string? ProviderName { get; set; }

```

#### Property: `ProviderFirstName`

```csharp
public string? ProviderFirstName { get; set; }

```

#### Property: `ProviderLastName`

```csharp
public string? ProviderLastName { get; set; }

```

#### Property: `OrganizationName`

```csharp
public string? OrganizationName { get; set; }

```

#### Property: `ParentOrganizationLegalBusinessName`

```csharp
public string? ParentOrganizationLegalBusinessName { get; set; }

```

#### Property: `Gender`

```csharp
public string? Gender { get; set; }

```

#### Property: `SoleProprietor`

```csharp
public string? SoleProprietor { get; set; }

```

#### Property: `EnumerationDate`

```csharp
public string? EnumerationDate { get; set; }

```

#### Property: `LastUpdated`

```csharp
public string? LastUpdated { get; set; }

```

#### Property: `Status`

```csharp
public string? Status { get; set; }

```

#### Property: `OtherOrganizationName`

```csharp
#endregion

#region -- Other Names --
public string? OtherOrganizationName { get; set; }

```

#### Property: `PrimaryTaxonomyCode`

```csharp
#endregion

#region -- Taxonomy --
public string? PrimaryTaxonomyCode { get; set; }

```

#### Property: `PrimaryTaxonomyStateLicense`

```csharp
public string? PrimaryTaxonomyStateLicense { get; set; }

```

#### Property: `PrimaryTaxonomyDescription`

```csharp
public string? PrimaryTaxonomyDescription { get; set; }

```

#### Property: `PrimaryTaxonomyGroup`

```csharp
public string? PrimaryTaxonomyGroup { get; set; }

```

#### Property: `Identifiers`

```csharp
#endregion

#region -- Identifiers --
public List<IdentifierDto>? Identifiers { get; set; }

```

#### Property: `Endpoints`

```csharp
#endregion

#region -- Endpoints --
public List<EndpointDto>? Endpoints { get; set; }

```

#### Property: `DynamicName`

```csharp
#endregion

#region -- Dynamic --
public string? DynamicName => string.IsNullOrWhiteSpace(OtherOrganizationName) ? Name : OtherOrganizationName;

```

#### Property: `DynamicLegalName`

```csharp

public string? DynamicLegalName => string.IsNullOrWhiteSpace(ParentOrganizationLegalBusinessName) ? Name : ParentOrganizationLegalBusinessName;

```

