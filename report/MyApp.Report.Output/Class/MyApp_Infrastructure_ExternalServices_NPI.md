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

| Name | Signature |
|------|-----------|
| `GetProvidersAsync` | `public Task<List<Provider?>> GetProvidersAsync(SearchProviderCriteria searchProviderCriteria)` |
| `GetProviderByNpiAsync` | `public Task<Provider?> GetProviderByNpiAsync(string npiNumber)` |
| `ParseProvider` | `static Provider? ParseProvider(Result provider)` |

#### Method: `GetProvidersAsync`

```csharp

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

```

#### Method: `GetProviderByNpiAsync`

```csharp

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

```

#### Method: `ParseProvider`

```csharp

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

```

