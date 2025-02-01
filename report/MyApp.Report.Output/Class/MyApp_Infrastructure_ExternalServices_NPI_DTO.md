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

| Name | Type |
|------|------|
| `Country_code` | `string?` |
| `Country_name` | `string?` |
| `Address_purpose` | `string?` |
| `Address_type` | `string?` |
| `Address_1` | `string?` |
| `City` | `string?` |
| `State` | `string?` |
| `Postal_code` | `string?` |
| `Telephone_number` | `string?` |
| `Fax_number` | `string?` |
| `Address_2` | `string?` |

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

| Name | Type |
|------|------|
| `Organization_name` | `string?` |
| `Organizational_subpart` | `string?` |
| `Enumeration_date` | `string?` |
| `Last_updated` | `string?` |
| `Certification_date` | `string?` |
| `Status` | `string?` |
| `Authorized_official_first_name` | `string?` |
| `Authorized_official_last_name` | `string?` |
| `Authorized_official_telephone_number` | `string?` |
| `Authorized_official_title_or_position` | `string?` |
| `Authorized_official_name_prefix` | `string?` |
| `Authorized_official_name_suffix` | `string?` |
| `Authorized_official_credential` | `string?` |
| `Authorized_official_middle_name` | `string?` |
| `First_name` | `string?` |
| `Last_name` | `string?` |
| `Middle_name` | `string?` |
| `Sole_proprietor` | `string?` |
| `Gender` | `string?` |
| `Name_prefix` | `string?` |
| `Parent_organization_legal_business_name` | `string?` |
| `Name` | `string?` |

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

| Name | Type |
|------|------|
| `EndpointType` | `string?` |
| `EndpointTypeDescription` | `string?` |
| `endpoint` | `string?` |
| `Affiliation` | `string?` |
| `UseDescription` | `string?` |
| `ContentTypeDescription` | `string?` |
| `Country_code` | `string?` |
| `Country_name` | `string?` |
| `Address_type` | `string?` |
| `Address_1` | `string?` |
| `City` | `string?` |
| `State` | `string?` |
| `Postal_code` | `string?` |

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

| Name | Type |
|------|------|
| `Description` | `string?` |
| `Field` | `string?` |
| `Number` | `string?` |

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

| Name | Type |
|------|------|
| `Code` | `string?` |
| `Desc` | `string?` |
| `Issuer` | `string?` |
| `identifier` | `string?` |
| `State` | `string?` |

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

| Name | Type |
|------|------|
| `Organization_name` | `string?` |
| `Type` | `string?` |
| `Code` | `string?` |

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

| Name | Type |
|------|------|
| `Country_code` | `string?` |
| `Country_name` | `string?` |
| `Address_purpose` | `string?` |
| `Address_type` | `string?` |
| `Address_1` | `string?` |
| `City` | `string?` |
| `State` | `string?` |
| `Postal_code` | `string?` |
| `Telephone_number` | `string?` |
| `Fax_number` | `string?` |

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

| Name | Type |
|------|------|
| `Created_epoch` | `string?` |
| `Enumeration_type` | `string?` |
| `Last_updated_epoch` | `string?` |
| `Number` | `string?` |
| `Addresses` | `List<Address>?` |
| `PracticeLocations` | `List<PracticeLocation>?` |
| `Basic` | `Basic?` |
| `Taxonomies` | `List<Taxonomy>?` |
| `Identifiers` | `List<Identifier>?` |
| `Endpoints` | `List<Endpoint>?` |
| `Other_names` | `List<OtherName>?` |

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

| Name | Type |
|------|------|
| `Result_count` | `int` |
| `Results` | `List<Result>?` |
| `Errors` | `List<Error>?` |

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

| Name | Type |
|------|------|
| `Code` | `string?` |
| `Taxonomy_group` | `string?` |
| `Desc` | `string?` |
| `State` | `string?` |
| `License` | `string?` |
| `Primary` | `bool` |

