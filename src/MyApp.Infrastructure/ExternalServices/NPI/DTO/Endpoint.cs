using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.ExternalServices.NPI.DTO
{
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
}
