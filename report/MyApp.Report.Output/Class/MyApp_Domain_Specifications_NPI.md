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

| Name | Type | Definition |
|------|------|-------------|
| `Number` | `string?` | `public string? Number { get; set; }` |
| `Enumeration_type` | `string?` | `public string? Enumeration_type { get; set; }` |
| `Taxonomy_description` | `string?` | `public string? Taxonomy_description { get; set; }` |
| `Name_purpose` | `string?` | `public string? Name_purpose { get; set; }` |
| `First_name` | `string?` | `public string? First_name { get; set; }` |
| `Use_first_name_alias` | `string?` | `public string? Use_first_name_alias { get; set; }` |
| `Last_name` | `string?` | `public string? Last_name { get; set; }` |
| `Organization_name` | `string?` | `public string? Organization_name { get; set; }` |
| `Address_purpose` | `string?` | `public string? Address_purpose { get; set; }` |
| `City` | `string?` | `public string? City { get; set; }` |
| `State` | `string?` | `public string? State { get; set; }` |
| `Postal_code` | `string?` | `public string? Postal_code { get; set; }` |
| `Country_code` | `string?` | `public string? Country_code { get; set; }` |
| `Limit` | `string?` | `public string? Limit { get; set; }` |
| `Skip` | `string?` | `public string? Skip { get; set; }` |
| `Pretty` | `string?` | `public string? Pretty { get; set; }` |
| `Version` | `string` | `public static string Version => "2.1";` |

### Methods

| Name | Signature | Definition |
|------|-----------|-------------|
| `GetSearchParameter` | `public string GetSearchParameter()` | `public string GetSearchParameter()<br>        {<br>            var parameters = new List<string><br>            {<br>                $"number={Number}",<br>                $"enumeration_type={Enumeration_type}",<br>                $"taxonomy_description={Taxonomy_description}",<br>                $"name_purpose={Name_purpose}",<br>                $"first_name={First_name}",<br>                $"use_first_name_alias={Use_first_name_alias}",<br>                $"last_name={Last_name}",<br>                $"organization_name={Organization_name}",<br>                $"address_purpose={Address_purpose}",<br>                $"city={City}",<br>                $"state={State}",<br>                $"postal_code={Postal_code}",<br>                $"country_code={Country_code}",<br>                $"limit={Limit}",<br>                $"skip={Skip}",<br>                $"pretty={Pretty}",<br>                $"version={Version}"<br>            };<br><br>            return string.Join("&", parameters);<br>        }` |

