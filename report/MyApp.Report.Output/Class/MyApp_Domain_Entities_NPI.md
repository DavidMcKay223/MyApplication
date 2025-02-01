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

| Name | Type | Definition |
|------|------|-------------|
| `EndpointType` | `string?` | `public string? EndpointType { get; set; }` |
| `EndpointTypeDescription` | `string?` | `public string? EndpointTypeDescription { get; set; }` |
| `EndpointValue` | `string?` | `public string? EndpointValue { get; set; }` |
| `Affiliation` | `string?` | `public string? Affiliation { get; set; }` |
| `UseDescription` | `string?` | `public string? UseDescription { get; set; }` |
| `ContentTypeDescription` | `string?` | `public string? ContentTypeDescription { get; set; }` |
| `CountryCode` | `string?` | `public string? CountryCode { get; set; }` |
| `CountryName` | `string?` | `public string? CountryName { get; set; }` |
| `AddressType` | `string?` | `public string? AddressType { get; set; }` |
| `Address1` | `string?` | `public string? Address1 { get; set; }` |
| `City` | `string?` | `public string? City { get; set; }` |
| `State` | `string?` | `public string? State { get; set; }` |
| `PostalCode` | `string?` | `public string? PostalCode { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `Code` | `string?` | `public string? Code { get; set; }` |
| `Description` | `string?` | `public string? Description { get; set; }` |
| `Issuer` | `string?` | `public string? Issuer { get; set; }` |
| `IdentifierValue` | `string?` | `public string? IdentifierValue { get; set; }` |
| `State` | `string?` | `public string? State { get; set; }` |

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

| Name | Type | Definition |
|------|------|-------------|
| `NPI` | `string` | `[Key]<br>        #region -- NPI Number --<br>        [MaxLength(10)]<br>        public required string NPI { get; set; }` |
| `Address1` | `string?` | `#endregion<br><br>        #region -- Address Info --<br>        public string? Address1 { get; set; }` |
| `Address2` | `string?` | `public string? Address2 { get; set; }` |
| `City` | `string?` | `public string? City { get; set; }` |
| `State` | `string?` | `public string? State { get; set; }` |
| `Zip` | `string?` | `public string? Zip { get; set; }` |
| `Phone` | `string?` | `public string? Phone { get; set; }` |
| `Fax` | `string?` | `public string? Fax { get; set; }` |
| `MailingAddress1` | `string?` | `#endregion<br><br>        #region -- Mailing Address Info --<br>        public string? MailingAddress1 { get; set; }` |
| `MailingAddress2` | `string?` | `public string? MailingAddress2 { get; set; }` |
| `MailingCity` | `string?` | `public string? MailingCity { get; set; }` |
| `MailingState` | `string?` | `public string? MailingState { get; set; }` |
| `MailingZip` | `string?` | `public string? MailingZip { get; set; }` |
| `MailingPhone` | `string?` | `public string? MailingPhone { get; set; }` |
| `MailingFax` | `string?` | `public string? MailingFax { get; set; }` |
| `Name` | `string?` | `#endregion<br><br>        #region -- Basic Info --<br>        public string? Name { get; set; }` |
| `ProviderName` | `string?` | `public string? ProviderName { get; set; }` |
| `ProviderFirstName` | `string?` | `public string? ProviderFirstName { get; set; }` |
| `ProviderLastName` | `string?` | `public string? ProviderLastName { get; set; }` |
| `OrganizationName` | `string?` | `public string? OrganizationName { get; set; }` |
| `ParentOrganizationLegalBusinessName` | `string?` | `public string? ParentOrganizationLegalBusinessName { get; set; }` |
| `Gender` | `string?` | `public string? Gender { get; set; }` |
| `SoleProprietor` | `string?` | `public string? SoleProprietor { get; set; }` |
| `EnumerationDate` | `string?` | `public string? EnumerationDate { get; set; }` |
| `LastUpdated` | `string?` | `public string? LastUpdated { get; set; }` |
| `Status` | `string?` | `public string? Status { get; set; }` |
| `OtherOrganizationName` | `string?` | `#endregion<br><br>        #region -- Other Names --<br>        public string? OtherOrganizationName { get; set; }` |
| `PrimaryTaxonomyCode` | `string?` | `#endregion<br><br>        #region -- Taxonomy --<br>        public string? PrimaryTaxonomyCode { get; set; }` |
| `PrimaryTaxonomyStateLicense` | `string?` | `public string? PrimaryTaxonomyStateLicense { get; set; }` |
| `PrimaryTaxonomyDescription` | `string?` | `public string? PrimaryTaxonomyDescription { get; set; }` |
| `PrimaryTaxonomyGroup` | `string?` | `public string? PrimaryTaxonomyGroup { get; set; }` |
| `Identifiers` | `List<Identifier>?` | `#endregion<br><br>        #region -- Identifiers --<br>        public List<Identifier>? Identifiers { get; set; }` |
| `Endpoints` | `List<Endpoint>?` | `#endregion<br><br>        #region -- Endpoints --<br>        public List<Endpoint>? Endpoints { get; set; }` |

