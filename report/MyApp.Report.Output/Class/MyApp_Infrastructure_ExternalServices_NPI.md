# Namespace: `MyApp.Infrastructure.ExternalServices.NPI`

## Class: `NpiRegistryService`

- **File Path:** `MyApp.Infrastructure/ExternalServices/NPI/NpiRegistryService.cs`
- **Inherits From:** `INpiRegistryClient`

### Class Code

```csharp
public class NpiRegistryService : INpiRegistryClient
    {
        private readonly HttpClient _httpClient;

        public NpiRegistryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Provider?>> GetProvidersAsync(SearchProviderCriteria searchProviderCriteria)
        {
            var response = await _httpClient.GetFromJsonAsync<Root>($"?{searchProviderCriteria.GetSearchParameter()}");

            if (response != null)
            {
                var providers = response.Results?.Select(ParseProvider).ToList();
                return providers ?? [];
            }

            return [];
        }

        public async Task<Provider?> GetProviderByNpiAsync(string npiNumber)
        {
            var response = await _httpClient.GetFromJsonAsync<Root>($"?number={npiNumber}&version=2.1");

            if (response != null)
            {
                var provider = ParseProvider(response?.Results?.FirstOrDefault()!);
                return provider;
            }

            return null;
        }

        private static Provider? ParseProvider(Result provider)
        {
            if (provider == null) return null;

            var npiProvider = new Provider
            {
                NPI = provider.Number!,
                Name = provider.Basic?.Name,
                ProviderName = $"{provider.Basic?.Last_name}, {provider.Basic?.First_name}",
                ProviderFirstName = provider.Basic?.First_name,
                ProviderLastName = provider.Basic?.Last_name,
                OrganizationName = provider.Basic?.Organization_name,
                ParentOrganizationLegalBusinessName = provider.Basic?.Parent_organization_legal_business_name,
                Gender = provider.Basic?.Gender,
                SoleProprietor = provider.Basic?.Sole_proprietor,
                EnumerationDate = provider.Basic?.Enumeration_date,
                LastUpdated = provider.Basic?.Last_updated,
                Status = provider.Basic?.Status,
                OtherOrganizationName = provider.Other_names?.FirstOrDefault()?.Organization_name,
                PrimaryTaxonomyCode = provider.Taxonomies?.FirstOrDefault(x => x.Primary)?.Code,
                PrimaryTaxonomyStateLicense = provider.Taxonomies?.FirstOrDefault(x => x.Primary)?.License,
                PrimaryTaxonomyDescription = provider.Taxonomies?.FirstOrDefault(x => x.Primary)?.Desc,
                PrimaryTaxonomyGroup = provider.Taxonomies?.FirstOrDefault(x => x.Primary)?.Taxonomy_group,
                Identifiers = provider.Identifiers?.Select(i => new Domain.Entities.NPI.Identifier
                {
                    Code = i.Code,
                    Description = i.Desc,
                    Issuer = i.Issuer,
                    IdentifierValue = i.identifier,
                    State = i.State
                }).ToList(),
                Endpoints = provider.Endpoints?.Select(e => new Domain.Entities.NPI.Endpoint
                {
                    EndpointType = e.EndpointType,
                    EndpointTypeDescription = e.EndpointTypeDescription,
                    EndpointValue = e.endpoint,
                    Affiliation = e.Affiliation,
                    UseDescription = e.UseDescription,
                    ContentTypeDescription = e.ContentTypeDescription,
                    CountryCode = e.Country_code,
                    CountryName = e.Country_name,
                    AddressType = e.Address_type,
                    Address1 = e.Address_1,
                    City = e.City,
                    State = e.State,
                    PostalCode = e.Postal_code
                }).ToList()
            };

            if (provider.Addresses?.Count > 0)
            {
                var primaryAddress = provider.Addresses[0];
                npiProvider.Address1 = primaryAddress.Address_1;
                npiProvider.Address2 = primaryAddress.Address_2;
                npiProvider.City = primaryAddress.City;
                npiProvider.State = primaryAddress.State;
                npiProvider.Zip = primaryAddress.Postal_code;
                npiProvider.Phone = primaryAddress.Telephone_number;
                npiProvider.Fax = primaryAddress.Fax_number;
            }

            if (provider.Addresses?.Count > 1)
            {
                var mailingAddress = provider.Addresses[1];
                npiProvider.MailingAddress1 = mailingAddress.Address_1;
                npiProvider.MailingAddress2 = mailingAddress.Address_2;
                npiProvider.MailingCity = mailingAddress.City;
                npiProvider.MailingState = mailingAddress.State;
                npiProvider.MailingZip = mailingAddress.Postal_code;
                npiProvider.MailingPhone = mailingAddress.Telephone_number;
                npiProvider.MailingFax = mailingAddress.Fax_number;
            }

            return npiProvider;
        }
    }
```

### Methods

