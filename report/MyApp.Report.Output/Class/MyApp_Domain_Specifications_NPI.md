# Namespace: `MyApp.Domain.Specifications.NPI`

## Class: `SearchProviderCriteria`

- **File Path:** `MyApp.Domain/Specifications/NPI/SearchProviderCriteria.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public class SearchProviderCriteria
{
    public string? Number { get; set; }
    public string? Enumeration_type { get; set; }
    public string? Taxonomy_description { get; set; }
    public string? Name_purpose { get; set; }
    public string? First_name { get; set; }
    public string? Use_first_name_alias { get; set; }
    public string? Last_name { get; set; }
    public string? Organization_name { get; set; }
    public string? Address_purpose { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Postal_code { get; set; }
    public string? Country_code { get; set; }
    public string? Limit { get; set; }
    public string? Skip { get; set; }
    public string? Pretty { get; set; }
    public static string Version => "2.1";

    public string GetSearchParameter()
    {
        var parameters = new List<string>
        {
            $"number={Number}",
            $"enumeration_type={Enumeration_type}",
            $"taxonomy_description={Taxonomy_description}",
            $"name_purpose={Name_purpose}",
            $"first_name={First_name}",
            $"use_first_name_alias={Use_first_name_alias}",
            $"last_name={Last_name}",
            $"organization_name={Organization_name}",
            $"address_purpose={Address_purpose}",
            $"city={City}",
            $"state={State}",
            $"postal_code={Postal_code}",
            $"country_code={Country_code}",
            $"limit={Limit}",
            $"skip={Skip}",
            $"pretty={Pretty}",
            $"version={Version}"
        };

        return string.Join("&", parameters);
    }
}

```

### Properties

| Name | Type |
|------|------|
| `Number` | `string?` |
| `Enumeration_type` | `string?` |
| `Taxonomy_description` | `string?` |
| `Name_purpose` | `string?` |
| `First_name` | `string?` |
| `Use_first_name_alias` | `string?` |
| `Last_name` | `string?` |
| `Organization_name` | `string?` |
| `Address_purpose` | `string?` |
| `City` | `string?` |
| `State` | `string?` |
| `Postal_code` | `string?` |
| `Country_code` | `string?` |
| `Limit` | `string?` |
| `Skip` | `string?` |
| `Pretty` | `string?` |
| `Version` | `string` |

#### Property: `Number`

```csharp
public string? Number { get; set; }

```

#### Property: `Enumeration_type`

```csharp
public string? Enumeration_type { get; set; }

```

#### Property: `Taxonomy_description`

```csharp
public string? Taxonomy_description { get; set; }

```

#### Property: `Name_purpose`

```csharp
public string? Name_purpose { get; set; }

```

#### Property: `First_name`

```csharp
public string? First_name { get; set; }

```

#### Property: `Use_first_name_alias`

```csharp
public string? Use_first_name_alias { get; set; }

```

#### Property: `Last_name`

```csharp
public string? Last_name { get; set; }

```

#### Property: `Organization_name`

```csharp
public string? Organization_name { get; set; }

```

#### Property: `Address_purpose`

```csharp
public string? Address_purpose { get; set; }

```

#### Property: `City`

```csharp
public string? City { get; set; }

```

#### Property: `State`

```csharp
public string? State { get; set; }

```

#### Property: `Postal_code`

```csharp
public string? Postal_code { get; set; }

```

#### Property: `Country_code`

```csharp
public string? Country_code { get; set; }

```

#### Property: `Limit`

```csharp
public string? Limit { get; set; }

```

#### Property: `Skip`

```csharp
public string? Skip { get; set; }

```

#### Property: `Pretty`

```csharp
public string? Pretty { get; set; }

```

#### Property: `Version`

```csharp
public static string Version => "2.1";

```

### Methods

| Name | Signature |
|------|-----------|
| `GetSearchParameter` | `public string GetSearchParameter()` |

#### Method: `GetSearchParameter`

```csharp

public string GetSearchParameter()
{
    var parameters = new List<string>
    {
        $"number={Number}",
        $"enumeration_type={Enumeration_type}",
        $"taxonomy_description={Taxonomy_description}",
        $"name_purpose={Name_purpose}",
        $"first_name={First_name}",
        $"use_first_name_alias={Use_first_name_alias}",
        $"last_name={Last_name}",
        $"organization_name={Organization_name}",
        $"address_purpose={Address_purpose}",
        $"city={City}",
        $"state={State}",
        $"postal_code={Postal_code}",
        $"country_code={Country_code}",
        $"limit={Limit}",
        $"skip={Skip}",
        $"pretty={Pretty}",
        $"version={Version}"
    };

    return string.Join("&", parameters);
}

```

