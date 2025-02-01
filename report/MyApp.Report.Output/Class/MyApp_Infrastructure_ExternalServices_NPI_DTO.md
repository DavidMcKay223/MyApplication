# Namespace: `MyApp.Infrastructure.ExternalServices.NPI.DTO`

## Class: `Address`

- **File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/Address.cs`
- **Inherits From:** N/A

### Class Code

```csharp
internal class Address
    {
        public string? Country_code { get; set; }
        public string? Country_name { get; set; }
        public string? Address_purpose { get; set; }
        public string? Address_type { get; set; }
        public string? Address_1 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Postal_code { get; set; }
        public string? Telephone_number { get; set; }
        public string? Fax_number { get; set; }
        public string? Address_2 { get; set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `Country_code` | `string?` | `public string? Country_code { get; set; }` |
| `Country_name` | `string?` | `public string? Country_name { get; set; }` |
| `Address_purpose` | `string?` | `public string? Address_purpose { get; set; }` |
| `Address_type` | `string?` | `public string? Address_type { get; set; }` |
| `Address_1` | `string?` | `public string? Address_1 { get; set; }` |
| `City` | `string?` | `public string? City { get; set; }` |
| `State` | `string?` | `public string? State { get; set; }` |
| `Postal_code` | `string?` | `public string? Postal_code { get; set; }` |
| `Telephone_number` | `string?` | `public string? Telephone_number { get; set; }` |
| `Fax_number` | `string?` | `public string? Fax_number { get; set; }` |
| `Address_2` | `string?` | `public string? Address_2 { get; set; }` |

## Class: `Basic`

- **File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/Basic.cs`
- **Inherits From:** N/A

### Class Code

```csharp
internal class Basic
    {
        public string? Organization_name { get; set; }
        public string? Organizational_subpart { get; set; }
        public string? Enumeration_date { get; set; }
        public string? Last_updated { get; set; }
        public string? Certification_date { get; set; }
        public string? Status { get; set; }
        public string? Authorized_official_first_name { get; set; }
        public string? Authorized_official_last_name { get; set; }
        public string? Authorized_official_telephone_number { get; set; }
        public string? Authorized_official_title_or_position { get; set; }
        public string? Authorized_official_name_prefix { get; set; }
        public string? Authorized_official_name_suffix { get; set; }
        public string? Authorized_official_credential { get; set; }
        public string? Authorized_official_middle_name { get; set; }
        public string? First_name { get; set; }
        public string? Last_name { get; set; }
        public string? Middle_name { get; set; }
        public string? Sole_proprietor { get; set; }
        public string? Gender { get; set; }
        public string? Name_prefix { get; set; }
        public string? Parent_organization_legal_business_name { get; internal set; }
        public string? Name { get; internal set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `Organization_name` | `string?` | `public string? Organization_name { get; set; }` |
| `Organizational_subpart` | `string?` | `public string? Organizational_subpart { get; set; }` |
| `Enumeration_date` | `string?` | `public string? Enumeration_date { get; set; }` |
| `Last_updated` | `string?` | `public string? Last_updated { get; set; }` |
| `Certification_date` | `string?` | `public string? Certification_date { get; set; }` |
| `Status` | `string?` | `public string? Status { get; set; }` |
| `Authorized_official_first_name` | `string?` | `public string? Authorized_official_first_name { get; set; }` |
| `Authorized_official_last_name` | `string?` | `public string? Authorized_official_last_name { get; set; }` |
| `Authorized_official_telephone_number` | `string?` | `public string? Authorized_official_telephone_number { get; set; }` |
| `Authorized_official_title_or_position` | `string?` | `public string? Authorized_official_title_or_position { get; set; }` |
| `Authorized_official_name_prefix` | `string?` | `public string? Authorized_official_name_prefix { get; set; }` |
| `Authorized_official_name_suffix` | `string?` | `public string? Authorized_official_name_suffix { get; set; }` |
| `Authorized_official_credential` | `string?` | `public string? Authorized_official_credential { get; set; }` |
| `Authorized_official_middle_name` | `string?` | `public string? Authorized_official_middle_name { get; set; }` |
| `First_name` | `string?` | `public string? First_name { get; set; }` |
| `Last_name` | `string?` | `public string? Last_name { get; set; }` |
| `Middle_name` | `string?` | `public string? Middle_name { get; set; }` |
| `Sole_proprietor` | `string?` | `public string? Sole_proprietor { get; set; }` |
| `Gender` | `string?` | `public string? Gender { get; set; }` |
| `Name_prefix` | `string?` | `public string? Name_prefix { get; set; }` |
| `Parent_organization_legal_business_name` | `string?` | `public string? Parent_organization_legal_business_name { get; internal set; }` |
| `Name` | `string?` | `public string? Name { get; internal set; }` |

## Class: `Endpoint`

- **File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/Endpoint.cs`
- **Inherits From:** N/A

### Class Code

```csharp
internal class Endpoint
    {
        public string? EndpointType { get; set; }
        public string? EndpointTypeDescription { get; set; }
        public string? endpoint { get; set; }
        public string? Affiliation { get; set; }
        public string? UseDescription { get; set; }
        public string? ContentTypeDescription { get; set; }
        public string? Country_code { get; set; }
        public string? Country_name { get; set; }
        public string? Address_type { get; set; }
        public string? Address_1 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Postal_code { get; set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `EndpointType` | `string?` | `public string? EndpointType { get; set; }` |
| `EndpointTypeDescription` | `string?` | `public string? EndpointTypeDescription { get; set; }` |
| `endpoint` | `string?` | `public string? endpoint { get; set; }` |
| `Affiliation` | `string?` | `public string? Affiliation { get; set; }` |
| `UseDescription` | `string?` | `public string? UseDescription { get; set; }` |
| `ContentTypeDescription` | `string?` | `public string? ContentTypeDescription { get; set; }` |
| `Country_code` | `string?` | `public string? Country_code { get; set; }` |
| `Country_name` | `string?` | `public string? Country_name { get; set; }` |
| `Address_type` | `string?` | `public string? Address_type { get; set; }` |
| `Address_1` | `string?` | `public string? Address_1 { get; set; }` |
| `City` | `string?` | `public string? City { get; set; }` |
| `State` | `string?` | `public string? State { get; set; }` |
| `Postal_code` | `string?` | `public string? Postal_code { get; set; }` |

## Class: `Error`

- **File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/Error.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class Error
    {
        public string? Description { get; set; }
        public string? Field { get; set; }
        public string? Number { get; set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `Description` | `string?` | `public string? Description { get; set; }` |
| `Field` | `string?` | `public string? Field { get; set; }` |
| `Number` | `string?` | `public string? Number { get; set; }` |

## Class: `Identifier`

- **File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/Identifier.cs`
- **Inherits From:** N/A

### Class Code

```csharp
internal class Identifier
    {
        public string? Code { get; set; }
        public string? Desc { get; set; }
        public string? Issuer { get; set; }
        public string? identifier { get; set; }
        public string? State { get; set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `Code` | `string?` | `public string? Code { get; set; }` |
| `Desc` | `string?` | `public string? Desc { get; set; }` |
| `Issuer` | `string?` | `public string? Issuer { get; set; }` |
| `identifier` | `string?` | `public string? identifier { get; set; }` |
| `State` | `string?` | `public string? State { get; set; }` |

## Class: `OtherName`

- **File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/OtherName.cs`
- **Inherits From:** N/A

### Class Code

```csharp
internal class OtherName
    {
        public string? Organization_name { get; set; }
        public string? Type { get; set; }
        public string? Code { get; set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `Organization_name` | `string?` | `public string? Organization_name { get; set; }` |
| `Type` | `string?` | `public string? Type { get; set; }` |
| `Code` | `string?` | `public string? Code { get; set; }` |

## Class: `PracticeLocation`

- **File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/PracticeLocation.cs`
- **Inherits From:** N/A

### Class Code

```csharp
internal class PracticeLocation
    {
        public string? Country_code { get; set; }
        public string? Country_name { get; set; }
        public string? Address_purpose { get; set; }
        public string? Address_type { get; set; }
        public string? Address_1 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Postal_code { get; set; }
        public string? Telephone_number { get; set; }
        public string? Fax_number { get; set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `Country_code` | `string?` | `public string? Country_code { get; set; }` |
| `Country_name` | `string?` | `public string? Country_name { get; set; }` |
| `Address_purpose` | `string?` | `public string? Address_purpose { get; set; }` |
| `Address_type` | `string?` | `public string? Address_type { get; set; }` |
| `Address_1` | `string?` | `public string? Address_1 { get; set; }` |
| `City` | `string?` | `public string? City { get; set; }` |
| `State` | `string?` | `public string? State { get; set; }` |
| `Postal_code` | `string?` | `public string? Postal_code { get; set; }` |
| `Telephone_number` | `string?` | `public string? Telephone_number { get; set; }` |
| `Fax_number` | `string?` | `public string? Fax_number { get; set; }` |

## Class: `Result`

- **File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/Result.cs`
- **Inherits From:** N/A

### Class Code

```csharp
internal class Result
    {
        public string? Created_epoch { get; set; }
        public string? Enumeration_type { get; set; }
        public string? Last_updated_epoch { get; set; }
        public string? Number { get; set; }
        public List<Address>? Addresses { get; set; }
        public List<PracticeLocation>? PracticeLocations { get; set; }
        public Basic? Basic { get; set; }
        public List<Taxonomy>? Taxonomies { get; set; }
        public List<Identifier>? Identifiers { get; set; }
        public List<Endpoint>? Endpoints { get; set; }
        public List<OtherName>? Other_names { get; set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `Created_epoch` | `string?` | `public string? Created_epoch { get; set; }` |
| `Enumeration_type` | `string?` | `public string? Enumeration_type { get; set; }` |
| `Last_updated_epoch` | `string?` | `public string? Last_updated_epoch { get; set; }` |
| `Number` | `string?` | `public string? Number { get; set; }` |
| `Addresses` | `List<Address>?` | `public List<Address>? Addresses { get; set; }` |
| `PracticeLocations` | `List<PracticeLocation>?` | `public List<PracticeLocation>? PracticeLocations { get; set; }` |
| `Basic` | `Basic?` | `public Basic? Basic { get; set; }` |
| `Taxonomies` | `List<Taxonomy>?` | `public List<Taxonomy>? Taxonomies { get; set; }` |
| `Identifiers` | `List<Identifier>?` | `public List<Identifier>? Identifiers { get; set; }` |
| `Endpoints` | `List<Endpoint>?` | `public List<Endpoint>? Endpoints { get; set; }` |
| `Other_names` | `List<OtherName>?` | `public List<OtherName>? Other_names { get; set; }` |

## Class: `Root`

- **File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/Root.cs`
- **Inherits From:** N/A

### Class Code

```csharp
internal class Root
    {
        public int Result_count { get; set; }
        public List<Result>? Results { get; set; }
        public List<Error>? Errors { get; set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `Result_count` | `int` | `public int Result_count { get; set; }` |
| `Results` | `List<Result>?` | `public List<Result>? Results { get; set; }` |
| `Errors` | `List<Error>?` | `public List<Error>? Errors { get; set; }` |

## Class: `Taxonomy`

- **File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/Taxonomy.cs`
- **Inherits From:** N/A

### Class Code

```csharp
internal class Taxonomy
    {
        public string? Code { get; set; }
        public string? Taxonomy_group { get; set; }
        public string? Desc { get; set; }
        public string? State { get; set; }
        public string? License { get; set; }
        public bool Primary { get; set; }
    }
```

### Properties

| Name | Type | Definition |
|------|------|-------------|
| `Code` | `string?` | `public string? Code { get; set; }` |
| `Taxonomy_group` | `string?` | `public string? Taxonomy_group { get; set; }` |
| `Desc` | `string?` | `public string? Desc { get; set; }` |
| `State` | `string?` | `public string? State { get; set; }` |
| `License` | `string?` | `public string? License { get; set; }` |
| `Primary` | `bool` | `public bool Primary { get; set; }` |

