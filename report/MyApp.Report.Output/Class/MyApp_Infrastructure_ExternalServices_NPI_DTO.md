# Namespace: `MyApp.Infrastructure.ExternalServices.NPI.DTO`

## Class: `Address`

- **File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/Address.cs`
- **Inherits From:** N/A

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

### Properties

| Name | Type |
|------|------|
| `Description` | `string?` |
| `Field` | `string?` |
| `Number` | `string?` |

## Class: `Identifier`

- **File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/Identifier.cs`
- **Inherits From:** N/A

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

### Properties

| Name | Type |
|------|------|
| `Organization_name` | `string?` |
| `Type` | `string?` |
| `Code` | `string?` |

## Class: `PracticeLocation`

- **File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/PracticeLocation.cs`
- **Inherits From:** N/A

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

### Properties

| Name | Type |
|------|------|
| `Result_count` | `int` |
| `Results` | `List<Result>?` |
| `Errors` | `List<Error>?` |

## Class: `Taxonomy`

- **File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/Taxonomy.cs`
- **Inherits From:** N/A

### Properties

| Name | Type |
|------|------|
| `Code` | `string?` |
| `Taxonomy_group` | `string?` |
| `Desc` | `string?` |
| `State` | `string?` |
| `License` | `string?` |
| `Primary` | `bool` |