| Name | Signature | Definition |
|------|-----------|-------------|
| `GetProvidersAsync` | `public Task<List<Provider?>> GetProvidersAsync(SearchProviderCriteria searchProviderCriteria)` | `public async Task<List<Provider?>> GetProvidersAsync(SearchProviderCriteria searchProviderCriteria)<br>        {<br>            var response = await _httpClient.GetFromJsonAsync<Root>($"?{searchProviderCriteria.GetSearchParameter()}");<br><br>            if (response != null)<br>            {<br>                var providers = response.Results?.Select(ParseProvider).ToList();<br>                return providers ?? [];<br>            }<br><br>            return [];<br>        }` |
| `GetProviderByNpiAsync` | `public Task<Provider?> GetProviderByNpiAsync(string npiNumber)` | `public async Task<Provider?> GetProviderByNpiAsync(string npiNumber)<br>        {<br>            var response = await _httpClient.GetFromJsonAsync<Root>($"?number={npiNumber}&version=2.1");<br><br>            if (response != null)<br>            {<br>                var provider = ParseProvider(response?.Results?.FirstOrDefault()!);<br>                return provider;<br>            }<br><br>            return null;<br>        }` |
| `ParseProvider` | `static Provider? ParseProvider(Result provider)` | `private static Provider? ParseProvider(Result provider)<br>        {<br>            if (provider == null) return null;<br><br>            var npiProvider = new Provider<br>            {<br>                NPI = provider.Number!,<br>                Name = provider.Basic?.Name,<br>                ProviderName = $"{provider.Basic?.Last_name}, {provider.Basic?.First_name}",<br>                ProviderFirstName = provider.Basic?.First_name,<br>                ProviderLastName = provider.Basic?.Last_name,<br>                OrganizationName = provider.Basic?.Organization_name,<br>                ParentOrganizationLegalBusinessName = provider.Basic?.Parent_organization_legal_business_name,<br>                Gender = provider.Basic?.Gender,<br>                SoleProprietor = provider.Basic?.Sole_proprietor,<br>                EnumerationDate = provider.Basic?.Enumeration_date,<br>                LastUpdated = provider.Basic?.Last_updated,<br>                Status = provider.Basic?.Status,<br>                OtherOrganizationName = provider.Other_names?.FirstOrDefault()?.Organization_name,<br>                PrimaryTaxonomyCode = provider.Taxonomies?.FirstOrDefault(x => x.Primary)?.Code,<br>                PrimaryTaxonomyStateLicense = provider.Taxonomies?.FirstOrDefault(x => x.Primary)?.License,<br>                PrimaryTaxonomyDescription = provider.Taxonomies?.FirstOrDefault(x => x.Primary)?.Desc,<br>                PrimaryTaxonomyGroup = provider.Taxonomies?.FirstOrDefault(x => x.Primary)?.Taxonomy_group,<br>                Identifiers = provider.Identifiers?.Select(i => new Domain.Entities.NPI.Identifier<br>                {<br>                    Code = i.Code,<br>                    Description = i.Desc,<br>                    Issuer = i.Issuer,<br>                    IdentifierValue = i.identifier,<br>                    State = i.State<br>                }).ToList(),<br>                Endpoints = provider.Endpoints?.Select(e => new Domain.Entities.NPI.Endpoint<br>                {<br>                    EndpointType = e.EndpointType,<br>                    EndpointTypeDescription = e.EndpointTypeDescription,<br>                    EndpointValue = e.endpoint,<br>                    Affiliation = e.Affiliation,<br>                    UseDescription = e.UseDescription,<br>                    ContentTypeDescription = e.ContentTypeDescription,<br>                    CountryCode = e.Country_code,<br>                    CountryName = e.Country_name,<br>                    AddressType = e.Address_type,<br>                    Address1 = e.Address_1,<br>                    City = e.City,<br>                    State = e.State,<br>                    PostalCode = e.Postal_code<br>                }).ToList()<br>            };<br><br>            if (provider.Addresses?.Count > 0)<br>            {<br>                var primaryAddress = provider.Addresses[0];<br>                npiProvider.Address1 = primaryAddress.Address_1;<br>                npiProvider.Address2 = primaryAddress.Address_2;<br>                npiProvider.City = primaryAddress.City;<br>                npiProvider.State = primaryAddress.State;<br>                npiProvider.Zip = primaryAddress.Postal_code;<br>                npiProvider.Phone = primaryAddress.Telephone_number;<br>                npiProvider.Fax = primaryAddress.Fax_number;<br>            }<br><br>            if (provider.Addresses?.Count > 1)<br>            {<br>                var mailingAddress = provider.Addresses[1];<br>                npiProvider.MailingAddress1 = mailingAddress.Address_1;<br>                npiProvider.MailingAddress2 = mailingAddress.Address_2;<br>                npiProvider.MailingCity = mailingAddress.City;<br>                npiProvider.MailingState = mailingAddress.State;<br>                npiProvider.MailingZip = mailingAddress.Postal_code;<br>                npiProvider.MailingPhone = mailingAddress.Telephone_number;<br>                npiProvider.MailingFax = mailingAddress.Fax_number;<br>            }<br><br>            return npiProvider;<br>        }` |

