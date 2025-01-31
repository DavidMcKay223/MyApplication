using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Specifications.NPI
{
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
}
