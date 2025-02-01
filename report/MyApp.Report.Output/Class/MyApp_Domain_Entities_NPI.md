# Namespace: `MyApp.Domain.Entities.NPI`

## Class: `Endpoint`

- **File Path:** `MyApp.Domain/Entities/NPI/Endpoint.cs`
- **Inherits From:** N/A

### Class Code

```csharp
[ComplexType]
    [Serializable]
    public class Endpoint
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

## Class: `Identifier`

- **File Path:** `MyApp.Domain/Entities/NPI/Identifier.cs`
- **Inherits From:** N/A

### Class Code

```csharp
[ComplexType]
    [Serializable]
    public class Identifier
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

## Class: `Provider`

- **File Path:** `MyApp.Domain/Entities/NPI/Provider.cs`
- **Inherits From:** N/A

### Class Code

```csharp
[Table("NPI_Provider")]
    [Serializable]
    public class Provider
    {
        [Key]
        #region -- NPI Number --
        [MaxLength(10)]
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
        public List<Identifier>? Identifiers { get; set; }
        #endregion

        #region -- Endpoints --
        public List<Endpoint>? Endpoints { get; set; }
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
| `Identifiers` | `List<Identifier>?` |
| `Endpoints` | `List<Endpoint>?` |

