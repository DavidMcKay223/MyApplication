# Address

**Namespace:** `MyApp.Infrastructure.ExternalServices.NPI.DTO`

**File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/Address.cs`

## Properties

- `string? Country_code`
- `string? Country_name`
- `string? Address_purpose`
- `string? Address_type`
- `string? Address_1`
- `string? City`
- `string? State`
- `string? Postal_code`
- `string? Telephone_number`
- `string? Fax_number`
- `string? Address_2`

# Basic

**Namespace:** `MyApp.Infrastructure.ExternalServices.NPI.DTO`

**File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/Basic.cs`

## Properties

- `string? Organization_name`
- `string? Organizational_subpart`
- `string? Enumeration_date`
- `string? Last_updated`
- `string? Certification_date`
- `string? Status`
- `string? Authorized_official_first_name`
- `string? Authorized_official_last_name`
- `string? Authorized_official_telephone_number`
- `string? Authorized_official_title_or_position`
- `string? Authorized_official_name_prefix`
- `string? Authorized_official_name_suffix`
- `string? Authorized_official_credential`
- `string? Authorized_official_middle_name`
- `string? First_name`
- `string? Last_name`
- `string? Middle_name`
- `string? Sole_proprietor`
- `string? Gender`
- `string? Name_prefix`
- `string? Parent_organization_legal_business_name`
- `string? Name`

# Endpoint

**Namespace:** `MyApp.Infrastructure.ExternalServices.NPI.DTO`

**File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/Endpoint.cs`

## Properties

- `string? EndpointType`
- `string? EndpointTypeDescription`
- `string? endpoint`
- `string? Affiliation`
- `string? UseDescription`
- `string? ContentTypeDescription`
- `string? Country_code`
- `string? Country_name`
- `string? Address_type`
- `string? Address_1`
- `string? City`
- `string? State`
- `string? Postal_code`

# Error

**Namespace:** `MyApp.Infrastructure.ExternalServices.NPI.DTO`

**File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/Error.cs`

## Properties

- `string? Description`
- `string? Field`
- `string? Number`

# Identifier

**Namespace:** `MyApp.Infrastructure.ExternalServices.NPI.DTO`

**File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/Identifier.cs`

## Properties

- `string? Code`
- `string? Desc`
- `string? Issuer`
- `string? identifier`
- `string? State`

# OtherName

**Namespace:** `MyApp.Infrastructure.ExternalServices.NPI.DTO`

**File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/OtherName.cs`

## Properties

- `string? Organization_name`
- `string? Type`
- `string? Code`

# PracticeLocation

**Namespace:** `MyApp.Infrastructure.ExternalServices.NPI.DTO`

**File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/PracticeLocation.cs`

## Properties

- `string? Country_code`
- `string? Country_name`
- `string? Address_purpose`
- `string? Address_type`
- `string? Address_1`
- `string? City`
- `string? State`
- `string? Postal_code`
- `string? Telephone_number`
- `string? Fax_number`

# Result

**Namespace:** `MyApp.Infrastructure.ExternalServices.NPI.DTO`

**File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/Result.cs`

## Properties

- `string? Created_epoch`
- `string? Enumeration_type`
- `string? Last_updated_epoch`
- `string? Number`
- `List<Address>? Addresses`
- `List<PracticeLocation>? PracticeLocations`
- `Basic? Basic`
- `List<Taxonomy>? Taxonomies`
- `List<Identifier>? Identifiers`
- `List<Endpoint>? Endpoints`
- `List<OtherName>? Other_names`

# Root

**Namespace:** `MyApp.Infrastructure.ExternalServices.NPI.DTO`

**File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/Root.cs`

## Properties

- `int Result_count`
- `List<Result>? Results`
- `List<Error>? Errors`

# Taxonomy

**Namespace:** `MyApp.Infrastructure.ExternalServices.NPI.DTO`

**File Path:** `MyApp.Infrastructure/ExternalServices/NPI/DTO/Taxonomy.cs`

## Properties

- `string? Code`
- `string? Taxonomy_group`
- `string? Desc`
- `string? State`
- `string? License`
- `bool Primary`

