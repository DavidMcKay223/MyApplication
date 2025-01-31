using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.ExternalServices.NPI.DTO
{
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
}
