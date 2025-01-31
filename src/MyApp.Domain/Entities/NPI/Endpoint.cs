using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities.NPI
{
    [ComplexType]
    [Serializable]
    public class Endpoint
    {
        public string? EndpointType { get; set; }
        public string? EndpointTypeDescription { get; set; }
        public string? EndpointValue { get; set; }
        public string? Affiliation { get; set; }
        public string? UseDescription { get; set; }
        public string? ContentTypeDescription { get; set; }
        public string? CountryCode { get; set; }
        public string? CountryName { get; set; }
        public string? AddressType { get; set; }
        public string? Address1 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
    }
}
